namespace Minesweeper_code
{
    partial class Rules
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(-3, -2);
            label1.Name = "label1";
            label1.Size = new Size(344, 21);
            label1.TabIndex = 0;
            label1.Text = "Welcome to minesweeper (military edition)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(1, 19);
            label2.Name = "label2";
            label2.Size = new Size(685, 34);
            label2.TabIndex = 1;
            label2.Text = "This is a two player game, hence there are a few more rules that you need to be aware of before playing this game \r\neffectively:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(1, 67);
            label3.Name = "label3";
            label3.Size = new Size(644, 272);
            label3.TabIndex = 2;
            label3.Text = resources.GetString("label3.Text");
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(170, 56, 30);
            textBox1.ForeColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(122, 353);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(170, 56, 30);
            textBox2.ForeColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(122, 393);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(170, 56, 30);
            textBox3.ForeColor = SystemColors.ButtonHighlight;
            textBox3.Location = new Point(347, 353);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(170, 56, 30);
            textBox4.ForeColor = SystemColors.ButtonHighlight;
            textBox4.Location = new Point(347, 393);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 356);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 7;
            label4.Text = "Player 1 Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 396);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 8;
            label5.Text = "Player 1 Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(237, 356);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 9;
            label6.Text = "Player 2 Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(237, 396);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 10;
            label7.Text = "Player 2 Password";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(170, 56, 30);
            button1.Location = new Point(465, 353);
            button1.Name = "button1";
            button1.Size = new Size(108, 63);
            button1.TabIndex = 11;
            button1.Text = "Create account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(75, 83, 32);
            button2.Location = new Point(595, 353);
            button2.Name = "button2";
            button2.Size = new Size(102, 63);
            button2.TabIndex = 12;
            button2.Text = "Play Game";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Rules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 94, 62);
            ClientSize = new Size(728, 441);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Rules";
            Text = "Rules";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
    }
}