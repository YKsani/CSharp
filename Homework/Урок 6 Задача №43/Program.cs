/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

try
{
    Console.WriteLine("введите значение b1");
    double b1 = double.Parse(Console.ReadLine());
    Console.WriteLine("введите число k1");
    double k1 = double.Parse(Console.ReadLine());
    Console.WriteLine("введите значение b2");
    double b2 = double.Parse(Console.ReadLine());
    Console.WriteLine("введите число k2");
    double k2 = double.Parse(Console.ReadLine());

    if (k1 == k2 && b1 != b2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (k1 != k2 && b1 != b2)
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = k2 * x + b2;
        Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    }
}
catch (Exception)
{
    Console.WriteLine("Вы ввели некоректные значения");
}


