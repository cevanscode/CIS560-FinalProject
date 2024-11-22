using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace CIS560FinalProject
{
    internal class FetchAccountDataDelegate : DataReaderDelegate<Account>
    {
        private readonly int accountID;

        public FetchAccountDataDelegate(int accountID)
            : base("FetchAccount")
        {
            this.accountID = accountID;
        }

        public override void PrepareCommand(Command command)
        {
            var p = command.Parameters.Add("AccountID", SqlDbType.Int);
            p.Value = accountID;
        }

        public override Account Translate(Command command, IDataRowReader reader)
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
