#include <iostream>
#include <vector>
#include <algorithm>
#include <string>
#include <cmath>

// Функция за проверка на валидност на входното число
bool isValidInput(long long number) {
    return (number > 0 && number < 1e50);
}

// Функция за проверка дали дадено число е цяло
bool isInteger(double number) {
    return std::abs(number - round(number)) < 1e-9;
}

// Намиране на най-голямото число, което може да се състави с цифрите на входното число
std::string findLargestNumber(long long number) {
    std::vector<int> digits;
    while (number > 0) {
        int digit = number % 10;
        digits.push_back(digit);
        number /= 10;
    }

    // Сортиране на цифрите в низходящ ред
    std::vector<int> descendingOrder = digits;
    std::sort(descendingOrder.rbegin(), descendingOrder.rend());

    std::string largestNumber;
    for (int num : descendingOrder) {
        largestNumber += std::to_string(num);
    }

    return largestNumber;
}

// Намиране на най-малкото число, което може да се състави с цифрите на входното число
std::string findSmallestNumber(long long number) {
    std::vector<int> digits;
    while (number > 0) {
        int digit = number % 10;
        digits.push_back(digit);
        number /= 10;
    }

    // Сортиране на цифрите във възходящ ред, без първата цифра да бъде 0
    std::vector<int> ascendingOrder = digits;
    std::sort(ascendingOrder.begin(), ascendingOrder.end());
    while (ascendingOrder[0] == 0) {
        ascendingOrder.erase(ascendingOrder.begin());
        ascendingOrder.push_back(0);
    }

    std::string smallestNumber;
    for (int num : ascendingOrder) {
        smallestNumber += std::to_string(num);
    }

    return smallestNumber;
}

int main() {
    double input;
    std::cin >> input;

    if (!isValidInput(static_cast<long long>(input)) || !isInteger(input)) {
        std::cout << "Invalid input. Please enter a positive integer within the valid range." << std::endl;
        return 1;
    }

    long long number = static_cast<long long>(input);

    std::string largestNumber = findLargestNumber(number);
    std::string smallestNumber = findSmallestNumber(number);

    std::cout <<  largestNumber << std::endl;
    std::cout << smallestNumber << std::endl;

    return 0;
}
