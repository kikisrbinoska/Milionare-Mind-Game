using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milionare_Mind_Game
{
    public partial class LeaderboardForm : Form
    {
        public LeaderboardForm(List<Player> players)
        {
            InitializeComponent();
            LoadLeaderboard(players);
        }
        private void LoadLeaderboard(List<Player> players)
        {
            // Assuming you have a DataGridView named dataGridView1
            dataGridView1.DataSource = players.OrderByDescending(p => p.Score).ToList();
        }
    }
}
