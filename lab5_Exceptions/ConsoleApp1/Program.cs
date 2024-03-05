using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
    {
    class Circle
        {
        double radius;
        public void SetRadius(double radius)
            {
            if (radius <= 0)
                {
                throw new InvalidRadiusException(radius);
                }
            else
                {
                this.radius = radius;
                }
            }

        public override string ToString()
            {
            return $"Valid radius: {radius} is greater than zero";
            }

        }
    class InvalidRadiusException : Exception
        {
        //constrcutor
        public InvalidRadiusException() : base("This radius is valid") { }

        public InvalidRadiusException(double radius) : base($"Invalid radius: The {radius} is not greater than zero") { }
        }

        internal class Program
            {
            static void Main(string[] args)
                {
                Circle circle1 = new Circle();
                Circle circle2 = new Circle();
                Circle circle3 = new Circle();

            
            
                try
                    {
                    circle1.SetRadius(-1);
                    Console.WriteLine(circle1.ToString());
                    }
                catch (InvalidRadiusException ex)
                    {
                    Console.WriteLine(ex.Message);
                    }

                try
                    {
                    circle2.SetRadius(0);
                    Console.WriteLine(circle2.ToString());
                    }
                catch (InvalidRadiusException ex)
                    {
                    Console.WriteLine(ex.Message);
                    }

                try
                    {
                    circle3.SetRadius(1);
                    Console.WriteLine(circle3.ToString());
                    }
                catch (InvalidRadiusException ex)
                    {
                    Console.WriteLine(ex.Message);
                    }


                Console.ReadLine();



                }
            }
        }
    
