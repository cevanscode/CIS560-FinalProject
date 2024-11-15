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
    public partial class EditForm : Form
    {
        public EditForm(string sender)
        {
            InitializeComponent();

            //changes visibility of items to allow user to either just edit character or account details
            if (sender == "character")
            {
                ChangeAccountUIVisibility(false);
            }
            else if (sender == "account")
            {
                ChangeAccountUIVisibility(true);
            }
        }

        /// <summary>
        /// Changes the visibility of Account modifying UI elements
        /// </summary>
        /// <param name="visibility">If the UI elements are visible or not</param>
        public void ChangeAccountUIVisibility(bool visibility)
        {
            UsernameLabel.Visible = visibility;
            UsernameTextBox.Visible = visibility;
            PasswordLabel.Visible = visibility;
            PasswordTextBox.Visible = visibility;
            EmailLabel.Visible = visibility;
            EmailTextBox.Visible = visibility;
            FullNameLabel.Visible = visibility;
            FullNameTextBox.Visible = visibility;
            BirthdayLabel.Visible = visibility;
            BirthdayTextBox.Visible = visibility;
        }

        /// <summary>
        /// Changes the visibility of Character modifying UI elements
        /// </summary>
        /// <param name="visibility">If the UI elements are visible or not</param>
        public void ChangeCharacterUIVisibility(bool visibility)
        {

        }
    }
}
