/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B(2, 1, -7), -> 15.84
A(7, -5, 0); B(1, -1, 9)-> 11.53*/



try
{
    Console.WriteLine("Введите координту x1");
    int x1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координту y1");
    int y1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координту z1");
    int z1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координту x2");
    int x2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координту y2");
    int y2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координту z2");
    int z2 = int.Parse(Console.ReadLine());

    int a = (x2 - x1);
    int b = (y2 - y1);
    int c = (z2 - z1);

    double res = Math.Sqrt(a * a + b * b + c * c);
    Console.WriteLine(res);
}
catch (Exception)
{
    Console.WriteLine("Вы ввели не число");
}
Console.ReadLine();