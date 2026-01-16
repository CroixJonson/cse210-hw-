using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int favnum = PromptUserNumber();

        int birthYear;
        PromptUserBirthYear(out birthYear);

        int squared = SquareNumber(favnum);

        DisplayResult(userName, squared, birthYear);





    }




    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your Name:");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        int userNum = int.Parse(Console.ReadLine());
        return userNum;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());

    }

    static int SquareNumber(int numb)
    {
        int squared = numb * numb;
        return squared;
    }
    
    static void DisplayResult(string name, int squared, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}.");
        Console.WriteLine($"{name}, you will turn {2026 - birthYear} years old this year.");
    }

}