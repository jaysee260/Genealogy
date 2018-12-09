using System;

namespace Genealogy.Classes.Abstract
{
    public abstract class PersonUtilityMethods
    {

        protected bool CheckIfIsAlive()
        {
            // Whatever calculations or operations would go here.
            // This is mainly to reduce noise in the Person class.
            return true;
        }

        protected byte CalculateAge(int year, byte month, byte day)
        {
            DateTime Dob = Convert.ToDateTime($"{year}/{month}/{day}");
            return (byte)(new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1);
        }
    }
}
