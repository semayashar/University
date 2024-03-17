#pragma once
#include "CPlant.h"
#include <string>
using namespace std;
class CFlower: public CPlant
{
protected:
	string color;
public:
	CFlower();
	CFlower(string color, string plantSpecies, float price, int count);
	void getData();
	void display();
};

