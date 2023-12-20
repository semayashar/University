//HEADERS:
#include "Town.h"
#include "ConnectedTown.h"

//INCLUDES:
#include<iostream>
#include<list>
#include<string>

using namespace std;

Town::Town() {
	Town::townName = "";
	Town::phoneID = 0;
}
Town::Town(string name, int id) {
	Town::townName = name;
	Town::phoneID = id;
}

//SETTERS:
void	Town::setTownName(string name) { Town::townName = name; }
void	Town::setPhoneID(int id) { Town::phoneID = id; }
void	Town::addToConnectedList(ConnectedTown town) { Town::connectedTownsList.push_back(town); }
//GETTERS:
string	Town::getTownName() { return Town::townName; }
int		Town::getPhoneID() { return Town::phoneID; }
list <ConnectedTown> Town::getConnectedTownsList() { return Town::connectedTownsList; }

//OTHERS:
void Town::printconnectionList() {
	list <ConnectedTown> connectionList = Town::getConnectedTownsList();
	cout << "{";
	for (auto it = connectionList.begin(); it != connectionList.end(); it++) {
		cout << "[" << it->getDestinationPhone_TownName() << "-" << it->getDestinationPhone_ID() << "(" << it->getDestinationPhone_Time() << ")], ";
	}
	cout << "}";
	cout << endl;
}
double Town::returnConnectedPhoneTime(int id) {
	list <ConnectedTown> connectionList = Town::getConnectedTownsList();
	for (auto it = connectionList.begin(); it != connectionList.end(); it++) {
		if (it->getDestinationPhone_ID() == id)
		{
			return it->getDestinationPhone_Time();
		}
	}
}

