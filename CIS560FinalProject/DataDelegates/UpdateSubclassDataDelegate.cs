using DataAccess;
using System.Data;

namespace CIS560FinalProject
{
    internal class UpdateSubclassDataDelegate : NonQueryDataDelegate<Subclass>
    {
        private readonly int classID;
        public readonly string name;
        public readonly string description;

        public UpdateSubclassDataDelegate(int classID, string name, string description)
            : base("UpdateSubclass")
        {
            this.name = name;
            this.description = description;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ClassID", classID);
            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Description", description);

            var p = command.Parameters.Add("SubclassID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Subclass Translate(Command command)
        {
            return new Subclass(command.GetParameterValue<int>("SubclassID"), classID, name, description);
        }
    }
}
