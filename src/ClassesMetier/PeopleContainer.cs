using src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.ClassesMetier
{
    internal class PeopleContainer : IPersonContainer
    {
        private List<Person> people;
        public PeopleContainer()
        {
            people = new List<Person>();
        }
        public void AddPerson(Person person)
        {
            people.Add(person);
        }
        public List<Person> SortByFirstName()
        {
            this.people.Sort(new ComparerPrenom());
            return this.people;
        }

        public List<Person> SortByLastName()
        {
            this.people.Sort(new ComparerNom());
            return this.people;
        }

        public List<Person> People { get { return people; } }
    }
}
