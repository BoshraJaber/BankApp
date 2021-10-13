using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    public class Tansaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get;}
        // constrctor
        public Tansaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;

        }

    }
   
}
