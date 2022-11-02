/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int rows = 0;
int columns = 0;
EnterRows();
EnterColumns();
int[,] array = CreateTwoDimensionalArray(rows, columns);
PrintTwoDimensionalArray(array);
int[] array2 = SortingArray(array);
Console.WriteLine("Сумма элементов каждой из строк двумерного массива: \n");
PrintOneDimensionalArray(array2);

void EnterRows()
{
    try
    {
        Console.Write("Введите число строк: ");
        rows = int.Parse(Console.ReadLine());
        if (rows <= 0)
        {
            Console.WriteLine("Вы ввели отрицательное значение");
            EnterRows();
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Вы ввели некоректное значение");
        EnterRows();
    }
}

void EnterColumns()
{
    try
    {
        Console.Write("Введите число столбцов: ");
        columns = int.Parse(Console.ReadLine());
        if (columns <= 0)
        {
            Console.WriteLine("Вы ввели отрицательное значение");
            EnterColumns();
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Вы ввели некоректное значение");
        EnterColumns();
    }
}

int[,] CreateTwoDimensionalArray(int localRows, int localColumns)
{
    int[,] ints = new int[localRows, localColumns];
    Random random = new Random();
    for (uint i = 0; i < localRows; i++)
        for (uint j = 0; j < localColumns; j++)
        {
            ints[i, j] = random.Next(-10, 11);
        }
    return ints;
}

void PrintTwoDimensionalArray(int[,] localArray)
{
    for (uint i = 0; i < localArray.GetLength(0); i++)
    {
        for (uint j = 0; j < localArray.GetLength(1); j++)
        {
            Console.Write(Convert.ToString(localArray[i, j]).PadLeft(5));
            if (j < localArray.GetLength(1) - 1)
            {
                Console.Write(" | ");
            }
        }
        Console.WriteLine();
    }
}

void PrintOneDimensionalArray(int[] localArray)
{
    int numbers = 1;
    for (uint i = 0; i < localArray.Length; i++)
    {
        Console.Write(Convert.ToString(localArray[i]).PadLeft(5));
        if (i < localArray.Length)
        {
            Console.Write($" | строка № {numbers++}");
        }
        Console.WriteLine();
    }
}

int[] SortingArray(int[,] localArray)
{
    int[] summRows = new int[rows];
    int summ = 0;
    int minIndex = summRows[0];
    int EltmentMinSumm = 1;
    for (uint i = 0; i < localArray.GetLength(0); i++)
    {
        summ = 0;
        for (uint j = 0; j < localArray.GetLength(1); j++)
        {
            summ += localArray[i, j];
            summRows[i] = summ;
        }
    }
    for (int i = 0; i < summRows.Length; i++)
    {
        if (summRows[i] < minIndex)
        {
            minIndex = summRows[i];
            EltmentMinSumm = i + 1;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов = {EltmentMinSumm} \n");
    return summRows;
}
