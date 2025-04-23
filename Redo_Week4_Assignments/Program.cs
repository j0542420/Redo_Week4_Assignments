using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redo_Week4_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while loop to return to program menu
            while (true)
            {
                // display menu for user to pick an exercise from 1-4, 5 to exit
                Console.WriteLine("Pick an Excercise from 1 - 4 to pick on");
                Console.WriteLine("1. Exercise 1");
                Console.WriteLine("2. Exercise 2");
                Console.WriteLine("3. Exercise 3");
                Console.WriteLine("4. Exercise 4");
                Console.WriteLine("5. Exit");

                // get user input
                string choice = Console.ReadLine();

                // swtich statement to determine which exercise to run
                switch (choice)
                {
                    case "1":
                        // call exercise 1
                        Exercise1();
                        break;
                    case "2":
                        // call exercise 2
                        Exercise2();
                        break;
                    case "3":
                        // call exercise 3
                        Exercise3();
                        break;
                    case "4":
                        // call exercise 4
                        Exercise4();
                        break;
                    case "5":
                        // exit the program
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        static void Exercise1()
        {
            // Exercise 1 code here
            Console.WriteLine("You selected Exercise 1.");
            // user inputs an amount of currency
            Console.WriteLine("Enter an amount of currency:");
            // get user input
            string input = Console.ReadLine();

        }
        // method to Convert currency to USD
        public static double ConvertToUSD(double amount, string fromCurrency)
        {
            // conversion rates
            double conversionRate = 0.0;
            switch (fromCurrency.ToUpper())
            {
                case "EUR":
                    conversionRate = 1.1; // Example conversion rate
                    break;
                case "GBP":
                    conversionRate = 1.3; // Example conversion rate
                    break;
                case "JPY":
                    conversionRate = 0.009; // Example conversion rate
                    break;
                default:
                    Console.WriteLine("Invalid currency.");
                    return 0;
            }
            return amount * conversionRate;
        }
        static void Exercise2()
        {
            // Exercise 1 code here
            Console.WriteLine("You selected Exercise 2.");
            // Add your logic for Exercise 1
        }
        static void Exercise3()
        {
            // Exercise 1 code here
            Console.WriteLine("You selected Exercise 3.");
            // Add your logic for Exercise 1
        }
        static void Exercise4()
        {
            // Exercise 1 code here
            Console.WriteLine("You selected Exercise 4.");
            // Add your logic for Exercise 1
        }
    }
}
