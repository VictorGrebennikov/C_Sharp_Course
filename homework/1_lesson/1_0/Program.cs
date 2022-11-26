// Задача №1.
// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число больше, а какое меньше.

Console.WriteLine("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 == num2)
{
    Console.Write("Введённые числа равны");
}
else
    if (num1 > num2)
    {
        Console.Write("Первое число " + num1 + " больше чем второе число " + num2);
    }
    else
        Console.Write("Второе число " + num2 + " больше чем первое число " + num1);