using DataAccess;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.Security.Cryptography;

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

            //string pw = password;
            //Encoding encoding = Encoding.ASCII;

            //byte[] pwBytes = encoding.GetBytes(pw);

            //byte[] keep;

            //using (SHA256 mySHA256 = SHA256.Create())
            //{
            //    keep = mySHA256.ComputeHash(pwBytes);
            //}

                // Add other parameters
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
