using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using SalaryProgram.Model;
using System.Linq;
using System.Threading;

namespace SalaryProgram.Controller
{
    public class UserCheck
    {

        /// <summary>
        /// Checks if the user exists
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        public void IsUserOk(string name, string password, Dictionary<string, Account> userList)
        {



            if (userList.ContainsKey(name) && userList[name].Password == password)
            {
                if (userList[name].IsAdmin)
                {
                    View.LoggedIn.LoggedInAdminView(name, userList);
                }
                else
                {
                    View.LoggedIn.LoggedInUserView(name, userList);
                }
            }
            else
            {
                Console.WriteLine("Wrong credentials, please try again.");
            }
        }

        /// <summary>
        /// Checks if the user exists and removes them
        /// </summary>
        /// <param name="password"></param>
        /// <param name="username"></param>
        public static bool RemoveOwnUser(string password, string username, Dictionary<string, Account> userList)
        {
            if (userList.ContainsKey(username) && userList[username].Password == password)
            {
                userList.Remove(username);
                Console.WriteLine("Your user is removed");
                Thread.Sleep(3000);
                return true;
            }
            return false;
        }
    }
}
