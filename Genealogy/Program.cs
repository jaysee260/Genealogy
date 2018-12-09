using Genealogy.Classes;
using Genealogy.Classes.PersonInfo;
using Genealogy.Enums.Person;
using System;
using System.Collections.Generic;

namespace Genealogy
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameInfo = new NameInfo() { First = "Juan", Middle = "Carlos", Last = "Gonzalez", Maiden = "Molina" };
            var birthInfo = new BirthInfo() { Year = 1990, Month = 11, Day = 5, Place = new BirthPlaceInfo() { City = "Guayaquil", Country = "Ecuador" } };
            var relationsInfo = new RelationsInfo()
            {
                Parents = new ParentsInfo()
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
                                City = "Guayaquil",
                                Country = "Ecuador"
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
                                City = "Guayaquil",
                                Country = "Ecuador"
                            }
                        }
                    }
                },
                Siblings =
                {
                    Sisters = new List<Person>()
                    {
                        new Person()
                    }
                }

            };
            Person p = new Person(nameInfo, birthInfo, Sex.M, null, relationsInfo);
            Console.WriteLine(p.Relations.Parents.Mother.GetFullLegalName());
        }
    }
}
