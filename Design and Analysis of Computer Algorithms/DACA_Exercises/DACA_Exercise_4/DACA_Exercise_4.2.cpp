///*Задача 2.
//Даден е символен низ. Да се изведат символите, които се срещат повече от един път в низа.
//*/
//
//#include <iostream>
//#include <unordered_map>
//#include <vector>
//
//int main() {
//    std::string input;
//    std::cout << "Въведете символен низ: ";
//    std::getline(std::cin, input);
//
//    std::unordered_map<char, int> charCount;
//
//    // Преброяване на срещанията на всеки символ в низа
//    for (char ch : input) {
//        if (isalpha(ch)) {  // Можете да изключите този ред, ако искате да включите и други символи
//            charCount[ch]++;
//        }
//    }
//
//    // Извеждане на символите, които се срещат повече от веднъж
//    std::cout << "Символите, които се срещат повече от веднъж: ";
//    for (const auto& pair : charCount) {
//        if (pair.second > 1) {
//            std::cout << pair.first << " ";
//        }
//    }
//
//    return 0;
//}
