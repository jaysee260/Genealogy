using Genealogy.Classes;

namespace Genealogy.Interfaces.PersonInfo
{
    public interface IParentsInfo
    {
        Person Father { get; set; }
        Person Mother { get; set; }
    }
}
