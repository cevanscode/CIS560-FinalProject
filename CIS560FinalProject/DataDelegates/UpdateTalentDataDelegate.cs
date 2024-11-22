using DataAccess;
using System.Data;

namespace CIS560FinalProject
{
    internal class UpdateTalentDataDelegate : NonQueryDataDelegate<Talent>
    {
        public readonly string name;
        public readonly string description;
        public readonly Rank rank;
        public readonly TalentType type;

        public UpdateTalentDataDelegate(string name, string description, Rank rank, TalentType type)
            : base("UpdateTalent")
        {
            this.name = name;
            this.description = description;
            this.rank = rank;
            this.type = type;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Description", description);
            command.Parameters.AddWithValue("Rank", rank);
            command.Parameters.AddWithValue("Type", type);

            var p = command.Parameters.Add("TalentID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Talent Translate(Command command)
        {
            return new Talent(command.GetParameterValue<int>("TalentID"), name, description, rank, type);
        }
    }
}
