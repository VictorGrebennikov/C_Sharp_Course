// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CountPositiveNums()
{
    List<string> list_of_entered_nums = new List<string>();
    int count_positive_nums = 0;

    while (true)
    {
        Console.Write("Enter number (or 'Spacebar'->'Enter' for exit): ");
        var value = Console.ReadLine();

        if (int.TryParse(value, out int number))
            list_of_entered_nums.Add(value);

        else if (value == " ")
        {
            for (int i = 0; i < list_of_entered_nums.Count; i++)
            {
                if (int.Parse(list_of_entered_nums[i]) > 0) count_positive_nums++;
            }
            break;
        }

        else
            Console.WriteLine("Couldn't recognize the number, try again!");
    }

    int size = list_of_entered_nums.Count;

    for (int i = 0; i < size; i++)
        Console.Write($"{list_of_entered_nums[i]} ");
    Console.Write($"-> {count_positive_nums}");
}

CountPositiveNums();