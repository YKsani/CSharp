/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6]-> 0*/

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

int[] CreateArray(int array)
{
    int[] ints = new int[array];
    Random random = new Random();
    for (int i = 0; i < array; i++)
    {
        ints[i] = random.Next(-10, 11);
    }
    return ints;
}

int SummNegativeArray(int[] localArray)
{
    int summ = 0;
    for (int i = 1; i < localArray.Length; i += 2)
    {
        summ = summ + localArray[i];
    }
    return summ;
}

void PrintArraySumm(int[] array, int summ)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }

    Console.WriteLine("]");
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {summ}");
}


int[] array = CreateArray(EnterSizeArray());
PrintArraySumm(array, SummNegativeArray(array));
