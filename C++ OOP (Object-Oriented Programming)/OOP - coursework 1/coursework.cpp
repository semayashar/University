#include <iostream>
#include <string>
#include <tuple>
#include <vector>
#include "CWorker.h"
using namespace std;

int menu() {
	int answer;
	cout << "1 - Add new worker.\n";
	cout << "2 - Display data.\n";
	cout << "3 - Display the data about woman over 22 years old with at least 15 days worked.\n";
	cout << "4 - Create new array for woman who earned over 300lv.\n";
	cout << "5 - Close the program.\n\n";
	cout << "CHOICE: "; cin >> answer;
	cout << endl;
	return answer;
}

int main()
{
	CWorker* person = new CWorker[30];
	CWorker arrayOfP[30];
	int c = 0;
	int counter = 0;
	while (true)
	{
		switch (menu())
		{
		case 1:
			cin.ignore();
			person[counter].addWorker();
			cout << endl;
			counter++;
			break;

		case 2:
			for (int i = 0; i < counter; i++)
			{
				person[i].display();
				cout << endl;
			}
			cout << endl;
			break;

		case 3:
			cout << "Those are the woman above 22 years old with at lest 15 days worked: " << endl;
			for (int i = 0; i < counter; i++)
			{
				person[i].womenAboveTwentyTwoYers();
			}
			cout << endl;
			break;

		case 4:

			cout << "The array is being created..." << endl;
			for (int i = 0; i < counter; i++)
			{
				if (person[i].returnPerson() == true)
				{
					arrayOfP[c] = person[i];
					c++;
				}
			}
			cout << "Those are the people in the array: " << endl<<endl;
			for (int i = 0; i < c; i++)
			{
				arrayOfP[i].display();
				cout << endl;
			}
			break;

		case 5:
			return false;
			break;
		}
	}
	delete[]person;
}
