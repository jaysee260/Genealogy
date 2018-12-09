using System;

namespace Genealogy.Classes.Abstract
{
    // For any methods that may grow verbose. Or just because.
    public abstract class PersonUtilityMethods
    {
        protected byte CalculateAge(int year, byte month, byte day)
        {
            DateTime Dob = Convert.ToDateTime($"{year}/{month}/{day}");
            return (byte)(new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1);
        }
    }
}
