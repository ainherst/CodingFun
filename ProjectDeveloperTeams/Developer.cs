using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDeveloperTeams
{
    public class Developer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public bool PluralSightAccess { get; set; }
        // public int TeamNumber { get; set; } <-I don't know if they need to have a team number assigned to them, the ID should be sufficient..

        public Developer() { }

        public Developer(string firstName, string lastName, string iD, bool pluralSightAccess)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = iD;
            PluralSightAccess = pluralSightAccess;
        }
    }
}
