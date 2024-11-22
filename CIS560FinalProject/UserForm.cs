using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS560FinalProject.Models;

namespace CIS560FinalProject
{
    public partial class UserForm : Form
    {
        private bool _loggedIn = false;
        private Character? _viewCharacter;
        private Account? _viewAccount;

        /// <summary>
        /// Constructor that takes no account (used when user is not logging in)
        /// </summary>
        public UserForm()
        {
            InitializeComponent();

            //Disables Account and Character tabs.
            UserTabs.TabPages[0].Enabled = false;
            UserTabs.TabPages[1].Enabled = false;
            UserTabs.Selecting += UserTabDeselect!;
            UserTabs.SelectedIndex = 2;
        }

        /// <summary>
        /// Constructor that takes an account (used when the user is logging in)
        /// </summary>
        /// <param name="a">The account that is being used to log in</param>
        public UserForm(Account a)
        {
            InitializeComponent();

            //Enables Account and Character tabs
            UserTabs.TabPages[0].Enabled = true;
            UserTabs.TabPages[1].Enabled = true;
            UserTabs.Selecting -= UserTabDeselect!;
            UserTabs.SelectedIndex = 0;

            _viewAccount = a;
        }

        /// <summary>
        /// Does not allow a user to select Account or Character when activated
        /// </summary>
        /// <param name="sender">The object signaling the event</param>
        /// <param name="e">Information about the event</param>
        private void UserTabDeselect(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == UserTabs.TabPages[0] || e.TabPage == UserTabs.TabPages[1])
            {
                e.Cancel = true;
            }
        }

        private void ModifyCharacterButton_Click(object sender, EventArgs e)
        {
            EditCharacterForm editForm = new EditCharacterForm();

            editForm.ShowDialog();
        }

        private void ModifyAccountButton_Click(object sender, EventArgs e)
        {
            EditAccountForm editForm = new EditAccountForm();

            editForm.ShowDialog();
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            //database removal stuff here

            //return to login menu
            this.Close();
        }
    }
}