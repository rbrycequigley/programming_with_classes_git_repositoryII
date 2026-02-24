using System;
using System.ComponentModel;
using System.Globalization;

class Scripture
{   
    private string[] _words = [];

    public string[] SetUpScripture(string words)
    {
        _words = words.Split(' ');
        return _words;
    }

    public void PrintScripture(string[] words)
    {
        Console.WriteLine("#----------------------------------------------------------------------------------------------#");
        int i = 0;
        foreach (string word in words)
        {
            i++;
            if (i == words.Length)
            {
               Console.Write($"\n- {word}");
                
            }
            else if (i%10 == 0)
            {
                Console.Write($"\n{word} ");
            }
            else
            {
                Console.Write($"{word} ");
            }
            
        }
        Console.WriteLine("\n#----------------------------------------------------------------------------------------------#");
    }

    public string[] CallStrikeOut(string[] words)
    {
        Word word = new Word();
        return word.StrikeOut(words);
    }
}