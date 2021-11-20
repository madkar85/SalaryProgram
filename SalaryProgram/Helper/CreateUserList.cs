using SalaryProgram.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryProgram.Helper
{
    public class CreateUserList
    {
        public static Dictionary<string, Account> allUsers;
        /// <summary>
        /// Creates a Dictionary with the starting users
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, Account> UserList()
        {
            allUsers = new Dictionary<string, Account>();
            allUsers.Add("Madde", new User("Madde", "abc123", 20000, "receptionist"));
            allUsers.Add("admin1", new Admin("admin1", "admin1234", 25000, "admin"));

            return allUsers;
        }
    }
}
