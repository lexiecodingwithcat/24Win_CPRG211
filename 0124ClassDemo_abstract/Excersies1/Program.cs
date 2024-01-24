using System;

namespace Excersies1
    {
    abstract class SpaceStation
        {
        public abstract void FireLaser(); 
        }

    class DeathStar: SpaceStation { 
        public override void FireLaser()
            {
            Console.WriteLine("Phew phew");
            }
        
        
        }

    public class Program
        {
        static void Main(string[] args)
            {
            DeathStar star = new DeathStar();
            star.FireLaser();

            Console.ReadLine();

            }
        }
    }
