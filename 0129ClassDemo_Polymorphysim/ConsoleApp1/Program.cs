using System;


namespace ConsoleApp1
    {

    class Addclass
        {
        //stastic polymorphism, stastic binding

        public void Add(int a, int b)
            {
            int r = a + b;
            Console.WriteLine($"The addition of a and b is{r}");
            }

        public void Add(string x, string y) {
            string s = x + y;
            Console.WriteLine($"Concatination of string is {s}");
            }
        }


    internal class Program
        {
        static void Main(string[] args)
            {
             Addclass addclass = new Addclass();
            //addition of 2 interger numbers

            //because the input is string by default, parse can parse it as intergers
            Console.WriteLine("Enter the values of interger:");
            int m = int.Parse( Console.ReadLine() );
            int n = int.Parse( Console.ReadLine() );
            addclass.Add( m, n );

            //adding two strings together
            Console.WriteLine("Enter the values of string:");
            string s1  =  Console.ReadLine();
            string s2 = Console.ReadLine();
            addclass.Add( s1, s2 );

            //the type of parameters decides which method will be called 


            Console.ReadLine();
            }
        }
    }
