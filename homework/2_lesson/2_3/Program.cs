// Задача 4:
// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

void DayOfTheWeek (int num)
{
    if (num > 0 && num <= 5)
    {
        Console.WriteLine("It's a weekday.");
    }
    else if (num == 6 || num == 7)
    {
        Console.WriteLine("It's a day off.");
    }
    else if (num > 7 || num <=0)
    {
        Console.WriteLine("Invalid number");
    }
}

Console.WriteLine("Enter the number of the day of the week: ");
int entered_num = int.Parse(Console.ReadLine());
DayOfTheWeek(entered_num);
