using DataAccess;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.Security.Cryptography;

namespace CIS560FinalProject
{
    internal class ModifyAccountDataDelegate : NonQueryDataDelegate<Account>
    {
        private readonly string oldusername;
        private readonly string username;
        private readonly string password;
        private readonly string email;
        public readonly string fullName;
        private readonly DateTime birthday;
        //private readonly bool isAdmin;

        public ModifyAccountDataDelegate(string oldusername, string userName, string password, string email, string fullName, DateTime birthday)
            : base("ModifyAccount")
        {
            this.oldusername = oldusername;
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

            // Add other parameters
            command.Parameters.AddWithValue("OldUserName", oldusername);
            command.Parameters.AddWithValue("UserName", username);
            command.Parameters.AddWithValue("Email", email);
            command.Parameters.AddWithValue("Password", password);
            command.Parameters.AddWithValue("FullName", fullName);
            command.Parameters.AddWithValue("Birthday", birthday);
        }


        public override Account Translate(Command command)
        {
            return new Account(0, username, password, email, fullName, birthday); //there may be consequences to having 0 here :3
        }
    }
}
