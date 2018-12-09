using Genealogy.Interfaces.PersonInfo;
using System.Collections.Generic;

namespace Genealogy.Classes.PersonInfo
{
    public class RelationsInfo : IRelationsInfo
    {
        public ParentsInfo Parents { get; set; }
        public SiblingsInfo Siblings { get; set; }
        public GrandparentsInfo Grandparents { get; set; }
        public AuntsInfo Aunts { get; set; }
        public UnclesInfo Uncles { get; set; }
        public CousinsInfo Cousins { get; set; }
        public Person Spouse { get; set; }
        public List<Person> Children { get; set; }
    }
}
