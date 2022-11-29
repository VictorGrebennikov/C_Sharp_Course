// 3. Напишите программу, которая принимает на вход число
// и проверяет, кратно ли оно одновременно 7 и 23.

string Divisible_7_23(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
        return "Divisible";
    else
        return "Not divisible";
}

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(Divisible_7_23(number));