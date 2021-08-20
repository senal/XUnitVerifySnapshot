using Sample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class PersonBuilder
    {
        public static List<Person> People = new()
        {
            new(
                Id: new ("e7b6b3f8-5db5-4fdc-877a-f0512f67d68a"),
                GivenNames: "Emmy",
                FamilyName: "Annachiara",
                DateOfBirth: new (2000, 1, 2, 0, 0, 0),
                Address: new(
                    street: "30 Greenwood Parkway",
                    city: "Jordan Springs",
                    state: "NSW"
                ))
            ,
            new
            (
                Id: new("88a56488-115a-4544-81cb-439e821bdb73"),
                GivenNames: "Manoj",
                FamilyName: "Silva",
                DateOfBirth: new(1982, 3, 8, 0, 0, 0),
                Address: new(
                    street: "20 High Street",
                    city: "Bankstown",
                    state: "NSW"
                )
            )

        };

        public static Person Find (Guid id)
        {
            return People.SingleOrDefault(i => i.Id == id);
        }

        public static IEnumerable<Person> FindAll()
        {
            return People;
        }
        
    }
}
