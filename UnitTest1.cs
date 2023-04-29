using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "racecar";
            string reversed = new string(input.Reverse().ToArray());
            Assert.AreEqual(input, reversed);
        }
    }
}
