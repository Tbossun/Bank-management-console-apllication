using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program 
    {
        static void Main(string[] args)
        {
          
          
            String input;
            DateOfBirth dob = new DateOfBirth();
            IDGENERATOR id = new IDGENERATOR();
            Savings sv = new Savings();
            Debit db = new Debit();
            Current cr = new Current();
            Bank bn = new Bank();
            Console.WriteLine("****  Welcome to ABC Bank App   ***");
            while (true)
            {
                Console.WriteLine("What do you want to do:");
                Console.WriteLine("Select an option to proceed:");
                Console.WriteLine("0 => Create account");
                Console.WriteLine("1 => Show account information");
                Console.WriteLine("2 => Deposit from account");
                Console.WriteLine("3 => Withdraw from account");
                Console.WriteLine("4 => Show all account with id");
                Console.WriteLine("5 => Clear screen");
                Console.WriteLine("6 => Exit");
                object ob1 = Console.ReadLine();
                input = Convert.ToString(ob1);

                //Methods
                if (input == "0")
                {
                    Console.WriteLine("Enter new account Type :");
                    bn.create_account();
                    
                }
                else if (input == "1")
                {
                    Console.Write("Enter account Number :");
                    bn.showInfo();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Enter Your Account Id: ");
                    bn.deposit();
                }
                else if (input == "3")
                {
                    Console.WriteLine("Enter your Account Id: ");
                    bn.withdraw();
                }
                else if (input == "4")
                {
                    bn.showAll();
                }
                else if (input == "5")
                {
                    Console.Clear();
                }
                else if (input == "6")
                {
                    Environment.Exit(0);
                }
                Console.ReadKey();


            }

           // Console.ReadKey();

        }



    }
}