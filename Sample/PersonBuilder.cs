using Sample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    static class PersonBuilder
    {
        static List<Person> People = new()
        {
            new Person()
            {
                Id = new Guid("e7b6b3f8-5db5-4fdc-877a-f0512f67d68a"),
                GivenNames = "Emmy",
                FamilyName = "Annachiara",
                DateOfBirth = new DateTime(2000, 1, 2, 0, 0, 0),
                Address = new Address
                {
                    Street = "30 Greenwood Parkway",
                    City = "Jordan Springs",
                    State = "NSW"
                }
            }
            ,
            new Person()
            {
                Id = new Guid("88a56488-115a-4544-81cb-439e821bdb73"),
                GivenNames = "",
                FamilyName = "",
                DateOfBirth = new DateTime(1982, 3, 8, 0, 0, 0),
                Address = new Address
                {
                    Street = "20 High Street",
                    City =  "Bankstown",
                    State = "NSW"
                }
            }
        };

        public static Person Find (Guid id)
        {
            return People.SingleOrDefault(i => i.Id == id);
        }
        
    }
}
