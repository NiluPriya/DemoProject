using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 cs = new Class1();
            Assert.AreEqual(cs.Name, "Hi There! This is Demo");

        }
    }
}
