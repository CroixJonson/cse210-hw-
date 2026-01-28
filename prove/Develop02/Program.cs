using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        List<string> prompts = new List<string>()
        {
         "Who was the most interesting person I interacted with today?",
         "What was the best part of my day?",
         "How did I see the hand of the Lord in my life today?",
         "What was the strongest emotion I felt today?",
         "If I had one thing I could do over today, what would it be?"
        };

        Random rand = new Random();

        string choice = "";

        // menu parts

        while (choice != "5")
        {
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            //menu choice one

            if (choice == "1")
            {
                string prompt = prompts[rand.Next(prompts.Count)];
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._prompt = prompt;
                entry._response = response;
                journal.AddEntry(entry);
            }
            // menu choice two
            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            // choice three

            else if (choice == "3")
            {
                Console.WriteLine("Please input a filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }

            // choice four
            else if (choice == "4")
            {
                Console.WriteLine("What file would you like to open: ");
                string loadfile = Console.ReadLine();
                journal.LoadFromFile(loadfile);
            }

            else if (choice == "5")
            {
                Console.WriteLine("Complete!");
            }

        }
        
    }
}

