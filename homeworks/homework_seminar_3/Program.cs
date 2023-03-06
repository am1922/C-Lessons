// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// string FindPalindrome (int num)
// {
//     int left = num / 1000;
//     int decLeft = left / 10;
//     int unitDigitLeft = left % 10;

//     int rigth = num % 100;
//     int decRigth = rigth / 10;
//     int unitDigitRight = rigth % 10;
  
//     if (decLeft == unitDigitRight & decRigth == unitDigitLeft) return "yes";
//     else return "no";
// }

// Console.WriteLine("Input five-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num} -> {FindPalindrome (num)}");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double FindDistace3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
}

Console.WriteLine("Input coordinates X of A point: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinates Y of A point: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinates Z of A point: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinates X of B point: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinates Y of B point: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinates Z of B point: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = FindDistace3D(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Distace between A and B is {distance}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
