using DataAccess;
using System.Data;

namespace CIS560FinalProject
{
    internal class GetSubclassDataDelegate : DataReaderDelegate<Subclass>
    {
        private readonly string name;

        public GetSubclassDataDelegate(string name)
            : base("GetSubclass")
        {
            this.name = name;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
        }

        public override Subclass Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Subclass(reader.GetInt32("SubclassID"), reader.GetInt32("ClassID"), name, reader.GetString("Description"));
        }
    }
}
