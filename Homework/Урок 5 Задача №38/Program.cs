/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

int EnterSizeArray()
{
    int size = 0;
    Console.Write("Введите длину массива: ");
    try
    {
        size = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Вы ввели некоректное значение");
        Environment.Exit(0);
    }
    return size;
}

double[] CreateArray(int array)
{
    double[] doubles = new double[array];
    Random random = new Random();
    for (int i = 0; i < array; i++)
    {
        doubles[i] = Math.Round(random.Next(-10, 11) + random.NextDouble(), 2);
    }
    return doubles;
}

double DiffMinMaxArray(double[] localArray)
{
    double result = 0;
    double min = localArray[0];
    double max = localArray[0];
    for (int i = 0; i < localArray.Length; i++)
    {
        if (localArray[i] < min)
        {
            min = localArray[i];
        }
        if (localArray[i] > max)
        {
            max = localArray[i];
        }
    }
    result = max - min;
    return result;
}

void PrintArrayDiff(double[] localArray, double diff)
{
    Console.Write("[");
    for (int i = 0; i < localArray.Length; i++)
    {
        Console.Write($"{localArray[i]}");
        if (i < localArray.Length - 1)
        {
            Console.Write(", ");
        }
    }

    Console.WriteLine("]");
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {diff}");
}


double[] array = CreateArray(EnterSizeArray());
PrintArrayDiff(array, DiffMinMaxArray(array));