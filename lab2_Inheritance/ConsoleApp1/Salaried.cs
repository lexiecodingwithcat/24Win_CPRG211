using System;
using System.Security.Policy;


namespace ConsoleApp1
    {
    class Salaried:Employee
        {
        public double Salary { get; set; }

        //parameter constructor 
        public Salaried(string id, string name, string address, string phone, long sin)
            {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            SIN = sin;
            }
        public override double WeeklySalary()
            {
            return (Salary/52);
            }
        }
    }
