using System;
using System.Collections.Generic;


namespace ConsoleApp1
    {
    internal class Relation
        {
        string RelationshipType;

        public Relation(string relationshipType)
            {
            this.RelationshipType = relationshipType;
            }


            List<string> relationshipType = new List<string> { "mother", "father", "sister", "brother" };

            public void ShowRelationship(Person person1, Person person2)
                {
                Console.WriteLine($"Relationship between {person1.firstName} and {person2.firstName} is {RelationshipType}hood");
                }
        }
    }
