using Genealogy.Classes.PersonInfo;
using Genealogy.Enums.Person;
using Genealogy.Interfaces;

namespace Genealogy.Classes
{
    public class Person : IPerson
    {
        public NameInfo Name { get; set; }
        public BirthInfo Birth { get; set; }
        public RelationsInfo Relations { get; set; }
        public Sex Sex { get; set; }
    }
}
