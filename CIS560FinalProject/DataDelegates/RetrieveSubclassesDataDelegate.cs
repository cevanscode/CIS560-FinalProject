using DataAccess;
using System.Data;

namespace CIS560FinalProject
{
    internal class RetrieveSubclassesDataDelegate : DataReaderDelegate<IReadOnlyList<Subclass>>
    {
        private readonly string className;

        public RetrieveSubclassesDataDelegate(string className)
            : base("RetrieveSubclass") // Make sure matches Procedure
        {
            this.className = className;
        }

        public override IReadOnlyList<Subclass> Translate(Command command, IDataRowReader reader)
        {
            var subclasses = new List<Subclass>();

            while (reader.Read())
            {
                subclasses.Add(new Subclass(
                    reader.GetString("SubclassName"),
                    reader.GetString("Description"),
                    className));
            }

            return subclasses;
        }
    }
}
