#include "CFlower.h"
#include "CPlant.h"
#include <string>
#include <cctype>
using namespace std;

string FirstLetter(string text)
{
	text[0] = toupper(text[0]);
	return text;
}
CFlower::CFlower() :CPlant::CPlant()
{
	CPlant::plantSpecies = "Flower";
	CFlower::color = "UNKNOWN";
}
CFlower::CFlower(string color, string plantSpecies, float price, int count) : CPlant::CPlant(price, count)
{
	CPlant::plantSpecies = "Flower";
	CPlant::plantSpecies = plantSpecies;
	CFlower::color = color;
}
void CFlower::getData()
{
	CPlant::getData();
	cout << "Enter color: ";cin.ignore(); getline(cin, CFlower::color);
	CFlower::color = FirstLetter(CFlower::color);
}
void CFlower::display()
{
	CPlant::display();
	cout << "Color: " << CFlower::color << endl;
}
