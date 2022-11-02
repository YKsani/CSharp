/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/


int EnterSizeArray()
{
    int value = 0;
    Console.Write("Введите длинну массива: ");
    try
    {
        value = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Вы ввели некоректное значение");
        Environment.Exit(0);
    }
    return value;
}

int[] CreateArray(int sizeArray)
{
    int[] ints = new int[sizeArray];
    Random random = new Random();
    for (int i = 0; i < sizeArray; i++)
    {
        ints[i] = random.Next(100, 1000);
    }
    return ints;
}

int CalculateEven(int[] localArray)
{
    int result = 0;
    for (int i = 0; i < localArray.Length; i++)
    {
        if (localArray[i] % 2 == 0)
            result++;
    }
    return result;
}

void PrintArrayEven(int[] localArray, int localEven)
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
    Console.WriteLine($"Количество четных чисел в массиве = {localEven}");
}

int[] globalArray = CreateArray(EnterSizeArray());
PrintArrayEven(globalArray, CalculateEven(globalArray));