using Genealogy.Interfaces.PersonInfo;
using System.Collections.Generic;

namespace Genealogy.Classes.PersonInfo
{
    public class CousinsInfo : ICousinsInfo
    {
        public List<Person> Maternal { get; set; }
        public List<Person> Paternal { get; set; }
    }
}
