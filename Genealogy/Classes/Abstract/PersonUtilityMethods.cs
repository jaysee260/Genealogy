using System;
using System.Linq;
using Genealogy.Classes.PersonInfo;

/*
    A thought on the possible usefulness of this method:
    Having your person utility methods here would require
    that they take parameters.
    This would make your person utility methods far easier to test,
    because you know what it's supposed to return when passed X arguments of Y type each.
*/

namespace Genealogy.Classes.Abstract
{
    // For any methods that may grow verbose. Or just because.
    public abstract class PersonUtilityMethods
    {
        protected bool CheckIfIsAlive(DateTime? dateOfDeath)
        {
            return dateOfDeath == null ? true : false;
        }

        protected string ComposeFullLegalName(string firstName, string middleName, string lastName, string maidenName)
        {
            var possibleMiddleName = middleName == null ? "" : $"{middleName} ";
            var possibleMaidenName = maidenName == null ? "" : $" {maidenName}";
            return $"{firstName} {possibleMiddleName}{lastName}{possibleMaidenName}";
        }

        protected string ComposeFullCasualName(string firstName, string middleName, string lastName)
        {
            string md = middleName;
            string possibleMiddleInitial = md.Equals(string.Empty) || md == null ? " " : $" {middleName.First()}. ";
            return $"{firstName}{possibleMiddleInitial}{lastName}";
        }

        protected byte CalculateAge(int year, byte month, byte day)
        {
            DateTime Dob = Convert.ToDateTime($"{year}/{month}/{day}");
            return (byte)(new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1);
        }

        protected DateTime ComposeBirthDate(int year, byte month, byte day)
        {
            return new DateTime(year, month, day);
        }

        protected bool CheckIfIsMarried(Person spouse)
        {
            return spouse == null ? false : true;
        }

        protected bool CheckIfHasSiblings(SiblingsInfo siblings)
        {
            var count = siblings.Brothers.Count + siblings.Sisters.Count;
            return count > 0 ? true : false;
        }

    }
}
