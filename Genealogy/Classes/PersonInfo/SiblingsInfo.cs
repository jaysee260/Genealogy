using Genealogy.Interfaces.PersonInfo;
using System.Collections.Generic;

namespace Genealogy.Classes.PersonInfo
{
    public class SiblingsInfo : ISiblingsInfo
    {
        public List<Person> Sisters { get; set; }
        public List<Person> Brothers { get; set; }
    }
}
