using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godiskalkylatorn
{
    [Serializable]
    class CandyCalculator
    {
        public int NumberOfCandies { get; set; }

        private List<Person> Personer { get; set; } = new List<Person>();

        public List<Person> AddPerson(Person personen)
        {
            Personer.Add(personen);
            return Personer;
        }

        public List<Person> GetPeople()
        {
            return Personer;
        }

        public List<Person> DivideCandy(List<Person> listofpeople, double amountOfCandy)
        {

            for (int i = 0; i < listofpeople.Count; i++)
            {
                listofpeople[i].Candies = Math.Truncate(amountOfCandy / listofpeople.Count);
            }

            for (int j = 0; j < amountOfCandy % listofpeople.Count; j++)
            {
                listofpeople[j].Candies += 1;
            }
            return listofpeople;
        }
        public List<Person> DivideCandyByAge(List<Person> listofpeople)
        {
            return listofpeople.OrderBy(x => x.Age).ToList();
        }
        public List<Person> DivideCandyByName(List<Person> listofpeople)
        { 
            return listofpeople.OrderBy(x => x.Firstname).ToList();
        }
    }
     


}