using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public 

class Journal
{
    public List<string> Write_Entry()
    {
        // Display random prompt entry
        var prompts = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "Did I see any cool bugs today?", "How well did I chef up today?", "If I were to take over the world, how would I do it?"};
        Random rng = new Random();
        int number = rng.Next(1, prompts.Count);
        Console.WriteLine("Need help? Try getting started with this:");
        Console.WriteLine($"{prompts[number]}");
        // Get the entry from the user and the date from the system. Then format it and ship it out.
        List<string> journal_entry = new List<string>();
        journal_entry.Clear();
        Console.WriteLine("Begin you entry below:");
        DateTime d = DateTime.Now;
        string date = $"{d.Year}/{d.Month}/{d.Day}";
        journal_entry.Add(date);
        journal_entry.Add(prompts[number]);
        string entry = Console.ReadLine();
        journal_entry.Add(entry);
        return journal_entry;
    }

    public static void Load_Menu()
    {
        Console.WriteLine("\nWhat would you like to do today?");
        Console.WriteLine("1. Write a new entry.");
        Console.WriteLine("2. Display previous entries");
        Console.WriteLine("3. Save entries");
        Console.WriteLine("4. Display saved entries");
        Console.WriteLine("5. Quit");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to JOYurnal!");
        List<List<string>> entries = new List<List<string>>();
        var journal = new Journal();
        while (true)
        {
            Journal.Load_Menu();
            string journal_option = Console.ReadLine();
            if (journal_option == "1")
            {
                Console.WriteLine("It's time for a new entry!");
                List<string> entry = journal.Write_Entry();
                entries.Add(entry);
                Console.WriteLine("Entry has been added.");
            }
            else if (journal_option == "2")
            {
                Console.WriteLine("Displaying previous entries:");
                for (int i = 0; i < entries.Count; i++)
                {
                    Console.WriteLine($"{entries[i][0]}: {entries[i][1]}\n{entries[i][2]}\n");
                }
                Console.WriteLine("All entries have been displayed.");
            }
            else if (journal_option == "3")
            {
                Console.WriteLine("Lets save your entries.");
                Console.WriteLine("Where would you like to save your entires?");
                string file_name = Console.ReadLine();
                Console.WriteLine(entries.Count);
                for (int i = 0; i < entries.Count; i++)
                {
                    string line = $"{entries[i][0]}: {entries[i][1]} {entries[i][2]}";
                    File.AppendAllText(file_name, line + Environment.NewLine);
                }
                Console.WriteLine($"All entries have been saved to {file_name}.");
            }
            else if (journal_option == "4")
            {
                Console.WriteLine("Showing old enteries:");
                Console.WriteLine("Where would you like to pull your past entries from?");
                string file_location = Console.ReadLine();
                Console.WriteLine($"Pulling all entries from {file_location}");
                string[] lines = File.ReadAllLines(file_location);
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("All entries have been displayed");
            }
            else if (journal_option == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Entry! Please try again.");
            }   
        }
        Console.WriteLine("See you next time!");
    }
}
