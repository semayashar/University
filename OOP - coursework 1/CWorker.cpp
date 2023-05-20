#include "CWorker.h"
#include <iostream>
#include <string>
#include <string.h>
#include <vector>
#include <tuple>
using namespace std;

//Needed functions:
tuple <int, int, int> Date() {
	struct tm newtime;
	time_t now = time(0);
	localtime_s(&newtime, &now);
	int currentDay = newtime.tm_mday;
	int currentMonth = 1 + newtime.tm_mon;
	int currentYear = 1900 + newtime.tm_year;
	return { currentDay, currentMonth ,currentYear };
}
int getAge(string IDE)
{
	//FINDING THE YEAR OF BIRTH
	string fullYear, year, month, day;
	int fullYearINT = 0, monthINT = 0, dayINT = 0;
	year = IDE.substr(0, 2);
	month = IDE.substr(2, 2);
	day = IDE.substr(4, 2);
	monthINT = stoi(month);
	if (monthINT > 40)
	{
		//за родените след 31 декември 1999 г. до 31 декември 2099 г. към месеца се прибавя числото 40.
		monthINT = monthINT - 40;
		month = to_string(monthINT);
		fullYear = { "20" + year };
		fullYearINT = stoi(fullYear);
		dayINT = stoi(day);
	}
	else if (monthINT > 20)
	{
		//за родените преди 1 януари 1900 г. към месеца се прибавя числото 20,
		monthINT = monthINT - 20;
		month = to_string(monthINT);
		fullYear = { "18" + year };
		fullYearINT = stoi(fullYear);
		dayINT = stoi(day);
	}
	else
	{
		//за родените след 1 януари 1900г. до 1999г.
		month = to_string(monthINT);
		fullYear = { "19" + year };
		fullYearINT = stoi(fullYear);
		dayINT = stoi(day);
	}

	//FINDING THE AGE OF THE PERSON:
	// 
	//today's date: 

	int currentDay, currentMonth, currentYear;
	tie(currentDay, currentMonth, currentYear) = Date();

	//age:
	int AGE = currentYear - fullYearINT;
	if (currentMonth < monthINT)
	{
		AGE--;
	}
	else if (currentMonth == monthINT)
	{
		if (currentDay < dayINT)
		{
			AGE--;
		}
	}

	return AGE;
}
char getGender(string IDE) {
	char digit = IDE[8];
	int digitINT = digit - '0';
	if (digitINT % 2 == 0)
	{
		return 'm';
	}
	else
	{
		return 'w';
	}
}
float earndMoney(int days, float dailyWage)
{
	float total = days * dailyWage;
	return total;
}

//FUNCTIONS:
CWorker::CWorker()
{
	CWorker::name = "UNKNOWN";
	CWorker::IDE = "0000000000";
	CWorker::dailyWage = 0;
	CWorker::daysWorked = 0;
}
CWorker::CWorker(string name, string IDE, float dailyWage, int daysWorked)
{
	CWorker::name = name;
	CWorker::IDE = IDE;
	CWorker::dailyWage = dailyWage;
	CWorker::daysWorked = daysWorked;
}
void CWorker::addWorker()
{
	cout << "Enter the name of the new worker: "; getline(cin, CWorker::name);
	cout << "Enter IDE of " << CWorker::name << " : "; cin >> IDE;
	cout << "Enter daily wage of " << CWorker::name << " : "; cin >> CWorker::dailyWage;
	cout << "Enter the cout of the days he/she worked: "; cin >> CWorker::daysWorked;
};
void CWorker::display()
{
	cout << "The name of the worker: " << CWorker::name << endl;
	cout << "IDE of " << CWorker::name << " : " << IDE << endl;
	{
		cout << fixed;
		cout.precision(2);
		cout << "Daily wage of " << CWorker::name << " : " << CWorker::dailyWage << "lv." << endl;
	}
	cout << "Cout of the days he/she worked: " << CWorker::daysWorked << endl;
}
void CWorker::womenAboveTwentyTwoYers()
{
	if (getAge(CWorker::IDE) >= 22 && CWorker::daysWorked >= 15 && getGender(CWorker::IDE) == 'w')
	{
		cout << "- " << CWorker::name << endl;
	}
};
bool CWorker::returnPerson()
{
	if (getGender(CWorker::IDE) == 'w' && earndMoney(CWorker::daysWorked, CWorker::dailyWage) >= 300)
	{
		return true;
	}
	else
	{
		return false;
	}
}
