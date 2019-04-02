using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    // 1 skapa en klass Person och ge den följande privata attribut: age, fName, lName, height, weight

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(20, "Kalle", " anka", 120, 50);       //3.1.1

            person.Age = 10;
            int ålder = person.Age;             //hämtar publika fältet Age från Person.cs
            person.Fname = "Mike";
            person.Lname = "Bukowski";
            person.Height = 182;
            person.Weight = 85;

        }
    }
}
