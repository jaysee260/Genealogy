namespace Genealogy.Interfaces.PersonInfo
{
    public interface INameInfo
    {
        string First { get; set; }
        string Middle { get; set; }
        string Last { get; set; }
        string Maiden { get; set; }
    }
}
