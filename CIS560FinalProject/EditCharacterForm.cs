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
    public partial class EditCharacterForm : Form
    {
        public EditCharacterForm()
        {
            InitializeComponent();
        }

        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubclassComboBox.Items.Clear();
            WizardComboBox1.Items.Clear();
            WizardComboBox2.Items.Clear();

            SubclassLabel.Visible = true;
            SubclassComboBox.Visible = true;
            WizardLabel1.Visible = false;
            WizardLabel2.Visible = false;
            WizardComboBox1.Visible = false;
            WizardComboBox2.Visible = false;

            switch (ClassComboBox.SelectedItem.ToString())
            {
                case "Cleric":
                    SubclassComboBox.Items.Add("Soothsayer");
                    SubclassComboBox.Items.Add("Paladin");
                    break;
                case "Noble":
                    SubclassComboBox.Items.Add("Knight");
                    SubclassComboBox.Items.Add("Lord");
                    break;
                case "Ranger":
                    SubclassComboBox.Items.Add("Marksman");
                    SubclassComboBox.Items.Add("Stalker");
                    break;
                case "Rogue":
                    SubclassComboBox.Items.Add("Assassin");
                    SubclassComboBox.Items.Add("Thief");
                    break;
                case "Spellbinder":
                    SubclassComboBox.Items.Add("Sentinel");
                    SubclassComboBox.Items.Add("Harbinger");
                    break;
                case "Warrior":
                    SubclassComboBox.Items.Add("Berserker");
                    SubclassComboBox.Items.Add("Champion");
                    break;
                case "Wizard": // :(
                    SubclassLabel.Visible = false;
                    SubclassComboBox.Visible = false;
                    WizardLabel1.Visible = true;
                    WizardLabel2.Visible = true;
                    WizardComboBox1.Visible = true;
                    WizardComboBox2.Visible = true;

                    WizardComboBox1.Items.Add("Hydromancy");
                    WizardComboBox1.Items.Add("Kairomancy");
                    WizardComboBox1.Items.Add("Pyromancy");

                    WizardComboBox2.Items.Add("Kinesiomancy");
                    WizardComboBox2.Items.Add("Avlomancy");
                    WizardComboBox2.Items.Add("Neuromancy");
                    break;
                default:
                    SubclassComboBox.Items.Add("How did you get here?");
                    break;
            }
        }
    }
}
