#include "CTree.h"
#include "CPlant.h"
#include<iostream>
#include<string>
#include <cctype>


string FirstLetter1(string text)
{
	text[0] = toupper(text[0]);
	return text;
}
CTree::CTree():CPlant()
{
	CPlant::plantSpecies = "Tree";
	CTree::type = "UNKNOWN";
	CTree::height = 0;
}
CTree::CTree(string type, float height, string plantSpecies, float price, int count) :CPlant(price, count)
{
	CPlant::plantSpecies = "Tree";
	CPlant::plantSpecies = plantSpecies;
	CTree::type = type;
	CTree::height = height;
}
void CTree::getData()
{
	CPlant::getData();
	cout << "WARNING: You should enter either coniferous or broad-leaved\nEnter type: ";
	cin.ignore();
	getline(cin, CTree::type);
	while (CTree::type != "coniferous" && CTree::type != "Coniferous"  && CTree::type != "broad-leaved" && CTree::type != "Broad-leaved")
	{
			cout << "TRY AGAIN!\nEnter type: ";
			getline(cin, CTree::type);
	}
	CTree::type = FirstLetter1(CTree::type);
	cout << "Enter height: ";cin >> CTree::height;
}														  
void CTree::display()
{
	CPlant::display();
	cout << "Type: " << CTree::type << endl;
	cout << "Height: " << CTree::height << endl;
}