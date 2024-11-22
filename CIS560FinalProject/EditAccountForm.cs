using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CIS560FinalProject
{
    public partial class EditAccountForm : Form
    {
        private Account _editAccount;

        public EditAccountForm(Account a)
        {
            InitializeComponent();

            _editAccount = a;

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
    }
}
