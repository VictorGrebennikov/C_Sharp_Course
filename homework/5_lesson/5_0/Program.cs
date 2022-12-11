// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int n)
{
    int[] array = new int[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}

void PrintArray(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void EvenElCount(int[] array)
{
    int all_even_el = 0;
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            all_even_el++;
        }
    }
    Console.WriteLine(all_even_el);
}

int[] arr = CreateArray(int.Parse(Console.ReadLine()));
PrintArray(arr);
Console.WriteLine();
EvenElCount(arr);
