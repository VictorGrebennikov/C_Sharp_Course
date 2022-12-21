// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyMatrix(int[,] arr_1, int[,] arr_2)
{
    int row_size = arr_1.GetLength(0);
    int column_size = arr_1.GetLength(1);

    int temp = 0;                                           
    int[,] res_arr = new int[row_size, column_size];

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            temp = 0;
            for (int k = 0; k < column_size; k++)
            {
                temp += arr_1[i, k] * arr_2[k, j];
            }
            res_arr[i, j] = temp;
        }
    }

    return res_arr;
}

Console.Write("Enter the number of rows: ");
int row1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column1 = int.Parse(Console.ReadLine());

int[,] arr_1 = CreateArray2(row1, column1,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));

PrintArray(arr_1);

Console.Write("Enter the number of rows: ");
int row2 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column2 = int.Parse(Console.ReadLine());

int[,] arr_2 = CreateArray2(row2, column2,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));

PrintArray(arr_2);
PrintArray(MultiplyMatrix(arr_1, arr_2));