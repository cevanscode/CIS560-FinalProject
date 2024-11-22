using CIS560FinalProject.Models;

namespace CIS560FinalProject.Repositories
{
    public class SqlTalentRepository : ITalentRepository
    {
        public Talent CreateTalent(string name, string description, int rank, TalentType type)
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
