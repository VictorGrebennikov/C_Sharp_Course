// Задача 2:
// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

int CutSecondDigit(int num)
{
    Console.WriteLine(num);

    return (num / 100) * 10 + (num % 10);
}

Console.WriteLine(CutSecondDigit(new Random().Next(100, 1000)));