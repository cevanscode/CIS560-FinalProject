using DataAccess;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CIS560FinalProject
{
    internal class RetrieveAccountsDataDelegate : IDataReaderDelegate<IReadOnlyList<Account>>
    {
        public RetrieveAccountsDataDelegate()
        {
        }

        public string ProcedureName { get; }

        public void PrepareCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Account> Translate(Command command, IDataRowReader reader)
        {
            var accounts = new List<Account>();

            while (reader.Read())
            {
                accounts.Add(new Account(
                    reader.GetInt32("AccountID"),
                    reader.GetString("Username"),
                    reader.GetString("Password"),
                    reader.GetString("Email"),
                    reader.GetString("FullName"),
                    reader.GetDateTime("Birthday", DateTimeKind.Unspecified),
                    reader.GetBoolean("IsAdmin")));
            }

            return accounts;
        }
    }
}
