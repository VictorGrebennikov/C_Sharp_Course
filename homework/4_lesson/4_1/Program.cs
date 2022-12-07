// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumCount(int n)
{
    
    int count = 0;
    int result = 0;

    while (n > 0)
    {
        result = result + (n % 10);
        n = n / 10;
        count++;
    }

    return result;
}

Console.Write("Enter a number: ");
Console.Write(NumCount(int.Parse(Console.ReadLine())));