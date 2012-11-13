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

        #region TestContext
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
        #endregion 

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

        #region PrintBalanceTest
        /// <summary>
        ///A test for PrintBalance
        ///</summary>
        [TestMethod()]
        public void PrintBalanceTest()
        {
            Account target = new Account(100.00, 12, "Test account", "11/12/12"); // TODO: Initialize to an appropriate value
            bool actual = target.PrintBalance();
            Assert.IsTrue(actual, "Print balance succeeded."); 
        }
        #endregion 

        #region ResetTest
        /// <summary>
        ///A test for Reset
        ///</summary>
        public void ResetTest()
        {
            Account target = new Account(); // TODO: Initialize to an appropriate value
            target.Reset();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
        #endregion

        #region DebitTest
        /// <summary>
        ///A test for Debit
        ///</summary>
        [TestMethod()]
        public void DebitTest()
        {
            Account target = new Account(100.00, 1, "test account", "11/12/12"); // TODO: Initialize to an appropriate value
            double amount = 25.00; // TODO: Initialize to an appropriate value
            double expected = 75.00; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Debit(amount);
            Assert.IsTrue((actual == expected), "Debit Test passes.");
            Assert.IsFalse(actual != expected, "Debit Test fails."); 
        }
        #endregion 

        #region DebitTest_Insufficient
        /// <summary>
        ///A test for Debit where the insufficient funds are available
        ///</summary>
        [TestMethod()]
        public void DebitTest_Insufficient()
        {
            Account target = new Account(15.00, 1, "test account", "11/12/12"); // TODO: Initialize to an appropriate value
            double amount = 25.00; // TODO: Initialize to an appropriate value
            double expected = 15.00; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Debit(amount);
            Assert.IsTrue((actual == expected), "Debit Test with insufficient funds passes.");
            Assert.IsFalse(actual != expected, "Debit Test with insufficient funds fails.");
        }
        #endregion 

        #region CreditTest
        /// <summary>
        ///A test for Credit
        ///</summary>
        [TestMethod()]
        public void CreditTest()
        {
            Account target = new Account(15.00, 1, "test account", "11/12/12"); // TODO: Initialize to an appropriate value
            double amount = 10.00; // TODO: Initialize to an appropriate value
            double expected = 25.00; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Credit(amount);
            Assert.IsTrue((actual == expected), "Credit Test passes.");
            Assert.IsFalse(actual != expected, "Credit Test fails.");
        }
        #endregion 


    }
}
