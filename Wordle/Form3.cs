using System;
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
            Math.Floor(percent);
            lblPlayed.Text = Properties.Settings.Default.Played.ToString();
            lblPercent.Text = ($"{percent.ToString()}%");
            lblStreak.Text = Properties.Settings.Default.Streak.ToString();
            lblMax.Text = Properties.Settings.Default.Max.ToString();
        }
        double percent = (Properties.Settings.Default.Wins / Properties.Settings.Default.Played);
    }
}
