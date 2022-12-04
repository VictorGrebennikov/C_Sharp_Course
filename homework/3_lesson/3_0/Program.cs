// Задача №0.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome(int num)
{
    while (true)
    {
        if (Math.Abs(num) < 10000 || Math.Abs(num) > 100000)
            {
                Console.WriteLine("A five digit number must be entered: ");
                num = int.Parse(Console.ReadLine());
            } 
        else
            {
                if (num % 10 == num / 10000 && (num % 100) / 10 == (num / 1000) % 10 )
                {
                    Console.WriteLine($"The number {num} is palindrome!");
                    break;
                }
                else
                {
                    Console.WriteLine($"The number {num} is NOT palindrome!");
                    break;
                }
            }
    }
}

Console.WriteLine("Enter a five-digit number: ");
int entered_num = int.Parse(Console.ReadLine());
Palindrome(entered_num);