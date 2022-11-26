// Задача №4.
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine());
int counter = 1;

while (counter <= num)
{
    if (counter % 2 == 0)
    {
        Console.Write(counter + " ");
    }
    counter++;
}