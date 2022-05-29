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
        default:
            flag = 1;
            Console.WriteLine("\nEnter valid choice");
            break;
    }
}