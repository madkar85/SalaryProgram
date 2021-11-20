using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaryProgram.Controller;
using SalaryProgram.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryProgram.Controller.Tests
{
    [TestClass()]
    public class UserCheckTests
    {
        public static Dictionary<string, Account> allUsers;

        [TestMethod()]
        [DataRow("abc123", "Madde", true)]
        [DataRow("abc", "Sol", false)]
        public void RemoveOwnUserTest_pass(string password, string username, bool expected)
        {
            allUsers = new Dictionary<string, Account>();
            allUsers.Add("Madde", new User(username, password, 20000, "receptionist"));

            var result = UserCheck.RemoveOwnUser(password, username, allUsers);

            Assert.AreEqual(result, expected);
           
        } 
    }
}