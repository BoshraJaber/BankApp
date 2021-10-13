using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    public class myBankCode
    {
        // Properties
        public string Number { get; } // I can only get numbers once it is assigned 
        public string Owner { get; set; }
        public decimal Balance { get {
                decimal balance = 0;
                foreach (var item in allTansactions)
                {
                    balance += item.Amount;
                }
                return balance; 
            } }
        //private means that people outside the myBankCode can't see it
        //Static: means it is shared with every back accound instances 
        private static int accountNumberSeed = 1234567890;

        // to link the transaction we are going to create our own type
        private List<Tansaction> allTansactions= new List<Tansaction>();


        //constructor  it has to have the class name?
        public myBankCode(string ownerName, decimal initialBalance)
            //because number don't have a setter so we should add its value here
        {
            this.Owner = ownerName;
          //  this.Balance = initialBalance; // I don't have to use this
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        //Methods
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "error message");
           
            }
            var deposit = new Tansaction(amount, date, note);
            allTansactions.Add(deposit);
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "error message");


            }

            if (Balance - amount <= 0)
            {
                throw new InvalidOperationException("error message");


            }
            var withdrawal = new Tansaction(amount, date, note);
            allTansactions.Add(withdrawal);
        }
    }
}
