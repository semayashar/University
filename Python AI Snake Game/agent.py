import torch
import random
import numpy as np
from collections import deque
from ai_snake_game import SnakeGameAI, Direction, Point
from model import Linear_QNet, QTrainer
from helper import plot

# памет, която ще запълваме с отчитаната информация
MAX_MEMORY = 100_000
BATCH_SIZE = 1000
# скорост на обучение - константа, която показва колко бързо се обучава модела над данните 
LR = 0.001

class Agent:

    def __init__(self):
        self.n_games = 0 # брой игри
        self.epsilon = 0 # случайна величина, помага за прогрес
        self.gamma = 0.9 # стойности на величината гама
        self.memory = deque(maxlen=MAX_MEMORY) # popleft() - изпозлваме deque за запазване на паметта на играта
        self.model = Linear_QNet(11, 256, 3)
        self.trainer = QTrainer(self.model, lr=LR, gamma=self.gamma)


    def get_state(self, game):
        head = game.snake[0]
        point_l = Point(head.x - 20, head.y)
        point_r = Point(head.x + 20, head.y)
        point_u = Point(head.x, head.y - 20)
        point_d = Point(head.x, head.y + 20)
        
        dir_l = game.direction == Direction.LEFT
        dir_r = game.direction == Direction.RIGHT
        dir_u = game.direction == Direction.UP
        dir_d = game.direction == Direction.DOWN

        state = [
            # Опасност пред нас
            (dir_r and game.is_collision(point_r)) or 
            (dir_l and game.is_collision(point_l)) or 
            (dir_u and game.is_collision(point_u)) or 
            (dir_d and game.is_collision(point_d)),

            # Опасност в дясно
            (dir_u and game.is_collision(point_r)) or 
            (dir_d and game.is_collision(point_l)) or 
            (dir_l and game.is_collision(point_u)) or 
            (dir_r and game.is_collision(point_d)),

            # Опасност в ляво
            (dir_d and game.is_collision(point_r)) or 
            (dir_u and game.is_collision(point_l)) or 
            (dir_r and game.is_collision(point_u)) or 
            (dir_l and game.is_collision(point_d)),
            
            # Посоки за движение
            dir_l,
            dir_r,
            dir_u,
            dir_d,
            
            # Разположение на наградка/храна 
            game.food.x < game.head.x,  # ляво
            game.food.x > game.head.x,  # дясно
            game.food.y < game.head.y,  # горе
            game.food.y > game.head.y  # долу
            ]

        return np.array(state, dtype=int)

    # Помним състоянието си
    def remember(self, state, action, reward, next_state, done):
        self.memory.append((state, action, reward, next_state, done)) # popleft if MAX_MEMORY is reached

    # Дългосрочна памет - използва се за модификация на тренировъчните данни
    def train_long_memory(self):
        if len(self.memory) > BATCH_SIZE:
            # Ако паметта ни е пълна, ние я "разбъркваме" без да променяме самите данни, т.е. вземаме разбъркани случайни примери от дългосрочната си памет
            mini_sample = random.sample(self.memory, BATCH_SIZE) # списък от тюпъли
        else:
            # Ако не е пълна паметта, просто я вземаме цялата неразбъркана
            mini_sample = self.memory

        # Разделяме целия mini_sample на отделни тюпъли, които използваме като тренировъчни стъпки (зип функцията разделя списъка на списъци)
        states, actions, rewards, next_states, dones = zip(*mini_sample)
        self.trainer.train_step(states, actions, rewards, next_states, dones)
        #for state, action, reward, nexrt_state, done in mini_sample:
        #    self.trainer.train_step(state, action, reward, next_state, done)


    # Краткосрочна памет - помага ни да не влизаме в краткосрочни цикличности
    def train_short_memory(self, state, action, reward, next_state, done):
        self.trainer.train_step(state, action, reward, next_state, done)

    # Дефинираме случайността и връзката между движенията по формулите
    def get_action(self, state):
        # random moves: tradeoff exploration / exploitation
        self.epsilon = 80 - self.n_games
        final_move = [0,0,0]

        # В началото ще имаме повече случайни действия, но колкото повече обучаваме алгоритъма, толкова по-малко случайности искаме
        if random.randint(0, 200) < self.epsilon:
            move = random.randint(0, 2)
            final_move[move] = 1
        else:
            state0 = torch.tensor(state, dtype=torch.float)
            prediction = self.model(state0)
            move = torch.argmax(prediction).item()
            final_move[move] = 1

        return final_move


# Функция от Агента за трениране на модела, тази функция навръзва всички останали
def train():
    plot_scores = []
    plot_mean_scores = []
    total_score = 0
    record = 0
    agent = Agent()
    game = SnakeGameAI()
    while True:
        # Вземи предходното състояние на играта (къде се е намирала змията, опасностите покрай нея, резултата и т.н.)
        state_old = agent.get_state(game)

        # Предходната посока, в която се е движела змията
        final_move = agent.get_action(state_old)

        # Избираме пътя, по който тя да поеме и след като бъде извършено движението, вземаме текущото състояние на играта
        reward, done, score = game.play_step(final_move)
        state_new = agent.get_state(game)

        # Трениране на краткосрочната памет
        agent.train_short_memory(state_old, final_move, reward, state_new, done)

        # Запомняме състоянието в общата голяма памет (за която също сме задали лимит при константите)
        agent.remember(state_old, final_move, reward, state_new, done)

        # Ако играта е в приключено състояние, тогава обновяваме графиката със статистически данни
        if done:
            # Тренираме дългосрочната памет и чертаем резултата в графиката
            game.reset()
            agent.n_games += 1
            agent.train_long_memory()

            if score > record:
                record = score
                agent.model.save()

            print('Game', agent.n_games, 'Score', score, 'Record:', record)

            # Добавяме резултата
            plot_scores.append(score)
            # Изчисляваме средно-аритметичното и го чертаем
            total_score += score
            mean_score = total_score / agent.n_games
            plot_mean_scores.append(mean_score)
            plot(plot_scores, plot_mean_scores)


if __name__ == '__main__':
    train()