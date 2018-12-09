using Genealogy.Classes;
using System.Collections.Generic;

namespace Genealogy.Interfaces.PersonInfo
{
    public interface ICousinsInfo
    {
        List<Person> Maternal { get; set; }
        List<Person> Paternal { get; set; }
    }
}
