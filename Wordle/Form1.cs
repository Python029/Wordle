namespace Wordle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string Solution;
        string Guess;
        #region Key Events
        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);         
        }

        #endregion
        private void CheckWord()
        {
            Solution = "Brain";
            Solution.ToCharArray();
            for (int i = 0; i < Solution.Length; i++)
            {
                for(int g = 0; g<Guess.Length; g++)
                {
                    if(Guess[g] == Solution[i])
                    {
                        if(Guess[g] == 1)
                        {
                            txt1.BackColor = Color.Green;
                        }
                        if (Guess[g] == 2)
                        {
                            txt2.BackColor = Color.Green;
                        }
                        if (Guess[g] == 3)
                        {
                            txt3.BackColor = Color.Green;
                        }
                        if (Guess[g] == 4)
                        {
                            txt4.BackColor = Color.Green;
                        }
                        if (Guess[g] == 5)
                        {
                            txt5.BackColor = Color.Green;
                        }
                    }
                }
            }
        }
        #region Tabbing
        #region Row 1
        private void txt1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt1.TextLength == 1)
            {
                SendKeys.SendWait("{TAB}");
            }
        }

        private void txt2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt2.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt1.Focus();
            }
        }

        private void txt3_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt3.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt2.Focus();
            }
        }

        private void txt4_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt4.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt3.Focus();
            }
        }

        private void txt5_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt5.TextLength == 1 && e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                Guess = txt1.Text + txt2.Text + txt3.Text + txt4.Text + txt5.Text;
                Guess.ToCharArray();
                CheckWord();
            }
            if(e.KeyCode == Keys.Back)
            {
                txt4.Focus();
            }
        }
        #endregion
        #region Row 2
        private void txt6_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt6.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txt7_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt7.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txt8_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt8.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txt9_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt9.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txt10_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt10.TextLength == 1 && e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        #endregion
        #endregion


    }
}