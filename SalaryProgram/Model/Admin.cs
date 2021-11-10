using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryProgram.Model
{
    public class Admin : Account
    {
        public Admin(string name, string password, int salary, string role)
        {
            this.Name = name;
            this.Password = password;
            this.IsAdmin = true;
            this.Salary = salary;
            this.Role = role;
        }

        public override void RemoveUser(string name, string password)
        {
            base.RemoveUser(name, password);
        }


    }
}
