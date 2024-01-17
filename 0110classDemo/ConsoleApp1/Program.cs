using System;   
using System.Runtime.CompilerServices;
using System.Threading;


//container 
namespace ConsoleApp1
{
    class Area
    {
        //Data member, variable, data types
       public double length ;
       public double width;
        //these variables are private, need to use function to use it
        //hiding the detail from external user but can be accessed by functions

        //If we want them public, we need the keyword public
        //this is a public function
        //public void Get_data()
        //{
        //    length = 2.3;
        //    width = 2.1;
        //    Console.WriteLine(length);
            
        //}

        public void Get_Area()
        {
            double area1;
            area1 = length * width; 
            Console.WriteLine("The area is" + " "+ area1);
        }
    }

    //class for main program
    //every class should start with uppercase letter
    internal class Program
    {
        //main function
        static void Main(string[] args)
        {
            //start a new object
            Area obj1 = new Area();
            //Access function through objects by using a dot operater
            //through function to get the attributes
            //obj1.Get_data();
            //obj1.Get_Area();
            //Console.WriteLine(value:obj1.length) ;  
            Area obj2 = new Area();
            //if we want to change the value of variables, we should change them to public first inside the class
            obj2.width = 1.2;
            obj2.length = 5.1;
            obj2.Get_Area();


            Console.ReadLine();


          
        }
    }
}
