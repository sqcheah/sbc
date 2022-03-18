using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShuttleBusCentral;
namespace SBCTest
{
    [TestClass]
    public class UnitTestLogin
    {
        
        string expectedUsername = "admin";
        string expectedPassword = "Test1234#";
        [TestMethod]
        public void TestLoginWithBlankUsernameAndPassword()
        {
            string actualusername = "";
            string actualPassword = "";
            Assert.ThrowsException<System.ArgumentException>(() => Login(actualusername, actualPassword, expectedUsername, expectedPassword));

        }
        [TestMethod]
        public void TestLoginWithWrongUsername()
        {

            string actualusername = "wronguser";
            string actualPassword = "Test1234#";
            Assert.ThrowsException<System.ArgumentException>(() => Login(actualusername, actualPassword, expectedUsername, expectedPassword));
        }
        [TestMethod]
        public void TestLoginWithWrongPassword()
        {

            string actualusername = "admin";
            string actualPassword = "wrongpass";
            Assert.ThrowsException<System.ArgumentException>(() => Login(actualusername, actualPassword, expectedUsername, expectedPassword));

        }
        [TestMethod]
        public void TestLoginWithCorrectUsernameAndPassword()
        {

            string actualusername = "admin";
            string actualPassword = "Test1234#";
            Assert.AreEqual(Login(actualusername, actualPassword, expectedUsername, expectedPassword), "Login success");
        }


        public string Login(string username, string password, string expectedUsername, string expectedPassword)
        {
            if (username == ""|| password=="")
            {
                throw new ArgumentException("Username or password is empty");
            }
       
            if (username == expectedUsername)
            {
                if (BCrypt.Net.BCrypt.Verify(password, encryptPassword(expectedPassword)))
                {
                    return "Login success";
                }
                else
                {
                    throw new ArgumentException("Login Fail:Incorrect Password");
                }
            }
            else
            {
                throw new ArgumentException("Login Fail:Incorrect Username");
            }

        }

        public string encryptPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
