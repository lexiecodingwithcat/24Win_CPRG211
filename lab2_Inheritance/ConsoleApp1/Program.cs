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
            //a.Fill a list with objects based on the supplied data file.
            //creat a list to add all objects
            List<Employee> employeeList = new List<Employee>();
            //creat a list to save all wages employee's salary
            List<double> wageList = new List<double>();
            //creat a list to save all salaried employees
            List<double> salariedList = new List<double>();
            //number of salaried employee
            int salariedNum = 0;
            //number of wages employee
            int wagesNum = 0;
            //number of part-time employee
            int ptNum = 0;
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
                    salariedList.Add(obj.Salary);
                    salariedNum++;
                    }
                //wages
                else if ('5' <= firstDigit && firstDigit <= '7')
                    {
                    Wages obj = new Wages(id, name, address, phoneNo, sinNo);
                    obj.Rate = double.Parse(data[7]);
                    obj.Hour = int.Parse(data[8]);
                    employeeList.Add(obj);
                    wageList.Add(obj.WeeklySalary());
                    wagesNum++;
                    }
                //part-time employee
                else if ('8' <= firstDigit && firstDigit <= '9')
                    {
                    PartTime obj = new PartTime(id, name, address, phoneNo, sinNo);
                    obj.Rate = double.Parse(data[7]);
                    obj.Hour = int.Parse(data[8]);
                    employeeList.Add(obj);
                    ptNum++;
                    }
                }
            //the number of objects is the length of the list
            int employeeNo = employeeList.Count;
            double totalSalary = 0;
            foreach(Employee obj in employeeList)
                {
                totalSalary += obj.WeeklySalary();
                //Console.WriteLine(obj.WeeklySalary());
                }
            double average = (double)totalSalary/ employeeNo;
            Console.WriteLine($"The weekly total salary is {totalSalary}, and the average is {average}");
            //c.Calculate and return the highest weekly pay for the wage employees, including the name of the employee.
            double maxWage = wageList.Max();
            double minSalaried = salariedList.Min();
            //find the object with highest and lowest salary
            string maxName = "";
            string minName = "";
            //Console.WriteLine(maxWage);
            foreach (Employee obj in employeeList)
                {
                if(maxWage == obj.Salary)
                    {
                    maxName = obj.Name;
                    }
                if(minSalaried == obj.Salary)
                    {
                    minName = obj.Name;
                    }
                }
            Console.WriteLine($"The highest weekly pay is {maxWage} by {maxName}");
            Console.WriteLine($"The lowest weekly pay is {minSalaried} by {minName}");

          
            double wagePer = Math.Round((double) wagesNum/ employeeNo,4)*100;
            double salariedPer = Math.Round( (double)salariedNum / employeeNo,4)* 100;
            double ptPer = Math.Round((double)ptNum / employeeNo,4) * 100;
            Console.WriteLine($"The percentage of wages employees is: {wagePer}%");
            Console.WriteLine($"The percentage of salaried employees is: {salariedPer}%");
            Console.WriteLine($"The percentage of part-time employees is: {ptPer}%");

            Console.ReadLine();
            }
        }
    }
