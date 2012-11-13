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

        #region createAccountTest
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
            Assert.IsFalse(!expected, "ERROR: Create account failed to return a new account"); 
        }
        #endregion 

        #region deleteAccountTest
        /// <summary>
        ///A test for deleteAccount
        ///</summary>
        [TestMethod()]
        public void deleteAccountTest()
        {
            BankManager target = new BankManager(); // TODO: Initialize to an appropriate value
            // Create an account 
            bool createAccount = target.createAccount();
            if (!createAccount)
                Assert.IsFalse(!createAccount, "ERROR! Could not create account.");
            Console.WriteLine("Successfully created account."); 
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.deleteAccount();
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(expected, "Delete account successfully deleted account");
            Assert.IsFalse(!expected, "ERROR: Delete account failed to delete account"); 
        }
        #endregion 

        #region displayAccountTest
        /// <summary>
        ///A test for displayAccount
        ///</summary>
        [TestMethod()]
        public void displayAccountTest()
        {
            BankManager target = new BankManager(); // TODO: Initialize to an appropriate value
            bool createAccount = target.createAccount();
            if (!createAccount)
                Assert.IsFalse(!createAccount, "ERROR! Could not create account.");
            Console.WriteLine("Successfully created account.");
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.displayAccount(); 
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(expected, "Display account successfully displayed account");
            Assert.IsFalse(!expected, "ERROR: Display account failed to display account");
        }
        #endregion 

        #region displayMenuTest
        /// <summary>
        ///A test for displayMenu
        ///</summary>
        [TestMethod()]
        public void displayMenuTest()
        {
            BankManager target = new BankManager(); // TODO: Initialize to an appropriate value
            target.displayMenu();
            Assert.IsTrue(true, "The display menu test assumes ability to print to console."); 
        }
        #endregion 

        #region findAccountTest
        /// <summary>
        ///A test for findAccount
        ///</summary>
        [TestMethod()]
        public void findAccountTest()
        {
            BankManager target = new BankManager(); // TODO: Initialize to an appropriate value
            
            // Create an account with accountNumber = 0
            bool createAccount = target.createAccount();
            if (!createAccount)
                Assert.IsFalse(!createAccount, "ERROR! Could not create account.");
            Console.WriteLine("Successfully created account."); 
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.findAccount();
            Assert.AreEqual(expected, actual);
            Assert.IsTrue((expected == actual), "Find account successfully found account.");
            Assert.IsFalse((expected != actual), "Find account unable to find account."); 
        }
        #endregion 

        #region getMenuOptionTest
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
            Assert.IsTrue(expected == 0, "Get menu option returned expected value");
            Assert.IsFalse(expected != 0, "Get menu option did not return expected value"); 
        }
        #endregion 


        #region updateAccountTest
        /// <summary>
        ///A test for updateAccount
        ///</summary>
        [TestMethod()]
        public void updateAccountTest()
        {
            BankManager target = new BankManager(); // TODO: Initialize to an appropriate value
            bool createAccount = target.createAccount();
            if (!createAccount)
                Assert.IsFalse(!createAccount, "ERROR! Could not create account.");
            Console.WriteLine("Successfully created account.");
            target.NumberAccounts++; 
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.updateAccount();
            try
            {
                Assert.AreEqual(expected, actual);
                Assert.IsTrue(expected, "Account update successful.");
                Assert.IsFalse(!expected, "Account update teriminated with error."); 
            }
            catch (Exception e)
            {

            }
        }
        #endregion
    }
}
