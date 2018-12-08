using Genealogy.Interfaces.PersonInfo;
using System.Collections.Generic;

namespace Genealogy.Classes.PersonInfo
{
    public class UnclesInfo : IUnclesInfo
    {
        public List<Person> Maternal { get; set; }
        public List<Person> Paternal { get; set; }
    }
}
