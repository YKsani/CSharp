/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите число от 1 до 7, согласно номеру дня недели: ");
int day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1:
        {
            Console.WriteLine("Нет / Понедельник не выходной");
            break;
        }
    case 2:
        {
            Console.WriteLine("Нет / Вторник не выходной день");
            break;
        }
    case 3:
        {
            Console.WriteLine("Нет / Среда не выходной день");
            break;
        }
    case 4:
        {
            Console.WriteLine("Нет / Четверг не выходной день");
            break;
        }
    case 5:
        {
            Console.WriteLine("Нет / Пятница не выходной день");
            break;
        }
    case 6:
        {
            Console.WriteLine("Да / Суббота выходной день");
            break;
        }
    case 7:
        {
            Console.WriteLine("Да / Воскресенье выходной день");
            break;
        }
    default:
        {
            Console.WriteLine("Вы ввели неподходящее значение");
            break;
        }
}
Console.ReadLine();