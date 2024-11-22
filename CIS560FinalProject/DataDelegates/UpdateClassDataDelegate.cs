using DataAccess;
using System.Data;

namespace CIS560FinalProject
{
    internal class UpdateClassDataDelegate : NonQueryDataDelegate<Class>
    {
        public readonly string name;
        public readonly string description;

        public UpdateClassDataDelegate(string name, string description)
            : base("UpdateClass")
        {
            this.name = name;
            this.description = description;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Description", description);

            var p = command.Parameters.Add("ClassID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Class Translate(Command command)
        {
            return new Class(command.GetParameterValue<int>("ClassID"), name, description);
        }
    }
}
