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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Going to the UserForm without logging into an account; Only shows encyclopedia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartNoLoginButton_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(false);

            userForm.FormClosed += (s, args) => this.Show();
            userForm.Show();
            this.Hide();
        }
    }
}
