using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ConsoleApp1
    {
   public class Dog : Animal, IAnimal
        {
       public string Height { get; set; }
        public Dog(string name, string color, string height, int age) {
            this.Age = age;
            this.Name = name;
            this.Color = color;
            this.Height = height;

                    }

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
        public Cat(string name, string color, string height, int age)
            {
            this.Name = name;
            this.Color = color;
            this.Height = height;
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
           
          Console.WriteLine("What is the name of your dog?");
            string name1 = Console.ReadLine();
            
            Console.WriteLine("What is the color of your dog?");
            string color1 = Console.ReadLine();
            Console.WriteLine("How tall is your dog?");
            string height1 = Console.ReadLine();    
            Console.WriteLine("What is the age of your dog?");
            int age1 = int.Parse(Console.ReadLine());
            Dog dog = new Dog(name1,color1, height1, age1);
            dog.Eat();
            Console.WriteLine(dog.Cry());
            

            //cat object 
            Console.WriteLine("What is the name of your cat?");
            string name2 = Console.ReadLine() ;
            Console.WriteLine("What is the color of your cat?");
            string color2 = Console.ReadLine() ;
            Console.WriteLine("How tall is your dog?");
            string height2 = Console.ReadLine();
            Console.WriteLine("What is the age of your cat?");
            int age2 = int.Parse(Console.ReadLine()) ;
            Cat cat = new Cat(name2,color2,height2,age2);
            cat.Eat();
            Console.WriteLine(cat.Cry());
           
            //create an animal list
            List <Animal> animal_list = new List<Animal> { dog, cat};
            foreach(Animal animal in animal_list)
                {
                Console.WriteLine($"The name of the animal is{animal.Name}");
                }


            Console.ReadLine();



            }
        }
    }
