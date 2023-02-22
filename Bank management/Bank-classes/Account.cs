using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
   abstract class Account
    {
        public readonly string name;
        public readonly string ID;
        public readonly DateOfBirth DOB;
        public readonly string referee;
        public double balance;
        protected string type;
        public double amount;
        public abstract bool deposit(double amount);

        public abstract bool withdraw(double amount);
        
        public double getBalance()
        {
            return balance;
        }
        public string getAccType()
        {
            string actype; 
            actype = Convert.ToString(Console.ReadLine());
            return actype;
        }
        public void printAccount()
        {
            Console.WriteLine("|------------------|------------------|--------------------|--------------------|----------------|");
            Console.WriteLine("|   Acct Name      |    Acct No       |     Acct id        |     Acct type      |  acct balance  |");
            Console.WriteLine("|------------------|------------------|--------------------|--------------------|----------------|");                     
            Console.Write("   " + name + "\t");
            Console.Write(" \t" + ID + "\t");
            Console.Write("  " + DOB + "\t");
            Console.Write( type + "\t");
            Console.Write("  " + balance + "\t");
            Console.Write(" \t\t" + balance + "\t");

            /*Console.Write("  " + myName[indexNum] + "\t");
            Console.Write("\t" + acctNumber + "\t");
            Console.Write("  " + myId[indexNum] + "\t");
            Console.Write(myAccType[indexNum]);
            Console.Write("  \t\t" + myBalance[indexNum]);*/

            /*Console.WriteLine("Name : " + name + "\t");
            Console.Write("Date of Birth :" + DOB + "\t");
            Console.WriteLine("Referee : " + referee + "\t");
            Console.WriteLine("Balance :" + balance + "\t");*/

        }
        public Account()
        {

        }
        public Account(string name, DateOfBirth DOB, string nominee, double balance)
        {
            this.name = name;
            this.DOB = DOB;
            this.referee = referee;
            this.balance = balance;
        }
    }
}
