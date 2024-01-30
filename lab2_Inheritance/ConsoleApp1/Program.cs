using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            //creat a list to add objects
            List<Employee> employeeList = new List<Employee>();
            foreach (string line in result)
                {
                //split the line 
                string[] data = line.Split(':');
                string id = data[0];
                char firstDigit = id[0];
                string name = data[1];
                string address = data[2];
                string phoneNo = data[3];
                long sinNo = long.Parse(data[4]);

                //salaried employee
                if ('0' <= firstDigit && firstDigit <= '4')
                    {
                    Salaried obj = new Salaried(id, name, address, phoneNo, sinNo);
                    obj.Salary = double.Parse(data[7]);
                    employeeList.Add(obj);
                    }
                //wages
                else if ('5' <= firstDigit && firstDigit <= '7')
                    {
                    Wages obj = new Wages(id, name, address, phoneNo, sinNo);
                    obj.Rate = double.Parse(data[7]);
                    obj.Hour = int.Parse(data[8]);
                    employeeList.Add(obj);
                    }
                //part-time employee
                else if ('8' <= firstDigit && firstDigit <= '9')
                    {
                    PartTime obj = new PartTime(id, name, address, phoneNo, sinNo);
                    obj.Rate = double.Parse(data[7]);
                    obj.Hour = int.Parse(data[8]);
                    employeeList.Add(obj);
                    }
                }
            foreach(Employee obj in employeeList)
                {
                Console.WriteLine(obj.Name);
                }


            Console.ReadLine();
            }
        }
    }
