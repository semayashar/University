#pragma once
#include "CPlant.h"
#include<iostream>
#include<string>
using namespace std;
class CTree: public CPlant
{
protected:
	//coniferous - iglolistni
	//broad leaved / deciduous - широколистни
	string type;
	float height;
public:
	CTree();
	CTree(string type, float height, string plantSpecies, float price, int count);
	void getData();
	void display();
};

