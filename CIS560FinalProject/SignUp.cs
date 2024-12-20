﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace CIS560FinalProject
{
    public partial class SignUp : Form
    {
        private IAccountRepository repo;
        private string connectionString = ConfigurationManager.ConnectionStrings["LarpDatabase"].ConnectionString;

        public SignUp()
        {
            InitializeComponent();
            repo = new SqlAccountRepository(connectionString);
        }

        /// <summary>
        /// Closes the form without creating an account
        /// </summary>
        /// <param name="sender">The object signaling the event</param>
        /// <param name="e">Information about the event</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Sends the information given to the database added as a new Account
        /// </summary>
        /// <param name="sender">The object signaling the event</param>
        /// <param name="e">Information about the event</param>
        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            //send the information over
            string fullName = FullNameTextBox.Text;
            string password = PasswordTextBox.Text;
            string username = UsernameTextBox.Text;
            string email = EmailTextBox.Text;
            DateTime birthday = BirthdayPicker.Value;

            repo.CreateAccount(username, password, email, fullName, birthday);

            //...then close this form to return to the main, allowing login
            this.Close();
        }
    }
}
