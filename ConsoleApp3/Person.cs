using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Person
    {
        //private int age;

        //public int GetAge()
        //{
        //return age;
        //}

        //public void SetAge(int age)
        //{
        //    this.age = age;
        //}

        //public int Age { get; set; } // denna rad är samma som raderna 25-34

        private int age;                // skapa privat fält
        public int Age                  // skapa publikt fält
        {
            get { return age; }         // lämna värdet
            set                         // hämta värdet, med villkor
            {
                if(value > 0)
                age = value;
            }
        }

        private string fName;
        public string Fname { get; set; }

        private string lName;
        public string Lname { get; set; }

        private double height;
        public double Height { get; set; }

        private double weight;
        public double Weight { get; set; }

        // konstruktor för att hantera metoden. CreatePerson i PersonHandler
        public Person(int age, string fName, string lName, double height, double weight)
        {
            this.age = age;
            this.fName = fName;
            this.lName = lName;
            this.height = height;
            this.weight = weight;
        }

       
    }

}
