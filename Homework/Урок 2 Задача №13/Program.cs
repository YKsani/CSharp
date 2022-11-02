/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Введите число: ");
try
{
    int number = int.Parse(Console.ReadLine());
    int amount = number.ToString().Length;
    if (amount < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }    
    else if (amount > 3)
        {
            Console.WriteLine("Вы ввели больше трёх цифр");
        }
    else
    {
        int result = (number % 10);
        Console.WriteLine($"Третье число это - {result}");
    }
}
catch (Exception)
{
    Console.WriteLine("Вы ввели не число");
}Console.ReadLine();