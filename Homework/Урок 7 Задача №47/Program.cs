/* Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/


int rows = 0;
int columns = 0;
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
        Environment.Exit(0);
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
            Console.Write(Convert.ToString(localArray[i, j]).PadLeft(6));
            if (j < localArray.GetLength(1) - 1)
            {
                Console.Write(" | ");
            }
        }
        Console.WriteLine();
    }
}

EnterRowsAndColumns();
double[,] array = CreateTwoDimensionalArray(rows, columns);
PrintTwoDimensionalArray(array);