// ===============================
// AUTHOR     : Jonathan Lubaway
// CREATE DATE: October 21st, 2019
// PURPOSE    : Write a program that will recognize invalid inputs using regular expressions
// ===============================
using System;
using System.Text.RegularExpressions;

namespace Lab_7_Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing the methods for different inputs
            Console.WriteLine("Names True " + ValidateNames("Jack"));
            Console.WriteLine("Names True " + ValidateNames("Fredericksonmandoodfaceperson"));
            Console.WriteLine("Names False " + ValidateNames("Fredericksonmandoodfacepersonthing"));
            Console.WriteLine("Names False " + ValidateNames("Jack2"));
            Console.WriteLine("Names False " + ValidateNames("Jack;"));
            Console.WriteLine("Emails True " + ValidateEmails("coolgai@gmail.com"));
            Console.WriteLine("Emails False " + ValidateEmails("uncool@wa.com;"));
            Console.WriteLine("Emails False " + ValidateEmails("not@gmail.com"));
            Console.WriteLine("Emails False " + ValidateEmails("nothing@gmail.c"));
            Console.WriteLine("Phone#s True " + ValidatePhoneNumbers("283-593-5239"));
            Console.WriteLine("Phone#s False " + ValidatePhoneNumbers("283593-5239"));
            Console.WriteLine("Phone#s False " + ValidatePhoneNumbers("283-5935239"));
            Console.WriteLine("Phone#s False " + ValidatePhoneNumbers("283-5a3-5239"));
            Console.WriteLine("Phone#s False " + ValidatePhoneNumbers("2a3-593-5239"));
            Console.WriteLine("Phone#s False " + ValidatePhoneNumbers("283-593-5a39"));
            Console.WriteLine("Dates True " + ValidateDates("09/12/1001"));
            Console.WriteLine("Dates False " + ValidateDates("092/12/1001"));
            Console.WriteLine("Dates False " + ValidateDates("09/122/1001"));
            Console.WriteLine("Dates False " + ValidateDates("09/12/10201"));
            Console.WriteLine("HTML True " + ValidateHTML("<h1></h1>"));
            Console.WriteLine("HTML False " + ValidateHTML("<h1</h1>"));
            Console.WriteLine("HTML False " + ValidateHTML("<h1>h1>"));
            Console.WriteLine("HTML False " + ValidateHTML("<h1></h1"));
            Console.WriteLine("HTML False " + ValidateHTML("<h1h1>"));
        }

        // Pattern for recognizing names
        public static bool ValidateNames(string input)
        {
            string pattern = @"^[A-Z]{1}[a-zA-Z]{0,29}$";
            return ValidateInput(input, pattern);
        }

        // Pattern for recognizing emails
        public static bool ValidateEmails(string input)
        {
            string pattern = @"^[A-Za-z0-9]{5,30}@[A-Za-z0-9]{5,10}.[A-Za-z0-9]{2,3}\b";
            return ValidateInput(input, pattern);
        }

        // Pattern for recognizing emails
        public static bool ValidatePhoneNumbers(string input)
        {
            string pattern = @"^[0-9]{3}-[0-9]{3}-[0-9]{4}\b";
            return ValidateInput(input, pattern);
        }

        // Pattern for recognizing dates
        public static bool ValidateDates(string input)
        {
            string pattern = @"^[0-9]{2}\/[0-9]{2}\/[0-9]{4}\b";
            return ValidateInput(input, pattern);
        }

        // Pattern for recognizing HTML tags
        public static bool ValidateHTML(string input)
        {
            string pattern = @"^<.{1,4}>.{0,}<.{1,4}>";
            return ValidateInput(input, pattern);
        }

        // This method matches the user's input to the inputted pattern and returns true or false as such
        public static bool ValidateInput(string input, string pattern)
        {
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            return false;
        }
    }
}
