#include "CPlant.h"
#include <string>
#include <iostream>
using namespace std;

char CPlant::findPS()
{
	if (CPlant::plantSpecies == "flower" || CPlant::plantSpecies == "Flower")
	{
		return 'f';
	}
	else if (CPlant::plantSpecies == "tree" || CPlant::plantSpecies == "Tree")
	{
		return 't';
	}
}
CPlant::CPlant()
{
	CPlant::plantSpecies = "UNKNOWN";
	CPlant::price = 0;
	CPlant::count = 0;
}
CPlant::CPlant(float price, int count)
{
	CPlant::price = price;
	CPlant::count = count;
}
void CPlant::getData()
{
	cout << "Enter price: "; cin >> CPlant::price;
	cout << "Enter count: "; cin >> CPlant::count;
}
void CPlant::display()
{
	cout << "Plant: " << CPlant::plantSpecies << endl;
	{
		cout << fixed;
		cout.precision(2);
		cout << "Price: " << CPlant::price << "lv." << endl;
	}
	cout << "Count: " << CPlant::count << endl;
}
float CPlant::getPrice()
{
	return CPlant::price;
}

