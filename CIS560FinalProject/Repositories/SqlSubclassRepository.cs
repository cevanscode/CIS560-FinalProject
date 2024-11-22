
using DataAccess;
using System.CodeDom.Compiler;

namespace CIS560FinalProject
{
    public class SqlSubclassRepository : ISubclassRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlSubclassRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Subclass UpdateSubclass(int classID, string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(description));

            var d = new UpdateSubclassDataDelegate(classID, name, description);
            return executor.ExecuteNonQuery(d);
        }

        public Subclass GetSubclass(string name)
        {
            var d = new GetSubclassDataDelegate(name);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Subclass> RetrieveSubclasses()
        {
            throw new NotImplementedException();
        }
    }
}
