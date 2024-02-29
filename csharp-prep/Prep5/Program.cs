using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string yourName = AskName();
        int favoriteNumber = AskNumber();
        int squared = SquareNumber(favoriteNumber);

        DisplayAnswers(yourName, squared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string AskName()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();

        return name;
    }

    static int AskNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayAnswers(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    } 
}