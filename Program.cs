/*
 Author: Nick Zaccaro
 Date: 1/28/2020
 Description: Program that uses the practice of conditional statements after gaining input from the user
 */
 using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for grade expectation
            Console.WriteLine("Please enter the grade you expect to get in ISM 4300 ...");

            //Use try catch statements to validate the users input and display error message if provided bad input
            try
            {
                //Create variable gathered from input
                string input = Console.ReadLine();

                //Convert input to an integer
                int grade = int.Parse(input);

                //if else if statements to test the inputs correct letter grade from syllabus
                if (grade < 60)
                {
                    //Displays the correct letter grade
                    Console.WriteLine("Your expected letter grade based on Syllabus: F");
                }
                else if ((grade <= 61) && (grade >= 60))
                {
                    //Displays correct letter grade
                    Console.WriteLine("Your expected letter grade based on Syllabus: D-");
                }
                else if ((grade <= 67) && (grade >= 62))
                {
                    //Displays correct letter grade
                    Console.WriteLine("Your expected letter grade based on Syllabus: D");
                }
                else if ((grade <= 69) && (grade >= 68))
                {
                    //Displays correct letter grade
                    Console.WriteLine("Your expected letter grade based on Syllabus: D+");
                }
                else if ((grade <= 71) && (grade >= 70))
                {
                    //Displays correct letter grade
                    Console.WriteLine("Your expected letter grade based on Syllabus: C-");
                }
                else if ((grade <= 77) && (grade >= 72))
                {
                    //Displays correct letter grade
                    Console.WriteLine("Your expected letter grade based on Syllabus: C");
                }
                else if ((grade <= 79) && (grade >= 78))
                {
                    //Displays correct letter grade
                    Console.WriteLine("Your expected letter grade based on Syllabus: C+");
                }
                else if ((grade <= 81) && (grade >= 80))
                {
                    //Displays correct letter grade
                    Console.WriteLine("Your expected letter grade based on Syllabus: B-");
                }
                else if ((grade <= 87) && (grade >= 82))
                {
                    //Displays correct letter grade
                    Console.WriteLine("Your expected letter grade based on Syllabus: B");
                }
                else if ((grade <= 89) && (grade >= 88))
                {
                    //Displays correct letter grade
                    Console.WriteLine("Your expected letter grade based on Syllabus: B+");
                }
                else if ((grade <= 91) && (grade >= 90))
                {
                    //Displays correct letter grade
                    Console.WriteLine("Your expected letter grade based on Syllabus: A-");
                }
                else if ((grade <= 97) && (grade >= 92))
                {
                    //Displays correct letter grade
                    Console.WriteLine("Your expected letter grade based on Syllabus: A");
                }
                else
                {
                    //Displays correct letter grade
                    Console.WriteLine("Your expected letter grade based on Syllabus: A+");
                }
            }

            //catches incorrect input from user
            catch
            {
                //Displays error message to user and asks to enter an integer and exit the program to try again
                Console.WriteLine("You have entered an incorrect data type for your expected grade :(");
                Console.WriteLine("Please enter an integer value for your expected grade next time!");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }
        }
    }
}
