using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string ControllUser = "admin";
            string ControllPass = "admin";
            string UserName;
            string UserPassword;
            int userTry = 0;
            while (userTry < 3)
            {
                Console.WriteLine("User:");
                UserName = Console.ReadLine();
                Console.WriteLine("Password:");
                UserPassword = Console.ReadLine();

                // match guess to correct number
                if (UserName != ControllUser && UserPassword != ControllPass)
                {
                    // set error message
                    Console.WriteLine($"Incorrect credentials, you have {2 - userTry} chances left");
                    userTry++;

                }
                else if (UserName == ControllUser && UserPassword == ControllPass)
                {
                    Console.WriteLine("You were correct!");
                    break;
                }
            }
        }
    }
}
