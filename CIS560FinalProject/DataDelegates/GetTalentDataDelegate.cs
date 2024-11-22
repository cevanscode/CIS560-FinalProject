using DataAccess;
using System.Data;

namespace CIS560FinalProject
{
    internal class GetTalentDataDelegate : DataReaderDelegate<Talent>
    {
        private readonly string name;

        public GetTalentDataDelegate(string name)
            : base("GetTalent") // Make sure matches Procedure
        {
            this.name = name;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("TalentName", name);
        }

        public override Talent Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Talent(name, reader.GetString("TalentDescription"), (Rank)reader.GetInt32("TalentRank"), (TalentType)reader.GetInt32("TalentCategoryID"));
            // Note Rank and Type will likely need updated
        }
    }
}
