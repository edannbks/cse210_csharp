using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int input = -1;
        while (input != 0)
        {
            Console.WriteLine("Please enter a numbers to add to the list. To quit, enter '0'.");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of the list is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The list average is: {average}");

        int greatest = 0;
        foreach (int number in numbers)
        {
            if (number > greatest)
            {
                greatest = number;
            }
        }

        Console.WriteLine($"The greatest number in the list is: {greatest}");

    }
}