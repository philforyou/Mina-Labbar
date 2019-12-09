using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godiskalkylatorn
{
    [Serializable]
    class Person
    {
        public int Age { get; set; }

        public double Candies { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public Person SkapaPerson(string firstname, int age)
        {
            Person person = new Person();
            person.Firstname = firstname;
            person.Age = age;
            return person;
        }





    }
}