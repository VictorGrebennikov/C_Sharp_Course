// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int n)
{
    int[] array = new int[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0, 100);
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

int[] arr = CreateArray(int.Parse(Console.ReadLine()));
PrintArray(arr);