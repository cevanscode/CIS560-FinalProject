
using static System.Windows.Forms.LinkLabel;
using System.CodeDom.Compiler;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DataAccess;

namespace CIS560FinalProject
{
    public class SqlTalentRepository : ITalentRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlTalentRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Talent UpdateTalent(string name, string description, Rank rank, TalentType type)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(description));

            var d = new CreateTalentDataDelegate(name, description, rank, type);
            return executor.ExecuteNonQuery(d);
        }

        public Talent GetTalent(string name)
        {
            var d = new GetTalentDataDelegate(name);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Talent> RetrieveTalents()
        {
            return executor.ExecuteReader(new RetrieveTalentsDataDelegate());
        }

        public IReadOnlyList<Talent> RetrieveTalentsForClass(string className)
        {
            return executor.ExecuteReader(new RetrieveTalentsForClassDataDelegate(className));
        }

        public IReadOnlyList<Talent> RetrieveTalentsForSubclass(string subclassName)
        {
            return executor.ExecuteReader(new RetrieveTalentsForSubclassDataDelegate(subclassName));
        }
    }
}
