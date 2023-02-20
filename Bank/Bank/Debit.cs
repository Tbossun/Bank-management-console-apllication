using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Debit : Account
    {
        public double maxBalance = 1000000;
        private double dailyTransLimit = 20000;

        public Debit() : base()
        {

        }

        public Debit(string name, DateOfBirth DOB, string nominee, double balance) : base(name, DOB, nominee, balance)
        {

        }



        /* private bool isDailyTransLimitOver(double amount)
         {

         }*/
       // Bank bn = new Bank();

        public override bool deposit(double amount)
        {
            this.amount = amount;
           if (amount > maxBalance)
            {
                Console.WriteLine("You can not deposit more than 100000!");
                return false;
            }
            else
            {
               // int num = bn.passArrNum;
               // bn.myBalance[num] = bn.myBalance[num] + ammount;
                this.balance = balance + amount;
                Console.WriteLine("Your fund was deposited successfully, New Balance is: "+balance);
                return true;
            }
        }

        public override bool withdraw(double amount)
        {
            this.amount = amount;
            
            if (amount > dailyTransLimit)
            {
                Console.WriteLine("You can not withdraw more than 20000.");
                return false;

            }
            else if(amount>maxBalance)
            {
                Console.WriteLine("You can not withdraw that ammount of money!");
                return false;
            }
            else
            {
                this.balance = balance - amount;
                Console.WriteLine("You account balance has been withdrawed.Balance is: " + balance);
                return true;
            }
        }
    }
}
