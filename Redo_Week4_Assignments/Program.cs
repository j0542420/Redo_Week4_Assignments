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
                Console.WriteLine("Pick an Exercise");
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
                        // space between exercises
                        Console.WriteLine();
                        break;
                    case "2":
                        // call exercise 2
                        Exercise2();
                        // space between exercises
                        Console.WriteLine();
                        break;
                    case "3":
                        // call exercise 3
                        Exercise3();
                        // space between exercises
                        Console.WriteLine();
                        break;
                    case "4":
                        // call exercise 4
                        Exercise4();
                        // space between exercises
                        Console.WriteLine();
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
        // method to run exercise 1
        static void Exercise1()
        {
            // declaration of variables
            double amount = 0.0;
            string fromCurrency = "";
            double choice = 0;
            double convert = 0.0;
            while (true)
            { 
                // Exercise 1 code here
                Console.WriteLine("You selected Exercise 1.");
                // user inputs an amount of currency
                Console.WriteLine("Enter an amount of currency:");
                // get user input
                amount = Convert.ToDouble(Console.ReadLine());

                // asking the what currency they are using
                Console.WriteLine("Enter the currency you are using (USD, EUR, JPY):");
                // get user input
                fromCurrency = Console.ReadLine();

                // user picks the currency they want to convert to
                Console.WriteLine("Enter the currency you want to convert to (1. USD, 2. EUR, 3. JPY):");
                // using a input for the user to close the program
                Console.WriteLine("4. to exit");

                // user inputs their choice
                choice = Convert.ToInt32(Console.ReadLine());

                // switch statement to determine which currency to convert to
                switch (choice) 
                {
                    // convert the amount to USD
                    case 1:
                        convert = ConvertToUSD(amount, fromCurrency);
                        Console.WriteLine($"Converted amount: {convert:f2} USD");
                        break;
                    case 2:
                        // convert the amount to EUR
                        convert = ConvertToEUR(amount, fromCurrency);
                        Console.WriteLine($"Converted amount: {convert:f2} EUR");
                        break;
                    case 3:
                        // convert the amount to JPY
                        convert = ConvertToJPY(amount, fromCurrency);
                        Console.WriteLine($"Converted amount: {convert:f2} JPY");
                        break;
                    case 4:
                        // exit the program
                        Console.WriteLine("Exiting the program.");
                        return;

                }
            }


        }
        // method to Convert currency to USD
        public static double ConvertToUSD(double amount, string fromCurrency)
        {
            // convert currency based on user input
            switch (fromCurrency.ToUpper())
            {
                // USD to EUR
                case "EUR":
                    return amount / 0.96; // Example conversion rate
                // USD to JPY
                case "JPY":
                    return amount / 152.20; // Example conversion rate
                default:
                    Console.WriteLine("Invalid currency.");
                    return amount;
            }
        }
        // method to Convert currency to EUR
        public static double ConvertToEUR(double amount, string fromCurrency)
        {
            // convert currency based on user input
            switch (fromCurrency.ToUpper())
            {
                // EUR to USD
                case "EUR":
                    return amount * 0.96; // Example conversion rate
                // EUR to JPY
                case "JPY":
                    return amount / 152.20; // Example conversion rate
                default:
                    Console.WriteLine("Invalid currency.");
                    return amount;
            }
        }
        // method to Convert currency to JPY
        public static double ConvertToJPY(double amount, string fromCurrency)
        {
            // convert currency based on user input
            switch (fromCurrency.ToUpper())
            {
                // JPY to USD
                case "USD":
                    return amount * 152.20; // Example conversion rate
                // JPY to EUR
                case "EUR":
                    return amount * 0.96; // Example conversion rate
                default:
                    Console.WriteLine("Invalid currency.");
                    return amount;
            }
        }
        // method to run exercise 2
        static void Exercise2()
        {
            // Exercise 1 code here
            Console.WriteLine("You selected Exercise 2.");
            // title of the program
            Console.WriteLine("Welcome to the Grade Calculator!");

            // space between the title and the rest of the program
            Console.WriteLine();

            // asking user to input the grades for the assignments
            Console.WriteLine("Enter the grades for the 3 assignments:");
            Console.WriteLine("Please enter the grades separated by Enter:");
            // declare an array for the grades
            double[] assignments = new double[3];
            // loop to get the grades from the user
            for (int i = 0; i < assignments.Length; i++)
            {
                // get user input
                assignments[i] = Convert.ToDouble(Console.ReadLine());
            }

            // asking user to input the grades for the midterms
            Console.WriteLine("Enter the grades for the 2 midterms:");
            Console.WriteLine("Please enter the grades separated by Enter:");
            // declare an array for the midterms
            double[] midTerms = new double[2];
            // loop to get the grades from the user
            for (int i = 0; i < midTerms.Length; i++)
            {
                // get user input
                midTerms[i] = Convert.ToDouble(Console.ReadLine());
            }

            // asking user to input the grades for the final exam
            Console.WriteLine("Enter the grade for the final exam:");
            // declare a variable for the final exam
            double finalExam = Convert.ToDouble(Console.ReadLine());

            // calculate the average of the assignments
            double averageAssignments = CalculateAverage(assignments);
            // display the average of the assignments
            Console.WriteLine($"Average of assignments: {averageAssignments:f2}");

            // calculate the average of the midterms
            double averageMidTerms = CalculateAverage(midTerms);
            // display the average of the midterms
            Console.WriteLine($"Average of midterms: {averageMidTerms:f2}");

            // calculate the final grade
            double finalGrade = CalculateFinaleGrade(averageAssignments, averageMidTerms, finalExam);
            // display the final grade
            Console.WriteLine($"Final grade: {finalGrade:f2}");


        }
        // method to calculate avarage of the grades
        static double CalculateAverage(double[] grades)
        {
            // declare variables
            double score = 0;
            // check if the array is empty
            double sum = 0;
            foreach(var grade in grades)
            {
                // add the grades together
                sum += grade;
            }
            // calculate the average
            score = sum / grades.Length;
            // return the average
            return score;
        }
        // method to calculate the final grade
        public static double CalculateFinaleGrade(double assignments, double midTerms, double finalExam) 
        {
            double finalGrade = 0;
            finalGrade = (assignments * 0.4) + (midTerms * 0.2) + (finalExam * 0.4);
            return finalGrade;
        }
        // method to run exercise 3

        static void Exercise3()
        {
            // Exercise 1 code here
            Console.WriteLine("You selected Exercise 3.");

            // space between the title and the rest of the program
            Console.WriteLine();

            // asking user to input a string
            Console.WriteLine("Enter a string:");
            // get user input
            string input = Console.ReadLine();

            // calling the method to reverse the string
            string reversed = ReverseString(input);
            // display the reversed string
            Console.WriteLine($"Reversed string: {reversed}");

            // calling the method to count the number of vowels
            int vowelCount = CountVowels(input);
            // display the number of vowels
            Console.WriteLine($"Number of vowels: {vowelCount}");

            // calling the method to check if the string is a palindrome
            bool isPalindrome = IsPalindrome(input);
            // display if the string is a palindrome
            if (isPalindrome)
            {
                Console.WriteLine($"{input} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome.");
            }
        }
        // method to reverse a string
        public static string ReverseString(string input)
        {
            // declare a variable for the reversed string
            string reversed = "";
            // loop to reverse the string
            for (int i = input.Length - 1; i >= 0; i--)
            {
                // add the characters to the reversed string
                reversed += input[i];
            }
            // return the reversed string
            return reversed;
        }
        // method to count the number of vowels in a string
        public static int CountVowels(string input)
        {
            // declare a variable for the number of vowels
            int count = 0;
            string vowels = "aeiou";
            // loop to count the vowels
            foreach (char c in input.ToLower())
            { 
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            // return the number of vowels
            return count;
        }
        // method to check if the string is a palindrome
        public static bool IsPalindrome(string input)
        {
            // declare a variable for the reversed string
            string reversed = ReverseString(input);
            // check if the string is a palindrome
            return (input.ToLower() == ReverseString(input));
        }
        // method to run exercise 4
        static void Exercise4()
        {
            // Exercise 1 code here
            Console.WriteLine("You selected Exercise 4.");

            // space between the title and the rest of the program
            Console.WriteLine();

            // declarations of the array
            int[] num = {1,2,3,4,5,6,7,8,9,10};
            int sum = sumArray(num);
            int max = maxArray(num);
            int min = minArray(num);
            int[] reverse = reverseArray(num);

            //loop through the array
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i + 1;
            }

            // outputs the method to print the array
            Console.WriteLine("The array is:");
            printArray(num);

            // outputs the method to sum the array
            Console.WriteLine($"The sum of the array is: {sum}");

            // outputs the method to find the max of the array
            Console.WriteLine($"The max of the array is: {max}");

            // outputs the method to find the min of the array
            Console.WriteLine($"The min of the array is: {min}");

            // outputs the method to reverse the array
            Console.WriteLine("The reversed array is:");
            printArray(reverse);
        }
        // method to print out the array
        public static void printArray(int[] num)
        {
            // loop through the array
            for (int i = 0; i < num.Length; i++)
            {
                // print out the array
                Console.WriteLine(num[i]);
            }
            // space between the array and the rest of the program
            Console.WriteLine();
        }
        // method to sum the array
        public static int sumArray(int[] num)
        {
            // declare a variable for the sum
            int sum = 0;
            // loop through the array
            for (int i = 0; i < num.Length; i++)
            {
                // add the numbers together
                sum += num[i];
            }
            // return the sum
            return sum;
        }
        // method to find the max of the array
        public static int maxArray(int[] num)
        {
            // declare a variable for the max
            int max = num[0];
            // loop through the array
            for (int i = 0; i < num.Length; i++)
            {
                // check if the number is greater than the max
                if (num[i] > max)
                {
                    // set the max to the number
                    max = num[i];
                }
            }
            // return the max
            return max;
        }
        // method to find the min of the array
        public static int minArray(int[] num)
        {
            // declare a variable for the min
            int min = num[0];
            // loop through the array
            for (int i = 0; i < num.Length; i++)
            {
                // check if the number is less than the min
                if (num[i] < min)
                {
                    // set the min to the number
                    min = num[i];
                }
            }
            // return the min
            return min;
        }
        // method to reverse the array
        public static int[] reverseArray(int[] num)
        {
            // declare a variable for the reversed array
            int[] reversed = new int[num.Length];
            // loop through the array
            for (int i = 0; i < num.Length; i++)
            {
                // set the reversed array to the number
                reversed[i] = num[num.Length - 1 - i];
            }
            // return the reversed array
            return reversed;
        }
    }
}
