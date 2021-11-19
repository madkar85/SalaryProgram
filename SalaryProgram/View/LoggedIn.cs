using Microsoft.VisualBasic;
using SalaryProgram.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace SalaryProgram.View
{
    public class LoggedIn
    {
        /// <summary>
        /// The menu when the user is logged in
        /// </summary>
        /// <param name="user"></param>
        public static void LoggedInView(string user, Dictionary<string, Account> userList)
        {
            bool keepgoing = true;

            Console.WriteLine("Welcome!");
            while (keepgoing)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. View information");
                Console.WriteLine("2. Remove user");
                Console.WriteLine("3. Exit");
                string choice = Console.ReadLine();

                switch(choice){
                    case "1":
                        Controller.Information.DisplayInfo(user, userList);
                        break;
                    case "2":
                        View.RemoveOwnUser.RemoveOwnUserView(userList);
                        break;
                    case "3":
                        Exit.ExitView();
                        keepgoing = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input, try again.");
                        break;

                }
            }
            

        }
    }
}
