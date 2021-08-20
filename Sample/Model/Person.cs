using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Model
{
    record Person(
    Guid Id,
    string GivenNames,
    string FamilyName,
    DateTime DateOfBirth,
    Address Address)
    {
        public string Description => $"{GivenNames} {FamilyName} ({Id})";
        public TimeSpan Age => DateTime.Now - DateOfBirth;
    }
}
