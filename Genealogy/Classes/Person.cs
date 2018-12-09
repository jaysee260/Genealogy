using Genealogy.Classes.Abstract;
using Genealogy.Classes.PersonInfo;
using Genealogy.Enums.Person;
using Genealogy.Interfaces;
using System;

namespace Genealogy.Classes
{
    public class Person : PersonUtilityMethods, IPerson
    {
        public NameInfo Name { get; set; }
        public BirthInfo Birth { get; set; }
        public RelationsInfo Relations { get; set; }
        public Sex Sex { get; set; }
        public DateTime? DateOfDeath { get; set; }

        public Person()
        {
            //Name = null;
            //Birth = null;
            //Relations = null;
            //Sex = Sex.M;
            //DateOfDeath = null;
        }

        public Person(NameInfo nameInfo, BirthInfo birthInfo, Sex sex, DateTime? dateOfDeath)
        {
            Name = nameInfo;
            Birth = birthInfo;
            Sex = sex;
            DateOfDeath = dateOfDeath;
        }

        public Person(NameInfo nameInfo, BirthInfo birthInfo, Sex sex, DateTime? dateOfDeath, RelationsInfo relationsInfo)
                : this(nameInfo, birthInfo, sex, dateOfDeath)
        {
            Relations = relationsInfo;
        }

        public bool IsAlive()
        {
            return base.CheckIfIsAlive(DateOfDeath);
        }

        public string GetFullLegalName()
        {
            return base.ComposeFullLegalName(Name.First, Name.Middle, Name.Last, Name.Maiden);
        }

        public string GetFullCasualName()
        {
            return base.ComposeFullCasualName(Name.First, Name.Middle, Name.Last);
        }

        public byte GetAge()
        {
            return base.CalculateAge(Birth.Year, Birth.Month, Birth.Day);
        }

        public DateTime GetBirthDate()
        {
            return base.ComposeBirthDate(Birth.Year, Birth.Month, Birth.Day);
        }

        public bool IsMarried()
        {
            return base.CheckIfIsMarried(Relations.Spouse);
        }

        public bool HasSiblings()
        {
            return base.CheckIfHasSiblings(Relations.Siblings);
        }

    }
}
