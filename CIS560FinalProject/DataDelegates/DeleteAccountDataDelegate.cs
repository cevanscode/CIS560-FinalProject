using DataAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CIS560FinalProject.DataDelegates
{
    internal class DeleteAccountDataDelegate : NonQueryDataDelegate<Account>
    {
        private readonly string username;
        private readonly string password;

        public DeleteAccountDataDelegate(string username, string password)
            : base("UserDeleteAccount")
        {
            this.username = username;
            this.password = password;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            // Add other parameters
            command.Parameters.AddWithValue("UserName", username);
            command.Parameters.AddWithValue("Password", password);
        }

        public override Account Translate(Command command)
        {
            throw new NotImplementedException();
        }
    }
}
