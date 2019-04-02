using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class PersonHandler                                     // hanterar att hämta och sätta parameterarna i Person
    {
        private int age;

        public int GetAge()
        {
          return age;
        }

        public void SetAge(Person pers,int age)             //3.1.2
        {
            pers.Age = age;                                 //hämta ålder, namn osv
        }
        
        public void SetfName(Person pers, string fName)
        {
            pers.Fname = fName;
        }
        public void SetlName(Person pers, string lName)
        {
            pers.Lname = lName;
        }
        public void Setheight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
        
        // Skapa en ny person
        // public=access, Person=returtyp, CreatePerson=metodnamn, (....)=parameterlista
        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            return new Person(age, fName, lName, height, weight); //returnera ny person
        }
    }
}
