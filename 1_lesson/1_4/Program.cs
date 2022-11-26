// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает
// все целые числа в промежутке от -N до N.

Console.WriteLine("Write a number: ");
int num = int.Parse(Console.ReadLine());
int counter = -num;

while (counter <= num)
{
    Console.Write(counter + " " );
    counter++;
}