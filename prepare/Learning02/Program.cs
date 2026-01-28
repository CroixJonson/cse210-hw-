using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Cybersecurity analyst";

        Job job2 = new Job();
        job2._company = "Microsoft";
        job1._company = "apple";

        job1.Display();
        job2.Display();


        Resume myResume = new Resume();
        myResume._membername = "Croix Jonson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}