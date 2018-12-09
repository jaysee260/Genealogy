using Genealogy.Interfaces.PersonInfo;
using System;

namespace Genealogy.Classes.PersonInfo
{
    public class BirthInfo : IBirthInfo
    {
        public int Year { get; set; }
        public byte Month { get; set; }
        public byte Day { get; set; }
        public BirthPlaceInfo Place { get; set; }
    }
}
