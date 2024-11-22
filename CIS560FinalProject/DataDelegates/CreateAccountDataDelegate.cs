using DataAccess;
using System.Data.SqlClient;
using System.Text;

namespace CIS560FinalProject
{
    internal class CreateAccountDataDelegate : NonQueryDataDelegate<Account>
    {
        private readonly string username;
        private readonly string password;
        private readonly string email;
        public readonly string fullName;
        private readonly DateTime birthday;
        //private readonly bool isAdmin;

        public CreateAccountDataDelegate(string userName, string password, string email, string fullName, DateTime birthday)
            : base("CreateAccount")
        {
            this.username = userName;
            this.password = password;
            this.email = email;
            this.fullName = fullName;
            this.birthday = birthday;
            //this.isAdmin = isAdmin;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserName", username);
            command.Parameters.AddWithValue("Password", Encoding.ASCII.GetBytes(password));
            command.Parameters.AddWithValue("Email", email);
            command.Parameters.AddWithValue("FullName", fullName);
            command.Parameters.AddWithValue("Birthday", birthday);
        }

        public override Account Translate(Command command)
        {
            return new Account(0, username, password, email, fullName, birthday);
        }
    }
}
