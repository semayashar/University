#pragma once
// HEADERS:
#include "Town.h"
#include "ConnectedTown.h"
#include "ConnectionsGraph.h"

// INCLUDES:
#include <iostream>
#include <vector>
#include <list>
#include <string>

using namespace std;

extern double** graph;
// CHECKERS:
bool ConnectionsGraph::checkIfTownExistByPhoneID(int id) {
    bool flag = false;
    for (int i = 0; i < connectionGraph.size(); i++) {
        if (connectionGraph.at(i).getPhoneID() == id) {
            return true;
        }
    }
    return flag;
}

bool ConnectionsGraph::checkIfConnectionExistByID(int fromphone, int tophone) {
    Town fromTown = getTownByPhoneID(fromphone);
    list<ConnectedTown> connectedTowns;
    connectedTowns = fromTown.getConnectedTownsList();
    bool flag = false;
    for (auto it = connectedTowns.begin(); it != connectedTowns.end(); it++) {
        if (it->getDestinationPhone_ID() == tophone) {
            flag = true;
            return flag;
            break;
        }
    }
    return flag;
}

// GETTERS:
Town ConnectionsGraph::getTownByPhoneID(int id) {
    Town temp;
    for (int i = 0; i < connectionGraph.size(); i++) {
        temp = connectionGraph.at(i);
        if (temp.getPhoneID() == id) {
            return temp;
        }
    }
    return temp;
}

string ConnectionsGraph::getNameByPhoneID(int id) {
    Town temp;
    for (int i = 0; i < connectionGraph.size(); i++) {
        temp = connectionGraph.at(i);
        if (temp.getPhoneID() == id) {
            return temp.getTownName();
        }
    }
    return temp.getTownName();
}

int ConnectionsGraph::getcountTown() {
    return countTown;
}

vector<vector<int>> ConnectionsGraph::getPaths() const {
    return paths;
}

// SETTERS:
void ConnectionsGraph::addTown(string townName) {
    Town curTown;
    curTown.setTownName(townName);
    curTown.setPhoneID(countTown);
    bool check = checkIfTownExistByPhoneID(curTown.getPhoneID());
    if (check == true) {
        cout << "A phone number with this ID already exists!" << endl;
    }
    else {
        connectionGraph.push_back(curTown);
        increaseSize();
        cout << "Unique phone number: " << curTown.getPhoneID() << endl;
        cout << "The phone number has been successfully recorded!" << endl;
    }
}

void ConnectionsGraph::addConnectionByPhoneID(int fromphone, int tophone, double time) {
    bool check1 = checkIfTownExistByPhoneID(fromphone);
    bool check2 = checkIfTownExistByPhoneID(tophone);
    bool check3 = checkIfConnectionExistByID(fromphone, tophone);

    if ((check1 && check2 == true)) {
        if (check3 == true) {
            cout << "\nThe connection between " << getTownByPhoneID(fromphone).getTownName() << "(" << fromphone << ") and "
                << getTownByPhoneID(tophone).getTownName() << "(" << tophone << ") already exists." << endl;
        }
        else {
            string nameFP, nameTP;
            for (int i = 0; i < connectionGraph.size(); i++) {
                if (connectionGraph.at(i).getPhoneID() == fromphone) {
                    nameFP = connectionGraph.at(i).getTownName();
                    fromphone = connectionGraph.at(i).getPhoneID();
                }
                if (connectionGraph.at(i).getPhoneID() == tophone) {
                    nameTP = connectionGraph.at(i).getTownName();
                    tophone = connectionGraph.at(i).getPhoneID();
                }
            }
            for (int i = 0; i < connectionGraph.size(); i++) {
                if (connectionGraph.at(i).getPhoneID() == fromphone) {
                    ConnectedTown e(nameTP, tophone, time);
                    connectionGraph.at(i).addToConnectedList(e);
                }
                else if (connectionGraph.at(i).getPhoneID() == tophone) {
                    ConnectedTown e(nameFP, fromphone, time);
                    connectionGraph.at(i).addToConnectedList(e);
                }
            }
            cout << "\nThe connection between " << nameFP << " and " << nameTP << " has been added SUCCESSFULLY!" << endl;
        }
    }
    else {
        cout << "\nIncorrect ID!";
    }
    vector<int> path = { fromphone, tophone};
    paths.push_back(path);
}

// OTHER:
void ConnectionsGraph::printGraph() {
    for (int i = 0; i < connectionGraph.size(); i++) {
        Town temp;
        temp = connectionGraph.at(i);
        cout << temp.getTownName() << " (" << temp.getPhoneID() << ") --> ";
        temp.printconnectionList();
    }
}

void ConnectionsGraph::createArray() {
    Town temp1, temp2;

    graph = new double* [countTown];

    for (int i = 0; i < countTown; i++) {
        graph[i] = new double[countTown];
        for (int j = 0; j < countTown; j++) {
            graph[i][j] = 9999;
        }
    }

    for (int i = 0; i < connectionGraph.size(); i++) {
        temp1 = connectionGraph.at(i);
        for (int y = 0; y < connectionGraph.size(); y++) {
            temp2 = connectionGraph.at(y);
            if (temp1.getPhoneID() != temp2.getPhoneID()) {
                if (checkIfConnectionExistByID(temp1.getPhoneID(), temp2.getPhoneID())) {
                    graph[i][y] = temp1.returnConnectedPhoneTime(temp2.getPhoneID());
                }
                else {
                    graph[i][y] = 9999;
                }
            }
            else {
                graph[i][y] = 0;
            }
        }
    }

    for (int i = 0; i < countTown; i++) {
        for (int y = 0; y < countTown; y++) {
            if (graph[i][y] == 9999) {
                cout << "-" << "\t";
            }
            else {
                cout << graph[i][y] << "\t";
            }
        }
        cout << "\n";
    }
}

void ConnectionsGraph::increaseSize() {
    ConnectionsGraph::countTown++;
}
