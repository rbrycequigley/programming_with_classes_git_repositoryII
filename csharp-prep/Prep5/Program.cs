using System;
using System.ComponentModel;

class Program
{
    // display message function
    static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

    // prompt user for name function
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();
        return username;
    }
    // prompt user for fav number
    static double PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        double favorite_number = double.Parse(number);
        return favorite_number;
    }
    // prompt user for birth year
    static int PromptUserBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        string year = Console.ReadLine();
        int birth_year = int.Parse(year);
        return birth_year;
    }
    // takes the favorite number and squares it
    static double SquareNumber(double num)
    {
        double numx2 = num * num;
        return numx2;
    }
    // takes birth year and calculates age (given current year is 2026)
    static void DisplayResult(string name, double num, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {SquareNumber(num)}");
        Console.WriteLine($"{name}, you will turn {2026 - year} this year.");
    }
    // main
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUserName();
        double fav_number = PromptUserNumber();
        int year_of_birth = PromptUserBirthYear();
        DisplayResult(name, fav_number, year_of_birth);
    }
}