// Задача 1: Задайте значение N. Напишите программу, которая выведет все четные натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void Numbers(int n)
{
    if (n <= 1) return;

    if (n % 2 != 0) n -= 1;

    Console.Write($"{n} ");
    Numbers(n - 1);
}

Console.WriteLine("Enter a number: ");
int n = int.Parse(Console.ReadLine());

Numbers(n);