using UserRegistration;

Console.WriteLine("\n\t\tUser Registration Program");
UserValidation validation = new UserValidation(); 
int flag = 0;
while (flag == 0)
{
    Console.WriteLine("\n1 - Validate first name");
    Console.WriteLine("2 - Validate Last name");

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
        default:
            flag = 1;
            Console.WriteLine("\nEnter valid choice");
            break;
    }
}