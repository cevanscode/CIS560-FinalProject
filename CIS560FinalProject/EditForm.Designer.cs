namespace CIS560FinalProject
{
    partial class EditForm
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
            UsernameTextBox = new TextBox();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            EmailLabel = new Label();
            EmailTextBox = new TextBox();
            FullNameLabel = new Label();
            FullNameTextBox = new TextBox();
            BirthdayTextBox = new TextBox();
            BirthdayLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(142, 25);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(150, 31);
            UsernameTextBox.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(12, 28);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(91, 25);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(12, 79);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(87, 25);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(142, 79);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(150, 31);
            PasswordTextBox.TabIndex = 3;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(12, 126);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(54, 25);
            EmailLabel.TabIndex = 4;
            EmailLabel.Text = "Email";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(142, 126);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(150, 31);
            EmailTextBox.TabIndex = 5;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(12, 178);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(91, 25);
            FullNameLabel.TabIndex = 6;
            FullNameLabel.Text = "Full Name";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(142, 178);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(150, 31);
            FullNameTextBox.TabIndex = 7;
            // 
            // BirthdayTextBox
            // 
            BirthdayTextBox.Location = new Point(142, 229);
            BirthdayTextBox.Name = "BirthdayTextBox";
            BirthdayTextBox.Size = new Size(150, 31);
            BirthdayTextBox.TabIndex = 8;
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.AutoSize = true;
            BirthdayLabel.Location = new Point(12, 229);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(77, 25);
            BirthdayLabel.TabIndex = 9;
            BirthdayLabel.Text = "Birthday";
            // 
            // button1
            // 
            button1.Location = new Point(106, 404);
            button1.Name = "button1";
            button1.Size = new Size(163, 34);
            button1.TabIndex = 10;
            button1.Text = "Confirm Changes";
            button1.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 450);
            Controls.Add(button1);
            Controls.Add(BirthdayLabel);
            Controls.Add(BirthdayTextBox);
            Controls.Add(FullNameTextBox);
            Controls.Add(FullNameLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(UsernameTextBox);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameTextBox;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Label EmailLabel;
        private TextBox EmailTextBox;
        private Label FullNameLabel;
        private TextBox FullNameTextBox;
        private TextBox BirthdayTextBox;
        private Label BirthdayLabel;
        private Button button1;
    }
}