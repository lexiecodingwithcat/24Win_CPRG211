using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;


namespace ConsoleApp1
    {
    

  
    class Program
        {
        static void Main(string[] args)
            {
            //create four person objects
            Person lan = new Person(1, "lan","Brooks","Red",30, true);
            Person gina = new Person(2,"Gina","James","Green",18,false);
            Person mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person mary = new Person(4,"Mary","Beals","Yellow",28,true);
            //Display Gina’s information as a sentence
            gina.DisplayPersonInfo();
            //Display all of Mike’s information as a list.
            mike.ToStringnew();
            //Change Ian’s Favorite Colour to white, and then print his information as a sentence.
            lan.ChangeFavoriteColour();
            lan.DisplayPersonInfo();
            //Display Mary’s age after ten years.
            mary.GetAgeInTenYears();

            //Create two Relation Objects
            Relation relation1 = new Relation("sister");
            Relation relation2 = new Relation("brother");
            relation1.ShowRelationship(gina, mary);
            relation2.ShowRelationship(lan, mike);
            




            Console.ReadLine();
            }
        }
    }

