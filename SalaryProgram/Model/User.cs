using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryProgram.Model
{
    public class User: Account
    {
        public User(string name, string password, int salary, string role)
        {
            this.Name = name;
            this.Password = password;
            this.IsAdmin = false;
            this.Salary = salary;
            this.Role = role;
        }

        public override void RemoveUser(string name, string password)
        {
            base.RemoveUser(name, password);
        }
    }
}
