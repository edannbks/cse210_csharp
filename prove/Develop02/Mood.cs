using System;

public class Mood
{
    
   
     public string DisplayMoods()
    {
        Console.WriteLine("1- Happy");
        Console.WriteLine("2- Sad");
        Console.WriteLine("3- Tired");
        Console.WriteLine("4- Angry");
        Console.WriteLine("5- Disappointed");
        Console.WriteLine("6- Grateful");
        Console.WriteLine("7- Excited");

        int mood = int.Parse(Console.ReadLine());
        string feeling = "";

        if (mood == 1)
        {
            feeling = "Happy";
            Console.WriteLine(feeling);
            return feeling;            
        }
        else if (mood == 2)
        {
            feeling = "Sad";
            Console.WriteLine(feeling);
            return feeling;            
        }
        else if (mood == 3)
        {
            feeling = "Tired";
            Console.WriteLine(feeling);
            return feeling;            
        }
        else if (mood == 4)
        {
            feeling = "Angry";
            Console.WriteLine(feeling);
            return feeling;            
        }
        else if (mood == 5)
        {
            feeling = "Dissapointed";
            Console.WriteLine(feeling);
            return feeling;            
        }
        else if (mood == 6)
        {
            feeling = "Grateful";
            Console.WriteLine(feeling);
            return feeling;            
        }
        else
        {
            feeling = "Excited";
            Console.WriteLine(feeling);
            return feeling;            
        }        
    }
}