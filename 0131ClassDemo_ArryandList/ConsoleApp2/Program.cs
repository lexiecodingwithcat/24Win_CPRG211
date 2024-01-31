using System;
using System.Collections.Generic;


namespace ConsoleApp2
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            //list is more flexiable than array
            //the length of array is fixed
            var number = new List<int>() { 1,2,3,4,5,6,7,8};
           //remove
            number.Remove(8);
            foreach (int i in number)
                {
                Console.WriteLine(i);
                }
            // the length of a list
            int count = number.Count;
            Console.WriteLine($"The length of this list is {count}");
            //clear
            //number.Clear();
            //indexOf
          int index = number.IndexOf(3);
            Console.WriteLine($"The index of 3 is {index}");


          





            Console.ReadLine();








            }
        }
    }
