using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SalaryProgram.View
{
    public class Exit
    {
        /// <summary>
        /// Shows a message that the user is logged out
        /// </summary>
        public static void ExitView()
        {
            Console.WriteLine("You are now logged out and the program will end.");
            Thread.Sleep(300);
        }
    }
}
