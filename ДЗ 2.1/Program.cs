// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число:");

string numberstring = Console.ReadLine();
int number = Convert.ToInt32(numberstring);
// Эксперементировал, если поставить "/" убирается последняя цифра в числе;
// Если поставить "%" то выводится последняя цифра в числе
// int x = number/10;
// System.Console.WriteLine(x);

int digit = number / 10 % 10;
System.Console.WriteLine(digit);