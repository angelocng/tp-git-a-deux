using src.Interfaces;
using System;
using System.Collections;
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
        public string Prenom { get { return prenom; } }
        public string Nom { get { return nom; } }
        public Person(string prenom, string nom)
        {
            this.prenom = prenom;
            this.nom = nom;
        }
    }
}
