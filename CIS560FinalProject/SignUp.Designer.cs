namespace CIS560FinalProject
{
    partial class SignUp
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
            CreateAccountButton = new Button();
            label3 = new Label();
            label2 = new Label();
            FullNameTextBox = new TextBox();
            label1 = new Label();
            label4 = new Label();
            PasswordTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            label5 = new Label();
            EmailTextBox = new TextBox();
            CancelButton = new Button();
            label6 = new Label();
            BirthdayPicker = new DateTimePicker();
            SuspendLayout();
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.Location = new Point(130, 348);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(163, 34);
            CreateAccountButton.TabIndex = 0;
            CreateAccountButton.Text = "Create Account";
            CreateAccountButton.UseVisualStyleBackColor = true;
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 242);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 8;
            label3.Text = "Create Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 305);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 7;
            label2.Text = "Create Password";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(224, 70);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(300, 31);
            FullNameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 70);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 12;
            label1.Text = "Enter Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 130);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 11;
            label4.Text = "Enter Birthday";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(224, 302);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(300, 31);
            PasswordTextBox.TabIndex = 10;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(224, 242);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(300, 31);
            UsernameTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 186);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 14;
            label5.Text = "Enter Email";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(224, 186);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(300, 31);
            EmailTextBox.TabIndex = 13;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(154, 388);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 34);
            CancelButton.TabIndex = 15;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(155, 15);
            label6.Name = "label6";
            label6.Size = new Size(134, 45);
            label6.TabIndex = 16;
            label6.Text = "Sign Up";
            // 
            // BirthdayPicker
            // 
            BirthdayPicker.Location = new Point(224, 130);
            BirthdayPicker.Name = "BirthdayPicker";
            BirthdayPicker.Size = new Size(300, 31);
            BirthdayPicker.TabIndex = 17;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 444);
            Controls.Add(BirthdayPicker);
            Controls.Add(label6);
            Controls.Add(CancelButton);
            Controls.Add(label5);
            Controls.Add(EmailTextBox);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(FullNameTextBox);
            Controls.Add(CreateAccountButton);
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateAccountButton;
        private Label label3;
        private Label label2;
        private TextBox FullNameTextBox;
        private Label label1;
        private Label label4;
        private TextBox PasswordTextBox;
        private TextBox UsernameTextBox;
        private Label label5;
        private TextBox EmailTextBox;
        private Button CancelButton;
        private Label label6;
        private DateTimePicker BirthdayPicker;
    }
}