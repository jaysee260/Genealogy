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
        string GetFullLegalName();
        string GetFullCasualName();
        byte GetAge();
        DateTime GetBirthDate();
    }
}
