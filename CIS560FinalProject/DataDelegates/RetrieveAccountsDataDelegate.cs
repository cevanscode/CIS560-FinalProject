using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CIS560FinalProject
{
    internal class RetrieveAccountsDataDelegate : DataReaderDelegate<IReadOnlyList<Account>>
    {
        public RetrieveAccountsDataDelegate()
         : base("RetrieveAccounts")
        {
        }

        public override IReadOnlyList<Account> Translate(Command command, IDataRowReader reader)
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
