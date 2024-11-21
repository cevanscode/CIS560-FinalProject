using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject
{
    public class SQLCharacterRepository : ICharacterRepository
    {
        public Character CreateCharacter(int accountID, string name, int age, int health, uint xp, int copper, Class characterClass, Subclass subclass, List<Talent> talents)
        {
            throw new NotImplementedException();
        }

        public Character FetchCharacter(int characterID)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Character> GetAllCharacters()
        {
            throw new NotImplementedException();
        }
    }
}
