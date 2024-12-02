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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace CIS560FinalProject
{
    public partial class EditAccountForm : Form
    {
        private Account _editAccount;
        private IAccountRepository repo;
        private string connectionString = ConfigurationManager.ConnectionStrings["LarpDatabase"].ConnectionString;

        public EditAccountForm(Account a)
        {
            InitializeComponent();

            _editAccount = a;
            repo = new SqlAccountRepository(connectionString);

            UsernameTextBox.Text = a.Username;
            PasswordTextBox.Text = a.Password;
            EmailTextBox.Text = a.Email;
            FullNameTextBox.Text = a.FullName;
            BirthdayPicker.Value = a.Birthday;
        }



        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            //send the information over
            string fullName = FullNameTextBox.Text;
            string password = PasswordTextBox.Text;
            string username = UsernameTextBox.Text;
            string email = EmailTextBox.Text;
            DateTime birthday = BirthdayPicker.Value;

            repo.ModifyAccount(username, password, email, fullName, birthday);
            this.Close();
        }
    }
}
