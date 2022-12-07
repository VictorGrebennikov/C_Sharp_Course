// Напишите программу, которая принимает на вход число N и выдаёт произведение чсел от 1 до N.

int ProductNums(int num)
{
    int all_product = 1;
    for (int i = 1;i <= num; i++)
    {
        all_product *= i;
    }

    return all_product;
}

Console.WriteLine(ProductNums(int.Parse(Console.ReadLine())));
