/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите число: ");
try
{
    int number = int.Parse(Console.ReadLine());
    int amount = number.ToString().Length;
    if (amount < 3 || amount > 3)
    {
        Console.WriteLine("Вы ввели не трехзначное число");
    }
    else
    {
        int result = (number / 10) % 10;
        Console.WriteLine($"Второе число это - {result}");
    }
}
catch (Exception)
{
    Console.WriteLine("Вы ввели не число");
} 