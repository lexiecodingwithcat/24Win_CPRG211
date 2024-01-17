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
            //read from the file 
            //1. specify the file path 
            string filepath = @"D:\SAIT\c#\0117ClassDemo\text1.txt";
            //2. create a list to store the lines of code to the list 
            List<string> strings = new List<string>();
            //3. read the lines from the file and store them in the list 
            strings  = File.ReadAllLines(filepath).ToList();
            //the data type of strings is list while the line read from the file is string
            foreach (string s in strings)// print lines from the list 
                {
                Console.WriteLine(s);
                }
            Console.ReadLine();


            //update the file - write something 
            //add a new line to the list 
            strings.Add("Good morning all to c sharp");
            strings.Add("happy wednesday");
          
            //write all lines back to the file
            File.WriteAllLines(filepath, strings);
            

            }



        }
    }
