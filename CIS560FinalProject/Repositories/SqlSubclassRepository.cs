
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

        public Subclass UpdateSubclass(string name, string description, string className)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(description));
            if (string.IsNullOrWhiteSpace(className))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(className));

            var d = new UpdateSubclassDataDelegate(name, description, className);
            return executor.ExecuteNonQuery(d);
        }

        public Subclass GetSubclass(string name, string className)
        {
            var d = new GetSubclassDataDelegate(name, className);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Subclass> RetrieveSubclasses(string className)
        {
            return executor.ExecuteReader(new RetrieveSubclassesDataDelegate(className));
        }
    }
}
