using System;
using System.Formats.Tar;

public class Reflection_Activity : Activity
{
    private static bool _running = true;

    public Reflection_Activity(string name, string description, int duration) : base(name, description, duration)
    {
        setup_activity(name, description);
        Random rand = new Random();
        List<string> prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
        Console.WriteLine($"{prompts[rand.Next(prompts.Count)]}");
        List<Thread> threads = new List<Thread>();
        Random random = new Random();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(random.Next(10, 60));
        DateTime currentTime = DateTime.Now;
        Thread.Sleep(random.Next(5000, 7000));
        while (currentTime < futureTime)
            {
                Thread t = new Thread(generate_question);
                t.Start();
                threads.Add(t);
                currentTime = DateTime.Now;
                Thread.Sleep(random.Next(500));
            }
        _running = false;
        foreach (Thread thread in threads)
        {
            thread.Join();
        }
        Console.Clear();
        Console.WriteLine("You have completed the Reflection Activity!\nPlease wait as we send you back to the menu.");
        waiting_animation();
    }

    public void generate_question()
    {
        while (_running)
        {
            List<string> follow_up_prompt = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
            Random random = new Random();
            Console.WriteLine(follow_up_prompt[random.Next(follow_up_prompt.Count)]);
            Thread.Sleep(random.Next(1000, 3000));
        }  
    }
}