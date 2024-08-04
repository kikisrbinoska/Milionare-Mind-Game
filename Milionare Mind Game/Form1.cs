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
    public partial class Form1 : Form
    {
        private Timer timer;
        private int remainingTime;
        private int totalPoints = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                remainingTime--;
                timerLabel.Text = $"{remainingTime} секунди";
            }
            else
            {
                timerLabel.Text = "Времето заврши!!!";
                timer.Stop();
                EndGame();
            }
        }
        private void EndGame()
        {
            string playerName = guna2Button1.Text;
            int score = totalPoints;
            //UpdateLeaderboard(playerName, score);
            //ShowLeaderboard();
            ResetGameState();
            this.Close();
        }
        private void ResetGameState()
        {
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel6.BackColor = Color.Transparent;
            panel7.BackColor = Color.Transparent;
            panel8.BackColor = Color.Transparent;
            panel9.BackColor = Color.Transparent;
            panel10.BackColor = Color.Transparent;
            panel11.BackColor = Color.Transparent;
            panel12.BackColor = Color.Transparent;
        }

    }
}
