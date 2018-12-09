using Genealogy.Classes;
using System.Collections.Generic;

namespace Genealogy.Interfaces.PersonInfo
{
    public interface ISiblingsInfo
    {
        List<Person> Sisters { get; set; }
        List<Person> Brothers { get; set; }
    }
}
