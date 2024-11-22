using DataAccess;
﻿
namespace CIS560FinalProject
{
    internal class SqlClassRepository : IClassRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlClassRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Class UpdateClass(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(description));

            var d = new UpdateClassDataDelegate(name, description);
            return executor.ExecuteNonQuery(d);
        }

        public Class GetClass(string name)
        {
            var d = new GetClassDataDelegate(name);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Class> RetrieveClasses()
        {
            return executor.ExecuteReader(new RetrieveClassesDataDelegate());
        }
    }
}
