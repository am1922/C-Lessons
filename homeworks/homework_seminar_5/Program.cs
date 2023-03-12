// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray (int size)
// {
//     int minValue = 100;
//     int maxValue = 999;

//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine ();
// }

// int EvenCount(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.WriteLine("Input array size:"); 
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size); 
// ShowArray(array);
// Console.WriteLine(EvenCount(array));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine ();
// }

// int FindSumOddElements(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 != 0)
//         {
//             sum = sum + array[i];
//         }
//     }
//     return sum;
// }

// Console.WriteLine("Input array size:"); 
// int size = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Input minimal value of array element:"); 
// int minValue = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Input maximal value of array element:"); 
// int maxValue = Convert.ToInt32(Console.ReadLine()); 

// int[] array = CreateRandomArray(size, minValue, maxValue); 
// ShowArray(array); 
// Console.WriteLine(FindSumOddElements(array));

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateRandomArray (int size)
{
    double[] newArray = new double[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().NextDouble() * new Random().Next(1, 100);
    }
    return newArray;
}

void ShowArray (double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (Math.Round(array[i], 2) + " ");
    }
    Console.WriteLine ();
}

double FindMaxMinDif(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        else if(array[i] < min)
        {
            min = array[i];
        }
    }
    return max - min;
}

Console.WriteLine("Input array size:"); 
int size = Convert.ToInt32(Console.ReadLine()); 

double[] array = CreateRandomArray(size); 
ShowArray(array); 
Console.WriteLine(Math.Round(FindMaxMinDif(array), 2));