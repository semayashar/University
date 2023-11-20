///*Задача 3.
//Дадени са два символни низа. Да се изведат символите, които се срещат и в двата низа.
//*/
//
//#include <iostream>
//#include <unordered_set>
//
//int main() {
//    std::string str1, str2;
//
//    // Въвеждане на двата символни низа
//    std::cout << "Въведете първия символен низ: ";
//    std::getline(std::cin, str1);
//
//    std::cout << "Въведете втория символен низ: ";
//    std::getline(std::cin, str2);
//
//    // Създаване на множество за уникални символи в първия низ
//    std::unordered_set<char> set1;
//    for (char ch : str1) {
//        set1.insert(ch);
//    }
//
//    // Извеждане на общите символи в двата низа
//    std::cout << "Общите символи в двата низа са: ";
//    for (char ch : str2) {
//        if (set1.find(ch) != set1.end()) {
//            std::cout << ch << " ";
//            // Използваме set1.erase(ch); ако искаме да изключим повтарящите се символи
//        }
//    }
//
//    return 0;
//}
