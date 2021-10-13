using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new myBankCode("Boshra", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with number {account.Balance}");



        }
    }
}
