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
            boxes = new TextBox[] {txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10, txt11, txt12 ,txt13, txt14, txt15, txt16, txt17, txt18, txt19, txt20, txt21, txt22, txt23, txt24, txt25, txt26, txt27, txt28, txt29, txt30 };
            rows = new Boolean[] { row1, row2, row3, row4, row5 };
        }
        TextBox[] boxes;
        Boolean[] rows;
        string s = "brain";
        bool row1 = false;
        bool row2 = false;
        bool row3 = false;
        bool row4 = false;
        bool row5 = false;
        string g;
        Char[] Solution;
        Char[] Guess;
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
            Solution = s.ToLower().ToCharArray();
            for (int i = 0; i < Guess.Length; i++)
            {
                if (rows[0])
                { 
                    if (Guess[i] == Solution[i])
                    {
                        boxes[i].BackColor = Color.Green;
                    }
                    else if (Guess[i] != Solution[i])
                    {
                        boxes[i].BackColor = Color.DarkGray;
                    }
                }
                else if (rows[1])
                {
                    if (Guess[i] == Solution[i])
                    {
                        boxes[i+5].BackColor = Color.Green;
                    }
                    else if (Guess[i] != Solution[i])
                    {
                        boxes[i+5].BackColor = Color.DarkGray;
                    }
                }
            }
        }
        #region Tabbing
        #region Row 1
        private void txt1_KeyUp(object sender, KeyEventArgs e)
        {
            txt1.Text = txt1.Text.ToUpper();
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
                rows[0] = true;
                txt6.Focus();
                g = txt1.Text.ToLower() + txt2.Text + txt3.Text + txt4.Text + txt5.Text;
                Guess = g.ToLower().ToCharArray();
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
            txt6.Text = txt6.Text.ToUpper();
            if (txt6.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
                rows[0] = false;
            }
        }

        private void txt7_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt7.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt6.Focus();
            }
        }

        private void txt8_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt8.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt7.Focus();
            }
        }

        private void txt9_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt9.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt8.Focus();
            }
        }

        private void txt10_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt10.TextLength == 1 && e.KeyCode == Keys.Enter)
            {
                rows[1] = true;
                txt6.Focus();
                g = txt6.Text.ToLower() + txt7.Text + txt8.Text + txt9.Text + txt10.Text;
                Guess = g.ToLower().ToCharArray();
                CheckWord();
            }
            if (e.KeyCode == Keys.Back)
            {
                txt9.Focus();
            }
        }
        #endregion
        #endregion


    }
}