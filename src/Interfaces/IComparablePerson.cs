using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Interfaces
{
    internal interface IComparerPerson
    {
        int ComparePrenom(object? x, object? y);
        int CompareNom(object? x, object? y);
    }
}
