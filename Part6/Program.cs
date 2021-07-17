using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part6
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount savingAccount = new SavingAccount(12345, 20000);

            try
            {
                savingAccount.Withdraw(3000);
                Console.WriteLine("withdrawn 3000");
                savingAccount.Withdraw(10000);
                Console.WriteLine("withdrawn 10000");
                savingAccount.Withdraw(8000);
            }
            catch(OverDrawnException ex)
            {
                //Console.WriteLine("your account balance is low");
                Console.WriteLine(ex.Message);
            }
            
        }
    }

    class SavingAccount
    {
        private int AccountNumber;
        private double balance;

        public SavingAccount(int accNum, double bal)
        {
            this.AccountNumber = accNum;
            this.balance = bal;

        }

        public void Withdraw(double amount)
        {
            balance -= amount;
            if(balance <0)
            {
                throw new OverDrawnException($"Account Balance should not be less than minimum balance {balance}",0);
            }
        }
    }

    class OverDrawnException : ApplicationException
    {
        public double bal;
        public OverDrawnException() { }

        public OverDrawnException(string error, double balance) : base(error)
        {
            //public double bal = balance;
            bal = balance;
        }
    }
}
