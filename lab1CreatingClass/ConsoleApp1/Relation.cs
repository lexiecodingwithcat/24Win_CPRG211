using System;



namespace ConsoleApp1
    {
    internal class Relation
        {
        string RelationshipType;

        public Relation(string relationshipType)
            {
            this.RelationshipType = relationshipType;
            }

            public void ShowRelationship(Person person1, Person person2)
                {
                Console.WriteLine($"Relationship between {person1.firstName} and {person2.firstName} is: {RelationshipType}hood");
                }
        }
    }
