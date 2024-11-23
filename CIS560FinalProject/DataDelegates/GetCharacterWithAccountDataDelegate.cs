using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace CIS560FinalProject
{
    internal class GetCharacterWithAccountDataDelegate : DataReaderDelegate<Character>
    {
        private readonly string username;
        private readonly string password;
        private readonly List<Talent> talents;

        public GetCharacterWithAccountDataDelegate(string username, string password, List<Talent> talents)
            : base("GetCharacter")
        {
            this.username = username;
            this.password = password;
            this.talents = talents;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Username", username);
            command.Parameters.AddWithValue("Password", password);
        }

        public override Character Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException($"No account found for Username: {username}");

            return new Character(
                reader.GetString("CharacterName"),
                reader.GetInt32("CharacterAge"),
                reader.GetInt32("Health"),
                reader.GetInt32("XP"),
                reader.GetInt32("Copper"),
                reader.GetString("ClassName"),
                reader.GetString("SubclassName"),
                talents);
        }
    }
}
