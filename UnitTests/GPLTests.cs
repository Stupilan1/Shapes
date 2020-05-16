using System;
using GraphicalProgramingLanguage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class GPLTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            UserVariables userVariables = new UserVariables();

            // Act
            userVariables.CreateVar("bed", 20);
            // Assert
            Assert.AreEqual(userVariables.GetVar("bed"),30 );
        }
    }
}
