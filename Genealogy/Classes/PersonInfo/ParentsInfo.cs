using Genealogy.Interfaces.PersonInfo;

namespace Genealogy.Classes.PersonInfo
{
    public class ParentsInfo : IParentsInfo
    {
        public Person Father { get; set; }
        public Person Mother { get; set; }
    }
}
