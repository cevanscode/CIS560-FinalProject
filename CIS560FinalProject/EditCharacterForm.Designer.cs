namespace CIS560FinalProject
{
    partial class EditCharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CopperLabel = new Label();
            XPLabel = new Label();
            HealthLabel = new Label();
            AgeLabel = new Label();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            TalentsLabel = new Label();
            SubclassLabel = new Label();
            ClassLabel = new Label();
            button1 = new Button();
            ClassComboBox = new ComboBox();
            SubclassComboBox = new ComboBox();
            WizardLabel1 = new Label();
            WizardLabel2 = new Label();
            WizardComboBox2 = new ComboBox();
            WizardComboBox1 = new ComboBox();
            XPUpDown = new NumericUpDown();
            HealthUpDown = new NumericUpDown();
            CopperUpDown = new NumericUpDown();
            AgeUpDown = new NumericUpDown();
            CancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)XPUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HealthUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CopperUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AgeUpDown).BeginInit();
            SuspendLayout();
            // 
            // CopperLabel
            // 
            CopperLabel.AutoSize = true;
            CopperLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CopperLabel.Location = new Point(12, 229);
            CopperLabel.Name = "CopperLabel";
            CopperLabel.Size = new Size(73, 25);
            CopperLabel.TabIndex = 19;
            CopperLabel.Text = "Copper";
            // 
            // XPLabel
            // 
            XPLabel.AutoSize = true;
            XPLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            XPLabel.Location = new Point(12, 178);
            XPLabel.Name = "XPLabel";
            XPLabel.Size = new Size(35, 25);
            XPLabel.TabIndex = 16;
            XPLabel.Text = "XP";
            // 
            // HealthLabel
            // 
            HealthLabel.AutoSize = true;
            HealthLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HealthLabel.Location = new Point(12, 126);
            HealthLabel.Name = "HealthLabel";
            HealthLabel.Size = new Size(69, 25);
            HealthLabel.TabIndex = 14;
            HealthLabel.Text = "Health";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AgeLabel.Location = new Point(12, 79);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(46, 25);
            AgeLabel.TabIndex = 12;
            AgeLabel.Text = "Age";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(12, 28);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(62, 25);
            NameLabel.TabIndex = 11;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(142, 25);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(150, 31);
            NameTextBox.TabIndex = 10;
            // 
            // TalentsLabel
            // 
            TalentsLabel.AutoSize = true;
            TalentsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TalentsLabel.Location = new Point(503, 28);
            TalentsLabel.Name = "TalentsLabel";
            TalentsLabel.Size = new Size(72, 25);
            TalentsLabel.TabIndex = 22;
            TalentsLabel.Text = "Talents";
            // 
            // SubclassLabel
            // 
            SubclassLabel.AutoSize = true;
            SubclassLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SubclassLabel.Location = new Point(12, 320);
            SubclassLabel.Name = "SubclassLabel";
            SubclassLabel.Size = new Size(84, 25);
            SubclassLabel.TabIndex = 21;
            SubclassLabel.Text = "Subclass";
            // 
            // ClassLabel
            // 
            ClassLabel.AutoSize = true;
            ClassLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClassLabel.Location = new Point(12, 277);
            ClassLabel.Name = "ClassLabel";
            ClassLabel.Size = new Size(54, 25);
            ClassLabel.TabIndex = 20;
            ClassLabel.Text = "Class";
            // 
            // button1
            // 
            button1.Location = new Point(202, 404);
            button1.Name = "button1";
            button1.Size = new Size(165, 34);
            button1.TabIndex = 23;
            button1.Text = "Confirm Changes";
            button1.UseVisualStyleBackColor = true;
            // 
            // ClassComboBox
            // 
            ClassComboBox.FormattingEnabled = true;
            ClassComboBox.Items.AddRange(new object[] { "Cleric", "Noble", "Ranger", "Rogue", "Spellbinder", "Warrior", "Wizard" });
            ClassComboBox.Location = new Point(142, 277);
            ClassComboBox.Name = "ClassComboBox";
            ClassComboBox.Size = new Size(150, 33);
            ClassComboBox.TabIndex = 24;
            ClassComboBox.SelectedIndexChanged += ClassComboBox_SelectedIndexChanged;
            // 
            // SubclassComboBox
            // 
            SubclassComboBox.FormattingEnabled = true;
            SubclassComboBox.Location = new Point(142, 320);
            SubclassComboBox.Name = "SubclassComboBox";
            SubclassComboBox.Size = new Size(150, 33);
            SubclassComboBox.TabIndex = 25;
            // 
            // WizardLabel1
            // 
            WizardLabel1.AutoSize = true;
            WizardLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            WizardLabel1.Location = new Point(12, 320);
            WizardLabel1.Name = "WizardLabel1";
            WizardLabel1.Size = new Size(96, 25);
            WizardLabel1.TabIndex = 26;
            WizardLabel1.Text = "Elemental";
            WizardLabel1.Visible = false;
            // 
            // WizardLabel2
            // 
            WizardLabel2.AutoSize = true;
            WizardLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            WizardLabel2.Location = new Point(12, 366);
            WizardLabel2.Name = "WizardLabel2";
            WizardLabel2.Size = new Size(89, 25);
            WizardLabel2.TabIndex = 27;
            WizardLabel2.Text = "Manifold";
            WizardLabel2.Visible = false;
            // 
            // WizardComboBox2
            // 
            WizardComboBox2.FormattingEnabled = true;
            WizardComboBox2.Location = new Point(142, 363);
            WizardComboBox2.Name = "WizardComboBox2";
            WizardComboBox2.Size = new Size(150, 33);
            WizardComboBox2.TabIndex = 28;
            WizardComboBox2.Visible = false;
            // 
            // WizardComboBox1
            // 
            WizardComboBox1.FormattingEnabled = true;
            WizardComboBox1.Location = new Point(142, 320);
            WizardComboBox1.Name = "WizardComboBox1";
            WizardComboBox1.Size = new Size(150, 33);
            WizardComboBox1.TabIndex = 29;
            WizardComboBox1.Visible = false;
            // 
            // XPUpDown
            // 
            XPUpDown.Location = new Point(142, 176);
            XPUpDown.Name = "XPUpDown";
            XPUpDown.Size = new Size(150, 31);
            XPUpDown.TabIndex = 30;
            // 
            // HealthUpDown
            // 
            HealthUpDown.Location = new Point(142, 126);
            HealthUpDown.Name = "HealthUpDown";
            HealthUpDown.Size = new Size(150, 31);
            HealthUpDown.TabIndex = 31;
            // 
            // CopperUpDown
            // 
            CopperUpDown.Location = new Point(142, 229);
            CopperUpDown.Name = "CopperUpDown";
            CopperUpDown.Size = new Size(150, 31);
            CopperUpDown.TabIndex = 32;
            // 
            // AgeUpDown
            // 
            AgeUpDown.Location = new Point(142, 79);
            AgeUpDown.Name = "AgeUpDown";
            AgeUpDown.Size = new Size(150, 31);
            AgeUpDown.TabIndex = 33;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(393, 404);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 34);
            CancelButton.TabIndex = 34;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditCharacterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(CancelButton);
            Controls.Add(AgeUpDown);
            Controls.Add(CopperUpDown);
            Controls.Add(HealthUpDown);
            Controls.Add(XPUpDown);
            Controls.Add(WizardComboBox1);
            Controls.Add(WizardComboBox2);
            Controls.Add(WizardLabel2);
            Controls.Add(WizardLabel1);
            Controls.Add(SubclassComboBox);
            Controls.Add(ClassComboBox);
            Controls.Add(button1);
            Controls.Add(TalentsLabel);
            Controls.Add(SubclassLabel);
            Controls.Add(ClassLabel);
            Controls.Add(CopperLabel);
            Controls.Add(XPLabel);
            Controls.Add(HealthLabel);
            Controls.Add(AgeLabel);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Name = "EditCharacterForm";
            Text = "Edit Character";
            ((System.ComponentModel.ISupportInitialize)XPUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)HealthUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CopperUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AgeUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CopperLabel;
        private Label XPLabel;
        private Label HealthLabel;
        private Label AgeLabel;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label TalentsLabel;
        private Label SubclassLabel;
        private Label ClassLabel;
        private Button button1;
        private ComboBox ClassComboBox;
        private ComboBox SubclassComboBox;
        private Label WizardLabel1;
        private Label WizardLabel2;
        private ComboBox WizardComboBox2;
        private ComboBox WizardComboBox1;
        private NumericUpDown XPUpDown;
        private NumericUpDown HealthUpDown;
        private NumericUpDown CopperUpDown;
        private NumericUpDown AgeUpDown;
        private Button CancelButton;
    }
}