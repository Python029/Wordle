using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;

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
            rows = new Boolean[] { row1, row2, row3, row4, row5, row6 };
            words = File.ReadAllText(@"H:\wordle_list.txt");
            words = Regex.Replace(words, @"\s", "");
            code = words.ToCharArray();

            Random gen = new Random();
            int start = gen.Next(0, 61) * 5;

            //get all characters in the rest of the word
            for (int i = start; i < (start + 5); i++)
            {
                wordle += code[i].ToString();
            }
            MessageBox.Show(wordle);
            Solution = wordle.ToCharArray();
        }
        TextBox[] boxes;
        Boolean[] rows;
        Char[] code;
        string wordle;
        string words;
        bool row1 = false;
        bool row2 = false;
        bool row3 = false;
        bool row4 = false;
        bool row5 = false;
        bool row6 = false;
        string g;
        Char[] Solution;
        Char[] Guess;

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void CheckWord()
        {         
            for (int i = 0; i < Guess.Length; i++)
            {
                for (int s = 0; s < Solution.Length; s++)
                {
                    if (rows[0])
                    {
                        if (Guess[i] == Solution[s] && i==s)
                        {
                            boxes[i].BackColor = Color.LimeGreen;
                        }
                        else if (Guess[i] == Solution[s] && i != s)
                        {
                            boxes[i].BackColor = Color.Gold;
                        }
                        else
                        {
                            boxes[i].BackColor = Color.DarkGray;
                        }
                    }
                    else if (rows[1])
                    {
                        if (Guess[i] == Solution[s] && i == s)
                        {
                            boxes[i+5].BackColor = Color.LimeGreen;
                        }
                        else if (Guess[i] == Solution[s] && i != s)
                        {
                            boxes[i+5].BackColor = Color.Gold;
                        }
                        else
                        {
                            boxes[i+5].BackColor = Color.DarkGray;
                        }
                    }
                    else if (rows[2])
                    {
                        if (Guess[i] == Solution[s] && i == s)
                        {
                            boxes[i + 10].BackColor = Color.LimeGreen;
                        }
                        else if (Guess[i] == Solution[s] && i != s)
                        {
                            boxes[i + 10].BackColor = Color.Gold;
                        }
                        else
                        {
                            boxes[i + 10].BackColor = Color.DarkGray;
                        }
                    }
                    else if (rows[3])
                    {
                        if (Guess[i] == Solution[s] && i == s)
                        {
                            boxes[i + 15].BackColor = Color.LimeGreen;
                        }
                        else if (Guess[i] == Solution[s] && i != s)
                        {
                            boxes[i + 15].BackColor = Color.Gold;
                        }
                        else
                        {
                            boxes[i + 15].BackColor = Color.DarkGray;
                        }
                    }
                    else if (rows[4])
                    {
                        if (Guess[i] == Solution[s] && i == s)
                        {
                            boxes[i + 20].BackColor = Color.LimeGreen;
                        }
                        else if (Guess[i] == Solution[s] && i != s)
                        {
                            boxes[i + 20].BackColor = Color.Gold;
                        }
                        else
                        {
                            boxes[i + 20].BackColor = Color.DarkGray;
                        }
                    }
                    else if (rows[5])
                    {
                        if (Guess[i] == Solution[s] && i == s)
                        {
                            boxes[i + 25].BackColor = Color.LimeGreen;
                        }
                        else if (Guess[i] == Solution[s] && i != s)
                        {
                            boxes[i + 25].BackColor = Color.Gold;
                        }
                        else
                        {
                            boxes[i + 25].BackColor = Color.DarkGray;
                        }
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
                Array.Clear(Guess, 0, Guess.Length);
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
                txt11.Focus();
                g = txt6.Text.ToLower() + txt7.Text + txt8.Text + txt9.Text + txt10.Text;
                Guess = g.ToLower().ToCharArray();
                CheckWord();
                Array.Clear(Guess, 0, Guess.Length);
            }
            if (e.KeyCode == Keys.Back)
            {
                txt9.Focus();
            }
        }
        #endregion
        #region Row 3
        private void txt11_KeyUp(object sender, KeyEventArgs e)
        {
            txt11.Text = txt11.Text.ToUpper();
            if (txt11.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
                rows[1] = false;
            }
        }
        private void txt12_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt12.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt11.Focus();
            }
        }
        private void txt13_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt13.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt12.Focus();
            }
        }
        private void txt14_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt14.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt13.Focus();
            }
        }
        private void txt15_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt15.TextLength == 1 && e.KeyCode == Keys.Enter)
            {
                rows[2] = true;
                txt16.Focus();
                g = txt11.Text.ToLower() + txt12.Text + txt13.Text + txt14.Text + txt15.Text;
                Guess = g.ToLower().ToCharArray();
                CheckWord();
                Array.Clear(Guess, 0, Guess.Length);
            }
            if (e.KeyCode == Keys.Back)
            {
                txt14.Focus();
            }
        }
        #endregion
        #region Row 4
        private void txt16_KeyUp(object sender, KeyEventArgs e)
        {
            txt16.Text = txt16.Text.ToUpper();
            if (txt16.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
                rows[2] = false;
            }
        }
        private void txt17_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt17.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt16.Focus();
            }
        }
        private void txt18_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt18.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt17.Focus();
            }
        }
        private void txt19_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt19.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt20.Focus();
            }
        }
        private void txt20_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt20.TextLength == 1 && e.KeyCode == Keys.Enter)
            {
                rows[3] = true;
                txt21.Focus();
                g = txt16.Text.ToLower() + txt17.Text + txt18.Text + txt19.Text + txt20.Text;
                Guess = g.ToLower().ToCharArray();
                CheckWord();
                Array.Clear(Guess, 0, Guess.Length);
            }
            if (e.KeyCode == Keys.Back)
            {
                txt19.Focus();
            }
        }
        #endregion
        #region Row 5
        private void txt21_KeyUp(object sender, KeyEventArgs e)
        {
            txt21.Text = txt21.Text.ToUpper();
            if (txt21.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
                rows[3] = false;
            }
        }
        private void txt22_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt22.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt21.Focus();
            }
        }
        private void txt23_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt23.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt22.Focus();
            }
        }
        private void txt24_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt24.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt23.Focus();
            }
        }
        private void txt25_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt25.TextLength == 1 && e.KeyCode == Keys.Enter)
            {
                rows[4] = true;
                txt26.Focus();
                g = txt21.Text.ToLower() + txt22.Text + txt23.Text + txt24.Text + txt25.Text;
                Guess = g.ToLower().ToCharArray();
                CheckWord();
                Array.Clear(Guess, 0, Guess.Length);
            }
            if (e.KeyCode == Keys.Back)
            {
                txt24.Focus();
            }
        }
        #endregion
        #region Row 6
        private void txt26_KeyUp(object sender, KeyEventArgs e)
        {
            txt26.Text = txt26.Text.ToUpper();
            if (txt26.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
                rows[4] = false;
            }
        }
        private void txt27_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt27.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt26.Focus();
            }
        }
        private void txt28_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt28.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt27.Focus();
            }
        }
        private void txt29_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt29.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Back)
            {
                txt28.Focus();
            }
        }
        private void txt30_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt30.TextLength == 1 && e.KeyCode == Keys.Enter)
            {
                rows[5] = true;
                this.Focus();
                g = txt26.Text.ToLower() + txt27.Text + txt28.Text + txt29.Text + txt30.Text;
                Guess = g.ToLower().ToCharArray();
                CheckWord();
                Array.Clear(Guess, 0, Guess.Length);
            }
            if (e.KeyCode == Keys.Back)
            {
                txt29.Focus();
            }
        }
        #endregion
        #endregion
    }
}