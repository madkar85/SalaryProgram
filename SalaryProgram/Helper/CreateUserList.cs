using SalaryProgram.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryProgram.Helper
{
    public class CreateUserList
    {
        public static Dictionary<string, Account> allUsers;

        public static Dictionary<string, Account> UserList()
        {
            allUsers = new Dictionary<string, Account>();
            allUsers.Add("Madde", new User("Madde", "abc123", 20000, "receptionist"));

            return allUsers;
        }
    }
}
