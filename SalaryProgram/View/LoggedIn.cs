using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;


namespace SalaryProgram.View
{
    public class LoggedIn
    {
        public static void LoggedInView(string user)
        {
            bool keepgoing = true;

            Console.WriteLine("Welcome!");
            while (!keepgoing)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. View information");
                Console.WriteLine("2. Remove user");
                Console.WriteLine("3. Exit");
                string choice = Console.ReadLine();

                switch(choice){
                    case "1":
                        Controller.Information.DisplayInfo(user);
                        break;
                    case "2":
                        //Lägg till metod RemoveUser
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
