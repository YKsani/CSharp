/* Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17->такого числа в массиве нет*/

int rows = 0;
int columns = 0;
int numbers = 0;
EnterRowsAndColumns();
double[,] array = CreateTwoDimensionalArray(rows, columns);
PrintTwoDimensionalArray(array);
EnterArray();
FindArrayAndPrint(array);

void EnterRowsAndColumns()
{

    try
    {
        Console.Write("Введите число строк: ");
        rows = int.Parse(Console.ReadLine());
        Console.Write("Введите число столбцов: ");
        columns = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Вы ввели некоректное значение");
        EnterRowsAndColumns();
    }
}

void EnterArray()
{
    try
    {
        Console.WriteLine("Введите позицию элемента");
        numbers = int.Parse(Console.ReadLine());
    }
    catch(Exception)
    {
        Console.WriteLine("Некорректное значение");
        EnterArray();
    }
}

double[,] CreateTwoDimensionalArray(int localRows, int localColumns)
{
    double[,] doubles = new double[localRows, localColumns];
    Random random = new Random();
    for (int i = 0; i < localRows; i++)
        for (int j = 0; j < localColumns; j++)
        {
            doubles[i, j] = Math.Round(random.Next(-10, 11) + random.NextDouble(), 1);
        }
    return doubles;
}

void PrintTwoDimensionalArray(double[,] localArray)
{
    for (int i = 0; i < localArray.GetLength(0); i++)
    {
        for (int j = 0; j < localArray.GetLength(1); j++)
        {
            Console.Write(Convert.ToString(localArray[i, j]).PadRight(6));
            if (j < localArray.GetLength(1) - 1)
            {
                Console.Write(" | ");
            }
        }
        Console.WriteLine();
    }
}

void FindArrayAndPrint(double[,] localArray)
{
    if (numbers == 0)
    {
        Console.WriteLine("Вы ввели некорректное значение");
    }
    if (numbers > (rows * columns))
    {
        Console.WriteLine("Такого элемента нет в массиве");
    }
    else
    {
        int i = (numbers - 1) / columns;
        int j = (numbers - 1) % columns;
        Console.WriteLine($"Значение элемента = {localArray[i, j]}");
    }
}