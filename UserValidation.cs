using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserValidation
    {
        string CONDITION = "^[A-Z][A-Za-z]{2,}$";
        public void FirstName()
        {
            Console.Write("\nEnter your first name : ");
            string input = Console.ReadLine();

            if(Regex.IsMatch(input, CONDITION))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n"+input + " is valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n"+input + " is invalid\t ( Try again )");
                Console.ResetColor();
            }
        }
        public void LastName()
        {
            Console.Write("\nEnter your last name : ");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, CONDITION))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n" + input + " is valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + input + " is invalid\t ( Try again )");
                Console.ResetColor();
            }
        }
    }
}
