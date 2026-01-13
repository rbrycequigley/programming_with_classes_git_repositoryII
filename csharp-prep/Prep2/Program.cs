using System;

class Program
{
    static void Main(string[] args)
    {
        // Prep 02
        Console.Write("What is your grade (out of 100)? ");
        string str_grade = Console.ReadLine();
        int grade_0_100 = int.Parse(str_grade);
        string letter_grade = "";

        // stretch challenge (plus or minus)
        string plus_or_minus = "";
        if (grade_0_100 == 100 || grade_0_100 <= 60)
        {
            //pass
        }
        else
        {
            int plus_or_minus_determiner = str_grade[1];
            if (plus_or_minus_determiner >= 7)
            {
                plus_or_minus = "+";
            }
            else if (plus_or_minus_determiner < 3)
            {
                plus_or_minus = "-";
            }
            else
            {
                //pass
            }
        }

        // main challange
        if (grade_0_100 >= 90)
        {
            letter_grade = "A";
            Console.WriteLine($"Your grade is an {letter_grade}{plus_or_minus}. You're doing great!");
        }
        else if (grade_0_100 >= 80 && grade_0_100 <= 89)
        {
            letter_grade = "B";
            Console.WriteLine($"Your grade is a {letter_grade}{plus_or_minus}. Doing good but could do better.");
        }
        else if (grade_0_100 >= 70 && grade_0_100 <= 79)
        {
            letter_grade = "C";
            Console.WriteLine($"Your grade is a {letter_grade}{plus_or_minus}. Better start getting worried.");
        }
        else if (grade_0_100 >= 60 && grade_0_100 <= 69) //nice
        {
            letter_grade = "D";
            Console.WriteLine($"Your grade is a {letter_grade}{plus_or_minus}. You will fail if you don't start working.");
        }
        else
        {
            letter_grade = "F";
            Console.WriteLine($"Your grade is an {letter_grade}{plus_or_minus}. Do better.");
        }
    }
}