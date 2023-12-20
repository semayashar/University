#pragma once

//HEADERS:
#include "ConnectedTown.h"

//INCLUDES:
#include<iostream>
#include<list>
#include<string>

using namespace std;

/*
This class is intended for the phones that are connected.
Each town is defined with a name, an unique phone number
and a list with its connections.

Functions:
 - printconnectionList() - prints all connected towns of a selected town.
 - returnConnectedPhoneTime(id) - prints connected town's time by its ID.
 */

class Town
{
	string	townName;
	int		phoneID;
	list <ConnectedTown> connectedTownsList;

public:
	//CONSTRUCTORS:
	Town();
	Town(string, int);

	//SETTERS:
	void	setTownName(string);
	void	setPhoneID(int);
	void	addToConnectedList(ConnectedTown);

	//GETTERS:
	string	getTownName();
	int		getPhoneID();
	list <ConnectedTown> getConnectedTownsList();

	//OTHERS:
	void printconnectionList();
	double returnConnectedPhoneTime(int);
};

