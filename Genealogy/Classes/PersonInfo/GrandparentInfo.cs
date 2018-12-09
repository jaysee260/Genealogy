using Genealogy.Interfaces.PersonInfo;

namespace Genealogy.Classes.PersonInfo
{
    public class GrandparentInfo : IGrandparentInfo
    {
        public Person Maternal { get; set; }
        public Person Paternal { get; set; }
    }
}
