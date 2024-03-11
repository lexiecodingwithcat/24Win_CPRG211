using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
    {
    [TestClass]
    public class UnitTest1
        {
        [TestMethod]
        public void Add_Method()
            {
            BasicMath bs = new BasicMath();
            double expected = 100;
            double actual = bs.Add(30, 70);
            Assert.AreEqual(expected, actual);
            }
        [TestMethod]
        public void Sub_Method()
            {
            BasicMath bs = new BasicMath();
            double expected = 100;
            double actual = bs.Subtract(120.2, 20.2);
            Assert.AreEqual(expected, actual);
            }
        [TestMethod]
        public void Multiply_Method()
            {
            BasicMath bs = new BasicMath();
            double expected = 40;
            double actual = bs.Multiply(5,8);
            Assert.AreEqual(expected, actual);
            }
        [TestMethod]
        public void Divide_Method()
            {
            BasicMath bs = new BasicMath();
            double expected = 7;
            double actual = bs.Divide(49,7); 
            Assert.AreEqual(expected, actual);
            }

        }
    }
