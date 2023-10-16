namespace Minesweeper_code
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Create Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(15, 56);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 1;
            label2.Text = "Create Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(170, 56, 30);
            button1.Location = new Point(277, 20);
            button1.Name = "button1";
            button1.Size = new Size(160, 87);
            button1.TabIndex = 4;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(170, 56, 30);
            textBox1.Location = new Point(143, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(170, 56, 30);
            textBox2.Location = new Point(143, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(170, 56, 30);
            textBox3.Location = new Point(143, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 94, 62);
            ClientSize = new Size(468, 134);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateAccount";
            Text = "Create Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}