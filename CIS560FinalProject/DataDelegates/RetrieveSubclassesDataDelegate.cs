using DataAccess;
using System.Data;
using System.Xml.Linq;

namespace CIS560FinalProject
{
    internal class RetrieveSubclassesDataDelegate : DataReaderDelegate<IReadOnlyList<Subclass>>
    {
        private readonly string className;

        public RetrieveSubclassesDataDelegate(string className)
            : base("RetrieveSubclasses") // Make sure matches Procedure
        {
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ClassName", className);
        }

        public override IReadOnlyList<Subclass> Translate(Command command, IDataRowReader reader)
        {
            var subclasses = new List<Subclass>();

            while (reader.Read())
            {
                subclasses.Add(new Subclass(
                    reader.GetString("SubclassName"),
                    reader.GetString("SubclassDescription"),
                    className));
            }

            return subclasses;
        }
    }
}
