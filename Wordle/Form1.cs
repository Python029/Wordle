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
        string tries = "";
        bool row1 = false;
        bool row2 = false;
        bool row3 = false;
        bool row4 = false;
        bool row5 = false;
        bool row6 = false;
        string g;
        Char[] Solution;
        Char[] Guess;
        Form2 f2 = new Form2();

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        #region Endgame
        private void Loser()
        {
            this.Focus();
            DialogResult dialogResult = MessageBox.Show($"The word was {wordle}.\nWould you like to play again?", "You Lose", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
        }
        private void Winner()
        {
            this.Focus();
            DialogResult dialogResult = MessageBox.Show($"You correctly guessed the word on your {tries} try.\nWould you like to play again?", "You Win", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
            
        }
        #endregion
        public void CheckWord()
        {         
            for (int i = 0; i < Guess.Length; i++)
            {
                for (int s = 0; s < Solution.Length; s++)
                {                    
                    if (rows[0])
                    {
                        tries = "1st";
                        if (Guess[i] == Solution[s] && i == s && boxes[i].Tag.ToString() != "Green")
                        { 
                            boxes[i].BackColor = Color.LimeGreen;
                            boxes[i].Tag = "Green";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.LimeGreen;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Green";
                        }
                        else if (Guess[i] == Solution[s] && i != s && boxes[i].Tag.ToString() != "Green" && boxes[i].Tag.ToString() != "Yellow")
                        {
                            boxes[i].BackColor = Color.Gold;
                            boxes[i].Tag = "Yellow";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.Gold;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Yellow";
                        }
                        else if (Guess[i] != Solution[s] && boxes[i].Tag.ToString() != "Green" && boxes[i].Tag.ToString() != "Yellow")
                        {
                            boxes[i].BackColor = Color.DarkGray;
                            boxes[i].Tag = "Gray";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.DarkGray;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Gray";
                        }
                        if (boxes[0].Tag.ToString() == "Green" && boxes[1].Tag.ToString() == "Green" && boxes[2].Tag.ToString() == "Green" && boxes[3].Tag.ToString() == "Green" && boxes[4].Tag.ToString() == "Green")
                        {
                            Winner();
                        }
                        
                    }
                    else if (rows[1])
                    {
                        tries = "2nd";
                        if (Guess[i] == Solution[s] && i == s && boxes[i + 5].Tag.ToString() != "Green")
                        {
                            boxes[i + 5].BackColor = Color.LimeGreen;
                            boxes[i + 5].Tag = "Green";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.LimeGreen;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Green";
                        }
                        else if (Guess[i] == Solution[s] && i != s && boxes[i + 5].Tag.ToString() != "Green" && boxes[i + 5].Tag.ToString() != "Yellow")
                        {
                            boxes[i + 5].BackColor = Color.Gold;
                            boxes[i + 5].Tag = "Yellow";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.Gold;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Yellow";
                        }
                        else if (Guess[i] != Solution[s] && boxes[i + 5].Tag.ToString() != "Green" && boxes[i + 5].Tag.ToString() != "Yellow")
                        {
                            boxes[i + 5].BackColor = Color.DarkGray;
                            boxes[i + 5].Tag = "Gray";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.DarkGray;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Gray";
                        }
                        if (boxes[5].Tag.ToString() == "Green" && boxes[6].Tag.ToString() == "Green" && boxes[7].Tag.ToString() == "Green" && boxes[8].Tag.ToString() == "Green" && boxes[9].Tag.ToString() == "Green")
                        {
                            Winner();
                        }
                    }
                    else if (rows[2])
                    {
                        tries = "3rd";
                        if (Guess[i] == Solution[s] && i == s && boxes[i + 10].Tag.ToString() != "Green")
                        {
                            boxes[i + 10].BackColor = Color.LimeGreen;
                            boxes[i + 10].Tag = "Green";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.LimeGreen;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Green";
                        }
                        else if (Guess[i] == Solution[s] && i != s && boxes[i + 10].Tag.ToString() != "Green" && boxes[i + 10].Tag.ToString() != "Yellow")
                        {
                            boxes[i + 10].BackColor = Color.Gold;
                            boxes[i + 10].Tag = "Yellow";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.Gold;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Yellow";
                        }
                        else if (Guess[i] != Solution[s] && boxes[i + 10].Tag.ToString() != "Green" && boxes[i + 10].Tag.ToString() != "Yellow")
                        {
                            boxes[i + 10].BackColor = Color.DarkGray;
                            boxes[i + 10].Tag = "Gray";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.DarkGray;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Gray";
                        }
                        if (boxes[10].Tag.ToString() == "Green" && boxes[11].Tag.ToString() == "Green" && boxes[12].Tag.ToString() == "Green" && boxes[13].Tag.ToString() == "Green" && boxes[14].Tag.ToString() == "Green")
                        {
                            Winner();
                        }
                    }
                    else if (rows[3])
                    {
                        tries = "4th";
                        if (Guess[i] == Solution[s] && i == s && boxes[i + 15].Tag.ToString() != "Green")
                        {
                            boxes[i + 15].BackColor = Color.LimeGreen;
                            boxes[i + 15].Tag = "Green";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.LimeGreen;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Green";
                        }
                        else if (Guess[i] == Solution[s] && i != s && boxes[i + 15].Tag.ToString() != "Green" && boxes[i + 15].Tag.ToString() != "Yellow")
                        {
                            boxes[i + 15].BackColor = Color.Gold;
                            boxes[i + 15].Tag = "Yellow";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.Gold;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Yellow";
                        }
                        else if (Guess[i] != Solution[s] && boxes[i + 15].Tag.ToString() != "Green" && boxes[i + 15].Tag.ToString() != "Yellow")
                        {
                            boxes[i + 15].BackColor = Color.DarkGray;
                            boxes[i + 15].Tag = "Gray";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.DarkGray;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Gray";
                        }
                        if (boxes[15].Tag.ToString() == "Green" && boxes[16].Tag.ToString() == "Green" && boxes[17].Tag.ToString() == "Green" && boxes[18].Tag.ToString() == "Green" && boxes[19].Tag.ToString() == "Green")
                        {
                            Winner();
                        }
                    }
                    else if (rows[4])
                    {
                        tries = "5th";
                        if (Guess[i] == Solution[s] && i == s && boxes[i + 20].Tag.ToString() != "Green")
                        {
                            boxes[i + 20].BackColor = Color.LimeGreen;
                            boxes[i + 20].Tag = "Green";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.LimeGreen;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Green";
                        }
                        else if (Guess[i] == Solution[s] && i != s && boxes[i + 20].Tag.ToString() != "Green" && boxes[i + 20].Tag.ToString() != "Yellow")
                        {
                            boxes[i + 20].BackColor = Color.Gold;
                            boxes[i + 20].Tag = "Yellow";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.Gold;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Yellow";
                        }
                        else if (Guess[i] != Solution[s] && boxes[i + 20].Tag.ToString() != "Green" && boxes[i + 20].Tag.ToString() != "Yellow")
                        {
                            boxes[i + 20].BackColor = Color.DarkGray;
                            boxes[i + 20].Tag = "Gray";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.DarkGray;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Gray";
                        }
                        if (boxes[20].Tag.ToString() == "Green" && boxes[21].Tag.ToString() == "Green" && boxes[22].Tag.ToString() == "Green" && boxes[23].Tag.ToString() == "Green" && boxes[24].Tag.ToString() == "Green")
                        {
                            Winner();
                        }
                    }
                    else if (rows[5])
                    {
                        tries = "6th";
                        if (Guess[i] == Solution[s] && i == s && boxes[i + 25].Tag.ToString() != "Green")
                        {
                            boxes[i + 25].BackColor = Color.LimeGreen;
                            boxes[i + 25].Tag = "Green";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.LimeGreen;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Green";
                        }
                        else if (Guess[i] == Solution[s] && i != s && boxes[i + 25].Tag.ToString() != "Green" && boxes[i + 25].Tag.ToString() != "Yellow")
                        {
                            boxes[i + 25].BackColor = Color.Gold;
                            boxes[i + 25].Tag = "Yellow";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.Gold;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Yellow";
                        }
                        else if (Guess[i] != Solution[s] && boxes[i + 25].Tag.ToString() != "Green" && boxes[i + 25].Tag.ToString() != "Yellow")
                        {
                            boxes[i + 25].BackColor = Color.DarkGray;
                            boxes[i + 25].Tag = "Gray";
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).BackColor = Color.DarkGray;
                            ((Button)this.Controls["btn" + Guess[i].ToString()]).Tag = "Gray";
                        }
                        if (boxes[25].Tag.ToString() == "Green" && boxes[26].Tag.ToString() == "Green" && boxes[27].Tag.ToString() == "Green" && boxes[28].Tag.ToString() == "Green" && boxes[29].Tag.ToString() == "Green")
                        {
                            Winner();
                        }
                        if (i == 4 && s == 4)
                        {
                            if (boxes[25].Tag.ToString() != "Green" || boxes[26].Tag.ToString() != "Green" || boxes[27].Tag.ToString() != "Green" || boxes[28].Tag.ToString() != "Green" || boxes[29].Tag.ToString() != "Green")
                            {
                                Loser();
                            }
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
                txt18.Focus();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            f2.Show();
        }
    }
}