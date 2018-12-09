using Genealogy.Classes.PersonInfo;

namespace Genealogy.Interfaces.PersonInfo
{
    public interface IGrandparentsInfo // Plural
    {
        GrandparentInfo Grandfather  { get; set; }
        GrandparentInfo Grandmother { get; set; }
    }
}
