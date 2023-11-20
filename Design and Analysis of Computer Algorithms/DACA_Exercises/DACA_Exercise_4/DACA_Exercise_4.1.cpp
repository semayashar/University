///*Задача 1.
//Зададен е символен низ с дължина не по-голяма от 1000000.
//Да намери броят на думите в низа. Думите са разделени с интервали.
//За всяка дума да се изведе и брой срещания в низа.
//Да се изведе и най-често срещаната дума.
//Ако има няколко такива, да се изведе най-малката в лексикографски ред.
//
//Пример
//Вход
//много много думи думи думи в един символен низ.
//
//Изход
//9
//много – 2
//думи – 3
//в – 1
//един – 1
//символен – 1
//низ – 1
//думи
//*/
//
//#include <iostream>
//#include <string>
//#include <sstream>
//#include <map>
//#include <set>
//
//int main() {
//
//    // Прочитане на входа
//    std::string input;
//    std::getline(std::cin, input);
//
//    // Проверка за максимална дължина на входа
//    if (input.length() > 1000000) {
//        std::cerr << "Грешка: Дължината на входния низ трябва да бъде не повече от 1000000 символа." << std::endl;
//        return 1;
//    }
//
//    // Подготовка за обработка на думите
//    std::map<std::string, int> wordCount;
//    std::istringstream iss(input);
//    std::string word;
//
//    // Броене на думите и запълване на мапа
//    while (iss >> word) {
//        wordCount[word]++;
//    }
//
//    // Извеждане на общия брой на думите
//    std::cout << wordCount.size() << std::endl;
//
//    // Извеждане на броя срещания за всяка дума
//    for (const auto& pair : wordCount) {
//        std::cout << pair.first << " – " << pair.second << std::endl;
//    }
//
//    // Намиране на най-често срещаната дума
//    int maxCount = 0;
//    std::set<std::string> mostFrequentWords;
//
//    for (const auto& pair : wordCount) {
//        if (pair.second > maxCount) {
//            maxCount = pair.second;
//            mostFrequentWords.clear();
//            mostFrequentWords.insert(pair.first);
//        }
//        else if (pair.second == maxCount) {
//            mostFrequentWords.insert(pair.first);
//        }
//    }
//
//    // Намиране на най-малката дума в лексикографски ред
//    std::string smallestWord = *mostFrequentWords.begin();
//    for (const auto& word : mostFrequentWords) {
//        if (word < smallestWord) {
//            smallestWord = word;
//        }
//    }
//
//    // Извеждане на най-често срещаната дума
//    std::cout << smallestWord << std::endl;
//
//    return 0;
//}
