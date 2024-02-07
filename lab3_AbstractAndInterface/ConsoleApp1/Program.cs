using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ConsoleApp1
    {
   public class Dog : Animal, IAnimal
        {
        public string Height {  get; set; }
        public override void Eat()
            {
            Console.WriteLine("Dogs eat meat.");
            }

        public string Cry()
            {
            return "Woof!";
            }
        }

    public class Cat: Animal, IAnimal
        {
        public string Height { get; set; }
        public Cat(string name, string color, int age)
            {
            this.Name = name;
            this.Color = color;
            this.Age = age;
            }
        public override void Eat()
            {
            Console.WriteLine("Cats eat mice.");
            }
        public string Cry()
            {
            return "Meow!";
            }
        }


    internal class Program
        {
        static void Main(string[] args)
            {
            //dog object
            Dog dog = new Dog();
          Console.WriteLine("What is the name of your dog?");
            string name1 = Console.ReadLine();
            dog.Name = name1;
            Console.WriteLine("What is the color of your dog?");
            string color = Console.ReadLine();
            dog.Color = color;
            Console.WriteLine("What is the age of your dog?");
            int age = int.Parse(Console.ReadLine());
            dog.Age = age;
            dog.Eat();
            Console.WriteLine(dog.Cry());
            

            //cat object 
            Console.WriteLine("What is the name of your cat?");
            string name2 = Console.ReadLine() ;
            Console.WriteLine("What is the color of your cat?");
            string color2 = Console.ReadLine() ;
            Console.WriteLine("What is the age of your cat?");
            int age2 = int.Parse(Console.ReadLine()) ;
            Cat cat = new Cat(name2,color2,age2);
            cat.Eat();
            Console.WriteLine(cat.Cry());
           
            Console.ReadLine();



            }
        }
    }
