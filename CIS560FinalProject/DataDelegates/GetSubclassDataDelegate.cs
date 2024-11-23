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

            command.Parameters.AddWithValue("SubclassName", name);
        }

        public override Subclass Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Subclass(name, reader.GetString("Description"), "");
        }
    }
}
