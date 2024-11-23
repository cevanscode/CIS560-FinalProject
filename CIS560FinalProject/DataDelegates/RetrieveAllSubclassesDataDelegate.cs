using DataAccess;
using System.Data;
using System.Xml.Linq;

namespace CIS560FinalProject
{
    internal class RetrieveAllSubclassesDataDelegate : DataReaderDelegate<IReadOnlyList<Subclass>>
    {

        public RetrieveAllSubclassesDataDelegate()
            : base("RetrieveAllSubclasses") // Make sure matches Procedure
        {
        }

        public override IReadOnlyList<Subclass> Translate(Command command, IDataRowReader reader)
        {
            var subclasses = new List<Subclass>();

            while (reader.Read())
            {
                subclasses.Add(new Subclass(
                    reader.GetString("SubclassName"),
                    reader.GetString("SubclassDescription"),
                    reader.GetString("ClassName")));
            }

            return subclasses;
        }
    }
}
