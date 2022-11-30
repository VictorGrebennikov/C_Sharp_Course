// Задача 3:
// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

void TheThirdDigit(int num)
{
    while (true)
    {
        if (Math.Abs(num) < 100)
            {
                Console.WriteLine("There is no third digit. Enter a number: ");
                num = int.Parse(Console.ReadLine());
            } 
        else
            {
                int num_for_crop = Math.Abs(num); 
                while(num_for_crop > 1000)
                {
                    num_for_crop = num_for_crop / 10;
                }

                Console.WriteLine($"The third digit of the number {num} is {Math.Abs(num_for_crop % 10)}");
                break;
            }
    }
   
}

Console.WriteLine("Enter a number: ");
int entered_num = int.Parse(Console.ReadLine());
TheThirdDigit(entered_num);
