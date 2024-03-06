using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
    {
    //this keyword must be mentioned when creating class
    [Serializable]
    //definition of the class
    public class Person
        {
        public string Name { get; set; }
        public int Age { get; set; }
        [XmlIgnore]
        public string Password { get; set; }
        }
    }
