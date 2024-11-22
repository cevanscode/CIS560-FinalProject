using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

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
                //accounts.Add(new Account(
                //    reader.GetInt32("AccountID"),
                //    reader.GetString("UserName"),
                //    Encoding.ASCII.GetString(reader.GetBytes("AccountPassword")),
                //    reader.GetString("Email"),
                //    reader.GetString("FullName"),
                //    reader.GetDateTime("Birthday", DateTimeKind.Unspecified)));

                accounts.Add(new Account(
                    reader.GetInt32("AccountID"),
                    reader.GetString("UserName"),
                    reader.GetBytes("AccountPassword"),
                    reader.GetString("Email"),
                    reader.GetString("FullName"),
                    reader.GetDateTime("Birthday", DateTimeKind.Unspecified)));
            }

            return accounts;
        }
    }
}
