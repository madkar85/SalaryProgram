using SalaryProgram.Model;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SalaryProgram.Controller
{
    public class Information
    {
        public static Dictionary<string, Account> allUsers;

        public static void DisplayInfo(string user)
        {
            allUsers = new Dictionary<string, Account>();
            //Skriv metod som visar användaren salary och role.
            //Även alternativet att ta bort användaren?
            Console.WriteLine("Username: " + allUsers[user].Name);
            Console.WriteLine("Salary: " + allUsers[user].Salary);
            Console.WriteLine("Role: " + allUsers[user].Role);
        }
    }
}
