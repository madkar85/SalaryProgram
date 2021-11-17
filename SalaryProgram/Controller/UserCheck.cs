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
    }
}
