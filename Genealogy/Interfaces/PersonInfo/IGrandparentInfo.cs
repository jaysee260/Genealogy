using Genealogy.Classes;

namespace Genealogy.Interfaces.PersonInfo
{
    public interface IGrandparentInfo // Singular
    {
        Person Maternal { get; set; }
        Person Paternal { get; set; }
    }
}
