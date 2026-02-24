using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        string Verse = "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. (1stNephi_3:7)";
        Scripture mem = new Scripture();
        string[] SlicedVerse = mem.SetUpScripture(Verse);
        string restart = "\nLet's begin!\n";
        while (true)
        {
            Console.Clear();
            Console.WriteLine(restart);
            if (SlicedVerse[0] == "end")
            {
                break;
            }
            mem.PrintScripture(SlicedVerse);
            Console.WriteLine("\nType out the verse or type 'QUIT' to quit.");
            string option = Console.ReadLine();
            if (option.ToLower() == "quit")
            {
                break;
            }
            else if (Verse == option)
            {
                string[] BlockedVerse = mem.CallStrikeOut(SlicedVerse);
                mem.PrintScripture(BlockedVerse);
                SlicedVerse = BlockedVerse;
                restart = "\nGood job! Let's make it harder!\n";
            }
            else
            {
                restart = "\nNot yet. Let's try again!\n";
            }
        } 
    } 
} 