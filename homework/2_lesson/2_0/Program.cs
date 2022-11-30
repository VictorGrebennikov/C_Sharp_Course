// Задача 1:
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

void TheSecondDigit(int num)
{
    while (true)
    {
        if (Math.Abs(num) < 100 || Math.Abs(num) > 1000)
            {
                Console.WriteLine("A three digit number must be entered: ");
                num = int.Parse(Console.ReadLine());
            } 
        else
            {
                Console.WriteLine($"The second digit is {Math.Abs((num / 10) % 10)}");
                break;
            }
    }
   
}

Console.WriteLine("Enter a three-digit number: ");
int entered_num = int.Parse(Console.ReadLine());
TheSecondDigit(entered_num);