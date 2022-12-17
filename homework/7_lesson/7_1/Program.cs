// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

string FindElement(int[,] arr, int row, int column)
{
    if (row <= arr.GetLength(0) && column <= arr.GetLength(1) && row > 0 && column > 0)
        return ($"An element with an position is {arr[row - 1, column - 1]}");
    return ($"There is no element with such an position!");
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = CreateArray2(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintArray(arr_1);

Console.WriteLine(FindElement(arr_1,
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine())));