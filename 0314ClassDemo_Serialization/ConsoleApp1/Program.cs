using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApp1
    {

    internal class Program
        {
        static void Main(string[] args)
            {
            //initialize the object
            Person p = new Person() { Name="David", Age = 30,Password="12356@" };
            SerializePersonObject(p);
            DeserializePersonObject();
            Console.ReadLine();
            



            }
        public static void SerializePersonObject(Person p)
            {
            //convert object to binary data
            //create a binary formatter
            BinaryFormatter bf = new BinaryFormatter();
            //create a stream
            FileStream fs = new FileStream("person.bin", FileMode.Create);
            //"using" can make sure it will automatically close and release resources after finishing 
            using (fs)
                {
                //serialize the object p into fs file
                bf.Serialize(fs, p);
                }
            Console.WriteLine("Serialization done");
            }

        public static void DeserializePersonObject()
            {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("person.bin", FileMode.Open);
            using (fs)
                {
                Person newP = (Person)bf.Deserialize(fs);
                Console.WriteLine($"Name: {newP.Name}, Age : {newP.Age}, Password: {newP.Password}");

                }
            }


        }
    



    }
