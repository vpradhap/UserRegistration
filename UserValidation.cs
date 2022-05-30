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
        string FIRSTANDLASTNAME = "^[A-Z][A-Za-z]{2,}$";
        string EMAILID = "^[A-Za-z0-9]{3,}([_.+-]{1}[0-9A-Za-z]{1,}){0,}@[a-z0-9]+[.](com|net){0,1}([.]((com)|([a-z]{2}){0,1})){0,1}$";
        string MOBILE = "^[+][0-9]{1,3}[ ][1-9]{1}[0-9]{9}$";
        string PASSWORD_R1 = "[A-Za-z0-9]{8,}";
        string PASSWORD_R2 = "^(?=.*[A-Z]).{8,}$";
        string PASSWORD_R3 = "^(?=.*[A-Z0-9]).{8,}$";
        string PASSWORD_R4 = "^(?=.*[A-Z0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
        public void FirstName()
        {
            Console.Write("\nEnter your first name : ");
            string input = Console.ReadLine();

            if(Regex.IsMatch(input, FIRSTANDLASTNAME))
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

            if (Regex.IsMatch(input,FIRSTANDLASTNAME))
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
        public void EmailId()
        {
            Console.Write("\nEnter your Email Id : ");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, EMAILID))
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
        public void Mobile()
        {
            Console.Write("\nEnter your mobile number with country code followed by a space : ");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, MOBILE))
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
        public void Password_R1()
        {
            Console.Write("\nEnter your password (minimum 8 characters) : ");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, PASSWORD_R1))
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
        public void Password_R2()
        {
            Console.Write("\nEnter your password (minimum 8 characters and one uppercase) : ");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, PASSWORD_R2))
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
        public void Password_R3()
        {
            Console.Write("\nEnter your password (min 8 characters , one uppercase and one number) : ");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, PASSWORD_R3))
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
        public void Password_R4()
        {
            Console.Write("\nEnter your password (min 8 characters , one uppercase , one number and exactly one special character) : ");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, PASSWORD_R4))
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
