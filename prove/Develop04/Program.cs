using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathingAct = new Breathing("Breathing","This activity promotes relaxation through guided breathwork. Focus on breathing deeply and slowly as we count the time together.");
        Reflecting reflectingAct = new Reflecting("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Listing listingAct = new Listing("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Affirmations affirm = new Affirmations();
        
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("\n\nThe Mindful Menu: Choose an activity!\n");
            Console.WriteLine("1- Breathing Activity");
            Console.WriteLine("2- Reflecting Activity");
            Console.WriteLine("3- Listing Activity");
            Console.WriteLine("4- Quit the Program\n");
            Console.WriteLine("     Please enter the number of your selection.");

            string selection = Console.ReadLine();
            choice = int.Parse(selection);
            Console.Clear();

            if (choice == 1)
                {
                    
                    breathingAct.RunBreathing();
                    Console.Clear();
                }
            else if (choice == 2)
                {
                    reflectingAct.RunReflecting();
                    Console.Clear();
                }
            else if (choice == 3)
                {
                    listingAct.RunListing();
                    Console.Clear();
                }
            else
                {                    
                    affirm.GetRandomAffirmation();
                }            
        }
    }
}