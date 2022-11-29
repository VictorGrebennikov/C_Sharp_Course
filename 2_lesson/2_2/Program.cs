// 2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли
// второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

string Divisible(int num1, int num2)
{
    if (num1 % num2 == 0)
        return "Divisible";
    else
        return $"Not divisible. The remainder of the division = {num1 % num2}";
}

Console.WriteLine("Enter the first number: ");
int first_num = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int second_num = int.Parse(Console.ReadLine());
Console.WriteLine(Divisible(first_num, second_num));