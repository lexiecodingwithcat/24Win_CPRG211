using System;


namespace ConsoleApp1
    {
    class Class2
        {

        //private varibales:
        //how to achieve it
        //encapsulution: tie the private variables to the function, increase the security of data 
        //2. using get and set method, property
        // get method: return the value of private variable
        //set method: assign the value to the private variable
        string name; //private member
        public string Name//property
        {
            get { return name; }//read only

            set { name = value; }//write only
            }




        }
    }
