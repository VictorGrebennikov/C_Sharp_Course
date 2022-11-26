// Задача №4.
// Напишите задачу вычисления модуля числа.

Console.WriteLine("Write a number: ");
int num = int.Parse(Console.ReadLine());

if (num < 0)
{
    Console.WriteLine(num * (-1));
}
else
    Console.WriteLine(num);