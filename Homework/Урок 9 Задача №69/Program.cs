/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите M ");
int M = int.Parse(Console.ReadLine());
int summ = 0;
int getNumbers(int N, int M)
{
    if (M == 1)
    {
        return M;
    }
    else
    {
        return getNumbers((summ += N * N), M - 1);
    }
}
Console.WriteLine(getNumbers(N, M));