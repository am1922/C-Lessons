// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Degree (int n, int x)
// {
//     int result = 1;
//     for (int i = 1; i <= x; i++)
//     {
//         result = result * n;
//     }
//     return result;
// }

// Console.WriteLine ("Input number:");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("Input degree:");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ($"{n} -> {Degree(n, x)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int FindSum (int n)
// {
//     int sum = 0;
//     while (n > 0)
//     {
//         sum += n % 10;
//         n = n / 10;
//     }
//     return sum;
// }

// Console.WriteLine ("Input number:");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ($"{n} -> {FindSum(n)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return  newArray;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine ("Input array size:");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input minimum value of array element:");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input maximum value of array element:");
int maxValue = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateRandomArray(size, minValue, maxValue));