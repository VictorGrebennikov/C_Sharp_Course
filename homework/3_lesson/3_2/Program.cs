// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cubes(int N)
{
    int i = 0;
    double result;
    while (i < N)
    {
       i ++;
       result = Math.Pow(i, 3);
       Console.WriteLine(result);
    }
}

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
Cubes(num);
