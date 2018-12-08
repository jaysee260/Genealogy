using Genealogy.Interfaces.PersonInfo;

namespace Genealogy.Classes.PersonInfo
{
    public class NameInfo : INameInfo
    {
        public string First { get; set; }
        public string Middle { get; set; }
        public string Last { get; set; }
        public string Maiden { get; set; }
    }
}
