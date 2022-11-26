// Задача №2.
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.


Console.WriteLine("Enter the number of the day of the week: ");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("!There can't be more than 7 days in a week!");    
        break;
}
