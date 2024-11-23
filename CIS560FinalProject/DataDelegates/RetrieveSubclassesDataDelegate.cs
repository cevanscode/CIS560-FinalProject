using DataAccess;
using System.Data;

namespace CIS560FinalProject
{
    internal class RetrieveSubclassesDataDelegate : DataReaderDelegate<IReadOnlyList<Subclass>>
    {
        public RetrieveSubclassesDataDelegate()
            : base("GetSubclasses") // Make sure matches Procedure
        {
        }

        public override IReadOnlyList<Subclass> Translate(Command command, IDataRowReader reader)
        {
            var subclasses = new List<Subclass>();

            while (reader.Read())
            {
                subclasses.Add(new Subclass(
                    reader.GetString("SubclassName"),
                    reader.GetString("Description"),
                    reader.GetString("ClassName")));
            }

            return subclasses;
        }
    }
}
