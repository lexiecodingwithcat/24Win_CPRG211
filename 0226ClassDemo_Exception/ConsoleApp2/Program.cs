using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
    {
    class Demo
        {
        int temp = 0;
        public void show()
            {
            if (temp == 0)
                {
                throw (new TemIsZeroException("Zero tempratuer found"));
                }
            else
                {
                Console.WriteLine("Temprature{0}", temp);
                }
            }
        }

    //user-defined exceptions should inherit from system.exception
    class TemIsZeroException : Exception
        {
        //constructor
        public TemIsZeroException(string message) : base(message) { }
        }
    internal class Program
        {
        static void Main(string[] args)
            {
            Demo obj1 = new Demo();
            try
                {
                obj1.show();
                }
            catch(TemIsZeroException ex) {
                Console.WriteLine(ex.Message);
                }
           
            Console.ReadLine();

            }
        }
    }
