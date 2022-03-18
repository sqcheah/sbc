using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ShuttleBusCentral;
using System.Text.RegularExpressions;

namespace SBCTest
{
    [TestClass]
    public class UnitTestCustomer
    {
        Customer cusData=null;
        [TestMethod]
        public void TestWithBlankData()
        {
            Customer cus = new Customer();
            Assert.ThrowsException<System.ArgumentException>(()=>validateCustomer(cus));
        }
        [TestMethod]
        public void TestWithIncorrectPhoneNumberFormat()
        {
            Customer cus = new Customer();
            cus.name = "Jacky Su Leh Hong";
            cus.phoneNum = "012abc234";
            cus.IC = "910101020406";
            cus.bankAcc = "2953622265681289";
            cus.email = "test@gmail.com";
            Assert.ThrowsException<System.ArgumentException>(() => validateCustomer(cus));
        }
        [TestMethod]
        public void TestWithIncorrectPhoneNumberMalaysiaFormat()
        {
            Customer cus = new Customer();
            cus.name = "Jacky Su Leh Hong";
            cus.phoneNum = "01223456789";
            cus.IC = "910101020406";
            cus.bankAcc = "2953622265681289";
            cus.email = "test@gmail.com";
            Assert.ThrowsException<System.ArgumentException>(() => validateCustomer(cus));
        }
        [TestMethod]
        public void TestWithIncorrectICLength()
        {
            Customer cus = new Customer();
            cus.name = "Jacky Su Leh Hong";
            cus.phoneNum = "0102345678";
            cus.IC = "01234";
            cus.bankAcc = "2953622265681289";
            cus.email = "test@gmail.com";
            Assert.ThrowsException<System.ArgumentException>(() => validateCustomer(cus));
        }
        [TestMethod]
        public void TestWithIncorrectICFormat()
        {
            Customer cus = new Customer();
            cus.name = "Jacky Su Leh Hong";
            cus.phoneNum = "0102345678";
            cus.IC = "910abc20406";
            cus.bankAcc = "2953622265681289";
            cus.email = "test@gmail.com";
            Assert.ThrowsException<System.ArgumentException>(() => validateCustomer(cus));
        }
        [TestMethod]
        public void TestWithIncorrectBankAccountFormat()
        {
            Customer cus = new Customer();
            cus.name = "Jacky Su Leh Hong";
            cus.phoneNum = "0102345678";
            cus.IC = "910101020406";
            cus.bankAcc = "2953abc81289";
            cus.email = "test@gmail.com";
            Assert.ThrowsException<System.ArgumentException>(() => validateCustomer(cus));
        }
        [TestMethod]
        public void TestWithWrongEmailFormat()
        {
            Customer cus = new Customer();
            cus.name = "Jacky Su Leh Hong";
            cus.phoneNum = "0102345678";
            cus.IC = "910101020406";
            cus.bankAcc = "2953622265681289";
            cus.email = "test@gmail";
            Assert.ThrowsException<System.ArgumentException>(() => validateCustomer(cus));
        }
        [TestMethod]
        public void TestWithCorrectData()
        {
            Customer cus = new Customer();
            cus.name = "Jacky Su Leh Hong";
            cus.phoneNum = "0102345678";
            cus.IC = "910101020406";
            cus.bankAcc = "2953622265681289";
            cus.email = "test@gmail.com";
            Assert.AreEqual( validateCustomer(cus),"Success");
        }
        [TestMethod]
        public void TestInsertUpdateCus()
        {
            Customer cus = new Customer();
            cus.name = "Jacky Su Leh Hong";
            cus.phoneNum = "0102345678";
            cus.IC = "910101020406";
            cus.bankAcc = "2953622265681289";
            cus.email = "test@gmail.com";
            Assert.AreEqual(InsertUpdateCus(cus), "Insert");
            Assert.AreEqual(InsertUpdateCus(cus), "Update");
        }
        public string InsertUpdateCus(Customer cus)
        {
            if (validateCustomer(cus) == "Success")
            {
                if (cusData == null)
                {
                    cusData = cus;
                    return "Insert";
                }
                else
                {
                    return "Update";
                }
            }
            return "Fail";
        }

        public string validateCustomer(Customer cus)
        {
            if (String.IsNullOrEmpty(cus.phoneNum) || String.IsNullOrEmpty(cus.name) || String.IsNullOrEmpty(cus.IC) || String.IsNullOrEmpty(cus.email))
            {
                throw new ArgumentException("One or more required field is blank");
            }
            if (Regex.Matches(cus.phoneNum, @"^\d+$").Count == 0)
            {
                throw new ArgumentException("Phone number is not in number format");
            }
            cus.phoneNum = cus.phoneNum.TrimStart('0');
            if (Regex.Matches(cus.phoneNum, @"^11[0-9]{8}|1[02-9][0-9]{7}$").Count == 0)
            {
                throw new ArgumentException("Phone number is not in Malaysia format");
            }
            if (cus.IC.Length != 12)
            {
                throw new ArgumentException("IC number length is incorrect");
            }
            if (Regex.Matches(cus.IC, @"^\d+$").Count == 0)
            {
                throw new ArgumentException("IC number is not in number format");
            }
            if (Regex.Matches(cus.email, @"^[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+$").Count == 0)
            {
                throw new ArgumentException("Invalid email format");
            }
            if (!String.IsNullOrEmpty(cus.bankAcc))
            {
                if (Regex.Matches(cus.bankAcc, @"^\d+$").Count == 0)
                {
                    throw new ArgumentException("Bank Account is not in number format");
                }
            }
            return "Success";
        }
    }
}
