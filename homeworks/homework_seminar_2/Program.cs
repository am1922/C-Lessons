// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int DecNum(int num)
// {
//     int dec = (num / 10) % 10;
//    return dec;
// }

// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(DecNum(number));

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int num)
{
    while(num > 999)
    {
        num /= 10;
    }
    return num % 10;
}

bool ValidateNum(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = Convert.ToInt32(Console.ReadLine());

if (ValidateNum(number))
{
    Console.WriteLine(ThirdDigit(number));
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// string Weekend(int num)
// {
//     if (num < 8 & num > 0)
//     {
//         if (num == 6 | num == 7) return "yes";
//         else return "no";
//     }
//     else return "Число не в диапазоне от 1 до 7";
// }

// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{number} -> {Weekend(number)}");