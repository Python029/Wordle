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
            
        }
        #region Tabbing
        private void txt1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt1.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txt2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt2.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txt3_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt3.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txt4_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt4.TextLength == 1)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txt5_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt5.TextLength == 1 && e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        #endregion

    }
}