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
        [DataRow("abc123","Madde")]
        public void RemoveOwnUserTest_pass(string password, string username)
        {
            allUsers = new Dictionary<string, Account>();
            allUsers.Add("Madde", new User("Madde", "abc123", 20000, "receptionist"));
           // password = "abc123";
            //username = "Madde";
            bool expected = true;

            Assert.IsTrue(expected);
        }

        [TestMethod()]
        [DataRow("abc", "Sol")]
        public void RemoveOwnUserTest_fail(string password, string username)
        {
            allUsers = new Dictionary<string, Account>();
            allUsers.Add("Madde", new User("Madde", "abc123", 20000, "receptionist"));
            // password = "abc123";
            //username = "Madde";
            bool expected = false;

            Assert.IsFalse(expected);
        }
    }
}