public class Resume
{
    public string _membername;


    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_membername}");
        Console.WriteLine("Jobs:");
        foreach (Job j in _jobs)
        {
            j.Display();
        }
    }

}