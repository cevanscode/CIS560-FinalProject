using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject.DataDelegates
{
    internal class DeleteCharacterDataDelegate : NonQueryDataDelegate<Character>
    {
        private readonly string username;
        private readonly string password;

        public DeleteCharacterDataDelegate(string username, string password)
            : base("UserDeleteCharacter")
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

        public override Character Translate(Command command)
        {
            throw new NotImplementedException();
        }
    }
}
