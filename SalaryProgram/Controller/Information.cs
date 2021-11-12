using System;
using System.Collections.Generic;
using System.Text;
using SalaryProgram.Model;

namespace SalaryProgram.Controller
{
    class Information
    {

        private  Dictionary<string, Account> allUsers;
        public void DisplayInfo()
        {
            //Skriv metod som visar användaren salary och role.
            //Även alternativet att ta bort användaren?

            allUsers = new Dictionary<string, Account>();

        }

        /// <summary>
        /// Returns Account if it excists else null
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Account GetAccount(string user)
        {
            if (allUsers.ContainsKey(user))
                return allUsers[user];
            return null;
        }

        /// <summary>
        /// Removes an Account unless it is an admin. True if it is successfull
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool RemoveAccount(string user)
        {
            if (allUsers.ContainsKey(user))
                if (allUsers[user].IsAdmin)
                {
                    allUsers.Remove(user);
                    return true;
                }
            return false;
        }

        /// <summary>
        /// Returns true if a unique user is added
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool AddNewUser(Account user)
        {
            if (allUsers.ContainsKey(user.Name)) return false;
            allUsers.Add(user.Name, user);
            return true;
        }
    }
}
