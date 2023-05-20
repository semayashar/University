#pragma once
#include<iostream>
#include<string>
using namespace std;
class CWorker
{
protected:
	string name;
	string IDE;
	float dailyWage;
	int daysWorked;
public:
	CWorker();
	CWorker(string name, string IDE, float dailyWage, int daysWorked);
	void addWorker();
	void display();
	void womenAboveTwentyTwoYers();
	bool returnPerson();
};