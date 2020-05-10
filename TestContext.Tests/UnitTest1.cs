using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestContextDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            TestContext.WriteLine("\n--TestInitialize--\n");
            TestContext.WriteLine("Test Name: {0}", TestContext.TestName);
            TestContext.WriteLine("Test State: {0}", TestContext.CurrentTestOutcome + "\n\n");
            TestContext.Properties["info"] = "This is an extra information";
        }

        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine("--TestCleanup--\n");
            TestContext.WriteLine("Test Name: {0}", TestContext.TestName);
            TestContext.WriteLine("Test State: {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test Info: {0}", TestContext.Properties["info"]);
        }

        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("--TestMethod1--\n");
            TestContext.WriteLine("Test Name: {0}", TestContext.TestName);
            TestContext.WriteLine("Test State: {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test Class: {0}", TestContext.FullyQualifiedTestClassName);
            TestContext.WriteLine("Test Info: {0}", TestContext.Properties["info"] + "\n\n");

            Assert.AreEqual(1, 1);
        }
    }
}