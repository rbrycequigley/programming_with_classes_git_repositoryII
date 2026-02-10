using System;

class Program
{
    static void Main(string[] args)
    {
        // setting up the magic number
        Random randomGenerator = new Random();
        int random_number = randomGenerator.Next(1, 100);
        bool end = false;
        Console.Write($"The magic number is: {random_number}\n");

        //stretch challenge: keep track of the number of attempts
        int attempts = 0;

        while (end != true)
        {
            attempts += 1; //part of stretch challenge
            // takes in user input and processes it
            Console.Write("Guess the number: ");
            string input =  Console.ReadLine();
            int int_input = int.Parse(input);
            if (int_input > random_number)
            {
                Console.Write("A little lower!\n");
            }
            else if (int_input < random_number)
            {
                Console.Write("A little higher!\n");
            }
            else
            {
                Console.Write("You found it!\n");
                end = true;
            }
        Console.Write($"It took you {attempts} attempt(s) to find the Magic Number");

        }
        
    }
}