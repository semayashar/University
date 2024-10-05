import torch
import torch.nn as nn
import torch.optim as optim
import torch.nn.functional as F
import os

# Дефинираме клас в който дефинираме своята ТРИСЛОЙНА невронна мрежа - 1 слой за вход, 1 скрит междинен и 1 изход
class Linear_QNet(nn.Module):
    # От агента подаваме в конструктора стойносттие за броя неврони на всеки от трите слоя - вход / скрит слой / изход
    def __init__(self, input_size, hidden_size, output_size):
        super().__init__()
        # Създаваме връзките между слоевете на невронната мрежа
        self.linear1 = nn.Linear(input_size, hidden_size)
        self.linear2 = nn.Linear(hidden_size, output_size)

    # Описваме предаването на тензорите (х - тензор) в права посока
    def forward(self, x):
        # Първо минаваме през линейния слой, после използваме функцията за придвижване 
        x = F.relu(self.linear1(x))
        # Минаваме през скрития слой и промените ги запазваме в изхода
        x = self.linear2(x)
        # Връщаме променените тензори като резултат (те нямат нужда от 'преместване', след като вече сме извън слоя)
        return x

    # Запазваме си модела така, че да може после да използваме тренирания модел (Агента извиква тази функция)
    def save(self, file_name='model.pth'):
        model_folder_path = './model'
        # Ако НЕ съществува, създаваме такъв път
        if not os.path.exists(model_folder_path):
            os.makedirs(model_folder_path)
        # Запазваме модела във файл, използвайки библиотеката torch
        file_name = os.path.join(model_folder_path, file_name)
        torch.save(self.state_dict(), file_name)

# Самият тренировъчен алгоритъм
class QTrainer:
    # Задаваме началните параметри за модела
    def __init__(self, model, lr, gamma):
        self.lr = lr
        self.gamma = gamma
        self.model = model
        # Избираме един от оптимизиращите  алгоритми - в случая Adam, като оптимизираме model.parameters() 
        self.optimizer = optim.Adam(model.parameters(), lr=self.lr)
        # Функция за загуба, използвайки "Mean Square Error" функция
        self.criterion = nn.MSELoss()

    # Добавяме списъците с всички параметри от играта/агента
    def train_step(self, state, action, reward, next_state, done):
        # Трансформираме за всичките необходими параметри към тензори използвайки torch
        state = torch.tensor(state, dtype=torch.float)
        next_state = torch.tensor(next_state, dtype=torch.float)
        action = torch.tensor(action, dtype=torch.long)
        reward = torch.tensor(reward, dtype=torch.float)
        # (n, x) - множество тензори

        # Проверка за това дали сме в начално състояни, или имаме всички списъци сложени на 1 място
        if len(state.shape) == 1:
            # (1, x) - в едно измерение сме, т.е. трябва да разбием на тюпъли
            state = torch.unsqueeze(state, 0)
            next_state = torch.unsqueeze(next_state, 0)
            action = torch.unsqueeze(action, 0)
            reward = torch.unsqueeze(reward, 0)
            # Дефиниране на тюпъл с 1 стойност
            done = (done, )

        # Уравнението на Белман за Q (Bellmans Equation for Q-learning)
        # 1: предвидените от модела Q стойности с текущото състояние
        pred = self.model(state)

        target = pred.clone()
        for idx in range(len(done)):
            Q_new = reward[idx]
            if not done[idx]:
                Q_new = reward[idx] + self.gamma * torch.max(self.model(next_state[idx]))

            target[idx][torch.argmax(action[idx]).item()] = Q_new
    
        # Q_new се прави САМО когато не сме готови (done)
        # 2: Q_new = r + y * max(next_predicted Q value) - новото Q - форматираме го така, че да е в същия вид
        # pred.clone()
        # preds[argmax(action)] = Q_new
        
        # Правим стъпка във функцията на загуба
        self.optimizer.zero_grad() # Изпразваме градиента на pytorch
        loss = self.criterion(target, pred)
        # Фунцкията със задна стъпка обновяваме градиентите си
        loss.backward()

        self.optimizer.step()



