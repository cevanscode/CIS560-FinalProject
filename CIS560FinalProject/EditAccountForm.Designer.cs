﻿namespace CIS560FinalProject
{
    partial class EditAccountForm
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
            BirthdayLabel = new Label();
            button1 = new Button();
            BirthdayPicker = new DateTimePicker();
            SuspendLayout();
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(142, 25);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(294, 31);
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
            PasswordTextBox.Size = new Size(294, 31);
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
            EmailTextBox.Size = new Size(294, 31);
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
            FullNameTextBox.Size = new Size(294, 31);
            FullNameTextBox.TabIndex = 7;
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
            button1.Location = new Point(106, 284);
            button1.Name = "button1";
            button1.Size = new Size(163, 34);
            button1.TabIndex = 10;
            button1.Text = "Confirm Changes";
            button1.UseVisualStyleBackColor = true;
            // 
            // BirthdayPicker
            // 
            BirthdayPicker.Location = new Point(142, 229);
            BirthdayPicker.Name = "BirthdayPicker";
            BirthdayPicker.Size = new Size(294, 31);
            BirthdayPicker.TabIndex = 11;
            // 
            // EditAccountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 346);
            Controls.Add(BirthdayPicker);
            Controls.Add(button1);
            Controls.Add(BirthdayLabel);
            Controls.Add(FullNameTextBox);
            Controls.Add(FullNameLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(UsernameTextBox);
            Name = "EditAccountForm";
            Text = "Edit Account";
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
        private Label BirthdayLabel;
        private Button button1;
        private DateTimePicker BirthdayPicker;
    }
}