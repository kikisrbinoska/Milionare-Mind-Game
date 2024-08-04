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
    public partial class PlayerSetupForm : Form
    {
        public string PlayerName { get; private set; }
        public PlayerSetupForm()
        {
            InitializeComponent();
        }

        private void guna2ButtonSumbit_Click(object sender, EventArgs e)
        {

            PlayerName = guna2TextBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
