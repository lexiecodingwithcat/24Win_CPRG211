using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
    {

    class Person //static class
        {
        //static data members
        public static string Name = "Steven";
        public static void Display() //static function 
            {
            Console.WriteLine(Name);

            }
       static  Person() //static constructor
            {
            Console.WriteLine("This is the static constructor");
            }
        }
     class Program
        {
        static void Main(string[] args) //main method
            {
            //static makes variables, methods and functions accessible without object creation
            //public still need  object creation 
            Person.Name = "hello";
            Console.WriteLine("output is " + Person.Name);
            Person.Display();

            //consturctor need an object to be evoked, so moved the static keyword before the class
            Person obj1 = new Person();

            Console.ReadLine();
            }
        }
    }
