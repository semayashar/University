// HEADERS:
#include "ConnectionsGraph.h"
#include "ConnectedTown.h"
#include "Town.h"

// INCLUDES
#include <iostream>
#include <string>
#include <Windows.h>

using namespace std;

// VARIABLES:
double** graph;
ConnectionsGraph connectionGraph;

// REQUIRED FUNCTIONS:
//void printSolution(double dist[], int id)
//{
//    string nameFrom = connectionGraph.getNameByPhoneID(id);
//    printf("!!! FROM -> TO (MTV) !!!\n*MTV - Minimum Time Required\n\n");
//    for (int i = 0; i < connectionGraph.getcountTown(); i++)
//    {
//        string townName = connectionGraph.getNameByPhoneID(i);
//        cout << " * " << nameFrom << " -> " << townName << " (";
//        if (dist[i] == 9999)
//        {
//            cout << "no connection";
//        }
//        else
//        {
//            cout << dist[i];
//        }
//        cout << ");" << endl;
//    }
//}
void printSolution(double dist[], int id, const vector<vector<int>>& paths) {
    string nameFrom = connectionGraph.getNameByPhoneID(id);
    printf("!!! FROM -> TO (MTV) !!!\n*MTV - Minimum Time Required\n\n");
    for (int i = 0; i < connectionGraph.getcountTown(); i++) {
        string townName = connectionGraph.getNameByPhoneID(i);
        cout << " * " << nameFrom << " -> " << townName << " (";
        if (dist[i] == 9999) {
            cout << "no connection";
        }
        else {
            cout << dist[i] << ", Path: ";
            // Print the path
            for (int node : paths[i]) {
                cout << node << " -> ";
            }
            cout << townName;
        }
        cout << ");" << endl;
    }
}



int menu()
{
    int option;
    cout << "\nPlease choose an option. " <<
        "Enter 0 to exit." << endl;
    cout << "1. Add town" << endl;
    cout << "2. Create connection" << endl;
    cout << "3. Phone number graph" << endl;
    cout << "4. Print all connections" << endl;
    cout << "0. Exit" << endl;

    cin >> option;
    return option;
}

// DIJKSTRA'S METHOD:
int miniDist(double distance[], bool Tset[], int countTown)
{
    double minimum = 9999, ind;

    for (int k = 0; k < countTown; k++)
    {
        if (Tset[k] == false && distance[k] <= minimum)
        {
            minimum = distance[k];
            ind = k;
        }
    }
    return ind;
}

void DijkstraAlgo(double** graph, int src, int countTown)
{
    double* distance = new double[countTown];
    bool* Tset = new bool[countTown];

    for (int k = 0; k < countTown; k++)
    {
        distance[k] = 9999;
        Tset[k] = false;
    }

    distance[src] = 0;

    for (int k = 0; k < countTown; k++)
    {
        int m = miniDist(distance, Tset, countTown);
        Tset[m] = true;
        for (int k = 0; k < countTown; k++)
        {
            if (!Tset[k] && graph[m][k] && distance[m] != 9999 && distance[m] + graph[m][k] < distance[k])
                distance[k] = distance[m] + graph[m][k];
        }
    }

    cout << endl << "Key town: " << src << endl;
    cout << "Connections:\n\n";
    printSolution(distance, src, connectionGraph.getPaths());
}

// PROGRAM:
/* Function: Determines the minimum time required to convey specific
information from a given starting town to all other towns. */
int main() {

    SetConsoleOutputCP(1251);
    system("chcp 1251");

    string townName;
    int ID1, ID2, option;
    double time;
    bool check;

    do {
        // Display menu and choose an option:
        option = menu();
        Town newTown;

        switch (option) {
        case 0:
            break;

        case 1:
            // Add a town by manually entering the name and automatically generating a unique number:
            cout << "\nOption: Add town" << endl;
            cout << "Name: "; cin.ignore(); getline(cin, townName);
            connectionGraph.addTown(townName);
            break;

        case 2:
            // Connect two towns by entering unique numbers and the required time:
            cout << "\nOption: Create connection" << endl;
            cout << "Unique number of the first phone cable: "; cin >> ID1;
            cout << "Unique number of the second phone cable: "; cin >> ID2;
            cout << "Time unit: "; cin >> time;
            connectionGraph.addConnectionByPhoneID(ID1, ID2, time);
            break;

        case 3:
            // Display all connections between towns:
            cout << "\nPhone number graph\n" << endl;
            connectionGraph.printGraph();
            break;

        case 4:
            // Display the interaction matrix:
            cout << "\nDisplay interaction matrix\n" << endl;
            connectionGraph.createArray();
            // Enter the key unique number and find the minimum required time:
            cout << "\nUnique number (key phone number): "; cin >> ID1; cout << endl;
            DijkstraAlgo(graph, ID1, connectionGraph.getcountTown());
            break;

        default:
            cout << "\nPlease try again" << endl;
            break;
        }
        cout << endl;

    } while (option != 0);

    return 0;
}
