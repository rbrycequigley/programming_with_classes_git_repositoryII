using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment task1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(task1.GetHomeworkList());
        MathAssignment task2 = new MathAssignment("Section 7.3", "8-19", "Roberto Rodriguez", "Fractions");
        Console.WriteLine(task2.GetHomeworkList());
        WritingAssignment task3 = new WritingAssignment("The Causes of World War II by Mary Waters", "Mary Waters", "European History");
        Console.WriteLine(task3.getWritingInformation());
    }
}