using DataAccess;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace CIS560FinalProject
{
    internal class FetchAccountDataDelegate : IDataReaderDelegate<Account>
    {
        private readonly int accountID;

        public string ProcedureName { get; }

        public FetchAccountDataDelegate(int accountID)
        {
            this.accountID = accountID;
        }

        public void PrepareCommand(Command command)
        {
            var p = command.Parameters.Add("AccountID", SqlDbType.Int);
            p.Value = accountID;
        }

        public Account Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(accountID.ToString());

            return new Account(accountID,
                reader.GetString("Username"),
                reader.GetString("Password"),
                reader.GetString("Email"),
                reader.GetString("FullName"),
                reader.GetDateTime("Birthday", DateTimeKind.Unspecified));

        }
    }
}
