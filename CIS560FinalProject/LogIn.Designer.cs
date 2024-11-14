namespace CIS560FinalProject
{
    partial class LogIn
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
            PasswordTextBox = new TextBox();
            Title = new Label();
            label2 = new Label();
            label3 = new Label();
            LoginButton = new Button();
            button2 = new Button();
            StartNoLoginButton = new Button();
            SuspendLayout();
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(165, 81);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(150, 31);
            UsernameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(165, 141);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(150, 31);
            PasswordTextBox.TabIndex = 1;
            // 
            // Title
            // 
            Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(150, 10);
            Title.Name = "Title";
            Title.Size = new Size(119, 52);
            Title.TabIndex = 2;
            Title.Text = "LARP";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 141);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 81);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(165, 202);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(112, 34);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(123, 404);
            button2.Name = "button2";
            button2.Size = new Size(227, 34);
            button2.TabIndex = 6;
            button2.Text = "Create New Account";
            button2.UseVisualStyleBackColor = true;
            // 
            // StartNoLoginButton
            // 
            StartNoLoginButton.Location = new Point(123, 364);
            StartNoLoginButton.Name = "StartNoLoginButton";
            StartNoLoginButton.Size = new Size(227, 34);
            StartNoLoginButton.TabIndex = 7;
            StartNoLoginButton.Text = "Start Without Logging In";
            StartNoLoginButton.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 444);
            Controls.Add(StartNoLoginButton);
            Controls.Add(button2);
            Controls.Add(LoginButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Title);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Name = "LogIn";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Label Title;
        private Label label2;
        private Label label3;
        private Button LoginButton;
        private Button button2;
        private Button StartNoLoginButton;
    }
}