using Genealogy.Classes.PersonInfo;

namespace Genealogy.Interfaces.PersonInfo
{
    public interface IBirthInfo
    {
        int Year { get; set;  }
        byte Month { get; set; }
        byte Day { get; set; }
        BirthPlaceInfo Place { get; set; }
    }
}
