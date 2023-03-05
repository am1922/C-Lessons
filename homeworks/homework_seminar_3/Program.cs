﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string FindPalindrome (int num)
{
    int left = num / 1000;
    int decLeft = left / 10;
    int unitDigitLeft = left % 10;

    int rigth = num % 100;
    int decRigth = rigth / 10;
    int unitDigitRight = rigth % 10;
  
    if (decLeft == unitDigitRight & decRigth == unitDigitLeft) return "yes";
    else return "no";
}

Console.WriteLine("Input five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num} -> {FindPalindrome (num)}");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
