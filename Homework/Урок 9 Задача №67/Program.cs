/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/

System.Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine());
int sum = 0;
int getNumbers(int N)
{
    if (N < 10)
    {
        System.Console.WriteLine(N);
        return N;
    }
    else
    {
        return getNumbers(N / 10 + (N % 10));
    }
}
getNumbers(N);

