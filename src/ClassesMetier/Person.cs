using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.ClassesMetier
{
    internal class Person
    {
        public Person(string prenom, string nom)
        {
            this.Prenom = prenom;
            this.Nom = nom;
        }

        public string Prenom {get; private set;}
        public string Nom {get; private set;}
    }
}
