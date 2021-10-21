using System.Collections.Generic;
using TechTest.Repositories.Models;

namespace TechTest.Controllers.Models
{
    public class PersonUpdate
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool Authorised { get; set; }

        public bool Enabled { get; set; }

        public IEnumerable<Colour> Colours { get; set; }
    }
}
