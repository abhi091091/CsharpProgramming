using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp_Tutorials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials.Tests
{
    [TestClass()]
    public class BasicProgramsTests
    {
        [TestMethod()]
        public void DivideTest()
        {
            // AAA'S  Arrange , Act and Assert

            int expected = 5;
            int numera = 20;
            int denomina = 5;

             int actual= BasicPrograms.Divide(numera, denomina);


            Assert.AreEqual(expected, actual);        }
    }
}