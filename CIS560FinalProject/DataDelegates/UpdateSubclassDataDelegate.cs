using DataAccess;
using System.Data;

namespace CIS560FinalProject
{
    internal class UpdateSubclassDataDelegate : NonQueryDataDelegate<Subclass>
    {
        public readonly string name;
        public readonly string description;
        public readonly string className;

        public UpdateSubclassDataDelegate(string name, string description, string className)
            : base("UpdateSubclass")
        {
            this.name = name;
            this.description = description;
            this.className = className;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("SubclassName", name);
            command.Parameters.AddWithValue("Description", description);
            // command.Parameters.AddWithValue("ClassName", className);

            // var p = command.Parameters.Add("SubclassID", SqlDbType.Int);
            // p.Direction = ParameterDirection.Output;
        }

        public override Subclass Translate(Command command)
        {
            return new Subclass(name, description, className);
        }
    }
}
