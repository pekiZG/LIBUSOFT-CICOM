using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibusoftCicomMVC4.DataAnnotationValidators;

namespace LibusoftCicomMVC4.Tests
{
    [TestClass]
    public class CheckOIBUnitTest
    {
        [TestMethod]
        public void CheckIfOIBIsValidTestMethod()
        {
            // Arrange
            CheckOIB check = new CheckOIB();
            // Act
            bool result = check.IsValid("31794169247");
            // Assert
            Assert.IsTrue(result);
        }
    }
}
