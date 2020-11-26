using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDeveloperTeams
{
    public class DeveloperRepo
    {
        private readonly List<Developer> _developerDirectory = new List<Developer>(); //<-- _developerDirectory is a field

        //Developer Create
        public void AddDevToList(Developer devcontent)
        {
            _developerDirectory.Add(devcontent);
        }
        //Developer Read
        public List<Developer> GetDevList()
        {
            return _developerDirectory;
        }
        //Developer Update
        //Developer Delete

        //Developer Helper (Get Developer by ID)
    }
}
