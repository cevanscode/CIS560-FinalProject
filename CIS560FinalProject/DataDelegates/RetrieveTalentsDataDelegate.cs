using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject
{
    internal class RetrieveTalentsDataDelegate : DataReaderDelegate<IReadOnlyList<Talent>>
    {
        public RetrieveTalentsDataDelegate()
            : base("GetTalents") // Make sure matches Procedure
        {
        }

        public override IReadOnlyList<Talent>Translate(Command command, IDataRowReader reader)
        {
            var talents = new List<Talent>();

            while (reader.Read())
            {
                talents.Add(new Talent(
                    reader.GetString("TalentName"),
                    reader.GetString("TalentDescription"),
                    (Rank)reader.GetInt32("TalentRank"),
                    (TalentType)(reader.GetInt32("TalentCategoryID"))));
            }

            return talents;
        }
    }
}
