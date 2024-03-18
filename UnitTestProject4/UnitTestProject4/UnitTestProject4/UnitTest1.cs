using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestProject4;

namespace UnitTestProject4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Method()
        {
            //add test logic here
            Program bm = new Program();
            Double res = bm.Add(20.50, 20.50);
            Assert.AreEqual(41, res);

        }
        [TestMethod]
        public void Sub_Method()
        {
            Program bm = new Program();
            Double res = bm.Sub(20, 2);
            Assert.AreEqual(18, res);
        }
        [TestMethod]
        public void Multiply_Method() 
        {
            Program bm = new Program();
            Double res = bm.Mul(20, 2);
            Assert.AreEqual(40, res);
        }
        [TestMethod]
        public void Divide_Method() 
        {
            Program bm = new Program();
            Double res = bm.Div(20, 2);
            Assert.AreEqual(10, res);
        }
    }
}
