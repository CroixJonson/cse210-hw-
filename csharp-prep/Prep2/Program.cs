using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percentage? ");
        string gradePercentage = Console.ReadLine();

        int gradePer = int.Parse(gradePercentage);
        string letter = "";

        if (gradePer >= 90)
        {
            letter = "A";
           
        }
        else if (gradePer >= 80)
        {
            letter = "B";
            
        }
        else if (gradePer >= 70)
        {
            letter = "C";
        }
        else if (gradePer >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (gradePer >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("Almost there see you next semester!");
        }





    }
}