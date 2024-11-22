using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560FinalProject
{
    public partial class LogIn : Form
    {
        private IAccountRepository repo;
        private string connectionString = ConfigurationManager.ConnectionStrings["LarpDatabase"].ConnectionString;

        public LogIn()
        {
            InitializeComponent();
            repo = new SqlAccountRepository(connectionString);
        }

        /// <summary>
        /// Going to the UserForm without logging into an account; Only shows encyclopedia
        /// </summary>
        /// <param name="sender">The object signaling the event</param>
        /// <param name="e">Information about the event</param>
        private void StartNoLoginButton_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(); //no account necessary; uses first constructor
            userForm.FormClosed += (s, args) => this.Show();
            userForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Logs into an account based on the information present in Username and Password fields
        /// </summary>
        /// <param name="sender">The object signaling the event</param>
        /// <param name="e">Information about the event</param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            IReadOnlyList<Account> accounts = repo.RetrieveAccounts();
            Account? loginAccount = null;

            foreach (Account account in accounts)
            {
                if (account.Username == UsernameTextBox.Text && account.Password == PasswordTextBox.Text)
                {
                    loginAccount = repo.FetchAccount(account.AccountID);
                    break;
                }
            }

            //Find the account from the database

            if (loginAccount != null)
            {
                UserForm userForm = new UserForm(loginAccount);
                userForm.FormClosed += (s, args) => this.Show();
                userForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Account does not exist");
            }
        }

        /// <summary>
        /// Allows a user to create an account (sending it to the database) before they can sign in with it
        /// </summary>
        /// <param name="sender">The object signaling the event</param>
        /// <param name="e">Information about the event</param>
        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.FormClosed += (s, args) => this.Show();
            signUp.Show();
            this.Hide();
        }
    }
}
