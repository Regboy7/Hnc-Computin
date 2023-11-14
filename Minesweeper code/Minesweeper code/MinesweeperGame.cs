using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        const string provider = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M:/Projects/MineScoreboard1.accdb";
        private Button[,] player1Buttons = new Button[Rows, Columns];
        private Button[,] player2Buttons = new Button[Rows, Columns];
        private bool[,] player1IsMine = new bool[Rows, Columns];
        private bool[,] player2IsMine = new bool[Rows, Columns];
        private int player1Score = 0;
        private int player2Score = 0;
        private int turnCounter = 0;
        private List<string> questions = new List<string>
                                    { "Is the British Army the only branch of the British Armed Forces?",
                                        "Does the Royal Navy focus solely on submarine operations?",
                                        "Is the Royal Air Force primarily responsible for ground-based operations?",
                                        "Did the British military stay completely neutral during World War I?",
                                        "Is the Prime Minister the operational commander of the British Armed Forces?",
                                        "Does the British military exclusively engage in combat operations?",
                                        "Is the Ministry of Defence solely responsible for domestic affairs?",
                                        "Are members of the British military prohibited from participating in civilian rescue efforts?",
                                        "Is the Gurkha Brigade an independent military force unrelated to the British Army?",
                                        "Does the British military have no presence outside the United Kingdom?",
                                        "Is the Royal Navy a branch of the British Armed Forces?",
                                        "Did the British military participate in the Falklands War in 1982?",
                                        "Is the SAS (Special Air Service) a special forces unit in the British Army?",
                                        "Does the Royal Air Force primarily handle maritime operations?",
                                        "Did the British military have a significant role in the Gulf War in 1990-1991?",
                                        "Is the Territorial Army now known as the Army Reserve?",
                                        "Is the Queen's Guard responsible for ceremonial duties at Buckingham Palace?",
                                        "Did the British military play a major role in the Battle of Normandy during World War II?",
                                        "Is the Trident missile system a component of the UK's nuclear deterrent?",
                                        "Does the British military engage in cyber warfare and intelligence operations?"};
        public List<string> Answers = new List<string>
        { 
                                        "No",
                                        "No",
                                        "No",
                                        "No",
                                        "No",
                                        "No",
                                        "No",
                                        "No",
                                        "No",
                                        "No",
                                        "Yes",
                                        "Yes",
                                        "Yes",
                                        "No",
                                        "Yes",
                                        "Yes",
                                        "Yes",
                                        "Yes",
                                        "Yes",
                                        "Yes"
        };
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
                    string Losses = DatabaseCon.Datalist("Losses", "Scoreboard", p1ID);
                    int NewLosses = 1 + Convert.ToInt32(Losses);
                    string insertionquery = "INSERT INTO Losses WHERE UID =" + p1ID; 
                    using (OleDbConnection connection = new OleDbConnection(provider))
                    {
                        using (OleDbCommand command = new OleDbCommand(insertionquery, connection))
                        {
                            command.Parameters.AddWithValue("@Losses", NewLosses);
                        }
                    }
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
                    string Losses = DatabaseCon.Datalist("Losses", "Scoreboard", p2ID);
                    int NewLosses = 1 + Convert.ToInt32(Losses);
                    string insertionquery = "INSERT INTO Losses WHERE UID =" + p2ID;
                    using (OleDbConnection connection = new OleDbConnection(provider))
                    {
                        using (OleDbCommand command = new OleDbCommand(insertionquery, connection))
                        {
                            command.Parameters.AddWithValue("@Losses", NewLosses);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Data inserted.");
                            }
                            else
                            {
                                Console.WriteLine("No rows affected.");
                            }
                        }
                    }
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
            string question = GetRandomQuestionAndAnswer();
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
            P1Name.Text = $"Player 1 Score: {player1Score}";
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
        private string GetRandomQuestionAndAnswer()
        {
            Random random = new Random();
            int index1 = random.Next(questions.Count);

            return questions[index1];
            return Answers[index1];
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
            P1Name.Text = P1User;
            P2Name.Text = P2User;
            player1ScoreLabel.Text = P1User + "has cleared 0 tiles";
            player2ScoreLabel.Text = P2User + "has cleared 0 tiles";
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

