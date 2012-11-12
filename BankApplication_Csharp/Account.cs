using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel; 

namespace BankApplication_Csharp    /* Common namespace between all classes */ 
{
    class Account : IEquatable<Account>
    {
        #region Balance 
        private double _balance;
        public double Balance
        {
            get { return _balance; }
            
            set { _balance = value; } 
        }
        #endregion 

        #region Account number
        private int _accountNumber;
        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; } 
        }
        #endregion 

        #region Name
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; } 
        }
        #endregion 

        #region Date created
        private string _dateCreated;
        public string DateCreated
        {
            get { return _dateCreated; }
            set { _dateCreated = value; } 
        }
        #endregion 

        #region Constructor
        public Account()
        {
            Name = "";
            Balance = 0.0;
            AccountNumber = -1;
            DateCreated = "";
        }
        #endregion 

        #region Direct copy
        public Account(double initialBalance,
            int newAccountNumber,
            string newName,
            string newDateCreated)
        {
            if (initialBalance < 0.0)
            {
                Balance = 0.0;
            }
            else
            {
                Balance = initialBalance; 
            }

            AccountNumber = newAccountNumber;
            Name = newName;
            DateCreated = newDateCreated;
        }
        #endregion 

        #region Copy constructor 
        public Account(Account account) /* Shallow copy */
        {
            this.Balance = account.Balance;
            this.AccountNumber = account.AccountNumber;
            this.Name = account.Name;
            this.DateCreated = account.DateCreated;
        }
        #endregion 

        #region Destructor
        ~Account()
        {
        }/* Desctructor */
        #endregion 

        #region override Equals
        public bool Equals(Account other)
        {
            if (other == null)
                return false;

            return (this.Name == other.Name &&
                this.Balance == other.Balance &&
                this.AccountNumber == other.AccountNumber &&
                this.DateCreated == other.DateCreated); 
        }
        #endregion 

        #region IEnumerator Members
        public void Reset()
        {
        }

        public Account Current
        {
            get { return this; }
        }

        public bool MoveNext()
        {
            return false; 
        }

        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this); 
        }
        #endregion 

        #region Print Balance
        public void PrintBalance()
        {
            Console.WriteLine("Account #: " + AccountNumber);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Current balance: " + Balance);
            Console.WriteLine("Date created: " + DateCreated);
        }
        #endregion 

        #region Debit
        public double Debit(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Warning! Insufficient funds. \nCurrent Balance: " + Balance);
            }
            else
            {
                Balance -= amount; 
            }

            return Balance; 
        }
        #endregion 

        #region Credit
        public double Credit(double amount)
        {
            Balance += amount;
            return Balance;
        }
        #endregion 


    }


}
