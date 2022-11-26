// Задача №2.
// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter third number: ");
int num3 = int.Parse(Console.ReadLine());

if (num1 < num2)
{
    if (num2 < num3)
    {
        Console.WriteLine(num3);
    }
    else
        Console.WriteLine(num2);
}
else if (num1 < num3)
{
    Console.WriteLine(num3);
}
else
{
    Console.WriteLine(num1);
}