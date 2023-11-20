#include <iostream>
#include <sstream>
#include <string>
#include <vector>
#include <map>
#include <set>
#include <unordered_map>
#include <unordered_set>

using namespace std;

void Exc_4_1() {
    // Прочитане на входа
    std::string input;
    std::getline(std::cin, input);

    // Проверка за максимална дължина на входа
    if (input.length() > 1000000) {
        std::cerr << "Грешка: Дължината на входния низ трябва да бъде не повече от 1000000 символа." << std::endl;
    }

    // Подготовка за обработка на думите
    std::map<std::string, int> wordCount;
    std::istringstream iss(input);
    std::string word;

    // Броене на думите и запълване на мапа
    while (iss >> word) {
        wordCount[word]++;
    }

    // Извеждане на общия брой на думите
    std::cout << wordCount.size() << std::endl;

    // Извеждане на броя срещания за всяка дума
    for (const auto& pair : wordCount) {
        std::cout << pair.first << " – " << pair.second << std::endl;
    }

    // Намиране на най-често срещаната дума
    int maxCount = 0;
    std::set<std::string> mostFrequentWords;

    for (const auto& pair : wordCount) {
        if (pair.second > maxCount) {
            maxCount = pair.second;
            mostFrequentWords.clear();
            mostFrequentWords.insert(pair.first);
        }
        else if (pair.second == maxCount) {
            mostFrequentWords.insert(pair.first);
        }
    }

    // Намиране на най-малката дума в лексикографски ред
    std::string smallestWord = *mostFrequentWords.begin();
    for (const auto& word : mostFrequentWords) {
        if (word < smallestWord) {
            smallestWord = word;
        }
    }

    // Извеждане на най-често срещаната дума
    std::cout << smallestWord << std::endl;
};

void Exc_4_2() {
    std::string input;
    std::cout << "Въведете символен низ: ";
    std::getline(std::cin, input);

    std::unordered_map<char, int> charCount;

    // Преброяване на срещанията на всеки символ в низа
    for (char ch : input) {
        if (isalpha(ch)) {  // Можете да изключите този ред, ако искате да включите и други символи
            charCount[ch]++;
        }
    }

    // Извеждане на символите, които се срещат повече от веднъж
    std::cout << "Символите, които се срещат повече от веднъж: ";
    for (const auto& pair : charCount) {
        if (pair.second > 1) {
            std::cout << pair.first << " ";
        }
    }
}

void Exc_4_3() {
    std::string str1, str2;

    // Въвеждане на двата символни низа
    std::cout << "Въведете първия символен низ: ";
    std::getline(std::cin, str1);

    std::cout << "Въведете втория символен низ: ";
    std::getline(std::cin, str2);

    // Създаване на множество за уникални символи в първия низ
    std::unordered_set<char> set1;
    for (char ch : str1) {
        set1.insert(ch);
    }

    // Извеждане на общите символи в двата низа
    std::cout << "Общите символи в двата низа са: ";
    for (char ch : str2) {
        if (set1.find(ch) != set1.end()) {
            std::cout << ch << " ";
            // Използваме set1.erase(ch); ако искаме да изключим повтарящите се символи
        }
    }
}

int main() {
	return 0;
}