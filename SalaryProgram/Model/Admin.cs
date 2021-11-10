using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryProgram.Model
{
    public class Admin : Account
    {
        public Admin(string name, string password)
        {
            this.Name = name;
            this.Password = password;
            this.IsAdmin = true;
        }


    }
}
