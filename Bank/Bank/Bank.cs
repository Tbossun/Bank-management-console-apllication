﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank 
{
    class Bank 
    {
      
        string id;//hold generated id  from idgenerator and add string
        string acctNumber;
        public int idnum = 0;//index number for id


        //hold separated id in separated index
        public string[] myId = new string[100];
        public string[] myName = new string[100];
        public string[] myAccType = new string[100];
        public string[] myDob = new string[100];
        public string[] myNominee = new string[100];
        public double[] myBalance = new double[100];


        
        IDGENERATOR id1 = new IDGENERATOR();
        DateOfBirth dob = new DateOfBirth();
        Savings sv = new Savings();
        Debit db = new Debit();
        Current cr = new Current();
       
        
        //see in create account
        public bool val = true;
        public bool debval = true;

        //id storing
        private void GetAcc(string ID)
        {
            ID = this.id;
            myId[idnum] = ID;
            idnum++;
           
        }
        public void showAll()
        {
            Console.WriteLine("All registerd accounts are:\n");
            for (int i=0;i<idnum;i++)
            {
                Console.WriteLine(myId[i]);
                
            }
        }
        
        public void showInfo()
        {
            int indexNum;//specific index for showing information
            string inId = Convert.ToString(Console.ReadLine());
          
            
            if (myId.Contains(inId))
            {
                indexNum = Array.IndexOf(myId,inId);//find out array number
                Console.WriteLine("Your Account details are: ");
                Console.WriteLine("|------------------|------------------|--------------------|--------------------|----------------|");
                Console.WriteLine("       Name        |    Acct No       |     Acct id        |     Acct type      |  acct balance  |");
                Console.WriteLine("|------------------|------------------|--------------------|--------------------|----------------|");
                Console.WriteLine("|        {}        |");
                Console.Write("  " + myName[indexNum] + "\t");
                Console.Write("\t" +acctNumber + "\t");
                Console.Write(" \t" +myId[indexNum] + "\t");
                Console.Write("\t" +myAccType[indexNum]);
                Console.Write("\t\t" + myBalance[indexNum]);
               
                /* Console.Write("Name: "+myName[indexNum]+ "");
                 Console.WriteLine("Your acount number :" + acctNumber);
                 Console.WriteLine("AcctId: " + myId[indexNum]);
                 Console.WriteLine("Acct Type: " + myAccType[indexNum]);
                 Console.WriteLine("Date of Birth: " + myDob[indexNum]);
                 Console.WriteLine("Referees's Name: " + myNominee[indexNum]);
                 Console.WriteLine("Account Balance: " + myBalance[indexNum]);*/
            }
            else
            {
                Console.WriteLine("You entered a wrong Id!");
            }
           

        }
     

        public void create_account()
        {
            
            string accType;
            string name;
            int dd, mm, yr;
            string nominee;
            double balance;
            string input;
            Console.WriteLine("0 => Debit Account");
            Console.WriteLine("1 => Savings Account");
            Console.WriteLine("2 => Current Account");
            object ob1 = Console.ReadLine();
            input = Convert.ToString(ob1);

            if (input == "0")
            {

                accType = "Debit";
                myAccType[idnum] = accType;
                Console.Write("Enter First name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter Last name: ");
                string lastName = Console.ReadLine();
                if (char.IsDigit(firstName[0]) || char.IsDigit(lastName[0]))
                {
                    Console.WriteLine("Name cannot begin with a number");
                }
                else if (char.IsLetter(firstName[0]) || char.IsLetter(lastName[0]))
                {
                     char.ToUpper(firstName[0]);
                     char.ToUpper(lastName[0]);
                }
                else
                {
                    Console.WriteLine("Enter a valid name!");
                }
               
                name = Convert.ToString(firstName) + " " + Convert.ToString(lastName);
                myName[idnum] = name;


                //The while loop checks to make sure that the dates are entered correctly and in the right format
                while (val==true)
                {
                    //Take date of birth
                    Console.WriteLine("Enter day of birth: ");
                    dd = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter month of birth: ");
                    mm = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter year of birth: ");
                    yr = Convert.ToInt32(Console.ReadLine());


                    dob.set(dd, mm, yr);


                    if (dob.printDate() == false)
                    {
                        myDob[idnum] = Convert.ToString(dd + "-" + mm + "-" + yr);
                        val = false;
                    }
                    else val = true;
                }



                val = true;
                //debit,savings,current all used the same val 


                Console.WriteLine("Enter Referee's name: ");
                nominee = Convert.ToString(Console.ReadLine());
                myNominee[idnum] = nominee;

                
                
                //takes input untill balance is correct
                while (debval == true)
                {
                    Console.WriteLine("Enter deposit amount: ");
                    balance = Convert.ToDouble(Console.ReadLine());
                    if (balance > db.maxBalance)
                    {
                        Console.WriteLine("Debit Account maximum deposit value is 1000000!");
                        debval = true;
                    }
                    else {
                        myBalance[idnum] = balance;
                        debval = false;
                    }
                }
                debval = true;
                //debit,credit using the same value

                Console.WriteLine("Debit account created successfully...! ");
                //Console.Write("Your Account Id : ");
                id =id1.generate();//collect id from id generator
                id = id + "Deb";//add string to that generated id
                acctNumber = "001" + id1.generate();
                Console.WriteLine("Your Account Id : "+id);
                Console.WriteLine("Your Account number : " + acctNumber);
                GetAcc(id);//store id and increase the index number

            }
            else if (input == "1")
            {
                accType = "Savings";
                myAccType[idnum] = accType;
                Console.Write("Enter FullName:");
                // object ob2 = Console.ReadLine();
                name = Convert.ToString(Console.ReadLine());
                myName[idnum] = name;
                //if user input for date is wrong then it will take untill the input is correct
                while (val == true)
                {
                    Console.WriteLine("Enter day of birth: ");
                    dd = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter month of birth: ");
                    mm = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter year of birth: ");
                    yr = Convert.ToInt32(Console.ReadLine());
                    dob.set(dd, mm, yr);

                    if (dob.printDate() == false)
                    {
                        myDob[idnum] = Convert.ToString(dd + "-" + mm + "-" + yr);
                        val = false;
                    }
                    else val = true;
                }
                val = true;//debit,credit,savings all used the same val 
                Console.WriteLine("Enter Referee's name: ");
                nominee = Convert.ToString(Console.ReadLine());
                myNominee[idnum] = nominee;
                //takes input untill balance is correct
                while (debval == true)
                {
                    Console.WriteLine("Enter deposit amount: ");
                    balance = Convert.ToDouble(Console.ReadLine());
                    if (balance < sv.minBalance)
                    {
                        Console.WriteLine("Savings Account's min val is 1000!");
                        debval = true;
                    }
                    else
                    {
                        myBalance[idnum] = balance;
                        debval = false;
                    }
                }
                debval = true;//debit,credit using the same value
                Console.WriteLine("Savings account created  successfully...! ");
                //Console.Write("Your Account Id : ");
                id = id1.generate();//collect id from id generator
                id = id + "Sav";//add string to that generated id
                acctNumber = "002" + id1.generate();
                // Console.Write("Deb");
                Console.WriteLine("Your Account Id : " + id);
                Console.WriteLine("Your Account number : " + acctNumber);
                GetAcc(id);

            }
            else if (input == "2")
            {
                accType = "Current";
                myAccType[idnum] = accType;
                Console.Write("Enter Fullname:");
          
                name = Convert.ToString(Console.ReadLine());
                myName[idnum] = name;
                //if user input for date is wrong then it will take untill the input is correct
                while (val == true)
                {
                    Console.WriteLine("Enter day of birth: ");
                    dd = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter month of birth: ");
                    mm = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter year of birth: ");
                    yr = Convert.ToInt32(Console.ReadLine());
                    dob.set(dd, mm, yr);
                    if (dob.printDate() == false)
                    {
                        myDob[idnum] = Convert.ToString(dd + "-" + mm + "-" + yr);
                        val = false;
                    }
                    else val = true;
                }
                val = true;//debit,credit,savings all used the same val 
                Console.WriteLine("Enter referee's name: ");
                nominee = Convert.ToString(Console.ReadLine());
                myNominee[idnum] = nominee;
                Console.WriteLine("Enter deposit amount: ");
                balance = Convert.ToDouble(Console.ReadLine());
                myBalance[idnum] = balance;
                Console.WriteLine("Current account created successfully...! ");
                //Console.Write("Your Account Id : ");
                id = id1.generate();//collect id from id generator
                id = id + "Cur";//add string to that generated id
                acctNumber = "003" + id1.generate();
                // Console.Write("Deb");
                Console.WriteLine("Your Account Id : " + id);
                Console.WriteLine("Your Account number : " + acctNumber);
                GetAcc(id);

            }
           


           

        }

        public void deposit()
        {
            int indexNum;
            string inId = Convert.ToString(Console.ReadLine());
            if (myId.Contains(inId))
            {
                indexNum = Array.IndexOf(myId, inId);
                //passArrNum = indexNum;
                Console.WriteLine("Your Balance is: " + myBalance[indexNum]);
                Console.WriteLine("How much you want to deposit: ");
                double depval = Convert.ToDouble(Console.ReadLine());
                if (myAccType[indexNum] == "Debit")
                {
                    db.balance = myBalance[indexNum];
                    db.deposit(depval);
                    myBalance[indexNum] = db.balance;
                }
                else if (myAccType[indexNum] == "Savings")
                {
                    sv.balance = myBalance[indexNum];
                    sv.deposit(depval);
                    myBalance[indexNum] = sv.balance;
                }
                else if (myAccType[indexNum] == "Current")
                {
                    cr.balance = myBalance[indexNum];
                    cr.deposit(depval);
                    myBalance[indexNum] = cr.balance;
                }
                
            }
                
            else
            {
                Console.WriteLine("Your id is wrong!");
            }

        }
        public void withdraw()
        {
            int indexNum;
            string inId = Convert.ToString(Console.ReadLine());
            if (myId.Contains(inId))
            {
                indexNum = Array.IndexOf(myId, inId);
                Console.WriteLine("Your Balance is: " + myBalance[indexNum]);
                Console.WriteLine("How much you want to withdraw: ");
                double depval = Convert.ToDouble(Console.ReadLine());
                if (myAccType[indexNum] == "Debit")
                {
                    db.balance = myBalance[indexNum];
                    db.withdraw(depval);
                    myBalance[indexNum] = db.balance;
                }
                else if (myAccType[indexNum] == "Savings")
                {
                    sv.balance = myBalance[indexNum];
                    sv.withdraw(depval);
                    myBalance[indexNum] = sv.balance;
                }
                else if (myAccType[indexNum] == "Current")
                {
                    cr.balance = myBalance[indexNum];
                    cr.withdraw(depval);
                    myBalance[indexNum] = cr.balance;
                }

            }

            else
            {
                Console.WriteLine("Your id is wrong!");
            }


        }
    }
}
