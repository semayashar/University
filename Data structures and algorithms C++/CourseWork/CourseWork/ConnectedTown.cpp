#include "ConnectedTown.h"
//INCLUDES:
#include<iostream>
#include<vector>
#include<string>
#include<list>
using namespace std;

//CONSTRUCTORS:
ConnectedTown::ConnectedTown() {
	ConnectedTown::DestinationPhone_TownName = "";
	ConnectedTown::DestinationPhone_ID = 0;
	ConnectedTown::DestinationPhone_Time = 0;
}
ConnectedTown::ConnectedTown(string name, int id, double time) {
	ConnectedTown::DestinationPhone_TownName = name;
	ConnectedTown::DestinationPhone_ID = id;
	ConnectedTown::DestinationPhone_Time = time;
}

//SETTERS:
void	ConnectedTown::setDestinationPhone_TownName(string name) { ConnectedTown::DestinationPhone_TownName = name; }
void	ConnectedTown::setDestinationPhone_ID(int id) { ConnectedTown::DestinationPhone_ID = id; }
void	ConnectedTown::setDestinationPhone_Time(double time) { ConnectedTown::DestinationPhone_Time = time; }

//GETTERS:
string	ConnectedTown::getDestinationPhone_TownName() { return ConnectedTown::DestinationPhone_TownName; }
int		ConnectedTown::getDestinationPhone_ID() { return ConnectedTown::DestinationPhone_ID; }
double	ConnectedTown::getDestinationPhone_Time() { return ConnectedTown::DestinationPhone_Time; }
