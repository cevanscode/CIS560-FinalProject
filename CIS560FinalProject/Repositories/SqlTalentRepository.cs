using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject
{
    public class SqlTalentRepository : ITalentRepository
    {
        public Talent CreateTalent(string? name, string? description, int rank, string? type)
        {
            throw new NotImplementedException();
        }

        public Talent FetchTalent(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Talent> GetAllTalents()
        {
            throw new NotImplementedException();
        }
    }
}
