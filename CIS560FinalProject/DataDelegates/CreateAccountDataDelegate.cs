using DataAccess;
using System.Data.SqlClient;

namespace CIS560FinalProject
{
    internal class CreateAccountDataDelegate : NonQueryDataDelegate<Account>
    {
        private readonly string username;
        private readonly string password;
        private readonly string email;
        public readonly string fullName;
        private readonly DateTime birthday;
        private readonly bool isAdmin;

        public CreateAccountDataDelegate(string userName, string password, string email, string fullName, DateTime birthday, bool isAdmin)
            : base("CreateAccount")
        {
            this.username = userName;
            this.password = password;
            this.email = email;
            this.fullName = fullName;
            this.birthday = birthday;
            this.isAdmin = isAdmin;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Username", username);
            command.Parameters.AddWithValue("Password", password);
            command.Parameters.AddWithValue("Email", email);
            command.Parameters.AddWithValue("FullName", fullName);
            command.Parameters.AddWithValue("Birthday", birthday);

            var p = command.Parameters.Add("AccountID", System.Data.SqlDbType.Int);
            p.Direction = System.Data.ParameterDirection.Output;
        }

        public override Account Translate(Command command)
        {
            return new Account(command.GetParameterValue<int>("AccountID"), username, password, email, fullName, birthday, isAdmin);
        }
    }
}
