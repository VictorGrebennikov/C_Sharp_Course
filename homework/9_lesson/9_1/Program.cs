// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers(int m, int n)
{
    if (m > n) return 0;
    return SumNumbers(m + 1, n) + m;
}

Console.WriteLine("Enter the first number:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(SumNumbers(m, n));