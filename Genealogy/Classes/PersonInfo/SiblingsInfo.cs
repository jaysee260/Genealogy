using Genealogy.Interfaces.PersonInfo;
using System.Collections.Generic;

namespace Genealogy.Classes.PersonInfo
{
    public class SiblingsInfo : ISiblingsInfo
    {
        public List<Person> Siblings { get; set; }
    }
}
