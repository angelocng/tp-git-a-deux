using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.ClassesMetier
{
    internal class Person
    {
        private string prenom;
        private string nom;
        public Person(string prenom, string nom)
        {
            this.prenom = prenom;
            this.nom = nom;
        }

        public string Prenom {get; private set;}
        public string Nom {get; private set;}
    }
}
