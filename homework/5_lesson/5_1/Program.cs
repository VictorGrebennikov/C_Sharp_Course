// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0

int[] CreateArray(int n, int from, int to)
{
    int[] array = new int[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(from, to);
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

void OddElSum(int[] array)
{
    int sum_odd_el = 0;
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        if (i % 2 == 0)
        {
            sum_odd_el += array[i];
        }
    }
    Console.WriteLine(sum_odd_el);
}

int[] arr = CreateArray(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintArray(arr);
Console.WriteLine();
OddElSum(arr);
