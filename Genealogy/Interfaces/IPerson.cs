using Genealogy.Classes.PersonInfo;
using Genealogy.Enums.Person;

namespace Genealogy.Interfaces
{
    public interface IPerson
    {
        NameInfo Name { get; set; }
        BirthInfo Birth { get; set; }
        RelationsInfo Relations { get; set; }
        Sex Sex { get; set; }
    }
}
