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
            BirthdayTextBox = new TextBox();
            FullNameTextBox = new TextBox();
            XPLabel = new Label();
            EmailTextBox = new TextBox();
            HealthLabel = new Label();
            PasswordTextBox = new TextBox();
            AgeLabel = new Label();
            NameLabel = new Label();
            UsernameTextBox = new TextBox();
            TalentsLabel = new Label();
            SubclassLabel = new Label();
            ClassLabel = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // CopperLabel
            // 
            CopperLabel.AutoSize = true;
            CopperLabel.Location = new Point(12, 229);
            CopperLabel.Name = "CopperLabel";
            CopperLabel.Size = new Size(71, 25);
            CopperLabel.TabIndex = 19;
            CopperLabel.Text = "Copper";
            // 
            // BirthdayTextBox
            // 
            BirthdayTextBox.Location = new Point(142, 229);
            BirthdayTextBox.Name = "BirthdayTextBox";
            BirthdayTextBox.Size = new Size(150, 31);
            BirthdayTextBox.TabIndex = 18;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(142, 178);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(150, 31);
            FullNameTextBox.TabIndex = 17;
            // 
            // XPLabel
            // 
            XPLabel.AutoSize = true;
            XPLabel.Location = new Point(12, 178);
            XPLabel.Name = "XPLabel";
            XPLabel.Size = new Size(33, 25);
            XPLabel.TabIndex = 16;
            XPLabel.Text = "XP";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(142, 126);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(150, 31);
            EmailTextBox.TabIndex = 15;
            // 
            // HealthLabel
            // 
            HealthLabel.AutoSize = true;
            HealthLabel.Location = new Point(12, 126);
            HealthLabel.Name = "HealthLabel";
            HealthLabel.Size = new Size(63, 25);
            HealthLabel.TabIndex = 14;
            HealthLabel.Text = "Health";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(142, 79);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(150, 31);
            PasswordTextBox.TabIndex = 13;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(12, 79);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(44, 25);
            AgeLabel.TabIndex = 12;
            AgeLabel.Text = "Age";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 28);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(59, 25);
            NameLabel.TabIndex = 11;
            NameLabel.Text = "Name";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(142, 25);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(150, 31);
            UsernameTextBox.TabIndex = 10;
            // 
            // TalentsLabel
            // 
            TalentsLabel.AutoSize = true;
            TalentsLabel.Location = new Point(503, 28);
            TalentsLabel.Name = "TalentsLabel";
            TalentsLabel.Size = new Size(65, 25);
            TalentsLabel.TabIndex = 22;
            TalentsLabel.Text = "Talents";
            // 
            // SubclassLabel
            // 
            SubclassLabel.AutoSize = true;
            SubclassLabel.Location = new Point(12, 320);
            SubclassLabel.Name = "SubclassLabel";
            SubclassLabel.Size = new Size(80, 25);
            SubclassLabel.TabIndex = 21;
            SubclassLabel.Text = "Subclass";
            // 
            // ClassLabel
            // 
            ClassLabel.AutoSize = true;
            ClassLabel.Location = new Point(12, 277);
            ClassLabel.Name = "ClassLabel";
            ClassLabel.Size = new Size(52, 25);
            ClassLabel.TabIndex = 20;
            ClassLabel.Text = "Class";
            // 
            // button1
            // 
            button1.Location = new Point(312, 404);
            button1.Name = "button1";
            button1.Size = new Size(165, 34);
            button1.TabIndex = 23;
            button1.Text = "Confirm Changes";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cleric", "Noble", "Ranger", "Rogue", "Spellbinder", "Warrior", "Wizard" });
            comboBox1.Location = new Point(142, 277);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 33);
            comboBox1.TabIndex = 24;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(142, 320);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(150, 33);
            comboBox2.TabIndex = 25;
            // 
            // EditCharacterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(TalentsLabel);
            Controls.Add(SubclassLabel);
            Controls.Add(ClassLabel);
            Controls.Add(CopperLabel);
            Controls.Add(BirthdayTextBox);
            Controls.Add(FullNameTextBox);
            Controls.Add(XPLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(HealthLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(AgeLabel);
            Controls.Add(NameLabel);
            Controls.Add(UsernameTextBox);
            Name = "EditCharacterForm";
            Text = "Edit Character";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CopperLabel;
        private TextBox BirthdayTextBox;
        private TextBox FullNameTextBox;
        private Label XPLabel;
        private TextBox EmailTextBox;
        private Label HealthLabel;
        private TextBox PasswordTextBox;
        private Label AgeLabel;
        private Label NameLabel;
        private TextBox UsernameTextBox;
        private Label TalentsLabel;
        private Label SubclassLabel;
        private Label ClassLabel;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}