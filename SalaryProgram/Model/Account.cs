using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryProgram.Model
{
    /*
    public enum Role
    {
        Admin = 1, 
        User
    }
    */
    public abstract class Account
    {
       protected string Name { get; set; }
       protected string Password { get; set; }
       protected bool IsAdmin { get; set; }
       protected int Salary { get; set; }
       //protected enum Role { get; set; }
       protected string Role { get; set; }

       public virtual void RemoveUser(string name, string password)
        {

        }
    }
}
