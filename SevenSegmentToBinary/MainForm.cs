using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Segment_to_Binary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void SetOutputTB()
        {
            string OutText="";
            OutText += button1.BackColor == Color.Red ? "1" : "0";
            OutText += button2.BackColor == Color.Red ? "1" : "0";
            OutText += button3.BackColor == Color.Red ? "1" : "0";
            OutText += button4.BackColor == Color.Red ? "1" : "0";
            OutText += button5.BackColor == Color.Red ? "1" : "0";
            OutText += button6.BackColor == Color.Red ? "1" : "0";
            OutText += button7.BackColor == Color.Red ? "1" : "0";
            BinaryTB.Text = OutText;
        }
        private void CopyBTN_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("0b0"+BinaryTB.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = button1.BackColor == Color.Black ? Color.Red : Color.Black;
            SetOutputTB();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = button2.BackColor == Color.Black ? Color.Red : Color.Black;
            SetOutputTB();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = button3.BackColor == Color.Black ? Color.Red : Color.Black;
            SetOutputTB();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = button4.BackColor == Color.Black ? Color.Red : Color.Black;
            SetOutputTB();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = button5.BackColor == Color.Black ? Color.Red : Color.Black;
            SetOutputTB();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = button6.BackColor == Color.Black ? Color.Red : Color.Black;
            SetOutputTB();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = button7.BackColor == Color.Black ? Color.Red : Color.Black;
            SetOutputTB();
        }

        private void PasteBTN_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText().Contains("0b0") && Clipboard.GetText().Length == 10)
                BinaryTB.Text = Clipboard.GetText().Remove(0,3);
        }

        private void BinaryTB_TextChanged(object sender, EventArgs e)
        {
            Button[] Buttons = { button1, button2, button3, button4, button5, button6, button7 };
            for (int i = 0; i < 7-BinaryTB.Text.Length; i++)
               Buttons[6-i].BackColor = Color.Black;
            for (int i = 0; i < BinaryTB.Text.Length; i++)
                Buttons[i].BackColor = BinaryTB.Text[i] == '1' ? Color.Red : Color.Black;
        }
    }
}