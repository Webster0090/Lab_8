using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4;)
            {
                try
                {

                    Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 0-13):");
                    int userInput = int.Parse(Console.ReadLine());
                    StudentFacts(userInput);
                    Console.WriteLine("Would you like to know more? (y/n)");
                    string userContinue = Console.ReadLine();
                    if (userContinue == "n")
                    {
                        return;
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("This is not valid input");
                }
            }
        }
        public static void StudentFacts(int userInput)
        {
            string[,] studentFacts = new string[14, 3]
            {
                {"Jacky", "Rochester, MI", "Sushi"},
                {"Levi", "Detroit, MI", "Pizza"},
                { "Brian", "West Bloomfield, MI", "Turkey Burger"},
                {"Ronald", "Lincoln Park, MI", "Saganaki"},
                {"Laura", "Albuquerque, NM", "Bibimbap"},
                {"Kent", "Sterling Heights, MI", "Pizza"},
                {"Justin", "Warren, MI", "Quesadillas"},
                {"Evan", "Waterville, OH", "Grilled Octopus" },
                {"Steve W", "Perrysburg, OH", "Pizza"},
                {"Kendra", "Oak Park, MI", "Veggie Burger & Fries"},
                {"AK", "San Diego, CA", "Burger"},
                {"Tommy", "Raliegh, NC", "Chicken Curry"},
                { "Mauricio", "Detroit, MI", "Grilled Chicken"},
                { "Rudy", "Detroit, MI", "Veggies"},
            };
            try
            {
                Console.WriteLine(studentFacts[userInput, 0]);
                Console.WriteLine("What would you like to know about? The students hometown or favorite food?");
                string fact = Console.ReadLine().ToLower();
                if (fact == "hometown")
                {
                    Console.WriteLine(studentFacts[userInput, 1]);
                }
                else if (fact == "favorite food")
                {
                    Console.WriteLine(studentFacts[userInput, 2]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Please try again");
            }
        }
    }
    
}
                
                
                
                
                
