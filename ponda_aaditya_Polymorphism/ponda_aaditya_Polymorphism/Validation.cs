/* 
 * Name: Aaditya Ponda
 * Date: Jan 11 2022
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponda_aaditya_Polymorphism
{
    public static class Validation
    {
        // validates if details are correct or false
        /* Validate a string that it is not empty */
        public static string ValidateString(string message)
        {
            Console.Write(message + " ");
            string input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("Please enter valid string ");
                input = Console.ReadLine();
            }
            Console.WriteLine();
            return input;
        }

        /* Validate if passed input is a number */
        public static int ValidateNumber(string message)
        {
            Console.Write(message + " ");
            string input = Console.ReadLine();
            int number;
            bool valid = int.TryParse(input, out number);
            while (string.IsNullOrWhiteSpace(input) || !valid)
            {
                Console.Write("Please enter valid number ");
                input = Console.ReadLine();
                valid = int.TryParse(input, out number);
            }
            Console.WriteLine();
            return number;
        }

        /* Validate if passed number is in the given range */
        public static int ValidateRange(string message, int FromNumber, int ToNumber)
        {
            Console.Write(message + " ");
            string input = Console.ReadLine();
            int number;
            bool valid = int.TryParse(input, out number);
            while (string.IsNullOrWhiteSpace(input) || !valid || number < FromNumber || number > ToNumber)
            {
                Console.Write($"Please enter valid number between {FromNumber} and {ToNumber} ");
                input = Console.ReadLine();
                valid = int.TryParse(input, out number);
            }
            Console.WriteLine();
            return number;
        }

        /* Validate if passed input is in the given list */
        public static string ValidatInList(string message, List<string> listOfValues)
        {
            Console.Write(message + " ");
            string input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input) || !listOfValues.Contains(input))
            {
                Console.Write("Please enter valid value ");
                input = Console.ReadLine().ToUpper();
            }
            Console.WriteLine();
            return input;
        }

    }
}
