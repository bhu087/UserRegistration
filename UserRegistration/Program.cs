using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            UserValidation userValidation = new UserValidation();
            Console.WriteLine("Welcome to User registration");
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            while (!userValidation.ValidateFirstName(firstName))
            {
                Console.WriteLine("Enter Valid Name");
                firstName = Console.ReadLine();
            }
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            while (!userValidation.ValidateLastName(lastName))
            {
                Console.WriteLine("Enter Valid Name");
                lastName = Console.ReadLine();
            }
        }
    }
}
