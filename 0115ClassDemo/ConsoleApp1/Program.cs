using System;


namespace ConsoleApp1
    {
     class Program
        {
        static void Main(string[] args)
            {
            //Class1 obj1 = new Class1();//object invoked and constructor called 
            //Class1 obj1 = new Class1(32,"Hello World");
            //obj1.Display();

            // because the age is declared by public, so we can change the value of it outside the class
            //by defult is private if there is no public keyword
            //obj1.age = 25;

            //Class1 obj2 = new Class1(obj1);// to call copy constructor
            //obj2.Display();

            //Class2 obj2 = new Class2();
            //obj2.Name = "sait";
            //Console.WriteLine(obj2.Name);

            BankAccount bk1 = new BankAccount();
            bk1.Balance = 0;
            bk1.name = "Steven";
            bk1.Deposit();
            bk1.Withdraw();

            bk1.Balance = 500;
            bk1.Deposit();
            bk1.Withdraw();


            //bk1.Deposit();
            //bk1.Withdraw();




            Console.ReadLine();





            }
        }
    }
