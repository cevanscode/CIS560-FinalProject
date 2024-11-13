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
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(130, 348);
            button1.Name = "button1";
            button1.Size = new Size(163, 34);
            button1.TabIndex = 0;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 209);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 8;
            label3.Text = "Create Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 272);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 7;
            label2.Text = "Create Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 37);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 12;
            label1.Text = "Enter Full Name";
            label1.Click += this.label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 97);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 11;
            label4.Text = "Enter Birthday";
            label4.Click += this.label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += this.textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(224, 209);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 153);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 14;
            label5.Text = "Enter Email";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(224, 153);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(154, 388);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 15;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 444);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Button button2;
    }
}