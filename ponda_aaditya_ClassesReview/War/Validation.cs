using System;
using System.Collections.Generic;
using System.Text;

namespace War
{
    class Validation
    {
        /* Validate a string that it is not empty */
        public static string ValidateString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("Please enter valid input ");
                input = Console.ReadLine();
            }
            return input;
        }

        /* Validate if passed input is a number */
        public static int ValidateNumber(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int number;
            bool valid = int.TryParse(input, out number);
            while (string.IsNullOrWhiteSpace(input) || !valid)
            {
                Console.Write("Please enter valid number ");
                input = Console.ReadLine();
                valid = int.TryParse(input, out number);
            }
            return number;
        }

        /* Validate if passed number is in the given range */
        public static int ValidateRange(string message, int FromNumber, int ToNumber)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int number;
            bool valid = int.TryParse(input, out number);
            while (string.IsNullOrWhiteSpace(input) || !valid || number < FromNumber || number > ToNumber)
            {
                Console.Write($"Please enter valid number between {FromNumber} and {ToNumber} ");
                input = Console.ReadLine();
                valid = int.TryParse(input, out number);
            }
            return number;
        }

        /* Validate if passed input is in the given list */
        public static string ValidatInList(string message, List<string> listOfValues)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input) || !listOfValues.Contains(input))
            {
                Console.Write("Please enter valid value ");
                input = Console.ReadLine();
            }
            return input;
        }

    }
}
