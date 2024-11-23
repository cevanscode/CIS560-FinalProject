using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject
{
    internal class RetrieveClassesDataDelegate : DataReaderDelegate<IReadOnlyList<Class>>
    {
        public RetrieveClassesDataDelegate()
            : base("RetrieveClasses") // Make sure matches Procedure
        {
        }

        public override IReadOnlyList<Class> Translate(Command command, IDataRowReader reader)
        {
            var classes = new List<Class>();

            while (reader.Read())
            {
                classes.Add(new Class(
                    reader.GetString("ClassName"),
                    reader.GetString("ClassDescription")));
            }

            return classes;
        }
    }
}
