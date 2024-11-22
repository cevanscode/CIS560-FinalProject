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
    public partial class UserForm : Form
    {
        private bool _loggedIn = false;
        private Character? _viewCharacter;
        private Account? _viewAccount;
        private IClassRepository _classRepo;
        private ISubclassRepository _subclassRepo;
        private ITalentRepository _talentRepo;
        private string _source;

        private string connectionString = ConfigurationManager.ConnectionStrings["LarpDatabase"].ConnectionString;

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
            ItemListView.Visible = false;
            SelectButton.Visible = false;

            _classRepo = new SqlClassRepository(connectionString);
            _subclassRepo = new SqlSubclassRepository(connectionString);
            _talentRepo = new SqlTalentRepository(connectionString);
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
            ItemListView.Visible = false;
            SelectButton.Visible = false;

            _viewAccount = a;
            FillUNLabel.Text = a.Username;
            FillPWLabel.Text = a.Password;
            FillFNLabel.Text = a.FullName;
            FillBDLabel.Text = a.Birthday.ToString(); //erm this may look weird unformatted
            FillEmailLabel.Text = a.Email;

            _classRepo = new SqlClassRepository(connectionString);
            _subclassRepo = new SqlSubclassRepository(connectionString);
            _talentRepo = new SqlTalentRepository(connectionString);


            //fill in the character if they have any here

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
            EditAccountForm editForm = new EditAccountForm(_viewAccount!);

            editForm.ShowDialog();
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            //database removal stuff here

            //return to login menu
            this.Close();
        }

        private void EncyclopediaClassButton_Click(object sender, EventArgs e)
        {
            _source = "class";
            ItemListView.Visible = true;
            ItemListView.Items.Clear();

            IReadOnlyList<Class> classList = _classRepo.RetrieveClasses();

            foreach (Class c in classList)
            {
                ItemListView.Items.Add(c.Name);
            }
        }

        private void EncyclopediaSubclassButton_Click(object sender, EventArgs e)
        {
            _source = "subclass";
            ItemListView.Visible = true;
            ItemListView.Items.Clear();

            IReadOnlyList<Subclass> subclassList = _subclassRepo.RetrieveSubclasses();

            foreach (Subclass s in subclassList)
            {
                ItemListView.Items.Add(s.Name);
            }
        }

        private void EncyclopediaTalentsButton_Click(object sender, EventArgs e)
        {
            _source = "talent";
            ItemListView.Visible = true;
            ItemListView.Items.Clear();

            IReadOnlyList<Talent> talentList = _talentRepo.RetrieveTalents();

            foreach (Talent t in talentList)
            {
                ItemListView.Items.Add(t.Name);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ItemListView.Visible = false;
            SelectButton.Enabled = false;
            EncyclopediaClassButton.Enabled = true;
            EncyclopediaSubclassButton.Enabled = true;
            EncyclopediaTalentsButton.Enabled = true;
            _source = "";
        }

        /// <summary>
        /// Button which makes a selection from the listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectButton_Click(object sender, EventArgs e)
        {
            switch (_source)
            {
                case "class":
                    
                    break;
                case "subclass":

                    break;
                case "talent":

                    break;
            }
        }
    }
}