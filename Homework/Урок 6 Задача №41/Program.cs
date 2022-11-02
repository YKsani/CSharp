/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */


Console.WriteLine($"Для завершения ввода чисел введите 'Exit'");
uint count = 0;

uint EnterValueAndScoreCount()
{
    string s = string.Empty;
    Console.WriteLine($"Вводите числа через Enter:");
    try
    {
        while (s.ToLower() != "exit")
        {
            s = Console.ReadLine();
            if (s.ToLower() != "exit")
                if (int.Parse(s) > 0)
                    count++;
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Вы ввели не число");
        return EnterValueAndScoreCount();

    }
    return count;
}

Console.WriteLine($"Количество чисел больше 0 = {EnterValueAndScoreCount()}");



