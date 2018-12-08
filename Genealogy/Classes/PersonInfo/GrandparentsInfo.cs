using System;
using System.Collections.Generic;
using System.Text;
using Genealogy.Interfaces.PersonInfo;

namespace Genealogy.Classes.PersonInfo
{
    public class GrandparentsInfo : IGrandparentsInfo
    {
        public Person MaternalGrandfather { get; set; }
        public Person MaternalGrandmother { get; set; }
        public Person PaternalGrandfather { get; set; }
        public Person PaternalGrandmother { get; set; }
    }
}
