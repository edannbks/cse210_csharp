using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage.");
        string percentgrade = Console.ReadLine();
        int percent = int.Parse(percentgrade);
        string letter = "";
        string sign = "";

        if (percent >= 90)
            {
                letter = "A";
            }
        else if (percent >= 80)
            {
                letter = "B";
            }
        else if (percent >= 70)
            {
                letter = "C";
            }
        else if (percent >= 60)
            {
                letter = "D";
            }
        else 
            {
                letter = "F";
            }
        if ((percent % 10) < 3 && (letter != "F"))
            {
                sign = "-";
            } 
        else if ((percent % 10) >= 7 && (letter != "A") && (letter != "F"))
            {
                sign = "+";
            }
        else
            {
                sign = "";
            }            
        if (letter == "F" || letter == "A")
            {
                Console.WriteLine($"Your grade is an {letter}");                              
            }
        else
            {
                Console.WriteLine($"Your grade is a {letter}{sign}");
            }
        if (percent < 70)
            {
                Console.WriteLine("Better luck next time!");                                
            }
        else
            {
                Console.WriteLine("You passed!");
            }
    }
}