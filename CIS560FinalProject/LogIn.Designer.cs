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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Title = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
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
            // button1
            // 
            button1.Location = new Point(165, 202);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
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
            // button3
            // 
            button3.Location = new Point(123, 364);
            button3.Name = "button3";
            button3.Size = new Size(227, 34);
            button3.TabIndex = 7;
            button3.Text = "Start Without Logging In";
            button3.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 444);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Title);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "LogIn";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label Title;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}