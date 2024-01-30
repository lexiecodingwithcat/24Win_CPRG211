using System;


namespace ConsoleApp1
    {
   class Wages:Employee
        {
        public double Rate { get; set; }
        public int Hour { get; set; }

        public Wages(string id, string name, string address, string phone, long sin)
            {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            SIN = sin;
            }
        public override double SumSalary()
            {
            if(Hour <= 40)
                {
                return Rate*Hour;
                }
            else
                {
                return (Rate*40+Rate*(Hour-40)*1.5);
                }
            }
        }
    }
