using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            // Frances S. Mosqueda
            // BSCS 3-2

            Console.WriteLine("WELCOME TO GRADE CALCULATOR!");

            bool continueEntering = true;

            while (continueEntering)
            {
                // Prompt the user for a score
                Console.Write("Enter the score (0-100): ");
                string input = Console.ReadLine();

                if (!float.TryParse(input, out float score) || score < 0 || score > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a numeric score between 0 and 100.");
                    Console.WriteLine();
                    continue;
                }

                // Determine the letter grade using if-else statements
                char grade;
                if (score >= 90)
                {
                    grade = 'A';
                }
                else if (score >= 80)
                {
                    grade = 'B';
                }
                else if (score >= 70)
                {
                    grade = 'C';
                }
                else if (score >= 60)
                {
                    grade = 'D';
                }
                else
                {
                    grade = 'F';
                }

                // Print the corresponding letter grade
                Console.WriteLine($"The letter grade is: {grade}");
                Console.WriteLine();

                // Ask the user if they want to enter another grade
                Console.Write("Do you want to enter another grade? (yes/no): ");
                string response = Console.ReadLine();
                Console.WriteLine();

                // Check the user's response (case-insensitive)
                if (!response.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    continueEntering = false; // Exit the loop if the user does not want to continue
                }
            }

            Console.WriteLine("Thank you for using the Grade Calculator!");
        }
    }
}
