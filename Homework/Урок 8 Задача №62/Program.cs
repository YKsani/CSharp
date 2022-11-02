/* Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int rows = 0;
int columns = 0;
EnterRows();
EnterColumns();
int[,] array1 = new int[rows, columns];
FillArraySpiral(array1, rows, columns);
PrintTwoDimensionalArray(array1);

void EnterRows()
{
    try
    {
        Console.Write("Введите число строк: ");
        rows = int.Parse(Console.ReadLine());
        if (rows <= 0)
        {
            Console.WriteLine("\nВы ввели отрицательное значение\n");
            EnterRows();
        }
    }
    catch (Exception)
    {
        Console.WriteLine("\nВы ввели некоректное значение\n");
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
            Console.WriteLine("\nВы ввели отрицательное значение\n");
            EnterColumns();
        }
        if (columns % 2 != 0)
        {
            Console.WriteLine("\nВведите четное колличество стобцов\n");
            EnterColumns();
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Вы ввели некоректное значение");
        EnterColumns();
    }
}


void FillArraySpiral(int[,] localArray, int n, int m)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * m; e++)
    {
        int k = 0;
        do
        {
            localArray[i, j++] = value++;
        }
        while (++k < m - 1);

        for (k = 0; k < n - 1; k++)
        {
            for (k = 0; k < n - 1; k++)
            {
                localArray[i++, j] = value++;
            }
        }
        for (k = 0; k < m - 1; k++)
        {
            for (k = 0; k < m - 1; k++)
            {
                localArray[i, j--] = value++;
            }
        }
        for (k = 0; k < n - 1; k++)
        {
            for (k = 0; k < n - 1; k++)
            {
                localArray[i--, j] = value++;
            }
        }
        i++; j++;
        n = n < 2 ? 0 : n - 2;
        m = m < 2 ? 0 : m - 2;
    }

}

void PrintTwoDimensionalArray(int[,] localArray)
{
    Console.WriteLine($"\n Спиральный массив размерами: {rows} на {columns}\n");
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
