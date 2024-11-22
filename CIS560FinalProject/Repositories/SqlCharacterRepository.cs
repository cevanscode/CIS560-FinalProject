using DataAccess;
﻿
namespace CIS560FinalProject
{
    public class SQLCharacterRepository : ICharacterRepository
    {
        private readonly SqlCommandExecutor executor;

        public SQLCharacterRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Character CreateCharacter(int accountID, string name, int age, int health, int xp, int copper, string className, string subclass, List<Talent> talents)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            var d = new CreateCharacterDataDelegate(accountID, name, age, health, xp, copper, className, subclass, talents);
            return executor.ExecuteNonQuery(d);
        }

        public Character FetchCharacter(int characterID)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Talent> GetCharacterTalents()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Character> RetrieveCharacters()
        {
            throw new NotImplementedException();
        }
    }
}
