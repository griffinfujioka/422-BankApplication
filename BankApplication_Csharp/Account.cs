using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApplication_Csharp
{
    class Account
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

        #region Credit
        private double _credit;
        public double Credit
        {
            get { return _credit; }
            set { _credit = value; } 
        }
        #endregion 

        #region Debit
        private double _debit;
        public double Debit
        {
            get { return _debit; }
            set { _debit = value; } 
        }
        #endregion 

        #region Constructor
        public Account()
        {
            Name = "";
            Balance = 0.0;
            AccountNumber = -1;
            DateCreated = "";
            Credit = 0.0;
            Debit = 0.0; 
        }
        #endregion 

        #region Direct copy
        public Account(double initialBalance,
            int newAccountNumber,
            string newName,
            string newDateCreated,
            double credit,
            double debit)
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
            Credit = credit;
            Debit = debit; 
        }
        #endregion 

        #region Copy constructor 
        public Account(Account account) /* Shallow copy */
        {
            this.Balance = account.Balance;
            this.AccountNumber = account.AccountNumber;
            this.Name = account.Name;
            this.DateCreated = account.DateCreated;
            this.Credit = account.Credit;
            this.Debit = account.Debit; 
        }
        #endregion 

        #region Destructor
        ~Account()
        {
        }/* Desctructor */
        #endregion 



    }
}
