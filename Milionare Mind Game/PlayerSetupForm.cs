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
        public Image PlayerPhoto { get; private set; }
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
        private void guna2ButtonUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PlayerPhoto = Image.FromFile(openFileDialog.FileName);
                    
                }
            }
        }
    }
}
