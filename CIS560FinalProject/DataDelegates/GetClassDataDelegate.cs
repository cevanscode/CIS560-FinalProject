using DataAccess;
using System.Data;

namespace CIS560FinalProject
{
    internal class GetClassDataDelegate : DataReaderDelegate<Class>
    {
        private readonly string name;

        public GetClassDataDelegate(string name)
            : base("GetClass") // Make sure matches Procedure
        {
            this.name = name;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ClassName", name);
        }

        public override Class Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Class(name, reader.GetString("ClassDescription"));
        }
    }
}
