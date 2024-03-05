using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
             Console.ReadLine();


            }

        public static void SerializeEventObject(Event eve, string filePath)
            {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            using (stream)
                {
                formatter.Serialize(stream, eve);
                }
            Console.WriteLine("Serialization done");
            }

        public static void DeserializationEventObject(string filePath)
            {
            IFormatter formatProvider = new BinaryFormatter();
            Stream stream = new FileStream(filePath,FileMode.Open,FileAccess.Read);
            Event event2 = (Event)formatProvider.Deserialize(stream);
               //if use "using", the event2 is enclosed in the using scope and can not be read by the outside
            Console.WriteLine(event2.EventNumber);
            Console.WriteLine(event2.Location);
            stream.Close();
            }

        public static void ReadFromFile(string filePath)
            {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);



            }



        }
    }
