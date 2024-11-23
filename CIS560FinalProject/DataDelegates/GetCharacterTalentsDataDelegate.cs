using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject
{
    internal class GetCharacterTalentsDataDelegate : DataReaderDelegate<IReadOnlyList<Talent>>
    {
        private readonly string username;
        private readonly string password;

        public GetCharacterTalentsDataDelegate(string username, string password)
            : base("GetTalentsForCharacter")
        {
            this.username = username;
            this.password = password;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Username", username);
            command.Parameters.AddWithValue("Password", password);
        }

        public override IReadOnlyList<Talent> Translate(Command command, IDataRowReader reader)
        {
            var talents = new List<Talent>();

            while (reader.Read())
            {
                talents.Add(new Talent(
                    reader.GetString("TalentName"),
                    reader.GetString("TalentDescription"),
                    (Rank)reader.GetInt32("TalentRank"),
                    (TalentType)reader.GetInt32("TalentType")));
            }

            return talents;
        }
    }
}
