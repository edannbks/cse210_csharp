using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();      
        Entry theEntry = new Entry();
        
        int choice = 0;
        while (choice != 5)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");                
                Console.WriteLine("Welcome to Your Journal!");
                Console.WriteLine("Please enter the number of your menu selection.");
                Console.WriteLine("1- Add a new entry.");
                Console.WriteLine("2- Display entries.");
                Console.WriteLine("3- Save to a file.");
                Console.WriteLine("4- Load from a file.");
                Console.WriteLine("5- Quit the program.");
                Console.WriteLine("What would you like to do?");
                
                string selection = Console.ReadLine();
                choice = int.Parse(selection);                 

            if (choice == 1)
                {
                    Console.Clear();
                    myJournal.AddEntry();
              //      myJournal._entries.Add(theEntry);
                }
            else if (choice == 2)
                {
                     myJournal.DisplayAll();
                }
            else if (choice == 3)
                {
                    myJournal.SaveToFile();
                }
            else if (choice == 4)
                {
                    myJournal.LoadFromFile();
                }
            else
                {
                    Console.WriteLine("Come back again soon!");
                }
            }
    }
} 