using System.Collections.Generic;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        // set up variables to run loop
        List<int> numbers_list;
        numbers_list = new List<int>();
        bool pass = false;
        // run loop
        while (pass != true)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            string temp = Console.ReadLine();
            int number = int.Parse(temp);

            if (number == 0)
            {
                pass = true;
            }
            else
            {
                numbers_list.Add(number);
            }
        }
        // set up after loop calcuations
        int sum = 0;
        int max_number = 0;
        // run after loop calculations
        foreach (int item in numbers_list)
        {
            sum += item;
            if (item > max_number)
            {
                max_number = item;
            }
        }
        double average = (double)sum / numbers_list.Count;
        // print everything out
        Console.Write($"The sum is: {sum}\n");
        Console.Write($"The average is: {average}\n");
        Console.Write($"The largest number is: {max_number}\n");
    }
}