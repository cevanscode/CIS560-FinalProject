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
            RulesTab = new TabPage();
            CharacterOptionsListView = new ListView();
            ReadButton = new Button();
            BackButton = new Button();
            EncyclopediaTalentsButton = new Button();
            EncyclopediaClassButton = new Button();
            TitleLabel = new Label();
            label1 = new Label();
            CharacterTab = new TabPage();
            FillSubclassLabel = new Label();
            FillClassLabel = new Label();
            FillCopperLabel = new Label();
            FillXPLabel = new Label();
            FillHealthLabel = new Label();
            listView1 = new ListView();
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
            UserTabs = new TabControl();
            tabPage1 = new TabPage();
            ClassPopularityButton = new Button();
            TalentPopularityButton = new Button();
            TalentRankingsButton = new Button();
            CopperAccumulationButton = new Button();
            RulesTab.SuspendLayout();
            CharacterTab.SuspendLayout();
            AccountTab.SuspendLayout();
            UserTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // RulesTab
            // 
            RulesTab.Controls.Add(CharacterOptionsListView);
            RulesTab.Controls.Add(ReadButton);
            RulesTab.Controls.Add(BackButton);
            RulesTab.Controls.Add(EncyclopediaTalentsButton);
            RulesTab.Controls.Add(EncyclopediaClassButton);
            RulesTab.Controls.Add(TitleLabel);
            RulesTab.Controls.Add(label1);
            RulesTab.Location = new Point(4, 34);
            RulesTab.Name = "RulesTab";
            RulesTab.Padding = new Padding(3);
            RulesTab.Size = new Size(789, 410);
            RulesTab.TabIndex = 2;
            RulesTab.Text = " Rules Encyclopedia";
            RulesTab.UseVisualStyleBackColor = true;
            // 
            // CharacterOptionsListView
            // 
            CharacterOptionsListView.Location = new Point(133, 75);
            CharacterOptionsListView.Name = "CharacterOptionsListView";
            CharacterOptionsListView.Size = new Size(528, 263);
            CharacterOptionsListView.TabIndex = 9;
            CharacterOptionsListView.UseCompatibleStateImageBehavior = false;
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(671, 370);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(112, 34);
            ReadButton.TabIndex = 8;
            ReadButton.Text = "Read";
            ReadButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(6, 367);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(112, 34);
            BackButton.TabIndex = 7;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Visible = false;
            BackButton.Click += BackButton_Click;
            // 
            // EncyclopediaTalentsButton
            // 
            EncyclopediaTalentsButton.Location = new Point(232, 301);
            EncyclopediaTalentsButton.Name = "EncyclopediaTalentsButton";
            EncyclopediaTalentsButton.Size = new Size(300, 100);
            EncyclopediaTalentsButton.TabIndex = 6;
            EncyclopediaTalentsButton.Text = "Talents";
            EncyclopediaTalentsButton.UseVisualStyleBackColor = true;
            EncyclopediaTalentsButton.Click += EncyclopediaTalentsButton_Click;
            // 
            // EncyclopediaClassButton
            // 
            EncyclopediaClassButton.Location = new Point(232, 124);
            EncyclopediaClassButton.Name = "EncyclopediaClassButton";
            EncyclopediaClassButton.Size = new Size(300, 100);
            EncyclopediaClassButton.TabIndex = 4;
            EncyclopediaClassButton.Text = "Classes";
            EncyclopediaClassButton.UseVisualStyleBackColor = true;
            EncyclopediaClassButton.Click += EncyclopediaClassButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.Location = new Point(241, 3);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(314, 48);
            TitleLabel.TabIndex = 3;
            TitleLabel.Text = "Table of Contents";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 30);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
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
            FillSubclassLabel.Size = new Size(106, 25);
            FillSubclassLabel.TabIndex = 16;
            FillSubclassLabel.Text = "Fill Subclass";
            // 
            // FillClassLabel
            // 
            FillClassLabel.AutoSize = true;
            FillClassLabel.Location = new Point(121, 237);
            FillClassLabel.Name = "FillClassLabel";
            FillClassLabel.Size = new Size(78, 25);
            FillClassLabel.TabIndex = 15;
            FillClassLabel.Text = "Fill Class";
            // 
            // FillCopperLabel
            // 
            FillCopperLabel.AutoSize = true;
            FillCopperLabel.Location = new Point(121, 198);
            FillCopperLabel.Name = "FillCopperLabel";
            FillCopperLabel.Size = new Size(97, 25);
            FillCopperLabel.TabIndex = 14;
            FillCopperLabel.Text = "Fill Copper";
            // 
            // FillXPLabel
            // 
            FillXPLabel.AutoSize = true;
            FillXPLabel.Location = new Point(121, 163);
            FillXPLabel.Name = "FillXPLabel";
            FillXPLabel.Size = new Size(59, 25);
            FillXPLabel.TabIndex = 13;
            FillXPLabel.Text = "Fill XP";
            // 
            // FillHealthLabel
            // 
            FillHealthLabel.AutoSize = true;
            FillHealthLabel.Location = new Point(121, 126);
            FillHealthLabel.Name = "FillHealthLabel";
            FillHealthLabel.Size = new Size(89, 25);
            FillHealthLabel.TabIndex = 12;
            FillHealthLabel.Text = "Fill Health";
            // 
            // listView1
            // 
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
            FillAgeLabel.Size = new Size(70, 25);
            FillAgeLabel.TabIndex = 4;
            FillAgeLabel.Text = "Fill Age";
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
            // UserTabs
            // 
            UserTabs.Controls.Add(AccountTab);
            UserTabs.Controls.Add(CharacterTab);
            UserTabs.Controls.Add(RulesTab);
            UserTabs.Controls.Add(tabPage1);
            UserTabs.Location = new Point(3, 3);
            UserTabs.Name = "UserTabs";
            UserTabs.SelectedIndex = 0;
            UserTabs.Size = new Size(797, 448);
            UserTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(CopperAccumulationButton);
            tabPage1.Controls.Add(TalentRankingsButton);
            tabPage1.Controls.Add(TalentPopularityButton);
            tabPage1.Controls.Add(ClassPopularityButton);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 410);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "AdminTab";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ClassPopularityButton
            // 
            ClassPopularityButton.Location = new Point(26, 6);
            ClassPopularityButton.Name = "ClassPopularityButton";
            ClassPopularityButton.Size = new Size(146, 34);
            ClassPopularityButton.TabIndex = 0;
            ClassPopularityButton.Text = "Class Popularity";
            ClassPopularityButton.UseVisualStyleBackColor = true;
            // 
            // TalentPopularityButton
            // 
            TalentPopularityButton.Location = new Point(197, 6);
            TalentPopularityButton.Name = "TalentPopularityButton";
            TalentPopularityButton.Size = new Size(156, 34);
            TalentPopularityButton.TabIndex = 1;
            TalentPopularityButton.Text = "Talent Popularity";
            TalentPopularityButton.UseVisualStyleBackColor = true;
            // 
            // TalentRankingsButton
            // 
            TalentRankingsButton.Location = new Point(376, 6);
            TalentRankingsButton.Name = "TalentRankingsButton";
            TalentRankingsButton.Size = new Size(150, 34);
            TalentRankingsButton.TabIndex = 2;
            TalentRankingsButton.Text = "Talent Rankings";
            TalentRankingsButton.UseVisualStyleBackColor = true;
            // 
            // CopperAccumulationButton
            // 
            CopperAccumulationButton.Location = new Point(556, 6);
            CopperAccumulationButton.Name = "CopperAccumulationButton";
            CopperAccumulationButton.Size = new Size(203, 34);
            CopperAccumulationButton.TabIndex = 3;
            CopperAccumulationButton.Text = "Copper Accumulation";
            CopperAccumulationButton.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UserTabs);
            Name = "UserForm";
            Text = "UserForm";
            RulesTab.ResumeLayout(false);
            RulesTab.PerformLayout();
            CharacterTab.ResumeLayout(false);
            CharacterTab.PerformLayout();
            AccountTab.ResumeLayout(false);
            AccountTab.PerformLayout();
            UserTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage RulesTab;
        private Button EncyclopediaTalentsButton;
        private Button EncyclopediaClassButton;
        private Label TitleLabel;
        private Label label1;
        private TabPage CharacterTab;
        private Label FillSubclassLabel;
        private Label FillClassLabel;
        private Label FillCopperLabel;
        private Label FillXPLabel;
        private Label FillHealthLabel;
        private ListView listView1;
        private Label CharacterTalentsLabel;
        private Label SubclassLabel;
        private Label ClassLabel;
        private Label CopperLabel;
        private Label XPLabel;
        private Label HealthLabel;
        private Label FillAgeLabel;
        private Label AgeLabel;
        private Label CharacterLabel;
        private Button DeleteCharacterButton;
        private Button ModifyCharacterButton;
        private TabPage AccountTab;
        private Label FillEmailLabel;
        private Label FillBDLabel;
        private Label FillFNLabel;
        private Label FillPWLabel;
        private Label FillUNLabel;
        private Label AccountLabel;
        private Label PasswordLabel;
        private Label EmailLabel;
        private Label BirthdayLabel;
        private Label FullNameLabel;
        private Label UserNameLabel;
        private Button DeleteAccountButton;
        private Button ModifyAccountButton;
        private TabControl UserTabs;
        private TabPage tabPage1;
        private Button BackButton;
        private ListView CharacterOptionsListView;
        private Button ReadButton;
        private Button ClassPopularityButton;
        private Button CopperAccumulationButton;
        private Button TalentRankingsButton;
        private Button TalentPopularityButton;
    }
}