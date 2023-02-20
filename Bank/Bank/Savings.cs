using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Savings : Account
    {
        public double minBalance = 1000;
        private double dailyWithdrawLimit = 20000;
        
      
        public Savings() : base()
        {
        }
        public Savings(string name, DateOfBirth DOB, string nominee, double balance) : base(name, DOB, nominee, balance)
        {

        }
        /*private bool isDailyWithdrawLimitOver(double amount)
        {
        }*/
        public override bool deposit(double amount)
        {
            this.amount = amount;
            this.balance = balance + amount;
            Console.WriteLine("Your funds was deposited successfully. New account Balance is: " + balance);
            return true;
        }
        public override bool withdraw(double amount)
        {
            this.amount = amount;
            if (amount < this.minBalance)
            {
                Console.WriteLine("You don't have sufficient amount of money in your account!");
                return false;
            }
            else if (amount > dailyWithdrawLimit)
            {
                Console.WriteLine("You cannot withdraw more than a daily amount of 20000.");
                return false;
            }
            else
            {

                this.balance = balance - amount;
                Console.WriteLine("Your withdrawal was successful. New account Balance is: " + balance);
                return true;
            }
        }
    }
}
