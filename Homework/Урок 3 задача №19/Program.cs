/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.WriteLine("Введите пятизначное число: ");
try
{
    int number = int.Parse(Console.ReadLine());
    int amount = number.ToString().Length;
    int palindrome = number;
    if (amount < 5 || amount > 5)
    {
        Console.WriteLine("Вы ввели не пятизначное число");
    }
    else
    {
        int reminder, reverse = 0;
        while (number > 0)
        {
            reminder = number % 10;
            reverse = (reverse * 10) + reminder;
            number = number / 10;
        }
            {
                if (palindrome == reverse)
                {
                    Console.WriteLine($"Число {palindrome} палиндромом");;
                }
                else
                {
                    Console.WriteLine($"Число {palindrome} не палиндромом");
                }

            }
        }
    }
catch (Exception)
{
    Console.WriteLine("Вы ввели не число");
}Console.ReadLine();





/*string a = Console.ReadLine();

if (a[0] == a[4] && a[1] == a[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}*/