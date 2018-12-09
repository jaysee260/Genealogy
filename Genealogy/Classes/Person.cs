using Genealogy.Classes.PersonInfo;
using Genealogy.Enums.Person;
using Genealogy.Interfaces;
using System;
using Genealogy.Classes.Abstract;

namespace Genealogy.Classes
{
    public class Person : PersonUtilityMethods, IPerson
    {
        public NameInfo Name { get; set; }
        public BirthInfo Birth { get; set; }
        public RelationsInfo Relations { get; set; }
        public Sex Sex { get; set; }
        public DateTime? DateOfDeath { get; set; }

        public bool IsAlive()
        {
            return DateOfDeath == null ? true : false; 
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
            
            return Relations.Spouse != null ? true : false;
        }

        public bool HasSiblings()
        {
            return Relations.Siblings.Count > 0 ? true : false;
        }

    }
}
