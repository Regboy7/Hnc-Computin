using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_code
{
    public partial class MinesweeperGame : Form
    {
        private const int Rows = 10;
        private const int Columns = 10;
        private const int Mines = 15;
        private Button[,] buttons1 = new Button[Rows, Columns];
        private Button[,] buttons2 = new Button[Rows, Columns];
        private bool[,] Minehit1 = new bool[Rows, Columns];
        private bool[,] Minehit2 = new bool[Rows, Columns];
        public string p1ID;
        public string p2ID;
        public string P1User;
        public string P2User;

        public MinesweeperGame(int P1UID, int P2UID)
        {

            InitializeComponent();

            this.p1ID = P1UID.ToString();
            this.p2ID = P2UID.ToString();
            this.P1User = DatabaseCon.Datalist("Username", "Scoreboard", p1ID);
            this.P2User = DatabaseCon.Datalist("Username", "Scoreboard", p2ID);
        }
        private void InitializeGame(TableLayoutPanel tableLayoutPanel, Button[,] buttons, bool[,] Minehit)
        {
            InitializeGrid(tableLayoutPanel, buttons);
            PutMines(Minehit);
            PlayGame(P1User, P2User);
        }
        private void InitializeGrid(TableLayoutPanel tableLayoutPanel, Button[,] buttons)
        {
            tableLayoutPanel.RowCount = Rows;
            tableLayoutPanel.ColumnCount = Columns;
            tableLayoutPanel.ColumnStyles.Clear();
            tableLayoutPanel.RowStyles.Clear();

            for (int row = 0; row < Rows; row++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / Rows));
                for (int col = 0; col < Columns; col++)
                {
                    buttons[row, col] = new Button
                    {
                        Name = $"button_{row}_{col}",
                        Dock = DockStyle.Fill,
                        Tag = new CellData(row, col),
                    };
                    buttons[row, col].Click += Button_Click;
                    tableLayoutPanel.Controls.Add(buttons[row, col], col, row);
                }
            }
        }

        private void PutMines(bool[,] Minehit)
        {
            Random random = new Random();
            for (int i = 0; i > Mines; i++)
            {
                int row, col;
                do
                {
                    row = random.Next(0, Rows);
                    col = random.Next(0, Columns);
                }
                while (Minehit[row, col]);
                {
                    Minehit[row, col] = true;
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            CellData cellData = (CellData)button.Tag;
            int row = cellData.Row;
            int col = cellData.Column;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            // NOT IN USE
        }


        private void MinesweeperGame_Load(object sender, EventArgs e)
        {
            label1.Text = P1User;
            label2.Text = P2User;
            label3.Text = P1User + "has cleared 0 tiles";
            label4.Text = P2User + "has cleared 0 tiles";
        }
        public void player1go(bool foundmin3)
        {

        }
        public void PlayGame(string P1, string P2)
        {
            int i1 = 0;
            int i2 = 0;
            bool foundmine = false;
            while (foundmine = false && i1 + i2 < 100)
            {
                int i = i1 + i2;
                if (i % 2 == 0)
                {
                    pictureBox3.SendToBack();
                    PlayerTurn(P1, i1);
                    i1++;
                    if (i1 % 3 == 0)
                    {
                        MilQuestion();
                    }
                }
                else
                {
                    pictureBox1.SendToBack();
                    PlayerTurn(P2, i2);
                    i2++;
                }
            }
        }
        public void PlayerTurn(string player, int turnnumber)
        {
            
        }
        public bool MilQuestion()
        {
            String[] Questions = { "What is the official name of the UK's Army, Navy, and Air Force?", "What is the highest rank in the British Army?", "What is the largest and most powerful warship in the Royal Navy's fleet?", "What is the British Army's elite special forces unit known as?", "Which conflict is often referred to as the Falklands War?", " in which the UK fought against Argentina?", "What is the British Army's primary battle tank?", "In which year did the Royal Air Force (RAF) become an independent branch of the UK's armed forces?", "What is the UK's nuclear deterrent system called, which consists of Trident II D5 ballistic missiles?", "What is the highest military award that can be bestowed upon a member of the British Armed Forces for acts of conspicuous gallantry and valor in the face of the enemy?", "What is the Royal Navy's nuclear-powered ballistic missile submarine class that carries the Trident II D5 missile system?" };
            String[] Answers = { "The British Army, the Royal Navy, and the Royal Air Force.", "Field Marshal.", "The HMS Queen Elizabeth, an aircraft carrier.", The SAS (Special Air Service).\r\n\r\nThe Falklands War took place in 1982.\r\n\r\nThe Challenger 2.\r\n\r\nThe Royal Air Force was founded on April 1, 1918.\r\n\r\nTrident, also known as the Trident nuclear program.\r\n\r\nThe Victoria Cross (VC).\r\n\r\nVanguard-class submarines." };
        }

    }
    class CellData
    {
        public int Row { get; }
        public int Column { get; }" , "        public CellData(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
