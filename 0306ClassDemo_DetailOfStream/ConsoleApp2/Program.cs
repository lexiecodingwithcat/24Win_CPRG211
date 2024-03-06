using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
    {
    internal class Program
        {
        static void Main()
            {
            //find largest number from array of bytes
            byte[] b1 = { 50, 2, 3, 10, 30, 40 };
            byte[] b2 = new byte[6];
            FileStream f1;
            f1 = new FileStream("text2.txt", FileMode.Create, FileAccess.Write);
            f1.Write(b1, 0, b1.Length);
            f1.Close();

            //seek(): find random 
            //which location you want to start seeking  
            //give read access
            f1 = new FileStream("text2.txt", FileMode.Open, FileAccess.Read);
            f1.Seek(3,SeekOrigin.Begin);
            //copy the data into b2
            f1.Read(b2,0,3);
            byte big1 = b2[0];
            for(int i = 0; i < b2.Length; i++)
                {
                if (big1 < b2[i])
                    {
                    big1 = b2[i];
                    }

                }
            Console.WriteLine($"Largest number:{big1}");


            }
        }
    }
