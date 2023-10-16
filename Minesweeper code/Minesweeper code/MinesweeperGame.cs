using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_code
{
    public partial class MinesweeperGame : Form
    {
        public MinesweeperGame(int P1UID, int P2UID)
        {
            InitializeComponent();
            string p1ID = Convert.ToString(P1UID);
            string p2ID = Convert.ToString(P2UID);
            string P1User = DatabaseCon.Datalist("Username", "Scoreboard", p1ID);
            string P2User = DatabaseCon.Datalist("Username", "Scoreboard", p2ID);
            MessageBox.Show(P2User + P1User);
        }
    }
}
