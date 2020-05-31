using System;
using System.Collections;
using GraphicalProgramingLanguage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class GPLTests
    {
        [TestMethod]
        public void USER_VARIABLE_BED()
        {
            // Arrange
            UserVariables userVariables = new UserVariables();

            // Act
            userVariables.CreateVar("bed", 20);
            // Assert
            Assert.AreEqual(userVariables.GetVar("bed"),20 );
        }

        [TestMethod]
        public void USER_VARIABLE_SIZE()
        {
            // Arrange
            UserVariables userVariables = new UserVariables();

            // Act
            userVariables.CreateVar("Size", 120);
            // Assert
            Assert.AreEqual(userVariables.GetVar("Size"), 120);
        }

        [TestMethod]
        public void TEST_COMMAND_RECTANLE()
        {

            Comand cmmds = new Comand();

            ArrayList shapes = new ArrayList();

            Rectangle rec = new Rectangle(0,0,100,100);

            shapes = cmmds.GetComands("Rectangle 100 100");

            Assert.AreEqual(shapes[0].GetType(), rec.GetType());

        }

        [TestMethod]
        public void TEST_COMMAND_CIRCLE()
        {

            Comand cmmds = new Comand();

            ArrayList shapes = new ArrayList();

            Circle circle = new Circle(0, 0,  100);

            shapes = cmmds.GetComands("Circle 100");

            Assert.AreEqual(shapes[0].GetType(), circle.GetType());

        }

        [TestMethod]
        public void TEST_COMMAND_TRIANGLE()
        {

            Comand cmmds = new Comand();

            ArrayList shapes = new ArrayList();

            Triangle triangle = new Triangle(0, 0, 100, 100);

            shapes = cmmds.GetComands("Triangle 100 100");

            Assert.AreEqual(shapes[0].GetType(), triangle.GetType());

        }

    }
}
