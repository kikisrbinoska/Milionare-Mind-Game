﻿using System;
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
            timer.Tick += new EventHandler(timer1_Tick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.Transparent)
            {
                label2.Text = " Кој е познат како таткото на модерната физика?";
                label1.Text = "1";
                q1.Text = "A) Исаак Њутн";
                q2.Text = "B) Алберт Ајнштајн";
                q3.Text = "C) Галилео Галилеј";
                q4.Text = "D) Никола Тесла";
                q2.FillColor = Color.SlateBlue;
            }
            if (panel1.BackColor == Color.DarkOrange)
            {
                label2.Text = "Кој дизајнер е познат по создавањето на малото црно фустанче?";
                label1.Text = "2";
                q1.Text = "A) Коко Шанел";
                q2.Text = "B) Ралф Лорен";
                q3.Text = "C) Донатела Версаче";
                q4.Text = "D) Џорџо Армани";
                q1.FillColor = Color.SlateBlue;
            }
            if (panel2.BackColor == Color.DarkOrange)
            {
                label2.Text = "Кој фудбалер има најмногу освојени Златни топки?";
                label1.Text = "3";
                q1.Text = "A) Кристијано Роналдо";
                q2.Text = "B) Лионел Меси";
                q3.Text = "C) Пеле";
                q4.Text = "D) Диего Марадона";
                q2.FillColor = Color.SlateBlue;
            }
            if (panel3.BackColor == Color.DarkOrange)
            {
                label2.Text = "Кој филм доби Оскар за најдобар филм во 2020 година?";
                label1.Text = "4";
                q1.Text = "A) Паразит";
                q2.Text = "B) 1917";
                q3.Text = "C) Џокер";
                q4.Text = "D) Имаш уште една шанса";
                q1.FillColor = Color.SlateBlue;
            }
            if (panel4.BackColor == Color.DarkOrange)
            {
                label2.Text = "Кој е основачот на компанијата Microsoft?";
                label1.Text = "5";
                q1.Text = "A) Стив Џобс";
                q2.Text = "B) Бил Гејтс";
                q3.Text = "C) Марк Закерберг";
                q4.Text = "D) Лари Пејџ";
                q2.FillColor = Color.SlateBlue;
            }
            if (panel5.BackColor == Color.DarkOrange)
            {
                label2.Text = "Кој е авторот на книгата \"Гордост и предрасуди\"?";
                label1.Text = "6";
                q1.Text = "A) Чарлс Дикенс";
                q2.Text = "B) Агата Кристи";
                q3.Text = "C) Лео Толстој";
                q4.Text = "D) Џејн Остин";
                q4.FillColor = Color.SlateBlue;
            }
            if (panel6.BackColor == Color.DarkOrange)
            {
                label2.Text = "Кој историски настан се случил на 14 јули 1789 година?";
                label1.Text = "7";
                q1.Text = "A) Почеток на Француската револуција";
                q2.Text = "B) Освојување на Грција";
                q3.Text = "C) Пад на Берлинскиот ѕид";
                q4.Text = "D) Првото слетување на Месечината";
                q1.FillColor = Color.SlateBlue;
            }
            if (panel7.BackColor == Color.DarkOrange)
            {
                label2.Text = "Кој дизајнер е познат по својата \"Гучи\" колекција?";
                label1.Text = "8";
                q1.Text = "A) Донатела Версаче";
                q2.Text = "B) Албер Елбаз";
                q3.Text = "C) Том Форд";
                q4.Text = "D) Фрида Џанини";
                q4.FillColor = Color.SlateBlue;
            }
            if (panel8.BackColor == Color.DarkOrange)
            {
                label2.Text = "Која е најстарата форма на пишување?";
                label1.Text = "9";
                q1.Text = "A) Хиероглифи";
                q2.Text = "B) Латинска азбука";
                q3.Text = "C) Кирилска азбука";
                q4.Text = "D) Грчка азбука";
                q1.FillColor = Color.SlateBlue;
            }
            if (panel9.BackColor == Color.DarkOrange)
            {
                label2.Text = "Која песна го освои првото место на топ-листите на Billboard во 2024 година?";
                label1.Text = "10";
                q1.Text = "A) Anti-Hero";
                q2.Text = "B) Kill Bill";
                q3.Text = "C) Flowers";
                q4.Text = "D) Blinding Lights";
                q3.FillColor = Color.DarkSlateGray;
            }
            if (panel10.BackColor == Color.DarkOrange)
            {
                label2.Text = "Кој композитор е познат по своите симфонии, вклучувајќи ја и \"9-та симфонија\"?";
                label1.Text = "11";
                q1.Text = "A) Јохан Себастијан Бах";
                q2.Text = "B) Лудвиг ван Бетовен";
                q3.Text = "C) Вивалди";
                q4.Text = "D) Вагнер";
                q2.FillColor = Color.SlateBlue;
            }
            if (panel11.BackColor == Color.DarkOrange)
            {
                label2.Text = "Кој беше првиот комерцијален web browser?";
                label1.Text = "12";
                q1.Text = "A) Netscape Navigator";
                q2.Text = "B) Internet Explorer";
                q3.Text = "C) Mozilla Firefox";
                q4.Text = "D) Safari";
                q1.FillColor = Color.SlateBlue;
            }
            if (label1.Text == "1")
            {
                totalPoints += 500;
                panel1.BackColor = Color.DarkOrange;
            }
            if (label1.Text == "2")
            {
                totalPoints += 1000;
                panel2.BackColor = Color.DarkOrange;
                panel1.BackColor = Color.Transparent;
            }
            if (label1.Text == "3")
            {
                totalPoints += 3000;
                panel3.BackColor = Color.DarkOrange;
                panel2.BackColor = Color.Transparent;
            }
            if (label1.Text == "4")
            {
                totalPoints += 5000;
                panel4.BackColor = Color.DarkOrange;
                panel3.BackColor = Color.Transparent;
            }
            if (label1.Text == "5")
            {
                totalPoints += 7500;
                panel5.BackColor = Color.DarkOrange;
                panel4.BackColor = Color.Transparent;
            }
            if (label1.Text == "6")
            {
                totalPoints += 15000;
                panel6.BackColor = Color.DarkOrange;
                panel5.BackColor = Color.Transparent;
            }
            if (label1.Text == "7")
            {
                totalPoints += 30000;
                panel7.BackColor = Color.DarkOrange;
                panel6.BackColor = Color.Transparent;
            }
            if (label1.Text == "8")
            {
                totalPoints += 60000;
                panel8.BackColor = Color.DarkOrange;
                panel7.BackColor = Color.Transparent;
            }
            if (label1.Text == "9")
            {
                totalPoints += 125000;
                panel9.BackColor = Color.DarkOrange;
                panel8.BackColor = Color.Transparent;
            }
            if (label1.Text == "10")
            {
                totalPoints += 250000;
                panel10.BackColor = Color.DarkOrange;
                panel9.BackColor = Color.Transparent;
            }
            if (label1.Text == "11")
            {
                totalPoints += 500000;
                panel11.BackColor = Color.DarkOrange;
                panel10.BackColor = Color.Transparent;
            }
            if (label1.Text == "12")
            {
                totalPoints += 1000000;
                panel12.BackColor = Color.DarkOrange;
                panel11.BackColor = Color.Transparent;
            }
            remainingTime = 60;
            timerLabel.Text = $"{remainingTime} секунди ";
            timer.Start();
        }
    }
}
