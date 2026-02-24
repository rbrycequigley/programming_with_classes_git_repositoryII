using System;

class Word
{
    private int _check = 0;
    public string[] StrikeOut(string[] words)
    {
        for (int i = 0; i < 3; i++)
        {
            Random rand = new Random();
            int j = rand.Next(0, words.Length-1);
            string block = "";
            int safety_net = 0;
            while (true)
            {
                if (_check >= words.Length-2)
                {
                    words[0] = "end";
                    break;
                }
                else if (words[j].Contains('_'))
                {     
                    j = rand.Next(0, words.Length-1);  
                    safety_net += 1;
                    if (safety_net >= 1000)
                    {
                        Console.Clear();
                        Console.WriteLine("\nYou did it!\n");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    for (int k = 0; k < words[j].Length; k++)
                    {
                        block += "_";
                    }
                    words[j] = block;
                    _check++;
                    break;
                }
                
            }
        }
        return words;
    }
}