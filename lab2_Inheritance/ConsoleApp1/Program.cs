using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ConsoleApp1
    {
   class Program
        {
        static void Main(string[] args)
            {
            //read the file
            string filePath = @"../../../employees.txt";
            List <string> result = new List<string>();
            result = File.ReadAllLines(filePath).ToList();
            foreach (string line in result)
                {
                //split the line 
                string[] data = line.Split(':');
                char firstDigit = line[0];
                Console.WriteLine(data[0]);


                

                //if (0<= firstDigit && firstDigit <= 4)
                //    {

                //    }
                }



            }
        }
    }
