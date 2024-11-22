using CIS560FinalProject.Models;

namespace CIS560FinalProject.Repositories
{
    public class SqlSubclassRepository : ISubclassRepository
    {
        public Subclass CreateSubclass(string name, string description, SubclassType type)
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
