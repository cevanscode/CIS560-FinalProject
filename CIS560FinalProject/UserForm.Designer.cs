namespace CIS560FinalProject
{
    partial class UserForm
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
            UserTabs = new TabControl();
            AccountTab = new TabPage();
            FillEmailLabel = new Label();
            FillBDLabel = new Label();
            FillFNLabel = new Label();
            FillPWLabel = new Label();
            FillUNLabel = new Label();
            AccountLabel = new Label();
            PasswordLabel = new Label();
            EmailLabel = new Label();
            BirthdayLabel = new Label();
            FullNameLabel = new Label();
            UserNameLabel = new Label();
            DeleteAccountButton = new Button();
            ModifyAccountButton = new Button();
            CharacterTab = new TabPage();
            FillSubclassLabel = new Label();
            FillClassLabel = new Label();
            FillCopperLabel = new Label();
            FillXPLabel = new Label();
            FillHealthLabel = new Label();
            listView1 = new ListView();
            RankColumn = new ColumnHeader();
            TalentNameColumn = new ColumnHeader();
            CharacterTalentsLabel = new Label();
            SubclassLabel = new Label();
            ClassLabel = new Label();
            CopperLabel = new Label();
            XPLabel = new Label();
            HealthLabel = new Label();
            FillAgeLabel = new Label();
            AgeLabel = new Label();
            CharacterLabel = new Label();
            DeleteCharacterButton = new Button();
            ModifyCharacterButton = new Button();
            RulesTab = new TabPage();
            SelectButton = new Button();
            BackButton = new Button();
            EncyclopediaTalentsButton = new Button();
            EncyclopediaSubclassButton = new Button();
            EncyclopediaClassButton = new Button();
            label2 = new Label();
            label1 = new Label();
            ItemListView = new ListView();
            UserTabs.SuspendLayout();
            AccountTab.SuspendLayout();
            CharacterTab.SuspendLayout();
            RulesTab.SuspendLayout();
            SuspendLayout();
            // 
            // UserTabs
            // 
            UserTabs.Controls.Add(AccountTab);
            UserTabs.Controls.Add(CharacterTab);
            UserTabs.Controls.Add(RulesTab);
            UserTabs.Location = new Point(3, 3);
            UserTabs.Name = "UserTabs";
            UserTabs.SelectedIndex = 0;
            UserTabs.Size = new Size(797, 448);
            UserTabs.TabIndex = 0;
            // 
            // AccountTab
            // 
            AccountTab.Controls.Add(FillEmailLabel);
            AccountTab.Controls.Add(FillBDLabel);
            AccountTab.Controls.Add(FillFNLabel);
            AccountTab.Controls.Add(FillPWLabel);
            AccountTab.Controls.Add(FillUNLabel);
            AccountTab.Controls.Add(AccountLabel);
            AccountTab.Controls.Add(PasswordLabel);
            AccountTab.Controls.Add(EmailLabel);
            AccountTab.Controls.Add(BirthdayLabel);
            AccountTab.Controls.Add(FullNameLabel);
            AccountTab.Controls.Add(UserNameLabel);
            AccountTab.Controls.Add(DeleteAccountButton);
            AccountTab.Controls.Add(ModifyAccountButton);
            AccountTab.Location = new Point(4, 34);
            AccountTab.Name = "AccountTab";
            AccountTab.Padding = new Padding(3);
            AccountTab.Size = new Size(789, 410);
            AccountTab.TabIndex = 0;
            AccountTab.Text = "Account";
            AccountTab.UseVisualStyleBackColor = true;
            // 
            // FillEmailLabel
            // 
            FillEmailLabel.AutoSize = true;
            FillEmailLabel.Location = new Point(313, 328);
            FillEmailLabel.Name = "FillEmailLabel";
            FillEmailLabel.Size = new Size(80, 25);
            FillEmailLabel.TabIndex = 12;
            FillEmailLabel.Text = "Fill Email";
            // 
            // FillBDLabel
            // 
            FillBDLabel.AutoSize = true;
            FillBDLabel.Location = new Point(313, 256);
            FillBDLabel.Name = "FillBDLabel";
            FillBDLabel.Size = new Size(103, 25);
            FillBDLabel.TabIndex = 11;
            FillBDLabel.Text = "Fill Birthday";
            // 
            // FillFNLabel
            // 
            FillFNLabel.AutoSize = true;
            FillFNLabel.Location = new Point(313, 184);
            FillFNLabel.Name = "FillFNLabel";
            FillFNLabel.Size = new Size(117, 25);
            FillFNLabel.TabIndex = 10;
            FillFNLabel.Text = "Fill Full Name";
            // 
            // FillPWLabel
            // 
            FillPWLabel.AutoSize = true;
            FillPWLabel.Location = new Point(313, 119);
            FillPWLabel.Name = "FillPWLabel";
            FillPWLabel.Size = new Size(113, 25);
            FillPWLabel.TabIndex = 9;
            FillPWLabel.Text = "Fill Password";
            // 
            // FillUNLabel
            // 
            FillUNLabel.AutoSize = true;
            FillUNLabel.Location = new Point(313, 62);
            FillUNLabel.Name = "FillUNLabel";
            FillUNLabel.Size = new Size(117, 25);
            FillUNLabel.TabIndex = 8;
            FillUNLabel.Text = "Fill Username";
            // 
            // AccountLabel
            // 
            AccountLabel.AutoSize = true;
            AccountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            AccountLabel.Location = new Point(204, 3);
            AccountLabel.Name = "AccountLabel";
            AccountLabel.Size = new Size(372, 48);
            AccountLabel.TabIndex = 7;
            AccountLabel.Text = "Account Information";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(163, 119);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(92, 25);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Password";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EmailLabel.Location = new Point(163, 328);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(58, 25);
            EmailLabel.TabIndex = 5;
            EmailLabel.Text = "Email";
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.AutoSize = true;
            BirthdayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BirthdayLabel.Location = new Point(163, 256);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(86, 25);
            BirthdayLabel.TabIndex = 4;
            BirthdayLabel.Text = "Birthday";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FullNameLabel.Location = new Point(163, 184);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(97, 25);
            FullNameLabel.TabIndex = 3;
            FullNameLabel.Text = "Full Name";
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLabel.Location = new Point(163, 62);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(97, 25);
            UserNameLabel.TabIndex = 2;
            UserNameLabel.Text = "Username";
            // 
            // DeleteAccountButton
            // 
            DeleteAccountButton.Location = new Point(490, 363);
            DeleteAccountButton.Name = "DeleteAccountButton";
            DeleteAccountButton.Size = new Size(151, 34);
            DeleteAccountButton.TabIndex = 1;
            DeleteAccountButton.Text = "Delete Account";
            DeleteAccountButton.UseVisualStyleBackColor = true;
            DeleteAccountButton.Click += DeleteAccountButton_Click;
            // 
            // ModifyAccountButton
            // 
            ModifyAccountButton.Location = new Point(158, 363);
            ModifyAccountButton.Name = "ModifyAccountButton";
            ModifyAccountButton.Size = new Size(112, 34);
            ModifyAccountButton.TabIndex = 0;
            ModifyAccountButton.Text = "Modify";
            ModifyAccountButton.UseVisualStyleBackColor = true;
            ModifyAccountButton.Click += ModifyAccountButton_Click;
            // 
            // CharacterTab
            // 
            CharacterTab.Controls.Add(FillSubclassLabel);
            CharacterTab.Controls.Add(FillClassLabel);
            CharacterTab.Controls.Add(FillCopperLabel);
            CharacterTab.Controls.Add(FillXPLabel);
            CharacterTab.Controls.Add(FillHealthLabel);
            CharacterTab.Controls.Add(listView1);
            CharacterTab.Controls.Add(CharacterTalentsLabel);
            CharacterTab.Controls.Add(SubclassLabel);
            CharacterTab.Controls.Add(ClassLabel);
            CharacterTab.Controls.Add(CopperLabel);
            CharacterTab.Controls.Add(XPLabel);
            CharacterTab.Controls.Add(HealthLabel);
            CharacterTab.Controls.Add(FillAgeLabel);
            CharacterTab.Controls.Add(AgeLabel);
            CharacterTab.Controls.Add(CharacterLabel);
            CharacterTab.Controls.Add(DeleteCharacterButton);
            CharacterTab.Controls.Add(ModifyCharacterButton);
            CharacterTab.Location = new Point(4, 34);
            CharacterTab.Name = "CharacterTab";
            CharacterTab.Padding = new Padding(3);
            CharacterTab.Size = new Size(789, 410);
            CharacterTab.TabIndex = 1;
            CharacterTab.Text = "Character";
            CharacterTab.UseVisualStyleBackColor = true;
            // 
            // FillSubclassLabel
            // 
            FillSubclassLabel.AutoSize = true;
            FillSubclassLabel.Location = new Point(121, 275);
            FillSubclassLabel.Name = "FillSubclassLabel";
            FillSubclassLabel.Size = new Size(44, 25);
            FillSubclassLabel.TabIndex = 16;
            FillSubclassLabel.Text = "N/A";
            // 
            // FillClassLabel
            // 
            FillClassLabel.AutoSize = true;
            FillClassLabel.Location = new Point(121, 237);
            FillClassLabel.Name = "FillClassLabel";
            FillClassLabel.Size = new Size(44, 25);
            FillClassLabel.TabIndex = 15;
            FillClassLabel.Text = "N/A";
            // 
            // FillCopperLabel
            // 
            FillCopperLabel.AutoSize = true;
            FillCopperLabel.Location = new Point(121, 198);
            FillCopperLabel.Name = "FillCopperLabel";
            FillCopperLabel.Size = new Size(44, 25);
            FillCopperLabel.TabIndex = 14;
            FillCopperLabel.Text = "N/A";
            // 
            // FillXPLabel
            // 
            FillXPLabel.AutoSize = true;
            FillXPLabel.Location = new Point(121, 163);
            FillXPLabel.Name = "FillXPLabel";
            FillXPLabel.Size = new Size(44, 25);
            FillXPLabel.TabIndex = 13;
            FillXPLabel.Text = "N/A";
            // 
            // FillHealthLabel
            // 
            FillHealthLabel.AutoSize = true;
            FillHealthLabel.Location = new Point(121, 126);
            FillHealthLabel.Name = "FillHealthLabel";
            FillHealthLabel.Size = new Size(44, 25);
            FillHealthLabel.TabIndex = 12;
            FillHealthLabel.Text = "N/A";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { RankColumn, TalentNameColumn });
            listView1.Location = new Point(248, 96);
            listView1.Name = "listView1";
            listView1.Size = new Size(533, 209);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // CharacterTalentsLabel
            // 
            CharacterTalentsLabel.AutoSize = true;
            CharacterTalentsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CharacterTalentsLabel.Location = new Point(458, 68);
            CharacterTalentsLabel.Name = "CharacterTalentsLabel";
            CharacterTalentsLabel.Size = new Size(75, 25);
            CharacterTalentsLabel.TabIndex = 10;
            CharacterTalentsLabel.Text = "Talents";
            // 
            // SubclassLabel
            // 
            SubclassLabel.AutoSize = true;
            SubclassLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SubclassLabel.Location = new Point(29, 275);
            SubclassLabel.Name = "SubclassLabel";
            SubclassLabel.Size = new Size(84, 25);
            SubclassLabel.TabIndex = 9;
            SubclassLabel.Text = "Subclass";
            // 
            // ClassLabel
            // 
            ClassLabel.AutoSize = true;
            ClassLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClassLabel.Location = new Point(29, 237);
            ClassLabel.Name = "ClassLabel";
            ClassLabel.Size = new Size(54, 25);
            ClassLabel.TabIndex = 8;
            ClassLabel.Text = "Class";
            // 
            // CopperLabel
            // 
            CopperLabel.AutoSize = true;
            CopperLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CopperLabel.Location = new Point(29, 198);
            CopperLabel.Name = "CopperLabel";
            CopperLabel.Size = new Size(73, 25);
            CopperLabel.TabIndex = 7;
            CopperLabel.Text = "Copper";
            // 
            // XPLabel
            // 
            XPLabel.AutoSize = true;
            XPLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            XPLabel.Location = new Point(29, 163);
            XPLabel.Name = "XPLabel";
            XPLabel.Size = new Size(35, 25);
            XPLabel.TabIndex = 6;
            XPLabel.Text = "XP";
            // 
            // HealthLabel
            // 
            HealthLabel.AutoSize = true;
            HealthLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HealthLabel.Location = new Point(29, 126);
            HealthLabel.Name = "HealthLabel";
            HealthLabel.Size = new Size(69, 25);
            HealthLabel.TabIndex = 5;
            HealthLabel.Text = "Health";
            // 
            // FillAgeLabel
            // 
            FillAgeLabel.AutoSize = true;
            FillAgeLabel.Location = new Point(121, 88);
            FillAgeLabel.Name = "FillAgeLabel";
            FillAgeLabel.Size = new Size(44, 25);
            FillAgeLabel.TabIndex = 4;
            FillAgeLabel.Text = "N/A";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AgeLabel.Location = new Point(29, 88);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(46, 25);
            AgeLabel.TabIndex = 3;
            AgeLabel.Text = "Age";
            // 
            // CharacterLabel
            // 
            CharacterLabel.AutoSize = true;
            CharacterLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            CharacterLabel.Location = new Point(290, 3);
            CharacterLabel.Name = "CharacterLabel";
            CharacterLabel.Size = new Size(180, 48);
            CharacterLabel.TabIndex = 2;
            CharacterLabel.Text = "Character";
            // 
            // DeleteCharacterButton
            // 
            DeleteCharacterButton.Location = new Point(458, 343);
            DeleteCharacterButton.Name = "DeleteCharacterButton";
            DeleteCharacterButton.Size = new Size(158, 34);
            DeleteCharacterButton.TabIndex = 1;
            DeleteCharacterButton.Text = "Delete Character";
            DeleteCharacterButton.UseVisualStyleBackColor = true;
            // 
            // ModifyCharacterButton
            // 
            ModifyCharacterButton.Location = new Point(168, 343);
            ModifyCharacterButton.Name = "ModifyCharacterButton";
            ModifyCharacterButton.Size = new Size(112, 34);
            ModifyCharacterButton.TabIndex = 0;
            ModifyCharacterButton.Text = "Modify";
            ModifyCharacterButton.UseVisualStyleBackColor = true;
            ModifyCharacterButton.Click += ModifyCharacterButton_Click;
            // 
            // RulesTab
            // 
            RulesTab.Controls.Add(ItemListView);
            RulesTab.Controls.Add(SelectButton);
            RulesTab.Controls.Add(BackButton);
            RulesTab.Controls.Add(EncyclopediaTalentsButton);
            RulesTab.Controls.Add(EncyclopediaSubclassButton);
            RulesTab.Controls.Add(EncyclopediaClassButton);
            RulesTab.Controls.Add(label2);
            RulesTab.Controls.Add(label1);
            RulesTab.Location = new Point(4, 34);
            RulesTab.Name = "RulesTab";
            RulesTab.Padding = new Padding(3);
            RulesTab.Size = new Size(789, 410);
            RulesTab.TabIndex = 2;
            RulesTab.Text = " Rules Encyclopedia";
            RulesTab.UseVisualStyleBackColor = true;
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(646, 367);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(112, 34);
            SelectButton.TabIndex = 9;
            SelectButton.Text = "Select";
            SelectButton.UseVisualStyleBackColor = true;
            SelectButton.Click += SelectButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(22, 367);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(112, 34);
            BackButton.TabIndex = 8;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // EncyclopediaTalentsButton
            // 
            EncyclopediaTalentsButton.Location = new Point(232, 304);
            EncyclopediaTalentsButton.Name = "EncyclopediaTalentsButton";
            EncyclopediaTalentsButton.Size = new Size(300, 100);
            EncyclopediaTalentsButton.TabIndex = 6;
            EncyclopediaTalentsButton.Text = "Talents";
            EncyclopediaTalentsButton.UseVisualStyleBackColor = true;
            EncyclopediaTalentsButton.Click += EncyclopediaTalentsButton_Click;
            // 
            // EncyclopediaSubclassButton
            // 
            EncyclopediaSubclassButton.Location = new Point(232, 185);
            EncyclopediaSubclassButton.Name = "EncyclopediaSubclassButton";
            EncyclopediaSubclassButton.Size = new Size(300, 100);
            EncyclopediaSubclassButton.TabIndex = 5;
            EncyclopediaSubclassButton.Text = "Subclasses";
            EncyclopediaSubclassButton.UseVisualStyleBackColor = true;
            EncyclopediaSubclassButton.Click += EncyclopediaSubclassButton_Click;
            // 
            // EncyclopediaClassButton
            // 
            EncyclopediaClassButton.Location = new Point(232, 68);
            EncyclopediaClassButton.Name = "EncyclopediaClassButton";
            EncyclopediaClassButton.Size = new Size(300, 100);
            EncyclopediaClassButton.TabIndex = 4;
            EncyclopediaClassButton.Text = "Classes";
            EncyclopediaClassButton.UseVisualStyleBackColor = true;
            EncyclopediaClassButton.Click += EncyclopediaClassButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(241, 3);
            label2.Name = "label2";
            label2.Size = new Size(314, 48);
            label2.TabIndex = 3;
            label2.Text = "Table of Contents";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 30);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // ItemListView
            // 
            ItemListView.Location = new Point(22, 54);
            ItemListView.Name = "ItemListView";
            ItemListView.Size = new Size(736, 307);
            ItemListView.TabIndex = 10;
            ItemListView.UseCompatibleStateImageBehavior = false;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UserTabs);
            Name = "UserForm";
            Text = "UserForm";
            UserTabs.ResumeLayout(false);
            AccountTab.ResumeLayout(false);
            AccountTab.PerformLayout();
            CharacterTab.ResumeLayout(false);
            CharacterTab.PerformLayout();
            RulesTab.ResumeLayout(false);
            RulesTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl UserTabs;
        private TabPage AccountTab;
        private TabPage CharacterTab;
        private TabPage RulesTab;
        private Button DeleteCharacterButton;
        private Button ModifyCharacterButton;
        private Button ModifyAccountButton;
        private Button DeleteAccountButton;
        private Label UserNameLabel;
        private Label BirthdayLabel;
        private Label FullNameLabel;
        private Label EmailLabel;
        private Label PasswordLabel;
        private Label AccountLabel;
        private Label FillUNLabel;
        private Label FillEmailLabel;
        private Label FillBDLabel;
        private Label FillFNLabel;
        private Label FillPWLabel;
        private Label CharacterLabel;
        private Label AgeLabel;
        private Label FillAgeLabel;
        private Label HealthLabel;
        private Label XPLabel;
        private Label CopperLabel;
        private Label ClassLabel;
        private Label SubclassLabel;
        private Label CharacterTalentsLabel;
        private ListView listView1;
        private Label FillXPLabel;
        private Label FillHealthLabel;
        private Label FillSubclassLabel;
        private Label FillClassLabel;
        private Label FillCopperLabel;
        private Label label2;
        private Label label1;
        private Button EncyclopediaTalentsButton;
        private Button EncyclopediaSubclassButton;
        private Button EncyclopediaClassButton;
        private ColumnHeader RankColumn;
        private ColumnHeader TalentNameColumn;
        private Button BackButton;
        private Button SelectButton;
        private ListView ItemListView;
    }
}