using System;

namespace ConsoleApp1
    {
    class BankAccount
        {
        double balance;
        public string name;

        public double Balance
            {
            get { return balance; }
            set { balance = value; }
            }

        // Function to deposit money
        public void Deposit()
            {
            Check();
            Console.WriteLine("How much money do you want to deposit?");
            double deposit = Convert.ToDouble(Console.ReadLine());
            balance += deposit;
            Check();
            }

        // Function to withdraw money
        public void Withdraw()
            {
            Check();
            Console.WriteLine("How much money do you want to withdraw?");
            double withdraw = Convert.ToDouble(Console.ReadLine());
            if (withdraw >= balance)
                {
                Console.WriteLine("Do you want to withdraw all the money from the account?");
                string option = Console.ReadLine().ToUpper();
                if (option == "Y")
                    {
                    balance -= balance;
                    Check();
                    Console.WriteLine("You have withdrawn all the money you have");
                    }
                }
            else
                {
                Console.WriteLine("How much money do you want to withdraw?");
                withdraw = Convert.ToDouble(Console.ReadLine());
                balance -= withdraw;
                Console.WriteLine($"You withdrew {withdraw}");
                Check();
                }
            }

        // Function to check balance
        public void Check()
            {
            Console.WriteLine($"Your current balance is {balance}");
            }


        }
    }