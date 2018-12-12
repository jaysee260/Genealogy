using Genealogy.Classes.PersonInfo;
using Genealogy.Enums.Person;
using Genealogy.Interfaces;
using System;
using System.Linq;
using static System.String;

namespace Genealogy.Classes
{
    public class Person : IPerson
    {
        // Properties
        public NameInfo Name { get; set; }
        public BirthInfo Birth { get; set; }
        public RelationsInfo Relations { get; set; }
        public Sex Sex { get; set; }
        public DateTime? DateOfDeath { get; set; }

        // Constructors
        public Person()
        {
            Name = null;
            Birth = null;
            Relations = null;
            Sex = 0;
            DateOfDeath = null;
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

        // Methods
        public bool IsAlive()
        {
            return DateOfDeath == null ? true : false;
        }

        public string GetFullLegalName()
        {
            // leave the whitespaces
            var possibleMiddleName = IsNullOrWhiteSpace(Name.Middle) ? " " : $" {Name.Middle} ";
            var possibleMaidenName = IsNullOrWhiteSpace(Name.Maiden) ? "" : $" {Name.Maiden}";
            return $"{Name.First}{possibleMiddleName}{Name.Last}{possibleMaidenName}";
        }

        public string GetFullCasualName()
        {
            var possibleMiddleInitial = IsNullOrWhiteSpace(Name.Middle) ? " " : $" {Name.Middle.First()}. ";
            return $"{Name.First}{possibleMiddleInitial}{Name.Last}";
        }

        public byte GetAge()
        {
            DateTime Dob = Convert.ToDateTime($"{Birth.Year}/{Birth.Month}/{Birth.Day}");
            var Age = (byte)(new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1);
            return Age;
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
            var count = Relations.Siblings.Brothers.Count + Relations.Siblings.Sisters.Count;
            return count > 0 ? true : false;
        }

    }
}
