
using System;

using System.Collections.Generic;
using System.Security.Permissions;
using System.Linq;  
using System.Xml.Schema;
using System.Collections;


namespace ConsoleApp1
    {
    

  
    class Program
        {
        static void Main(string[] args)
            {
            //create four person objects
            Person lan = new Person(1, "Lan","Brooks","Red",30, true);
            Person gina = new Person(2,"Gina","James","Green",18,false);
            Person mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person mary = new Person(4,"Mary","Beals","Yellow",28,true);
            //Display Gina’s information as a sentence
            gina.DisplayPersonInfo();
            //Display all of Mike’s information as a list.
            Console.WriteLine(mike.ToString());
            //Change Ian’s Favorite Colour to white, and then print his information as a sentence.
            lan.ChangeFavoriteColour();
            lan.DisplayPersonInfo();
            //Display Mary’s age after ten years.
            mary.GetAgeInTenYears();

            //Create two Relation Objects and show the relationship between them
            Relation relation1 = new Relation("sister");
            Relation relation2 = new Relation("brother");
            relation1.ShowRelationship(gina, mary);
            relation2.ShowRelationship(lan, mike);

            //Add all the Person objects to a list
            List<Person> listOfPpl = new List<Person>
                {
                gina, mike, lan, mary
                };
            //calculate average 
            int totalAge = 0;
            int number = listOfPpl.Count;
           foreach(Person person in listOfPpl) 
                {
                totalAge += person.age;
                }
            double average = (double)totalAge / number;
            Console.WriteLine($"Average age is: {average}");

            //The youngest person and the oldest person
            List<int> ageList = new List<int>
           {
           gina.age,
           mike.age,
           lan.age,
           mary.age,
           };

            int maxAge = ageList.Max();
            int minAge = ageList.Min();
            string oldName="";
            string youngName="";

            foreach(Person person in listOfPpl)
                {
                if(person.age == maxAge)
                    {
                    oldName = person.firstName;
                    }else if( person.age == minAge)
                    {
                    youngName = person.firstName;
                    }
                }

            Console.WriteLine($"The youngest person is: {youngName}");
            Console.WriteLine($"The oldest person is: {oldName}");

            //The names of the people whose first names start with M
            foreach(Person person in listOfPpl)
                {
                char firstLetter = person.firstName[0];
                if ( firstLetter =='M')
                    {
                    Console.WriteLine(person.ToString());
                    }
                }

            //The person information of the person that likes the colour blue
            foreach (Person person in listOfPpl)
                {
                string color = person.favoriteColor;
                if (color == "Blue")
                    {
                    Console.WriteLine(person.ToString());
                    }
                }


            Console.ReadLine();
            }
        }
    }

