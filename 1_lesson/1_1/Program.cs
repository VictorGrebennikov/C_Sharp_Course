// Задача №1. 
// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.

Console.WriteLine("Write first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Write second number: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine("Yes");
}

else

    Console.WriteLine("No");

