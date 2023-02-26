// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Input first number -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 != num2)
// {
//     if(num1 > num2)
//     {
//         Console.WriteLine($"First number {num1} bigest then second number {num2}");
//     }
//     else
//     {
//         Console.WriteLine($"Second number {num2} bigest then first number {num1}");
//     }
// }
// else
// {
//     Console.WriteLine("First number and second number are equals");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Input three numbers and the application will determine which one is the maximum");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > num1) max = num2;
if (num3 > num2) max = num3;

Console.WriteLine($"Maximum of three numbers is {max}");
