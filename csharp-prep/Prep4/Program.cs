using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> num = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int usenum = -1;

        // adding persons nums to the list
        while (usenum != 0)
        {
            Console.Write("Enter a number:");
            usenum = int.Parse(Console.ReadLine());

            if (usenum != 0)
            {
                num.Add(usenum);
            }

        }
        // sum

        int sum = 0;

        foreach (int number in num)
        {
            sum = number + sum;
        }
        Console.WriteLine($"The sum is {sum}!");

        //agv section

        float avg = sum / num.Count;
        Console.WriteLine($"The average is {avg}");


        // max value 

        int maxVal = 0;
        foreach (int number in num)
        {
            if (number > maxVal)
            {
                maxVal = number;
            }
        }
        Console.WriteLine($"The max value is {maxVal}!!");





        
    }
}