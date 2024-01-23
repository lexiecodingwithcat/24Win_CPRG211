using System;
using System.Collections.Generic;


namespace ConsoleApp1
    {
    internal class Person
        {
        
            int personId;
           public string firstName;
            string lastName;
            string favoriteColor;
            int age;
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
                age += 10;
                Console.WriteLine($"{firstName}{lastName}'s Age in 10 years is:{age}");
                }

            public void ToStringnew()
                {
                List<Person> personList = new List<Person>();
                personList.Add(this);
                foreach (Person person in personList)
                    {
                    Console.WriteLine($"PersonId: {person.personId}");
                    Console.WriteLine($"FirstName: {person.firstName}");
                    Console.WriteLine($"LastName: {person.lastName}");
                    Console.WriteLine($"FavoriteColour: {person.favoriteColor}");
                    Console.WriteLine($"Age: {person.age}");
                    Console.WriteLine($"IsWorking: {person.isWorking}");
                    }
                }
            }

        
    }
