using Genealogy.Classes.Abstract;
using Genealogy.Classes.PersonInfo;
using Genealogy.Enums.Person;
using Genealogy.Interfaces;
using System;
using System.Linq;

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

        public Person(NameInfo nameInfo, BirthInfo birthInfo, Sex sex, DateTime? dateOfDeath = null)
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
            return DateOfDeath == null ? true : false; 
        }

        public string GetFullLegalName()
        {
            var possibleMiddleName = Name.Middle == null ? "" : $"{Name.Middle} ";
            var possibleMaidenName = Name.Maiden == null ? "" : $" {Name.Maiden}";
            return $"{Name.First} {possibleMiddleName}{Name.Last}{possibleMaidenName}";
        }

        public string GetFullCasualName()
        {
            string md = Name.Middle;
            string possibleMiddleInitial = md.Equals(string.Empty) || md == null ? " " : $" {Name.Middle.First()}. ";
            return $"{Name.First}{possibleMiddleInitial}{Name.Last}";
        }

        public byte GetAge()
        {
            return base.CalculateAge(Birth.Year, Birth.Month, Birth.Day);
        }

        public DateTime GetBirthDate()
        {
            return new DateTime(Birth.Year, Birth.Month, Birth.Day);
        }

        public bool IsMarried()
        {
            return Relations.Spouse == null ? false : true;
        }

        public bool HasSiblings()
        {
            var siblingsCount = Relations.Siblings.Brothers.Count + Relations.Siblings.Sisters.Count;
            return siblingsCount > 0 ? true : false;
        }

    }
}
