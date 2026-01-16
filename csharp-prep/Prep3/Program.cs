using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int maginum = randomGenerator.Next(1, 101);
        int guess = 1;
        int guesscounter = 0;

        while (guess != maginum)
        {
            Console.Write("What is your guess: ");
            guess = int.Parse(Console.ReadLine());
            guesscounter++;

            if (guess > maginum)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < maginum)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!!");
                Console.WriteLine($"You took {guesscounter} attempts!");
            }
        }
    }
}