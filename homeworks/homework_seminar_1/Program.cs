// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Input first number -> ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number -> ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 != num2)
{
    if(num1 > num2)
    {
        Console.WriteLine($"First number {num1} bigest then second number {num2}");
    }
    else
    {
        Console.WriteLine($"Second number {num2} bigest then first number {num1}");
    }
}
else
{
    Console.WriteLine("First number and second number are equals");
}
