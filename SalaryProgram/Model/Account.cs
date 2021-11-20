using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryProgram.Model
{

    public abstract class Account
    {
       public string Name { get; set; }
       public string Password { get; set; }
       public bool IsAdmin { get; set; }
       public int Salary { get; set; }
       public string Role { get; set; }

       public virtual void RemoveUser(string name, string password)
        {

        }
    }
}
