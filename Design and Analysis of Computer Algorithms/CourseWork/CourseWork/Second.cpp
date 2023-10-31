#include <iostream>
#include <limits>
#include <cmath>

int main() {
    long long number;

    while (true) {
        std::cout << "Enter a number (0 < number < 10^50): ";
        if (std::cin >> number && number > 0 && number < 1e50) {
            break;
        }
        else {
            std::cin.clear();
            std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\number');
            std::cout << "Invalid input. Please try again." << std::endl;
        }
    }

    std::cout << "Valid number: " << number << std::endl;
    return 0;
}
