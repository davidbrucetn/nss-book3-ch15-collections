using System;
using System.Collections.Generic;

namespace collections
{
    //Book 1 Chap 15 tabloid - Collections
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Collections!");
            Console.WriteLine("In C#, Lists can only contain one type ->");
            Console.WriteLine("List<int> yearsBorn = new List<int>(){");
            Console.WriteLine("   1967, 1969, 1972");
            Console.WriteLine($"}};  ^^^ You can't have \"1967\" in there.");

            //Dictionary is used for key/value object pairs
            Dictionary<string, int> toysSold = new Dictionary<string, int>()
            { { "Hot WHeels", 344 }, { "Legos", 762 }, { "Gaming Consoles", 132 }, { "Board Games", 482 }
            };
            // Add some toys
            toysSold.Add("Uno Cards", 1201);

            //Use a method for it to see if it contains something:
            Console.WriteLine($"Does this dictionary contain Uno Cards? {toysSold.ContainsKey("Uno Cards")}");
            Console.WriteLine($"How may of those? ^^ -> {toysSold["Uno Cards"]}");

            Console.WriteLine("Let's do a foreach(KeyValuePair<string, int> toy in toysSold) for loop writeline: ");
            foreach (KeyValuePair<string, int> toy in toysSold)
            {
                Console.WriteLine($"We sold {toy.Value} units of {toy.Key}");
            }

            // How bout them lists?
            Console.WriteLine();
            Console.WriteLine("How bout them lists? ---------------------------------------->");
            Console.WriteLine($"List<string> students = new List<string>()");
            Console.WriteLine("{{  \"Megan,\"");
            Console.WriteLine("}}");
            Console.WriteLine("students.Add(\"Melanie\");");
            List<string> students = new List<string>()
            {
                "Megan",
                "Damon",
                "Chase",
                "Tekisha",
                "Castle",
                "Mark",
                "Keith",
                "Adam",
                "Patrick",
                "Hannah",
                "Mike"
            };

            // Can't do this easily with a base array
            students.Add("Melanie");
            students.Insert(3, "Simon");

            if (students.Contains("Chase"))
            {
                Console.WriteLine("Must be cohort 13");
            }

            // This looks a lot like JavaScript!
            students.ForEach(stu => Console.WriteLine(stu));

        }
    }
}