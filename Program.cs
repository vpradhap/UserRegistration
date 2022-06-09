using UserRegistration;

Console.WriteLine("\n\t\tUser Registration Program");
UserValidation validation = new UserValidation(); 
int flag = 0;
while (flag == 0)
{
    Console.WriteLine("\n1 - Validate first name");
    Console.WriteLine("2 - Validate Last name");
    Console.WriteLine("3 - Validate Email Id");
    Console.WriteLine("4 - Validate Mobile number");
    Console.WriteLine("5 - Validate password rule 1");
    Console.WriteLine("6 - Validate password rule 1 and rule 2 combined");
    Console.WriteLine("7 - Validate password rule 1 , rule 2 and rule 3 combined");
    Console.WriteLine("8 - Validate password rule 1 , rule 2 , rule 3 and rule 4 combined");
    Console.WriteLine("9 - Validate More Email Id's");
    Console.WriteLine("10 - Validation using lambda");

    Console.Write("\nEnter your choice : ");
    string pick = Console.ReadLine();
    switch (pick)
    {   
        case "1":
            validation.FirstName();
            break;
        case "2":
            validation.LastName();
            break;
        case "3":
            validation.EmailId();
            break;
        case "4":
            validation.Mobile();
            break;
        case "5":
            validation.Password_R1();
            break;
        case "6":
            validation.Password_R2();
            break;
        case "7":
            validation.Password_R3();
            break;
        case "8":
            validation.Password_R4();
            break;
        case "9":
            validation.EmailTest();
            break;
        case "10":
            Console.Write("\nEnter your first name : ");
            string first = Console.ReadLine();
            Console.Write("\nValidation result : ");
            Console.WriteLine(validation.First(first));
            Console.Write("\nEnter your last name : ");
            string last = Console.ReadLine();
            Console.Write("\nValidation result : "); 
            Console.WriteLine(validation.Last(last));
            Console.Write("\nEnter your Email ID : ");
            string email = Console.ReadLine();
            Console.Write("\nValidation result : ");
            Console.WriteLine(validation.Email(email));
            Console.Write("\nEnter your phone number : ");
            string phonenum = Console.ReadLine();
            Console.Write("\nValidation result : ");
            Console.WriteLine(validation.Email(phonenum));
            Console.Write("\nEnter your password : ");
            string password = Console.ReadLine();
            Console.Write("\nValidation result : ");
            Console.WriteLine(validation.Email(password));
            break;
        default:
            flag = 1;
            Console.WriteLine("\nEnter valid choice");
            break;
    }
}