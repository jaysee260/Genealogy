using Genealogy.Classes;
using Genealogy.Classes.PersonInfo;
using System.Collections.Generic;

namespace Genealogy.Interfaces.PersonInfo
{
    public interface IRelationsInfo
    {
        ParentsInfo Parents { get; set; }
        SiblingsInfo Siblings { get; set; }
        GrandparentsInfo Grandparents { get; set; }
        AuntsInfo Aunts { get; set; }
        UnclesInfo Uncles { get; set; }
        CousinsInfo Cousins { get; set; }
        Person Spouse { get; set; }
        List<Person> Children { get; set; }
    }
}
