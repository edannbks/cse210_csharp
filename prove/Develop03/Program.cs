using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {       
        Reference r1 = new Reference("John", 3, 16);
        string theWords1 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Reference r2 = new Reference("D&C",64,33,34);
        string theWords2 = "Wherfore, be not weary in well-doing, for ye are laying the foundation of a great work. And out of small things proceedeth that which is great. Behold, the Lord requireth the heart and a willing mind.";        
        Scripture scripture;
        Console.WriteLine("Let's memorize a scripture!");
        Console.WriteLine("1- John 3:16");
        Console.WriteLine("2- D&C 64:33-34");
        Console.WriteLine("Please enter the number of your choice:");
        
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            scripture = new Scripture(r1, theWords1);
            do
            {
                Console.WriteLine(scripture.GetFirstDisplayText());
                Console.WriteLine("Press enter to continue or type 'quit' to exit:");
                string input = Console.ReadLine();

                if (input == "quit")
                    break;

                scripture.HideRandomWords(3);
                Console.Clear();
            } while (!scripture.IsCompletelyHidden());
        }
        else
        {
            scripture = new Scripture(r2, theWords2);
            do
            {
                Console.WriteLine(scripture.GetSecondDisplayText());
                Console.WriteLine("Press enter to continue or type 'quit' to exit:");
                string input = Console.ReadLine();

                if (input == "quit")
                    break;

                scripture.HideRandomWords(3);
                Console.Clear();
            } while (!scripture.IsCompletelyHidden());
        }
    }
}