using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ShuttleBusCentral;
namespace SBCTest
{
    [TestClass]
    public class UnitTestMileageAndPermitCheck
    {
        int mileageLimit = 7000;
        int permitDayBefore = 7;
        [TestMethod]
        public void testMileageWithLessAmount()
        {
            int actualMileage = 10000;
            int lastServiceMileage = 7000;
            Assert.IsFalse(checkMileage(actualMileage, lastServiceMileage));

        }
        [TestMethod]
        public void testMileageWithBigAmount()
        {
            int actualMileage = 25000;
            int lastServiceMileage = 12000;
            Assert.IsTrue(checkMileage(actualMileage, lastServiceMileage));

        }
        [TestMethod]
        public void testPermitWithFurtherDate()
        {
            DateTime actualDate = DateTime.Now.AddDays(30);
            Assert.IsFalse(checkPermitExpiry(actualDate));
        }
        [TestMethod]
        public void testPermitWithNearerDate()
        {
            DateTime actualDate = DateTime.Now.AddDays(6);
            Assert.IsTrue(checkPermitExpiry(actualDate));

        }

        public bool checkMileage(int mileage,int lastServiceMileage)
        {
            if (mileage - lastServiceMileage >= mileageLimit)
            {
                return true;
            }
            return false;
        }

        public bool checkPermitExpiry(DateTime date)
        {
            if ((date.Date - DateTime.Now.Date).TotalDays <= permitDayBefore)
            {
                return true;
            }
            return false;
        }

    }
}
