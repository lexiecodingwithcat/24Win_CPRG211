using System;


namespace ConsoleApp1
    {
  class PartTime:Employee
        {
        public double Rate { get; set; }
        public int Hour {  get; set; }
        public override double SumSalary()
            {
            return (Rate * Hour);
            }
        }
    }
