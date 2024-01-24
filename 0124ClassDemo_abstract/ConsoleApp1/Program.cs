using System;


namespace ConsoleApp1
    {
    abstract class Animal
        {
        //1. abstract can have both abstract and non-abstarct methods
        //2.abstratct method will not be implemented 
        //3. abstract methods cannot decleared in non-abstract class
        public abstract void Animalsound();//abtsract method, just a name. no body, the body will defined in the derived class
        public void Sleep() //non-abstract method
            {
            Console.WriteLine("zzz");
            }
        }
    class Pig : Animal { //derived from Animal class
        
        public override void Animalsound() {
            Console.WriteLine("Hello pig"); //define 
            
            }
        
        }



    public class Program
        {
        static void Main(string[] args)
            {
            //Animal dog = new Animal();
            //cannot create an instance of abstract class
            //it does not have any instance creation
            //dog.animalsound();
            //dog.sleep();

            Pig pig1 = new Pig();
            pig1.Animalsound();
            pig1.Sleep();

            Console.ReadLine();

            }
        }
    }
