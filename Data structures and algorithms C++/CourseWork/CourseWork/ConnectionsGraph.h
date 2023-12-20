#pragma once
//HEADERS:
#include "Town.h"
#include "ConnectedTown.h"

//INCLUDES:
#include<iostream>
#include<vector>
#include<string>

using namespace std;

/*This class is intended for the all connections between towns.*/

class ConnectionsGraph
{
	vector <Town> connectionGraph;
	int countTown = 0;
	vector<vector<int>> paths;

public:
	//CHECKERS:
	bool	checkIfTownExistByPhoneID(int);
	bool	checkIfConnectionExistByID(int, int);

	//GETTERS:
	Town	getTownByPhoneID(int);
	string	getNameByPhoneID(int);
	int		getcountTown();
	vector<vector<int>> getPaths() const;

	//SETTERS:
	void	addTown(string);
	void	addConnectionByPhoneID(int, int, double);

	//OTHER:
	void	printGraph();
	void	createArray();
	void	increaseSize();
};


