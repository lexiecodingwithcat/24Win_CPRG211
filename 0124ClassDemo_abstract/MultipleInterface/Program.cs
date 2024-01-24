using System;


namespace MultipleInterface
    {
    //interface and its method are public by default, and cannot be private, proteced
    interface IFirstInterface
        {
        void MyMethod();
        }
    interface ISecondInterface
        {
        void AnotherMethod();
        }

    //interfaces should be implemented by class
    class Democlass: IFirstInterface , ISecondInterface
        { 
       public void MyMethod() {
            Console.WriteLine("Hello, this is the first method");
            
            }
        public void AnotherMethod() {
            Console.WriteLine("Hello, this is the second method");
            }

        }

    public class Program
        {
        static void Main(string[] args)
            {

            Democlass democlass = new Democlass();
            democlass.MyMethod();
            democlass.AnotherMethod();
            }
        }
    }

