using DataAccess;
using System.Data;

namespace CIS560FinalProject
{
    internal class GetTalentDataDelegate : DataReaderDelegate<Talent>
    {
        private readonly string name;

        public GetTalentDataDelegate(string name)
            : base("GetTalent")
        {
            this.name = name;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
        }

        public override Talent Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Talent(reader.GetInt32("TalentID"), name, reader.GetString("Description"), (Rank)reader.GetInt32("Rank"), (TalentType)reader.GetInt32("Type"));
            // Note Rank and Type will likely need updated
        }
    }
}
