using System;
using System.ComponentModel;


public class Breathing_Activity : Activity
{
    public Breathing_Activity(string name, string description, int duration) : base(name, description, duration)
    {
        // set up activity
        Console.Clear();
        Random random = new Random();
        setup_activity(name, description);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(random.Next(0, 60));
        DateTime coughingTime = startTime.AddSeconds(30);
        DateTime currentTime = DateTime.Now;
        Console.WriteLine();
        
        while (currentTime < futureTime)
        {
            Console.WriteLine("Breath in...");
            Thread.Sleep(random.Next(0, 5000));
            Console.WriteLine("Breath out...");
            Thread.Sleep(random.Next(0, 5000));
            currentTime = DateTime.Now;
            if (currentTime < coughingTime)
            {
                Console.Clear();
                Console.WriteLine("COUGH! COUGH! COUGH! COUGH!");
                Thread.Sleep(1000);
                Console.WriteLine("*gasp*");
                Thread.Sleep(250);
                Console.WriteLine("COUGH! COUGH! COUGH! COUGH!");
                Thread.Sleep(750);
                Console.WriteLine("COUGH! COUGH! COUGH! COUGH! COUGH! COUGH!");
                Thread.Sleep(150);
                Console.WriteLine("*gag*");
                Thread.Sleep(2000);
                Console.WriteLine("*clears throat*");
                Thread.Sleep(5000);

            }
        }
        Console.WriteLine("You have completed the Breathing Activity! Don't you feel more relaxed?\nPlease wait while we take you to the main program.");
        waiting_animation();
        Console.Clear();
    }
}