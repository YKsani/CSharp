/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int rows = 0;
int columns = 0;
EnterRows();
EnterColumns();
int[,] array1 = CreateTwoDimensionalArray(rows, columns);
int[,] array2 = CreateTwoDimensionalArray(rows, columns);
Console.WriteLine("\n Первая матрица: \n");
PrintTwoDimensionalArray(array1);
Console.WriteLine("\n Вторая матрица: \n");
PrintTwoDimensionalArray(array2);
Console.WriteLine("\n Произведение двух матриц \n");
int[,] resultArray = new int[rows, columns];
ResultArray();
PrintTwoDimensionalArray(resultArray);

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
            ints[i, j] = random.Next(1, 11);
        }
    return ints;
}

void PrintTwoDimensionalArray(int[,] localArray)
{
    for (uint i = 0; i < localArray.GetLength(0); i++)
    {
        for (uint j = 0; j < localArray.GetLength(1); j++)
        {
            Console.Write(Convert.ToString(localArray[i, j]).PadLeft(4));
            if (j < localArray.GetLength(1) - 1)
            {
                Console.Write(" | ");
            }
        }
        Console.WriteLine();
    }
}

int[,] ResultArray()
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                resultArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return resultArray;
}