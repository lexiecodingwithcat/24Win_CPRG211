using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
    {
    internal class Program
        {
        static void Main(string[] args)
            {
           Event event1 = new Event() {EventNumber = 1, Location="Calgary" };
            string file_path = "D:\\SAIT\\c#\\lab6_Serialization\\event.txt";
            SerializeEventObject(event1, file_path);
            DeserializationEventObject(file_path);
            Console.WriteLine("Tech Competiton");
            Console.WriteLine("In Word: Hackathon");
            ReadFromFile(file_path);

            Console.ReadLine();
            }

        public static void SerializeEventObject(Event eve, string filePath)
            {
            //create a binary fomatter
            BinaryFormatter formatter = new BinaryFormatter();
            //open a file
            FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            using (stream)
                {
                formatter.Serialize(stream, eve);
                }
            Console.WriteLine("Serialization done");
            }

        public static void DeserializationEventObject(string filePath)
            {
            //IFormatter is a parent interface of binaryformatter
            IFormatter formatProvider = new BinaryFormatter();
            //stream is the base class of filestream
            Stream stream = new FileStream(filePath,FileMode.Open,FileAccess.Read);
            Event event2 = (Event)formatProvider.Deserialize(stream);
               //if use "using", the event2 is enclosed in the using scope and can not be read by the outside
            Console.WriteLine(event2.EventNumber);
            Console.WriteLine(event2.Location);
            stream.Close();
            }

        public static void ReadFromFile(string filePath)
            {
            string content = "Hackathon";
            FileStream fsWrite = new FileStream(filePath, FileMode.Open, FileAccess.Write);
            //create a stream writer object
            StreamWriter writer = new StreamWriter(fsWrite);
            writer.WriteLine(content);
            
            //make sure the data in flush is written in the file before close the file
            writer.Flush();
            writer.Close();

            //create a new FileStream object with read mode only, the previous is write mode
            FileStream fsRead = new FileStream(filePath,FileMode.Open);
            //move the pointer to the begining of this file
            fsRead.Seek(0, SeekOrigin.Begin);
            //readbyte from the file after the pointer, using int to hold the bytes
            int byteValue = fsRead.ReadByte();
            //convert bytes to char
            char firstChar = Convert.ToChar(byteValue);
            Console.WriteLine($"The First Character is: \"{firstChar}\"");

            //the orginial location will start from the previous pointer
            fsRead.Seek(4, SeekOrigin.Begin);
            int byteValue2 = fsRead.ReadByte();
            char middleChar = Convert.ToChar(byteValue2);
            Console.WriteLine($"The Middel Character is: \"{middleChar}\"");

            fsRead.Seek(8, SeekOrigin.Begin);
            int byteValue3 = fsRead.ReadByte();
            char lastChar = Convert.ToChar(byteValue3);
            Console.WriteLine($"The Last Character is: \"{lastChar}\"");

            fsRead.Close();

            }



        }
    }
