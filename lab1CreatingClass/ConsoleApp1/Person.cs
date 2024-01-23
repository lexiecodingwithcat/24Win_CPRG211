using System;
using System.Collections.Generic;


namespace ConsoleApp1
    {
    internal class Person
        {

        int personId;
        public string firstName;
        string lastName;
        public string favoriteColor;
        public int age;
        bool isWorking;

        public Person(int id, string fstName, string laName, string color, int personAge, bool workSate)
            {
            this.personId = id;
            this.firstName = fstName;
            this.lastName = laName;
            this.favoriteColor = color;
            this.age = personAge;
            this.isWorking = workSate;
            }

        public void DisplayPersonInfo()
            {
            string name = firstName + " " + lastName;
            Console.WriteLine($"{personId}: {name}'s favorite color is {favoriteColor}");
            }

        public void ChangeFavoriteColour()
            {
            favoriteColor = "white";
            }

        public void GetAgeInTenYears()
            {
            Console.WriteLine($"{firstName}{lastName}'s Age in 10 years is:{age + 10}");
            }

        public override string ToString()
            {        
            return $"PersonId: {this.personId}\nFirstName: {this.firstName}\nLastName: {this.lastName}\nFavoriteColour: {this.favoriteColor}\nAge: {this.age}\nIsWroking: {this.isWorking}";
    
            }


        }
    }
