using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank.ClassFolder
{
    internal class BankAccount
    {
        private int _id;
        private string _accountNSP;
        private float _currentAmountOfMoney;
        private DateTime _dateOfOpeningAccount;
        private DateTime _dateOfClosingAccount;

        public int Id { get { return _id; } set { _id = value; } }
        public string AccountNSP { get { return _accountNSP; } set { _accountNSP = value; } }
        public float CurrentAmountOfMoney { get {   return _currentAmountOfMoney; } set { _currentAmountOfMoney = value; } }
        public DateTime DateOfOpeningAccount { get { return _dateOfOpeningAccount; } set { _dateOfOpeningAccount = value; } }
        public DateTime DateOfClosingAccount { get {return _dateOfClosingAccount; } set { _dateOfClosingAccount = value; } }
        public BankAccount()
        {
            this._id = 111;
            this._accountNSP = "default";
            this._currentAmountOfMoney= 0;
            this._dateOfOpeningAccount = DateTime.Now;
            this._dateOfClosingAccount = DateTime.Now;
        }

        public BankAccount(int id, string accountNSP, double currentAmountOfMoney, DateTime dateOfOpeningAccount, DateTime dateOfClosingAccount)
        {
            this._id = id;
            this._accountNSP = accountNSP;
            this._currentAmountOfMoney = (float)Convert.ToDouble(String.Format("{0:0.00}", currentAmountOfMoney));
            this._dateOfOpeningAccount = dateOfOpeningAccount;
            this._dateOfClosingAccount = dateOfClosingAccount;
        }
    }
}
