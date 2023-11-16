#include <iostream>
#include <vector>
using namespace std;

/*
Задача 2.
N студенти правят тест по ПАА. Всяка от задачите може да бъде решена от всеки от судентите за k минути, но тестът се състои от P задачи за m минути.
Студентите седят един до друг и са усъвършенствали едно от важните качества за това да бъдеш студент - да можеш да преписваш.
След като някой е сметнал отговора на дадена задача, на всеки от останалите му е нужна само една минута за да препише отговора.
Могат ли студентите да направят теста успешно?

Вход
На един ред на стандартния вход са зададени целите числа N, P, k и m.

Изход
На един ред на стандартния изход изведете едно цяло число – брой минути необходими на всички студенти да решат теста.
Ако тестът не може да бъде решен от всички студенти за m минути, изведете -1.

Пример
Вход
3 20 5 60

Изход
48
*/

class CStudent {
private:
	int countTasksPerStud;
	int neededTimeForSolving;
	int neededTimeforRW;
	int timePerStud;

public:
	CStudent() {
		countTasksPerStud = 0;
		neededTimeForSolving = 0;
		neededTimeforRW = 0;
		timePerStud = 0;
	}

	// Constructor with parameters for initializing values.
	CStudent(int _countTasksPerStud, int _neededTimeForSolving, int _neededTimeforRW, int _timePerStud) {
		countTasksPerStud = _countTasksPerStud;
		neededTimeForSolving = _neededTimeForSolving;
		neededTimeforRW = _neededTimeforRW;
		timePerStud = _timePerStud;
	}

	// Setters for class variables.
	void setCEPS(int task) { countTasksPerStud += task; }
	void setNTFS(int timeForOne) { neededTimeForSolving = countTasksPerStud * timeForOne; }
	void setNTFRW(int countTasks) { neededTimeforRW = countTasks - countTasksPerStud; }
	void setTPS() { timePerStud = neededTimeforRW + neededTimeForSolving; }

	// Getters for class variables.
	int getCEPS() { return countTasksPerStud; }
	int getNTFS() { return neededTimeForSolving; }
	int getNTFRW() { return neededTimeforRW; }
	int getTPS() { return timePerStud; }
};

int main()
{
	// Input variables for the number of students, tasks, time for one task, and the total time.
	int countStudents, countTasks, timeForOne, time;
	cin >> countStudents;
	cin >> countTasks;
	cin >> timeForOne;
	cin >> time;

	// Calculate the number of tasks per student and the remaining tasks.
	int countTasksPS = round(countTasks / countStudents);
	int countTasksPS_left = countTasks % countStudents;

	// Vector to store time needed by each student.
	vector <int> v_time;

	// Dynamically allocate an array of CStudent objects.
	CStudent** studentsArray = new CStudent * [countStudents];

	// Loop to initialize CStudent objects for each student.
	for (int i = 0; i < countStudents; i++)
	{
		studentsArray[i] = new CStudent();
		studentsArray[i]->setCEPS(countTasksPS);

		// If there are remaining tasks, distribute one to each student.
		if (countTasksPS_left > 0)
		{
			studentsArray[i]->setCEPS(1);
			countTasksPS_left -= 1;
		}

		studentsArray[i]->setNTFS(timeForOne);
		studentsArray[i]->setNTFRW(countTasks);
		studentsArray[i]->setTPS();

		// Store the time needed by each student in the vector.
		v_time.push_back(studentsArray[i]->getTPS());
	}

	// Output the maximum time needed by any student.
	if (!v_time.empty()) {
		auto maxValue = *std::max_element(v_time.begin(), v_time.end());
		std::cout << maxValue << std::endl;
	}
	else {
		// If the vector is empty, print an error message.
		std::cerr << "Vector is empty." << std::endl;
	}

	// Deallocate the dynamically allocated memory.
	delete[] studentsArray;

	return 0;
}
