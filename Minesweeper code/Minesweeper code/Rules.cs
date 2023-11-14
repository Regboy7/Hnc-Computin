using System.Data.OleDb;

namespace Minesweeper_code
{
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // create account form
        {
            CreateAccount newform = new CreateAccount();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string provider = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M:/Projects/MineScoreboard1.accdb";
            // database
            List<string> retrievedP1PasswordResults = new List<string>();
            string CheckP1HashPass = Hasher.Hash(textBox2.Text, 15);
            List<string> P1UID;
            using (OleDbConnection dbCon = new OleDbConnection(provider))
            {
                retrievedP1PasswordResults = DatabaseCon.Datalist("Password", "Scoreboard", "Username", textBox1.Text);
                P1UID = DatabaseCon.Datalist("UID", "Scoreboard", "Username", textBox1.Text);
            }

            // creates a list and checks the hashed password input with the hashed passwords within the database
            
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0)
            {
                MessageBox.Show("Not all boxes have been filled in.");
                return;
            }

            if (retrievedP1PasswordResults.Count.Equals(0))
            {
                MessageBox.Show("Player 1's username or password is incorrect.");
                return;
            }
            
            List<string> retrievedP2PasswordResults = new List<string>();
            string CheckP2HashPass = Hasher.Hash(textBox4.Text, 15);
            List<string> P2UID;
            using (OleDbConnection dbCon = new OleDbConnection(provider))
            {
                retrievedP2PasswordResults = DatabaseCon.Datalist("Password", "Scoreboard", "Username", textBox3.Text);
                P2UID = DatabaseCon.Datalist("UID", "Scoreboard", "Username", textBox3.Text);
            }
            if (retrievedP2PasswordResults.Count.Equals(0))
            {
                MessageBox.Show("Player 2's username or password is incorrect.");
                return;
            }

            if (retrievedP2PasswordResults.Contains(CheckP2HashPass) && retrievedP1PasswordResults.Contains(CheckP1HashPass))
            {
                MessageBox.Show("Game Started.");
                this.Hide();
            MinesweeperGame newform = new MinesweeperGame(Convert.ToInt32(P1UID[0]), Convert.ToInt32(P2UID[0]));
                newform.ShowDialog();
                this.Show();

            }
        }
    }
}