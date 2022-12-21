// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintArray(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();

}

int[,] CreateArray2(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

void MinSumLine(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    int? temp = null;                       // To store the previous smallest value of the row sum.
    int index_of_row = 1;                   // To store the i-index of the row with the smallest amount.

    for (int i = 0; i < row_size; i++)
    {
        int sum = 0;                        // To calculate the sum of each row.

        for (int j = 0; j < column_size; j++)
            sum += arr[i, j];

        if (temp == null)
            temp = sum;
        else
        {
            if (temp > sum)
            {
                temp = sum;
                index_of_row = i + 1;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"The line number with the minimum amount is {index_of_row}");
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = CreateArray2(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintArray(arr_1);
MinSumLine(arr_1);

