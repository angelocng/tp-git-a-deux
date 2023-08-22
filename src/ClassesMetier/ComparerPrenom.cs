using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.ClassesMetier
{
    internal class ComparerPrenom : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            return x.Prenom.CompareTo(y.Prenom);
        }
    }
}
