using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaryProgram.Controller;
using SalaryProgram.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryProgram.Controller.Tests
{
    [TestClass()]
    public class InformationTests
    {
        public static Dictionary<string, Account> allUsers;

        [TestMethod()]
        [DataRow("Madde", "abc123")]
        public void DisplayInfoTest(string name, string password)
        {
            allUsers = new Dictionary<string, Account>();
            allUsers.Add("Madde", new User(name, password, 20000, "receptionist"));

            var result = Information.DisplayInfo(name, allUsers);
            var expected = true;

            Assert.AreEqual(result, expected);
        }


        [TestMethod()]
        [DataRow("Lee", null)]
        [DataRow(null, null)]
        public void GetAccountTest(string name, string result)
        {
            var actual = Information.GetAccount(name);
            var res = result;

            Assert.AreEqual(result, res);
        }

        [TestMethod()]
        [DataRow("lee", true)]
        [DataRow(null, false)]
        public void AddNewUserTest(string name, bool result)
        {
            var actual = Information.AddNewUser(new User(name, "qwerty", 20000, "bouncer"));

            Assert.AreEqual(result, actual);
        }

        [TestMethod()]
        [DataRow("lee2", false)]
        public void RemoveAccountTest(string name, bool result)
        {
            var actual = Information.RemoveAccount(name);
            Assert.AreEqual(result, actual);
        }
    }
}