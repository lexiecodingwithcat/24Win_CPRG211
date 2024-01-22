using System;
using System.ComponentModel;

namespace ConsoleApp1
    {
    class ParentClass
        {
        public void Display()
            {
            Console.WriteLine("parent class called");
            }
        //if you want the child class to override this function
        //keyword should be written
        //protected void Print()
        public virtual void Print()
            {
            Console.WriteLine("I am in parent class");
            }
        }

    class Childclass : ParentClass {
        //by using override and virtual keywords, this function is override the parent function with the same name
        //when calling the obj created by childclass, only this one will be invoked 
        public override void Print() { 
            //this proteced function can only be accessed through same class or derived/ child class
            //like private function but only used in inheritence
            //PrintMessage();

            Console.WriteLine("Child class called");
            }
        
        }

    class Class3: Childclass { 
        public void Printdata()
            {
            Console.WriteLine("Class 3 called");
            }
        
        
        }
    

    class Program
        {
        static void Main(string[] args)
            {

            //Childclass child1 = new Childclass();//obj of child class
            //child1.Display(); //parent class method invoked
            //child1.PrintMessage(); //parent class method
            //child1.Print();//child class method

            //multi-level inheritence
            Class3 child2 = new Class3();
            //child2.Display(); //inherited from Parentclass
            //child2.PrintMessage(); //this will not work cuz this is protected
            child2.Print();//inherited from Childclass
            //child2.Printdata();//method from itself

            }
        }
    }
