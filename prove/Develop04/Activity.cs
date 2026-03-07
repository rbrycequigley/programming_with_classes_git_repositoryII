using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    
    //Constructor must match 'Activity' exactly
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void waiting_animation()
    {
        Random random = new Random();
        int choose = random.Next(1, 5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        DateTime currentTime = DateTime.Now;
        Console.WriteLine();
        if (choose == 1)
        {
            while (currentTime < futureTime)
            {
                Console.Write("|");
                Thread.Sleep(random.Next(0, 500));
                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(random.Next(0, 500));
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(random.Next(0, 500));
                Console.Write("\b \b");
                currentTime = DateTime.Now;
            }
        }
        else if (choose == 2)
        {
            while (currentTime < futureTime)
            {
                Console.Write("#");
                Thread.Sleep(1);
                currentTime = DateTime.Now;
            }
        }
        else if (choose == 3)
        {
            while (currentTime < futureTime)
            {
                Console.Write("|");
                Thread.Sleep(100);
                Console.Write("/");
                Thread.Sleep(100);
                Console.Write("-");
                Thread.Sleep(100);
                currentTime = DateTime.Now;
            }
        }
        else
        {
            Console.Write("Loading...");
            while (currentTime < futureTime)
            {
                Thread.Sleep(500);
                Console.Write("\b \b");
                currentTime = DateTime.Now;
            } 
        }
        Console.WriteLine();
    }

    public void setup_activity(string name, string description)
    {
        Console.Clear();
        Console.WriteLine($"{name}\n{description}");
        waiting_animation();
        Console.Write("Starting activity in ");
        for (int i = 3; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        } 
        Console.Clear();
    }
}