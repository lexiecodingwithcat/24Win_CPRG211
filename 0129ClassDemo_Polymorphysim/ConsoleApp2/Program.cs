using System;
using System.Collections.Generic;


namespace ConsoleApp2
    {
    internal class Program
        {
        //class by defult is public
        abstract class Shape
            {
            //by default the data members are private
            public string Name {  get; set; }
            //double means the return type should be double
            public abstract double Caculate(); //abstract method
            public virtual void Display()
                {
                Console.WriteLine($"Shape is {Name}");
                   }

            }

        class Circle:Shape { 
            public double Radius { get; set; }
            public Circle(string name, double radius)
                {
                Name = name;
                Radius = radius;
                }
            public override double Caculate()
                {
                return Math.PI * Radius*Radius;
                }
            public override void Display()
                {
                //base class function
                base.Display();
                Console.WriteLine($"radius is {Radius}");
                }

            }

        class Rectangle : Shape
            {
            public double Height {  get; set; }
            public double Width { get; set; }
            public Rectangle(string name, double height, double width)
                {
                Name = name;
                Height = height;
                Width = width;
                }
            public override double Caculate()
                {
                return Width * Height;
                }
            public override void Display()
                {
                base.Display();
                Console.WriteLine($"rectangle is {Width} and {Height}");
                }


            }

        static void Main(string[] args)
            {
            List<Shape> shapes = new List<Shape> { 
                new Circle("circle 1", 5),
                new Rectangle("rectangle 1", 4, 6),
                new Circle("circle 2", 6),
                new Rectangle("rectangle 2", 4.1, 6.2)
                 };
               

            foreach (Shape shape in shapes)
                {
                shape.Display();
                Console.WriteLine($"Area is {shape.Caculate()}");
                Console.WriteLine();
                Console.ReadLine();
                }




            }
        }
    }
