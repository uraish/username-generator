using System;
using System.Globalization;

namespace Username_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the username.");
            string username = Console.ReadLine();
            DateTime date;
            Console.WriteLine("Please enter your date of birth in DD/MM/YYYY format.\n");
            var dob = Console.ReadLine();

            if (DateTime.TryParseExact(dob.ToString(), "d/M/yyyy",CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine("Your username is: " + username.ToLower() + date.ToString("ddMMyyyy"));
            }
            else
            {
                Console.WriteLine("Invalid date of birth");
            }
        }
    }
}
