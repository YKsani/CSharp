/* Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int rows = 0;
int columns = 0;
EnterRows();
EnterColumns();
int[,] array = CreateTwoDimensionalArray(rows, columns);
PrintTwoDimensionalArray(array);
PrintArithmeticMean(array);

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
            Console.Write(Convert.ToString(localArray[i, j]).PadLeft(6));
            if (j < localArray.GetLength(1) - 1)
            {
                Console.Write(" | ");
            }
        }
        Console.WriteLine();
    }
}

void PrintArithmeticMean(int[,] localArray)
{

    for (uint j = 0; j < localArray.GetLength(1); j++)
    {
        double summ = 0;
        for (uint i = 0; i < localArray.GetLength(0); i++)
        {
            summ += localArray[i, j];
        }
        Console.WriteLine();
        Console.WriteLine($"Среднее арифметическое для столбца {j + 1} = {Math.Round(summ / localArray.GetLength(0), 2)} ");
    }
}