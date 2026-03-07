using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

public class Listing_Activity : Activity
{
    public static int Counter = 0;
    public Listing_Activity(string name, string description, int duration) : base(name, description, duration)
    {
        Console.Clear();
        setup_activity(name, description);
        int user_entries = listing(duration);
        Random random = new Random();
        Console.Write($"You have entered {user_entries} items. ");
        Thread.Sleep(2000);
        Console.WriteLine($"{random.Next(0, Counter/3)} were on topic with the current question.");
        Thread.Sleep(2000);
        Console.Write("I'm not mad.");
        Thread.Sleep(5000);
        Console.WriteLine(" Just dissapointed.");
        Thread.Sleep(3000);
        Console.WriteLine("Sending you back to the menu.");
        waiting_animation();
        Console.Clear();
    }

    public int listing(int duration)
    {
        List<string> prompts = ["Why?", "Are you sure your reading this right?", "Why do hotdogs come in packs of twelve but hotdog buns in packs of eight?", "What is your favorite food?", "Who are some of your personal heroes?", "Who are people that you have helped this week?", "What are personal strengths of yours?", "Who are people that you appreciate?"];
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;
        Random random = new Random();
        Console.WriteLine(prompts[random.Next(0, 7)]);
        while (currentTime < futureTime)
        {
            string who_cares = Console.ReadLine();
            Counter += 1;
            currentTime = DateTime.Now;
            if (currentTime.Second % 3 == 0)
            {
                Console.WriteLine(prompts[random.Next(0, 7)]);
            }
        }
        return Counter;
    }
}