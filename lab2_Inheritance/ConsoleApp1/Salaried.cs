using System;


namespace ConsoleApp1
    {
    class Salaried:Employee
        {
        public double Salary { get; set; }
        public override double SumSalary()
            {
            return Salary;
            }
        }
    }
