using SalaryProgram.Model;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SalaryProgram.Controller
{
    public class Information
    {

        /// <summary>
        /// Displays the information about the user
        /// </summary>
        /// <param name="user"></param>
        public static void DisplayInfo(string user, Dictionary<string, Account> userList)
        {
            Console.WriteLine("Username: " + userList[user].Name);
            Console.WriteLine("Salary: " + userList[user].Salary);
            Console.WriteLine("Role: " + userList[user].Role);
        }
    }
}
