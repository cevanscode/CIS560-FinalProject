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
    public partial class UserForm : Form
    {
        private bool _loggedIn = false;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="loggedIn">If the user logged in to create this form</param>
        public UserForm(bool loggedIn)
        {
            InitializeComponent();

            _loggedIn = loggedIn;

            if (!_loggedIn)
            {
                UserTabs.TabPages[0].Enabled = false;
                UserTabs.TabPages[1].Enabled = false;
                UserTabs.Selecting += UserTabDeselect!;
                UserTabs.SelectedIndex = 2;
            }
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
    }
}