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
        public static void LoggedInUserView(string user, Dictionary<string, Account> userList)
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
        /// <summary>
        /// The menu when admin is logged in
        /// </summary>
        /// <param name="user"></param>
        /// <param name="userList"></param>
        public static void LoggedInAdminView(string user, Dictionary<string, Account> userList)
        {
            bool keepgoing = true;

            Console.WriteLine("Welcome!");
            while (keepgoing)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. View information");
                Console.WriteLine("2. Search for user");
                Console.WriteLine("3. Remove user");
                Console.WriteLine("4. Add user");
                Console.WriteLine("5. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Controller.Information.DisplayInfo(user, userList);
                        break;
                    case "2":
                        Console.WriteLine("Which user are you looking for?");
                        string username = Console.ReadLine();
                        Controller.Information.GetAccount(username);                       
                        break;
                    case "3":
                        Console.WriteLine("Which user do you want to remove?");
                        username = Console.ReadLine();
                        Controller.Information.RemoveAccount(username);
                        break;
                    case "4":
                        Console.WriteLine("Which user do you want to add?");
                        username = Console.ReadLine();
                        Controller.Information.AddNewUser(userList[username]);
                        break;
                    case "5":
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
