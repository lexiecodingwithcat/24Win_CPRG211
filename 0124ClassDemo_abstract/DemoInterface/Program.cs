using System;


namespace DemoInterface
    {
    interface IAnimal
        {
        void Speak();
        }

    class Dog: IAnimal { 
        
        public void Speak()
            {
            Console.WriteLine("Woof");
            }
        
        }

    class Cat: IAnimal
        {
        public void Speak() 
            {
            Console.WriteLine("Meow");
                }
        }



    public class Program
        {
        static void Main(string[] args)
            {
            // create an object of dog
            Dog dog = new Dog();
            dog.Speak();
            Cat cat = new Cat();
            cat.Speak();



            }
        }
    }
