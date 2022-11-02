/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N(включительно).

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите число: ");
try
{
    int number = int.Parse(Console.ReadLine());
    for (int i = 0; i <= Math.Abs(number);  i++) //если необходимо не включать последнее значение меняем <= на <
    {
        if (i % 2 == 0)
        {
            if (number < 0)
                Console.Write($"{-i} ");
            else
                Console.Write($"{i} ");
        }

    }
}catch (Exception)
{
    Console.WriteLine("Вы ввели не число");
}
Console.ReadKey();  
//Ура! получилось сделать проверку на число, теперь понял как работает и с минусом!!!!