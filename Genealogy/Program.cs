using Genealogy.Classes;
using Genealogy.Classes.PersonInfo;
using Genealogy.Enums.Person;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Genealogy
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameInfo = new NameInfo()
            {
                First = "Juan", Middle = "Carlos", Last = "Gonzalez", Maiden = "Molina"
            };

            var birthInfo = new BirthInfo()
            {
                Year = 1990, Month = 11, Day = 5,
                Place = new BirthPlaceInfo()
                {
                    City = "Guayaquil", Country = "Ecuador"
                }
            };

            var parentsInfo = new ParentsInfo()
            {
                Father = new Person()
                {
                    Name = new NameInfo()
                    {
                        First = "Juan", Middle = "Carlos", Last = "Gonzalez", Maiden = "Almeida"
                    },
                    Birth = new BirthInfo()
                    {
                        Year = 1965, Month = 11, Day = 21,
                        Place = new BirthPlaceInfo()
                        {
                            City = "Guayaquil", Country = "Ecuador"
                        }
                    }
                },
                Mother = new Person()
                {
                    Name = new NameInfo()
                    {
                        First = "Sandra", Middle = "Lorena", Last = "Molina", Maiden = "Intriago"
                    },
                    Birth = new BirthInfo()
                    {
                        Year = 1966, Month = 10, Day = 22,
                        Place = new BirthPlaceInfo()
                        {
                            City = "Guayaquil", Country = "Ecuador"
                        }
                    }
                }
            };

            var sisterInfo = new Person()
            {
                Name = new NameInfo()
                {
                    First = "Andrea", Middle = "Cristina", Last = "Gonzalez", Maiden = "Molina"
                },
                Birth = new BirthInfo()
                {
                    Year = 1993, Month = 11, Day = 12,
                    Place = new BirthPlaceInfo()
                    {
                        City = "Guayaquil", Country = "Ecuador"
                    }
                }
            };

            var siblingsInfo = new SiblingsInfo()
            {
                Sisters = new List<Person>()
                {
                    sisterInfo
                },
                Brothers = new List<Person>()
            };

            var grandparentsInfo = new GrandparentsInfo()
            {
                Grandfather = new GrandparentInfo()
                {
                    Maternal = new Person()
                    {
                        Name = new NameInfo()
                        {
                            First = "Wilson", Middle = "Raul", Last = "Molina", Maiden = "Del Rio", 
                        }
                    },
                    Paternal = new Person()
                },
                Grandmother = new GrandparentInfo()
                {
                    Maternal = new Person()
                    {
                        Name = new NameInfo()
                        {
                            First = "Ángela", Middle = "Carolina", Last = "Intriago", Maiden = "Vasquez" 
                        },
                        Birth = new BirthInfo()
                        {
                            Year = 1942, Month = 8, Day = 2,
                            Place = new BirthPlaceInfo()
                            {
                                City = "Guayaquil", Country = "Ecuador"
                            }
                        }
                    },
                    Paternal = new Person()
                }
            };

            var relationsInfo = new RelationsInfo()
            {
                Parents = parentsInfo,
                Siblings = siblingsInfo,
                Grandparents = grandparentsInfo
            };

            Person p = new Person(nameInfo, birthInfo, Sex.M, null, relationsInfo);
            // .Where() returns an IEnumerable<Person>.
            // We want the first item of these results.
            Person sister = p.Relations.Siblings.Sisters.Where(sis => sis.Name.First == "Andrea").First();
            Console.WriteLine(sister.GetFullCasualName());
        }
    }
}
