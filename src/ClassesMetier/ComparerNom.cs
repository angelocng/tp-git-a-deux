using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.ClassesMetier
{
    internal class ComparerNom : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            return x.Nom.CompareTo(y.Nom);
        }
    }
}
