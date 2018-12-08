using Genealogy.Interfaces.PersonInfo;
using System.Collections.Generic;

namespace Genealogy.Classes.PersonInfo
{
    public class AuntsInfo: IAuntsInfo
    {
        public List<Person> Maternal { get; set; }
        public List<Person> Paternal { get; set; }
    }
}
