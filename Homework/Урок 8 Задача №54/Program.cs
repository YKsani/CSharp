/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int rows = 0;
int columns = 0;
EnterRows();
EnterColumns();
int[,] array = CreateTwoDimensionalArray(rows, columns);
PrintTwoDimensionalArray(array);
SortingArray(array);
Console.WriteLine("Отсортированный массив");
PrintTwoDimensionalArray(SortingArray(array));

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

int[,] SortingArray(int[,] localArray)
{
    int temp;
    for (uint rows = 0; rows < localArray.GetLength(0); rows++)
        for (uint i = 0; i < localArray.GetLength(1) - 1; i++)
        {
            for (uint j = i + 1; j < localArray.GetLength(1); j++)
            {
                if (localArray[rows, i] < localArray[rows, j])
                {
                    temp = localArray[rows, i];
                    localArray[rows, i] = localArray[rows, j];
                    localArray[rows, j] = temp;
                }
            }
        }
    return localArray;
}