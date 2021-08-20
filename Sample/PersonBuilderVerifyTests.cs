using Sample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VerifyTests;
using VerifyXunit;
using Xunit;

namespace Sample
{

    [UsesVerify]
    public class PersonBuilderVerifyTests
    {

        static VerifySettings verifySettings;

        static PersonBuilderVerifyTests()
        {
            verifySettings = new();
            verifySettings.ScrubInlineGuids();
            verifySettings.ModifySerialization(
                settings => settings.IgnoreMember<Person>(target => target.Age));
        }

        [Fact]
        public async Task  Find()
        {
            var id = new Guid("e7b6b3f8-5db5-4fdc-877a-f0512f67d68a");
            var person = PersonBuilder.Find(id);
            await Verifier.Verify(person, verifySettings);

        }

        [Fact]                                    
        public async Task FindAll()
        {
            var people = PersonBuilder.FindAll();
            await Verifier.Verify(people, verifySettings);

        }
           
        

    }
}
