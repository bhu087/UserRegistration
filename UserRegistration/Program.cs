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
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            while (!userValidation.ValidateEmail(email))
            {
                Console.WriteLine("Enter Valid email");
                email = Console.ReadLine();
            }
            Console.WriteLine("Enter Mobile Number");
            string mobileNumber = Console.ReadLine();
            while (!userValidation.ValidateMobileNumber(mobileNumber))
            {
                Console.WriteLine("Enter Valid mobile Number");
                mobileNumber = Console.ReadLine();
            }
            Console.WriteLine("Enter Password");
            string Password = Console.ReadLine();
            while (!userValidation.ValidatePassword(Password))
            {
                Console.WriteLine("Enter Valid password");
                Password = Console.ReadLine();
            }
        }
    }
}
