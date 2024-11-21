using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject
{
    internal class SqlClassRepository : IClassRepository
    {
        public Class CreateClass(string? name, string? description)
        {
            throw new NotImplementedException();
        }

        public Class FetchClass(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Class> GetAllClasses()
        {
            throw new NotImplementedException();
        }
    }
}
