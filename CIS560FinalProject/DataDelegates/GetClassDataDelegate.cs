using DataAccess;
using System.Data;

namespace CIS560FinalProject
{
    internal class GetClassDataDelegate : DataReaderDelegate<Class>
    {
        private readonly string name;

        public GetClassDataDelegate(string name)
            : base("GetClass")
        {
            this.name = name;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
        }

        public override Class Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Class(reader.GetInt32("ClassID"), name, reader.GetString("Description"));
        }
    }
}
