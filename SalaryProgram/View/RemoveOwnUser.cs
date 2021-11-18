using SalaryProgram.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryProgram.View
{
    public class RemoveOwnUser
    {
        /// <summary>
        /// The view when the user chooses to remove their own user
        /// </summary>
        public static void RemoveOwnUserView(Dictionary<string, Account> userList)
        {
            Console.WriteLine("Type your username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Type you password: ");
            string password = Console.ReadLine();

            Controller.UserCheck.RemoveOwnUser(username, password, userList);
        }
    }
}
