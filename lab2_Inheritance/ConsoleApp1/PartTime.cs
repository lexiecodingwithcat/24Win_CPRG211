using System;


namespace ConsoleApp1
    {
  class PartTime:Employee
        {
        public double Rate { get; set; }
        public int Hour {  get; set; }
        public PartTime(string id, string name, string address, string phone, long sin)
            {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            SIN = sin;
            }
        public override double SumSalary()
            {
            return (Rate * Hour);
            }
        }
    }
