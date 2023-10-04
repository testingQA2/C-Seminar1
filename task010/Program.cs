// 11. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = new Random().Next(100, 1000);

int deleteSecondDigit = DeleteSecondDigit(number);
Console.WriteLine($"{number} -> {deleteSecondDigit}");

int DeleteSecondDigit(int num) //решение с помощью метода
{
    int firstDigit = num / 100; 
    int lastDigit = num % 10;
    int numResult = firstDigit * 10 + lastDigit;
    return numResult;
}


// int number = new Random().Next(100, 1000); Решение задачи способом написания кода
// int firstDigit = number / 100; 
// int lastDigit = number % 10;
// int numResult = firstDigit * 10 + lastDigit;
// Console.WriteLine($"{number} -> {numResult}");



