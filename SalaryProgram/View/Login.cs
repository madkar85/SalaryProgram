using SalaryProgram.Controller;
using SalaryProgram.Model;
using System;
using System.Collections.Generic;
using System.Text;
using SalaryProgram.Helper;

namespace SalaryProgram
{
    public class Login
    {
        public static Dictionary<string, User> allUsers;

        /// <summary>
        /// The start view when the user logges in
        /// </summary>
        public static void Start()
        {
            Dictionary<string, Account> userList = CreateUserList.UserList();
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please enter your username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            UserCheck userCheck = new UserCheck();
            userCheck.IsUserOk(username, password, userList);
        }
    }
}
