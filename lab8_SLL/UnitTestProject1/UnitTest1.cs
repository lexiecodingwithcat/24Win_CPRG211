using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ConsoleApp1;
using System.Collections;

namespace UnitTestProject1
    {
    [TestClass]
    public class UnitTest1
        {
        MyLinkedList<string> my_list = new MyLinkedList<string>();

        [TestMethod]
        public void TestAddFirst()
            {
            my_list.AddFirst("Joe Blow");
            my_list.AddFirst("Joe Schmoe");
            my_list.AddFirst("John Smith");
            string result = my_list.GetValue(0);
            Assert.AreEqual("John Smith", result);
            }
        [TestMethod]
        public void TestAddLast()
            {
            my_list.AddLast("Jane Doe");
            my_list.AddLast("Bob Bobberson");
            int length = my_list.GetLength();
            string result = my_list.GetValue(length - 1);
            Assert.AreEqual("Bob Bobberson", result);
            }

        [TestMethod]
        public void TestRemoveFrist()
            {
            my_list.AddFirst("Joe Blow");
            my_list.AddFirst("Jane Doe");
            my_list.AddLast("Sam Sammerson");
            my_list.AddFirst("John Smith");
            my_list.RemoveFirst();
            string result = my_list.GetValue(0);
            Assert.AreEqual("Jane Doe", result);
            }

        [TestMethod]
        public void TestRemoveLast()
            {
            my_list.AddLast("Jane Doe");
            my_list.AddLast("Bob Bobberson");
            my_list.AddLast("Sam Sammerson");
            my_list.AddLast("Dave Daverson");
            my_list.RemoveLast();
            int length = my_list.GetLength();
            string result = my_list.GetValue(length - 1);
            Assert.AreEqual("Sam Sammerson", result);
            }

        [TestMethod]
        public void TestRetriveValue()
            {
            my_list.AddFirst("Joe Blow");
            my_list.AddFirst("Joe Schmoe");
            my_list.AddFirst("John Smith");
            my_list.AddLast("Bob Bobberson");
            my_list.AddLast("Sam Sammerson");
            my_list.AddLast("Dave Daverson");
            string result = my_list.GetValue(3);
            Assert.AreEqual("Bob Bobberson", result);
            }

        [TestMethod]
        public void TestLength()
            {
            my_list.AddLast("Jane Doe");
            my_list.AddLast("Bob Bobberson");
            my_list.AddLast("Sam Sammerson");
            my_list.AddLast("Dave Daverson");
            my_list.AddFirst("Joe Blow");
            my_list.AddFirst("Joe Schmoe");
            my_list.AddFirst("John Smith");
            int result = my_list.GetLength();
            Assert.AreEqual(7, result);
            }



        }
    }
