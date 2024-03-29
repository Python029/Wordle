﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordle
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Percent = ((double)Properties.Settings.Default.Wins / (double)Properties.Settings.Default.Played)*100;
            Math.Round(Math.Floor(Properties.Settings.Default.Percent),0);
            lblPlayed.Text = Properties.Settings.Default.Played.ToString();
            lblPercent.Text = ($"{Properties.Settings.Default.Percent.ToString("0")}%");
            lblStreak.Text = Properties.Settings.Default.Streak.ToString();
            lblMax.Text = Properties.Settings.Default.Max.ToString();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to clear your stats?", "Clear Stats", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Properties.Settings.Default.Reset();
                    Properties.Settings.Default.Save();
                    this.Close();
                    MessageBox.Show("Your stats have been reset.");
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
    }
}
