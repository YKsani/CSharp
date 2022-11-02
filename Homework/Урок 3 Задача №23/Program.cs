/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
Console.Write("Введите целое число: ");
try
{
    int a = int.Parse(Console.ReadLine());

    for (int i = 1; i <= a; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}
catch (Exception)
{
    Console.WriteLine("Вы ввели не число");
}
Console.ReadLine();