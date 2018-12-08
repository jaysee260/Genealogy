using Genealogy.Classes;
using System.Collections.Generic;

namespace Genealogy.Interfaces.PersonInfo
{
    public interface IAuntsInfo
    {
        List<Person> Maternal { get; set; }
        List<Person> Paternal { get; set; }
    }
}
