using System;

class Program
{
    static void Main(string[] args)
    {
        // Program Intro
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Thread.Sleep(3000);
        Console.WriteLine("Please prepare yourself mentally for your session...");
        Thread.Sleep(3000);

        // Begin perpetual loop
        while(true)
        {
            Console.WriteLine("Which activity would you like to do today?");
            Console.WriteLine("1. Breathing\n2. Listing\n3. Reflecting\nOr you could press 4 to quit");
            Console.Write("Enter '1', '2', or '3': ");
            string user_input = Console.ReadLine();
            if (user_input is "1")
            {
                Console.WriteLine("You have chosen the Breathing Activity!");
                Console.WriteLine("How long would you like to do this activity? Enter your time in seconds:");
                string how_long = Console.ReadLine();
                Console.WriteLine("Please wait while we load your activity");
                Console.Clear();
                string name = "Breathing Activity";
                string description = "This acivity is designed to help calm you by having you focus on your breathing.\nPlease wait as the activity loads.";
                int duration = int.Parse(how_long);
                Breathing_Activity activity_1 = new Breathing_Activity(name, description, duration);
            }
            else if (user_input is "2")
            {
                Console.WriteLine("You have chosen the Listing Activity!");
                Console.WriteLine("How long would you like to do this activity? Enter your time in seconds:");
                string how_long = Console.ReadLine();
                Console.WriteLine("Please wait while we load your activity");
                string name = "Listing Activity";
                string description = "This acivity is designed to help center your mind by listing important events.";
                int duration = int.Parse(how_long);
                Listing_Activity activity_2 = new Listing_Activity(name, description, duration);
            }
            else if (user_input is "3")
            {
                Console.WriteLine("You have chosen the Reflection Activity!");
                Console.WriteLine("How long would you like to do this activity? Enter your time in seconds:");
                string how_long = Console.ReadLine();
                Console.WriteLine("Please wait while we load your activity");
                string name = "Reflection Activity";
                string description = "This acivity is designed to help you contemplate the events that are on your mind.\nPlease wait as the activity loads.";
                int duration = int.Parse(how_long);
                Reflection_Activity activity_3 = new Reflection_Activity(name, description, duration);
            }
            else if (user_input is "4")
            {
                Console.Clear();
                Console.WriteLine("You are exiting the program.");
                Thread.Sleep(3000);
                Console.WriteLine("Please wait while the program closes.");
                Console.Clear();
                string name = "";
                string description = "";
                int duration = 0;
                Activity wait = new Activity(name, description, duration);
                while (true)
                {
                    Console.WriteLine("You are exiting the program.");
                    Console.WriteLine("Please wait while the program closes.");
                    wait.waiting_animation();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Invalid response. Please try again.");
                Thread.Sleep(3000);
            }
        }
    }
}