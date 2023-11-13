using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_code
{
    public partial class MinesweeperGame : Form
    {
        private const int Rows = 5;
        private const int Columns = 5;
        private const int Mines = 5;
        private const int QuestionsInterval = 3;

        private Button[,] player1Buttons = new Button[Rows, Columns];
        private Button[,] player2Buttons = new Button[Rows, Columns];
        private bool[,] player1IsMine = new bool[Rows, Columns];
        private bool[,] player2IsMine = new bool[Rows, Columns];
        private int player1Score = 0;
        private int player2Score = 0;
        private int turnCounter = 0;
        private List<string> questions = new List<string>
                                    { "What is the official name of the UK's Army, Navy, and Air Force?",
                                    "What is the highest rank in the British Army?",
                                    "What is the largest and most powerful warship in the Royal Navy's fleet?",
                                    "What is the British Army's elite special forces unit known as?",
                                    "Which conflict is often referred to as the Falklands War?",
                                    " in which the UK fought against Argentina?",
                                    "What is the British Army's primary battle tank?",
                                    "In which year did the Royal Air Force (RAF) become an independent branch of the UK's armed forces?",
                                    "What is the UK's nuclear deterrent system called, which consists of Trident II D5 ballistic missiles?",
                                    "What is the highest military award that can be bestowed upon a member of the British Armed Forces for acts of conspicuous gallantry and valor in the face of the enemy?",
                                    "What is the Royal Navy's nuclear-powered ballistic missile submarine class that carries the Trident II D5 missile system?" };
        public String[] Answers = { "The British Army, the Royal Navy, and the Royal Air Force.",
                                    "Field Marshal.",
                                    "The HMS Queen Elizabeth, an aircraft carrier.",
                                    "The SAS (Special Air Service)",
                                    "The Falklands War took place in 1982.",
                                    "The Challenger 2.",
                                    "1918.",
                                    "Trident, also known as the Trident nuclear program.",
                                    "The Victoria Cross (VC).",
                                    "Vanguard-class submarines." };
        public string p1ID;
        public string p2ID;
        public string P1User;
        public string P2User;
        public MinesweeperGame(int P1UID, int P2UID)
        {

            InitializeComponent();
            InitializeGame(player1TableLayoutPanel, player1Buttons, player1IsMine);
            InitializeGame(player2TableLayoutPanel, player2Buttons, player2IsMine);
            DisplayPlayerScores();
            this.p1ID = P1UID.ToString();
            this.p2ID = P2UID.ToString();
            this.P1User = DatabaseCon.Datalist("Username", "Scoreboard", p1ID);
            this.P2User = DatabaseCon.Datalist("Username", "Scoreboard", p2ID);
        }
        private void InitializeGame(TableLayoutPanel tableLayoutPanel, Button[,] buttons, bool[,] Minehit)
        {
            InitializeGrid(tableLayoutPanel, buttons);

            foreach (Button button in buttons)
            {
                button.Click += Button_Click;
            }
            PutMines(Minehit);
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
            if (turnCounter % QuestionsInterval == 0)
            {
                AskQuestion();
            }
            if (turnCounter % 2 == 0)
            {
                if (player1IsMine[row, col])
                {
                    MessageBox.Show("Player 1 hit a bomb! Game over for Player 1.");
                    // Implement game-over logic for Player 1
                    return;
                }
                else
                {
                    player1Score++;
                }
            }
            else
            {
                if (player2IsMine[row, col])
                {
                    MessageBox.Show("Player 2 hit a bomb! Game over for Player 2.");
                    // Implement game-over logic for Player 2
                    return;
                }
                else
                {
                    player2Score++;
                }
            }
            turnCounter++;
            SwitchTurns();
            DisplayPlayerScores();
        }


        private void AskQuestion()
        {
            // Display a random question from the array
            string question = GetRandomQuestion();
            DialogResult result = MessageBox.Show(question, "Question", MessageBoxButtons.YesNo);

            // If the answer is correct, give the player an extra turn
            if (result == DialogResult.Yes)
            {
                if (turnCounter % 2 == 0)
                {
                    player1Score++;
                }
                else
                {
                    player2Score++;
                }

                // Update turn counter to account for the extra turn
                turnCounter++;
            }
        }
        private void DisplayPlayerScores()
        {
            // Display player scores in the UI
            player1ScoreLabel.Text = $"Player 1 Score: {player1Score}";
            player2ScoreLabel.Text = $"Player 2 Score: {player2Score}";
        }
        private void SwitchTurns()
        {
            // Switch turns between players
            if (turnCounter % 2 == 0)
            {
                player1TableLayoutPanel.Enabled = true;
                player2TableLayoutPanel.Enabled = false;
            }
            else
            {
                player1TableLayoutPanel.Enabled = false;
                player2TableLayoutPanel.Enabled = true;
            }
        }
        private string GetRandomQuestion()
        {
            Random random = new Random();
            int index = random.Next(questions.Count);
            return questions[index];
        }

        private int CountAdjacentMines(int row, int col)
        {
            int count = 0;
            bool[,] currentPlayerMines = (turnCounter % 2 == 0) ? player1IsMine : player2IsMine;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int newRow = row + i;
                    int newCol = col + j;

                    if (newRow >= 0 && newRow < Rows && newCol >= 0 && newCol < Columns)
                    {
                        if (currentPlayerMines[newRow, newCol])
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            ///
        }

        private void MinesweeperGame_Load(object sender, EventArgs e)
        {
            label1.Text = P1User;
            label2.Text = P2User;
            label3.Text = P1User + "has cleared 0 tiles";
            label4.Text = P2User + "has cleared 0 tiles";
        }

    }



}

    class CellData
    {
        public int Row { get; }
        public int Column { get; }
        public CellData(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
