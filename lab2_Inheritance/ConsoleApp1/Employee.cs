using System;


namespace ConsoleApp1
    {
    abstract class Employee
        {
        //common attributes 
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public long SIN { get; set; }
        public double Salary {get;set;}

        public abstract double WeeklySalary();
        }
    }
