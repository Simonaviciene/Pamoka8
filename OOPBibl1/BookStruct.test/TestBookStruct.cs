using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookStruct;



namespace BookStruct.test
{
    [TestClass]
    public class TestBookStruct
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Assign
            Book knyga;
            knyga.Name = "vardas";
            knyga.ID = "1";

            // Act
            string locId = knyga.LocalID;

            // Assert
            Assert.AreEqual("vardas_1", locId);
        }

         [TestMethod]
        public void TestMethod2()
        {
            // Assign
            Book knyga;
            knyga.Name = "";
            knyga.ID = "1";

            // Act
            string locId = knyga.LocalID;

            // Assert
            Assert.AreEqual("1", locId);
        }


        [TestMethod]
        public void TestMethod3()
        {
            // Assign
            Book knyga;
            knyga.Name = "ASDFG";
            knyga.ID = "";

            // Act
            string locId = knyga.LocalID;

            // Assert
            Assert.AreEqual("ASDFG", locId);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Assign
            Book knyga;
            knyga.Name = "";
            knyga.ID = "";

            // Act
            string locId = knyga.LocalID;

            // Assert
            Assert.AreEqual("", locId);
        }

    }
}
