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
            try
            {
                if (input.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_STRING, "\n\nFirst name should not be empty\n");
                }
                if (input.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_STRING, "\n\nFirst name should not be null\n");
                }
                if (Regex.IsMatch(input, FIRSTANDLASTNAME))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n" + input + " is valid");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new CustomException(CustomException.ExceptionType.INVALID_STRING, "\n\nFirst name should be valid\n");
                    Console.ResetColor();
                }
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void LastName()
        {
            Console.Write("\nEnter your last name : ");
            string input = Console.ReadLine();

            try
            {
                if (input.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_STRING, "\n\nLast name should not be empty\n");
                }
                if (input.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_STRING, "\n\nLast name should not be null\n");
                }
                if (Regex.IsMatch(input, FIRSTANDLASTNAME))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n" + input + " is valid");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new CustomException(CustomException.ExceptionType.INVALID_STRING, "\n\nLast name should be valid\n");
                    Console.ResetColor();
                }
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void EmailId()
        {
            Console.Write("\nEnter your Email Id : ");
            string input = Console.ReadLine();

            try
            {
                if (input.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_STRING, "\n\nEmail Id should not be empty\n");
                }
                if (input.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_STRING, "\n\nEmail Id should not be null\n");
                }
                if (Regex.IsMatch(input, EMAILID))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n" + input + " is valid");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new CustomException(CustomException.ExceptionType.INVALID_STRING, "\n\nEmail Id should be valid\n");
                    Console.ResetColor();
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Mobile()
        {   
            Console.Write("\nEnter your mobile number with country code followed by a space : ");
            string input = Console.ReadLine();
            try
            {
                if (input.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_STRING, "\n\nmobile number should not be empty\n");
                }
                if (input.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_STRING, "\n\nmobile number should not be null\n");
                }
                if (Regex.IsMatch(input, EMAILID))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n" + input + " is valid");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new CustomException(CustomException.ExceptionType.INVALID_STRING, "\n\nmobile number should be valid\n");
                    Console.ResetColor();
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
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
            try
            {
                if (input.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_STRING, "\n\npassword should not be empty\n");
                }
                if (input.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_STRING, "\n\npassword should not be null\n");
                }
                if (Regex.IsMatch(input, PASSWORD_R4))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n" + input + " is valid");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new CustomException(CustomException.ExceptionType.INVALID_STRING, "\n\npassword should be valid\n");
                    Console.ResetColor();
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void EmailTest()
        {
            List<string> email = new List<string>()
            {
                 "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au"
            };
            foreach(string input in email)
            {
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

            
        }
    }
}
