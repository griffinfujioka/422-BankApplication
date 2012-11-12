using BankApplication_Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankApplicationUnitTests
{
    
    
    /// <summary>
    ///This is a test class for AccountTest and is intended
    ///to contain all AccountTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AccountTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            Account target = new Account(); // TODO: Initialize to an appropriate value
            Account other = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Equals(other);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MoveNext
        ///</summary>
        [TestMethod()]
        public void MoveNextTest()
        {
            Account target = new Account(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MoveNext();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PrintBalance
        ///</summary>
        [TestMethod()]
        public void PrintBalanceTest()
        {
            Account target = new Account(); // TODO: Initialize to an appropriate value
            target.PrintBalance();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Reset
        ///</summary>
        [TestMethod()]
        public void ResetTest()
        {
            Account target = new Account(); // TODO: Initialize to an appropriate value
            target.Reset();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Debit
        ///</summary>
        [TestMethod()]
        public void DebitTest()
        {
            Account target = new Account(); // TODO: Initialize to an appropriate value
            double amount = 0F; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Debit(amount);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Credit
        ///</summary>
        [TestMethod()]
        public void CreditTest()
        {
            Account target = new Account(); // TODO: Initialize to an appropriate value
            double amount = 0F; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Credit(amount);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
