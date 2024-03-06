using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
    {
    internal class Program
        {
        static void Main()
            {
            byte b1 = 10;
            byte b2 ;
            //paramaters: 1. path, 2. mode of file
            FileStream f1 = new FileStream("text1.txt", FileMode.Create, FileAccess.Write);
            //write the byte content into the file
            f1.WriteByte(b1);
            f1.Close();

            //if you want to read, then a new fileStream Object should be created
            FileStream f2 = new FileStream("text1.txt", FileMode.Open, FileAccess.Read);
            //the file is empty because the data is transfered to b2 now
            //ReadByte() will return an INT datatype
            b2 =(byte) f2.ReadByte();
            Console.WriteLine(b2);
            f2.Close();

            }
        }
    }
