using DataAccess;
using System.Data;

namespace CIS560FinalProject
{
    internal class UpdateClassDataDelegate : NonQueryDataDelegate<Class>
    {
        public readonly string name;
        public readonly string description;

        public UpdateClassDataDelegate(string name, string description)
            : base("UpdateClass") // Make sure matches Procedure
        {
            this.name = name;
            this.description = description;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ClassName", name);
            command.Parameters.AddWithValue("ClassDescription", description);

            //var p = command.Parameters.Add("ClassID", SqlDbType.Int);
            //p.Direction = ParameterDirection.Output;
        }

        public override Class Translate(Command command)
        {
            return new Class(name, description);
        }
    }
}
