using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
    {
    public abstract class Animal
        {
        private string name;
        private string color;
       private int age;
        public string Name { 
            get { return name; } 
            set { name = value; }
            }

         public string Color
            {
            get { return color; }
            set { color = value; }
            }
        public int Age
            {
            get { return age; }
            set { age = value; }
            }
        abstract public void Eat();
        
        }
    }
