using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using SalaryProgram.Model;
using System.Linq;

namespace SalaryProgram.Controller
{
    public class UserCheck
    {

        private Dictionary<string, Account> allUsers;
        //Lägg till användare i Dictionary
        
        /// <summary>
        /// Checks if the user exists
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        public void IsUserOk(string name, string password)
        {
            


            if (allUsers.ContainsKey(name) && allUsers.ContainsKey(password))
            {
                
                View.LoggedIn.LoggedInView(name);

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
        public void RemoveOwnUser(string password, string username)
        {
            if (allUsers.ContainsKey(username) && allUsers.ContainsKey(password))
            {
                    allUsers.Remove(username);
            }
        }
    }
}
