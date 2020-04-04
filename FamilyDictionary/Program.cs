using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family1 = new Family()
            {
                Relation = "Sister",
                Name = "Adrienne",
                Age = 40
            };

            Family family2 = new Family()
            {
                Relation = "Brother",
                Name = "Johnathan",
                Age = 42
            };
            Family family3 = new Family()
            {
                Relation = "GodSister",
                Name = "Donna",
                Age = 41
            };


            Dictionary <string, Family> myFamily = new Dictionary<string, Family>();

            myFamily.Add(family1.Relation, family1);
            myFamily.Add(family2.Relation, family2);
            myFamily.Add(family3.Relation, family3);

            Family mySister = myFamily["Sister"];
            Console.WriteLine($"I love {mySister.Name}");

            foreach (KeyValuePair<string, Family> familyKeyValuePair in myFamily)
            {
                Family familyVal = familyKeyValuePair.Value;
                Console.WriteLine($"I love my {familyVal.Relation} {familyVal.Name}.\n {familyVal.Name} is  the best {familyVal.Age} year old I know!");
            }


        }
    }
}
