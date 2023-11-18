namespace Minesweeper_code
{
    partial class MinesweeperGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinesweeperGame));
            P1Name = new Label();
            P2Name = new Label();
            player1TableLayoutPanel = new TableLayoutPanel();
            player2TableLayoutPanel = new TableLayoutPanel();
            player1ScoreLabel = new Label();
            player2ScoreLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // P1Name
            // 
            P1Name.BackColor = Color.FromArgb(170, 56, 30);
            P1Name.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            P1Name.ForeColor = SystemColors.ButtonHighlight;
            P1Name.Location = new Point(28, 25);
            P1Name.MaximumSize = new Size(1000, 1000);
            P1Name.Name = "P1Name";
            P1Name.Size = new Size(74, 37);
            P1Name.TabIndex = 2;
            P1Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // P2Name
            // 
            P2Name.BackColor = Color.FromArgb(170, 56, 30);
            P2Name.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            P2Name.ForeColor = SystemColors.ButtonHighlight;
            P2Name.Location = new Point(578, 25);
            P2Name.MaximumSize = new Size(1000, 1000);
            P2Name.Name = "P2Name";
            P2Name.Size = new Size(74, 37);
            P2Name.TabIndex = 3;
            P2Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // player1TableLayoutPanel
            // 
            player1TableLayoutPanel.BackColor = Color.White;
            player1TableLayoutPanel.ColumnCount = 10;
            player1TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.ForeColor = Color.FromArgb(170, 56, 30);
            player1TableLayoutPanel.Location = new Point(12, 80);
            player1TableLayoutPanel.Name = "player1TableLayoutPanel";
            player1TableLayoutPanel.RowCount = 10;
            player1TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player1TableLayoutPanel.Size = new Size(475, 434);
            player1TableLayoutPanel.TabIndex = 4;
            // 
            // player2TableLayoutPanel
            // 
            player2TableLayoutPanel.BackColor = Color.White;
            player2TableLayoutPanel.ColumnCount = 10;
            player2TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.ForeColor = Color.FromArgb(170, 56, 30);
            player2TableLayoutPanel.Location = new Point(578, 80);
            player2TableLayoutPanel.Name = "player2TableLayoutPanel";
            player2TableLayoutPanel.RowCount = 10;
            player2TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            player2TableLayoutPanel.Size = new Size(492, 434);
            player2TableLayoutPanel.TabIndex = 5;
            // 
            // player1ScoreLabel
            // 
            player1ScoreLabel.BackColor = Color.FromArgb(170, 56, 30);
            player1ScoreLabel.ForeColor = SystemColors.ButtonHighlight;
            player1ScoreLabel.Location = new Point(12, 548);
            player1ScoreLabel.Name = "player1ScoreLabel";
            player1ScoreLabel.Size = new Size(220, 32);
            player1ScoreLabel.TabIndex = 6;
            player1ScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // player2ScoreLabel
            // 
            player2ScoreLabel.BackColor = Color.FromArgb(170, 56, 30);
            player2ScoreLabel.ForeColor = SystemColors.ButtonHighlight;
            player2ScoreLabel.Location = new Point(589, 548);
            player2ScoreLabel.Name = "player2ScoreLabel";
            player2ScoreLabel.Size = new Size(235, 32);
            player2ScoreLabel.TabIndex = 7;
            player2ScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(450, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(450, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1033, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1033, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // MinesweeperGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 94, 62);
            ClientSize = new Size(1082, 634);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(player2ScoreLabel);
            Controls.Add(player1ScoreLabel);
            Controls.Add(player2TableLayoutPanel);
            Controls.Add(P2Name);
            Controls.Add(P1Name);
            Controls.Add(player1TableLayoutPanel);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MinesweeperGame";
            Text = "Game";
            Load += MinesweeperGame_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label P1Name;
        private Label P2Name;
        private TableLayoutPanel player1TableLayoutPanel;
        private TableLayoutPanel player2TableLayoutPanel;
        private Label player1ScoreLabel;
        private Label player2ScoreLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }


}