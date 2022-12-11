// Задача 3: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int n, double from, double to)
{
    double[] array = new double[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (to - from) + from, 2);
    }

    return array;
}

void PrintArray(double[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SubMaxMin(double[] array)
{
    int size = array.Length;
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < size; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }

    Console.WriteLine($"Maximum is {max}");
    Console.WriteLine($"Minimum is {min}");
    Console.WriteLine($"Substraction Max & Min is {Math.Round(max - min, 2)}");
}

Console.WriteLine("Enter number of array elements: ");
int num_arr_el = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the initial value of the range: ");
double start_of_range = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the final value of the range: ");
double end_of_range = double.Parse(Console.ReadLine());

double[] arr = CreateArray(num_arr_el, start_of_range, end_of_range);
PrintArray(arr);
Console.WriteLine();
SubMaxMin(arr);