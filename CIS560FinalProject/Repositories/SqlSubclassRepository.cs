using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject
{
    public class SqlSubclassRepository : ISubclassRepository
    {
        public Subclass CreateSubclass(string? name, string? description)
        {
            throw new NotImplementedException();
        }

        public Subclass FetchSubclass(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Subclass> GetAllSubclasses()
        {
            throw new NotImplementedException();
        }
    }
}
