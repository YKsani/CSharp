/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16*/

try
{
    Console.Write("Введите число A: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите число B: ");
    int b = int.Parse(Console.ReadLine());
    int degree = a;
    for (int i = 1; i < b; i++)
    {
        degree *= a;
    }
    Console.WriteLine($"А в степени В = {degree}");
}
catch (Exception)
{
    Console.WriteLine("Вы ввели не число");
}