using DataAccess;
using System.Data;

namespace CIS560FinalProject
{
    internal class CreateClassDataDelegate : NonQueryDataDelegate<Class>
    {
        public readonly string name;
        public readonly string description;

        public CreateClassDataDelegate(string name, string description)
            : base("AdminCreateClass") // Make sure matches Procedure
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
