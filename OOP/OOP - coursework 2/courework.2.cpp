#include <iostream>
#include <string>
#include"CTree.h"
#include"CPlant.h"
#include"CFlower.h"
using namespace std;

int menu()
{
	int choice;
	cout << "Type '1' if you want to add flowers.\nType '2' if you want to add trees.\nType '3' if you want to display all plants.\nType '4' if you want to display all info for flowers.\nType '5' if you want to create an array with all plants that cost 50lv.\nType '6' to end the program.\n";
	cout << "Your choice is: "; cin >> choice;
	cout << endl;
	return choice;
}
int main()
{
	CPlant* array[30];
	CPlant* createArray[30];
	int counterForSecArray = 0;
	int c = 0;
	while (true)
	{
		switch (menu())
		{
		case 1:
			cout << "You are now entering information about flowers!\n";
			array[c] = new CFlower();
			array[c]->getData();
			cout << endl;
			c++;
			break;
		case 2:
			cout << "You are now entering information about trees!\n";
			array[c] = new CTree();
			array[c]->getData();
			cout << endl;
			c++;
			break;
		case 3:
			cout << "This is the information about all plants\n\n";
			for (int i = 0; i < c; i++)
			{
				array[i]->display();
				cout << endl;
			}
			break;
		case 4:
			cout << "This is the information for all flowers:\n\n";
			for (int i = 0; i < c; i++)
			{
				if (array[i]->findPS()=='f')
				{
					array[i]->display();
					cout << endl;
				}
			}
			break;
		case 5:
			
			cout << "You are now creating an array\n";
			for (int i = 0; i < c; i++)
			{
				if (array[i]->getPrice() == 50)
				{
					createArray[counterForSecArray] = array[i];
					counterForSecArray++;
				}
			}
			cout << "The aray is created! Those are the elements in it:\n\n";
			for (int i = 0; i < counterForSecArray; i++)
			{
				createArray[i]->display();
				cout << endl;
			}
			break;
		case 6:
			cout << "Have a great day!\n";
			return false;
			break;
		default:
			return false;
			break;
		}
	}
}