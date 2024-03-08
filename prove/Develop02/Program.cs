using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateTime = DateTime.Now;
        
        Entry anEntry = new Entry();
        anEntry._date = $"{dateTime}";

        int choice = 0;
        while (choice != 5)
            {
                Console.WriteLine("Welcome to Your Journal!");
                Console.WriteLine("Please enter the number of your menu selection.");
                Console.WriteLine("1- Add a new entry.");
                Console.WriteLine("2- Display entries.");
                Console.WriteLine("3- Load from a file.");
                Console.WriteLine("4- Save to a file.");
                Console.WriteLine("5- Quit the program.");
                Console.WriteLine("What would you like to do?");
                
                string selection = Console.ReadLine();
                choice = int.Parse(selection);

            if (choice == 1)
                {
                    Journal myJournal = new Journal();
                    myJournal.AddEntry();
                    myJournal._entries.Add(anEntry);
                    Entry showEntry = new Entry();
                    showEntry.DisplayEntry();
                }
            else if (choice == 2)
                {
                    Journal myJournal = new Journal();
                    //How do I make this write to the console?
                    myJournal.DisplayAll();

                }
            else if (choice == 3)
                {
                    Journal myJournal = new Journal();
                    myJournal.SaveToFile("JE-Files.txt");
                }
            else if (choice == 4)
                {
                    Journal myJournal = new Journal();
                    myJournal.LoadFromFile("JE-Files.txt");
                }
            else
                {
                    Console.WriteLine("Come back again soon!");
                }
            }
    }
}