using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApplication_Csharp
{
    class BankManager
    {
        System.ConsoleKeyInfo KInfo;

        #region Attributes 
        private List<Account> managerAccounts;  // List of all accounts this manager has 
        private Account accountPtr; 
        private bool managerAccountsAvailable;  // True if manager has any accounts (i.e., mNumberAccounts > 0)
        int mNumberAccounts;        // Number of accounts this manager 
        #endregion 

        #region Default constructor
        // Default constructor
        public BankManager()
        {
            managerAccounts = new List<Account>();  /* Initialize accounts list */
            accountPtr = null ; /* Account pointer initially null, should always point to first element in ManagerAccounts */ 
            ManagerAccountsAvailable = false;   /* Initially no accounts */
            NumberAccounts = 0; 


        }
        #endregion 

        #region Constructor 
        // Constructor 
        public BankManager(int maxNumberAccounts)
        {

            // TODO: 
            List<Account> accountList = new List<Account>();
            accountPtr = accountList[0];
            


        }
        #endregion

        #region Getters and Setters
        public List<Account> ManagerAccounts
        {
            get { return managerAccounts; }
            set { managerAccounts = value; } 
        }

        public bool ManagerAccountsAvailable
        {
            get { return managerAccountsAvailable; }
            set { managerAccountsAvailable = value; } 

        }
        public int NumberAccounts
        {
            get { return mNumberAccounts; }
            set { mNumberAccounts = value; } 
        }
        #endregion 

        #region display menu 
        public void displayMenu()
        {
            Console.WriteLine( "1. Create account"); 
            Console.WriteLine( "2. Delete account"); 
            Console.WriteLine( "3. Update account"); 
            Console.WriteLine( "4. Display account"); 
            Console.WriteLine( "5. Exit"); 
        }
        #endregion 

        #region get menu option
        public int getMenuOption()
        {
            int option = 0;

            option = Convert.ToInt32(Console.ReadLine()); 

            return option;
        }
        #endregion 

        #region create account
        public bool createAccount()
        {

            int accountNumber = 0;
            double balance = 0.0; 
            string name = ""; 
            string dateCreated = ""; 
            bool success = true; 

            Console.WriteLine("Enter account number: "); 
            accountNumber = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Enter name: "); 
            name = Console.ReadLine(); 
            Console.WriteLine("Name: " + name);

            Console.WriteLine("Enter balance: "); 
            balance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter date: ");
            dateCreated = Console.ReadLine();

            var account = new Account(balance, accountNumber, name, dateCreated);
            ManagerAccounts.Insert(ManagerAccounts.Count, account);
            NumberAccounts++;

            ManagerAccounts[0].AccountNumber = accountNumber;
            ManagerAccounts[0].Name = name;
            ManagerAccounts[0].Balance = balance;
            ManagerAccounts[0].DateCreated = dateCreated; 


            return success; 
        }
        #endregion 

        #region Delete account
        public bool deleteAccount()
        {
            bool success = false;
            //int accountNumber = 0;
            int counter = 0;

            counter = findAccount();

            if (counter < NumberAccounts) // We found the account, so delete it 
            {
                success = true;
                Console.WriteLine("Found account.");
                ManagerAccounts[counter].PrintBalance();
                ManagerAccounts[counter] = null;
                NumberAccounts--;

                Console.WriteLine("Account deleted!");
            }
            else
            {
                Console.WriteLine("Error: Could not find account."); 
            }

            return success; 
        }
        #endregion 

        #region update account
        public bool updateAccount()
        {
            bool success = true;
            string name = "";
            string dateCreated = "";
            double balance = 0.0;
            double deposit = 0.0;
            int accountNumber = 0;
            int counter = 0;
            int option = 0;

            counter = findAccount();

            if (counter < NumberAccounts)
            {
                success = true;

                Console.WriteLine("1. Update name");
                Console.WriteLine("2. Withdraw money");
                Console.WriteLine("3. Deposit money");

                option = Convert.ToInt32(Console.ReadLine());

                // for testing
                //option = 1; 

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Current name: " + ManagerAccounts[counter].Name); 
                        Console.WriteLine("New name: ");
                        name = Console.ReadLine();
                        ManagerAccounts[counter].Name = name;
                        break; 
                    case 2:
                        Console.WriteLine("Enter amount to withdraw: ");
                        balance = Convert.ToDouble(Console.ReadLine());
                        ManagerAccounts[counter].Debit(balance); 
                        break; 
                    case 3:
                        Console.WriteLine("Enter amount to deposit: ");
                        deposit = Convert.ToDouble(Console.ReadLine());
                        ManagerAccounts[counter].Credit(deposit); 
                        break; 
                    default:
                        Console.WriteLine("ERROR: Invalid option!");
                        success = false; 
                        break; 
                }
            }

            return success; 
        }
        #endregion 

        #region display account
        public bool displayAccount()
        {
            int counter = 0;
            counter = findAccount();

            if ((counter < NumberAccounts) && (ManagerAccounts[counter] != null))
            {
                ManagerAccounts[counter].PrintBalance();
                return true; 
            }
            else
            {
                Console.WriteLine("Error! Account does not exist");
                return false; 
            }
        }
        #endregion 

        #region find account
        public int findAccount()
        {
            int accountNumber = 0;

            Console.WriteLine("Enter account number: ");
            accountNumber = Convert.ToInt32(Console.ReadLine());

            int counter = 0;
            for (counter = 0; ((counter < NumberAccounts) && (ManagerAccounts[counter].AccountNumber != accountNumber)); counter++)
            {
                // the header of the for-loop takes care of all logic 
            }
            return counter; 
        }
        #endregion 

        #region runBankApplication
        public void runBankApplication()
        {
            int option = 0;
            bool status = true, success = true; ;

            Console.WriteLine("*** Welcome to the Lee-Fujioka user friendly banking system ***\n"); 

            do
            {
                displayMenu();
                option = getMenuOption();

                switch (option)
                {
                    case 1: success = createAccount();
                        if (success == false)
                        {
                            Console.WriteLine("WARNING: Could not create account!");
                        }
                        break;
                    case 2: success = deleteAccount();
                        if (success == false)
                        {
                            Console.WriteLine("WARNING: Could not delete account!");
                        }

                        break;
                    case 3: success = updateAccount();
                        if (success == false)
                        {
                            Console.WriteLine("WARNING: Could not update account!");
                        }

                        break;
                    case 4: displayAccount();
                        break;
                    case 5: status = false;
                        break;
                    default: Console.WriteLine("ERROR: Invalid choice!");
                        break;
                }
            } while (status != false);
        }
        #endregion 


    }
}
