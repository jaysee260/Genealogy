using Genealogy.Classes;
using System.Collections.Generic;

namespace Genealogy.Interfaces.PersonInfo
{
    public interface ISiblingsInfo
    {
        List<Person> Siblings { get; set; }
    }
}
