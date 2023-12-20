#pragma once

//INCLUDES:
#include<iostream>
#include<vector>
#include<string>
#include<list>
using namespace std;

/*
This class is intended for the phones that are going to be connected.
Each phone is defined with a name, which will represent a town,
an unique number and needed time to connect with a selected town.
*/
class ConnectedTown
{
	string	DestinationPhone_TownName;
	int		DestinationPhone_ID;
	double	DestinationPhone_Time;

public:
	//CONSTRUCTORS:
	ConnectedTown();
	ConnectedTown(string, int, double);

	//SETTERS:
	void	setDestinationPhone_TownName(string);
	void	setDestinationPhone_ID(int);
	void	setDestinationPhone_Time(double);

	//GETTERS:
	string	getDestinationPhone_TownName();
	int		getDestinationPhone_ID();
	double	getDestinationPhone_Time();
};
