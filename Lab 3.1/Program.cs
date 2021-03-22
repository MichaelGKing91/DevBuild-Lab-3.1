using System;

namespace Lab_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to lab 3.1!");
            string another = "";
            do
            {
                string[] names = {"Mike","Sherman","Blake" };
                string[] favFood = { "pineapple chunks", "pizza", "tacos" };
                string[] preTitle = { "Surgical technologist", "Dish washer", "Insurance adjuster" };

                
                Console.Write("Which student would you like to know about? (Enter: 1,2, or 3)");
                int student = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                while (student != 1 && student != 2 && student != 3)
                {
                    try
                    {
                        Console.WriteLine("Invalid Entry! || Please enter 1, 2, or 3 to select a student: ");
                        student = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Entry! || Please enter 1, 2, or 3 to select a student: ");
                        student = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine($"Student {student}: {names[student - 1]}.");
                Console.WriteLine($"What would you like to know about {names[student-1]}? (enter \"favorite food\" or \"previous title\"): ");
                string choice = Console.ReadLine().ToLower();
                Console.WriteLine();

                while (choice != "favorite food" && choice != "previous title")
                {
                    Console.WriteLine("Error || Invalid input detected (Please enter \"favorite food\" or \"previous title\"): ");
                    choice = Console.ReadLine().ToLower();
                }
                Console.WriteLine();

                if (choice == "favorite food")
                {
                    Console.WriteLine($"{names[student - 1]}'s favorite food is {favFood[student - 1]}.");
                }
                else
                {
                    Console.WriteLine($"{names[student - 1]}'s previous title was {preTitle[student - 1]}.");
                }
                Console.WriteLine();


                Console.Write("Would you like to access another student's information? (Y/N)");
                another = Console.ReadLine().ToLower();
            } while (another == "yes" || another == "y");
        }
    }
}
