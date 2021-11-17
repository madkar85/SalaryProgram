using SalaryProgram.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryProgram
{
    public class Login
    {
        public static void Start()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please enter your username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            UserCheck userCheck = new UserCheck();
            userCheck.IsUserOk(username, password);
        }
    }
}
