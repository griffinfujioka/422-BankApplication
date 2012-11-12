using BankApplication_Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankApplicationUnitTests
{
    
    
    /// <summary>
    ///This is a test class for BankManagerTest and is intended
    ///to contain all BankManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BankManagerTest
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
        ///A test for createAccount
        ///</summary>
        [TestMethod()]
        public void createAccountTest()
        {
            BankManager target = new BankManager(); // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.createAccount();
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(expected, "Create account returned new account");
            Assert.IsFalse(!expected, "Create account returned new account"); 
        }

        /// <summary>
        ///A test for deleteAccount
        ///</summary>
        [TestMethod()]
        public void deleteAccountTest()
        {
            BankManager target = new BankManager(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.deleteAccount();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for displayAccount
        ///</summary>
        [TestMethod()]
        public void displayAccountTest()
        {
            BankManager target = new BankManager(); // TODO: Initialize to an appropriate value
            target.displayAccount();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for displayMenu
        ///</summary>
        [TestMethod()]
        public void displayMenuTest()
        {
            BankManager target = new BankManager(); // TODO: Initialize to an appropriate value
            target.displayMenu();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for findAccount
        ///</summary>
        [TestMethod()]
        public void findAccountTest()
        {
            BankManager target = new BankManager(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.findAccount();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getMenuOption
        ///</summary>
        [TestMethod()]
        public void getMenuOptionTest()
        {
            BankManager target = new BankManager(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.getMenuOption();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for runBankApplication
        ///</summary>
        [TestMethod()]
        public void runBankApplicationTest()
        {
            BankManager target = new BankManager(); // TODO: Initialize to an appropriate value
            target.runBankApplication();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for updateAccount
        ///</summary>
        [TestMethod()]
        public void updateAccountTest()
        {
            BankManager target = new BankManager(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.updateAccount();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
