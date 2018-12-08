using Genealogy.Interfaces.PersonInfo;

namespace Genealogy.Classes.PersonInfo
{
    public class BirthPlaceInfo : IBirthPlaceInfo
    {
        public string City { get; set; }
        public string Country { get; set; }
    }
}
