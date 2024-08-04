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
                //EndGame();
            }
        }
    }
}
