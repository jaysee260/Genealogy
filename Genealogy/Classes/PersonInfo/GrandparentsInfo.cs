using Genealogy.Interfaces.PersonInfo;

namespace Genealogy.Classes.PersonInfo
{
    public class GrandparentsInfo : IGrandparentsInfo
    {
        public GrandparentInfo Grandmother { get; set; }
        public GrandparentInfo Grandfather { get; set; }
    }
}
