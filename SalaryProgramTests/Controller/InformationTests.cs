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
        [DataRow("Madde","abc123")]
        public void DisplayInfoTest(string name, string password)
        {
            allUsers = new Dictionary<string, Account>();
            allUsers.Add("Madde", new User(name, password, 20000, "receptionist"));

            var result = Information.DisplayInfo(name, allUsers);
            var expected = true;

            Assert.AreEqual(result, expected);
        }

    }
}