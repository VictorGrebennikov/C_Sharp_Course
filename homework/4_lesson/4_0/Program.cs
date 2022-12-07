// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B. Без модуля Math, используем цикл for.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void PowFunc(int num, int pow)
{
    int result = num;
    for (int i = 1; i < pow; i++)
    {
        result *= num;
    }

    Console.WriteLine(result);
}

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number of pow: ");
int number_pow = int.Parse(Console.ReadLine());
PowFunc(number, number_pow);
