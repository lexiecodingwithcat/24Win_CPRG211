using System;

//namespace is just a container
namespace ConsoleApp1
    {
     class Class1
        {
       
         int age;
        string name;


        //the name of the conrtuctor should be the same as class
        //the contructor does not have any return value, so we don't write void here.
        //the constructor will be automatically called when creating an obj
        //public Class1() //1. default constructor:  will not have any pramas
        //    {
        //    age = 32;
        //    name = "Test";
        //    }
        //2. parameterised constructor: must pass params when creating objects, at least there should be one param
        public Class1(int age, string name)
            {
            this.age = age;
            this.name = name;

            }
        //3. copy conrtsuctor: copy the variables from one object to another, the param is an object
        public Class1(Class1 obj)
            {
            age = obj.age;
            name = obj.name;
            }
        public void Display()
            {

            //tie the private variable to the function 
            Console.WriteLine($"the name is {name}, the age is {age}");
            }
        }
    
    }
