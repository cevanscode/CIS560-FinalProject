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
            CharacterTab = new TabPage();
            RulesTab = new TabPage();
            UserTabs.SuspendLayout();
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
            AccountTab.Location = new Point(4, 34);
            AccountTab.Name = "AccountTab";
            AccountTab.Padding = new Padding(3);
            AccountTab.Size = new Size(789, 410);
            AccountTab.TabIndex = 0;
            AccountTab.Text = "Account";
            AccountTab.UseVisualStyleBackColor = true;
            // 
            // CharacterTab
            // 
            CharacterTab.Location = new Point(4, 34);
            CharacterTab.Name = "CharacterTab";
            CharacterTab.Padding = new Padding(3);
            CharacterTab.Size = new Size(789, 410);
            CharacterTab.TabIndex = 1;
            CharacterTab.Text = "Character";
            CharacterTab.UseVisualStyleBackColor = true;
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
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UserTabs);
            Name = "UserForm";
            Text = "UserForm";
            UserTabs.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl UserTabs;
        private TabPage AccountTab;
        private TabPage CharacterTab;
        private TabPage RulesTab;
    }
}