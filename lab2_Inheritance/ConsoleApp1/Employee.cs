using System;


namespace ConsoleApp1
    {
    abstract class Employee
        {
        //common attributes 
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long SIN { get; set; }
        public abstract double SumSalary();
        }
    }
