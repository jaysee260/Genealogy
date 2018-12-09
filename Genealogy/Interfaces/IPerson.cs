using Genealogy.Classes.PersonInfo;
using Genealogy.Enums.Person;
using System;

namespace Genealogy.Interfaces
{
    public interface IPerson
    {
        NameInfo Name { get; set; }
        BirthInfo Birth { get; set; }
        RelationsInfo Relations { get; set; }
        Sex Sex { get; set; }
        DateTime? DateOfDeath { get; set; }

        bool IsAlive();
        byte GetAge();
        DateTime GetBirthDate();
        bool IsMarried();
        bool HasSiblings();
    }
}
