using System;
using System.Drawing;
using System.Windows.Forms;

namespace YonatanMankovich.SevenSegmentToBinary
{
    public partial class MainForm : Form
    {
        private Button[] buttons;

        public MainForm()
        {
            InitializeComponent();
            buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7 };
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = clickedButton.BackColor == Color.Black ? Color.Red : Color.Black;
            SetOutputTB();
        }

        private void SetOutputTB()
        {
            string OutText = "";
            foreach (Button button in buttons)
                OutText += button.BackColor == Color.Red ? "1" : "0";
            BinaryTB.Text = OutText;
        }

        private void CopyBTN_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("0b0" + BinaryTB.Text);
        }

        private void PasteBTN_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText().Contains("0b0") && Clipboard.GetText().Length == 10)
                BinaryTB.Text = Clipboard.GetText().Remove(0, 3);
        }

        private void BinaryTB_TextChanged(object sender, EventArgs e)
        {
            if (new System.Text.RegularExpressions.Regex(@"[01]{7}").Match(BinaryTB.Text).Success)
            {
                BinaryTB.ForeColor = Color.Black;
                for (int i = 0; i < 7 - BinaryTB.Text.Length; i++)
                    buttons[6 - i].BackColor = Color.Black;
                for (int i = 0; i < BinaryTB.Text.Length; i++)
                    buttons[i].BackColor = BinaryTB.Text[i] == '1' ? Color.Red : Color.Black;
            }
            else
            {
                foreach (Button button in buttons)
                    button.BackColor = Color.Black;
                BinaryTB.ForeColor = Color.Red;
            }
        }
    }
}