using Genealogy.Classes;

namespace Genealogy.Interfaces.PersonInfo
{
    public interface IGrandparentsInfo
    {
        Person MaternalGrandfather { get; set; }
        Person MaternalGrandmother { get; set; }
        Person PaternalGrandfather { get; set; }
        Person PaternalGrandmother { get; set; }
    }
}
