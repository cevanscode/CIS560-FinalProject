using DataAccess;
using System.Data;

namespace CIS560FinalProject
{
    internal class GetSubclassDataDelegate : DataReaderDelegate<Subclass>
    {
        private readonly string name;
        private readonly string className;

        public GetSubclassDataDelegate(string name, string className)
            : base("GetSubclass")
        {
            this.name = name;
            this.className = className;
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

            return new Subclass(name, reader.GetString("Description"), className);
        }
    }
}
