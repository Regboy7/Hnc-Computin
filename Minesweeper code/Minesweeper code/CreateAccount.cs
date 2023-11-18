using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_code
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private bool HasSpecialChars(string TheString)
        {
            return TheString.Any(ch => !char.IsLetterOrDigit(ch));
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            List<string> UsernamesExisting = new List<string>();
            OleDbConnection Con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = G:/Projects/MineScoreboard1.accdb");

            Con.Open();
            UsernamesExisting = DatabaseCon.Datalist("Username", "Scoreboard");
            if (HasSpecialChars(textBox1.Text))
            {
                MessageBox.Show("Special characters are not allowed");
                return;
            }
            if (HasSpecialChars(textBox1.Text))
            {
                MessageBox.Show("Special characters are not allowed");
                return;
            }
            if (UsernamesExisting.Contains(textBox1.Text)) { MessageBox.Show("Username has already been taken"); return; }
            if (textBox1.Text.Length < 3) { MessageBox.Show("Username must be more than 3 characters"); return; }
            if (textBox1.Text.Length > 15) { MessageBox.Show("Username must be less than 15 characters"); return; }
            if (textBox2.Text.Length > 15) { MessageBox.Show("Password must be less than 15 characters"); return; }
            if (textBox2.Text.Length < 3) { MessageBox.Show("Password must be more than 3 characters"); return; }
            if (!(textBox2.Text == textBox3.Text)) { MessageBox.Show("Passwords do not match"); return; }

            var query = "INSERT INTO Scoreboard([Username], [Password])VALUES( @Username, @Password)";
            OleDbCommand cmd = new OleDbCommand(query, Con);
            string HashedPass = Hasher.Hash(textBox2.Text, 15);
            cmd.Parameters.AddWithValue("@Username", textBox1.Text); // can also you the text in the textbox - e.g. textbox1.Text
            cmd.Parameters.AddWithValue("@Password", HashedPass);

            try
            {
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("User has been added!");
                this.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}
