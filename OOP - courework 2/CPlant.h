#pragma once
#include <string>
#include <iostream>
using namespace std;

class CPlant
{
protected:
	string plantSpecies;
	float price;
	int count;
public:
	CPlant();
	CPlant(float price, int count);
	virtual void getData();
	virtual void display();
	char findPS();
	float getPrice();
};

