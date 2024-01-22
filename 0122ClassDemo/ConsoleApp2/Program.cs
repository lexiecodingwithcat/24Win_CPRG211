using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


namespace ConsoleApp2
    {
    class Product
        {
        int product_id;
        public string product_name;
        public double production_price;

        public int Id
            {
            get { return product_id; }
            set { product_id = value; }
            }

        public virtual void DisplayProductionInfo()
            {
            Console.WriteLine("Information about production");
            Console.WriteLine($"The product name is {product_name}, the id is {Id}, and the price is {production_price}");
            }
        }

    class Electronics : Product
        {
        int warrantyMonths;

        public int Warranty
            {
            get { return warrantyMonths; }
            set { warrantyMonths = value; }
            }

        public override void DisplayProductionInfo()
            {
            //both base and child class have the same function name
            //when you want to override the base function and meanwhile want to call the base function
            base.DisplayProductionInfo();
            Console.WriteLine($"The warranty month of this electronic is {warrantyMonths}");
            }

        }

    class Book : Product
        {
        //public string author;
        string author;


        //parameter instuctor
       public Book(string author)
            {
            this.author = author;
            }

        public override void DisplayProductionInfo()
            {
            base.DisplayProductionInfo();
            Console.WriteLine($"The author of the book is {author}");
            
            }
        }

    class Clothing : Product
        {
        public string size;
        public override void DisplayProductionInfo()
            {
            base.DisplayProductionInfo();
            Console.WriteLine($"The size of the closing is {size}");
            }
        }

    class Program
        {

        static void Main(string[] args)
            {
             Electronics phone = new Electronics();
            phone.Id = 1;
            phone.product_name = "iPhone 15 Pro";
            phone.production_price = 2000.56;
            phone.Warranty = 15;
            phone.DisplayProductionInfo();


            Book harryPotter = new Book("J.K.Rolin");
            harryPotter.Id = 2;
           harryPotter.product_name = "magic book";
           harryPotter.production_price = 50.7;
           harryPotter.DisplayProductionInfo() ;

            Clothing sweater = new Clothing();
            sweater.Id = 3;
            sweater.product_name = "a white sweater";
            sweater.production_price = 20.1;
            sweater.size = "Large";
            sweater.DisplayProductionInfo() ;




            Console.ReadLine();

            }
        }
    }
