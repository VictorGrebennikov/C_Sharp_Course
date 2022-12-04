// See https://aka.ms/new-console-template for more information

void Quarters(string a)
{
    if (a == "I")
        Console.WriteLine("x > 0 && y > 0");
    else if (a == "II")
        Console.WriteLine("x < 0 && y > 0");
    else if (a == "III")
        Console.WriteLine("x < 0 && y < 0");
    else if (a == "IV")
        Console.WriteLine("x > 0 && y < 0");
    else
        Console.WriteLine("error");
}

Quarters(Console.ReadLine());
