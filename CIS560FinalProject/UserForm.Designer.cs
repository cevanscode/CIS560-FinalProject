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
            DeleteCharacterButton = new Button();
            ModifyCharacterButton = new Button();
            RulesTab = new TabPage();
            CharacterLabel = new Label();
            AgeLabel = new Label();
            UserTabs.SuspendLayout();
            AccountTab.SuspendLayout();
            CharacterTab.SuspendLayout();
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
            RulesTab.Location = new Point(4, 34);
            RulesTab.Name = "RulesTab";
            RulesTab.Padding = new Padding(3);
            RulesTab.Size = new Size(789, 410);
            RulesTab.TabIndex = 2;
            RulesTab.Text = " Rules Encyclopedia";
            RulesTab.UseVisualStyleBackColor = true;
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
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AgeLabel.Location = new Point(29, 68);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(46, 25);
            AgeLabel.TabIndex = 3;
            AgeLabel.Text = "Age";
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
    }
}