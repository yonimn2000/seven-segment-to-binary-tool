using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace YonatanMankovich.SevenSegmentToBinary
{
    public partial class MainForm : Form
    {
        private readonly Button[] segmentButtons;
        private readonly static string[] SEGMENT_NAMES = { "Middle", "Top left", "Bottom left",
                                                           "Bottom", "Bottom right", "Top right", "Top" };
        private readonly static string PATH_TO_SAVE = "order.txt";

        public MainForm()
        {
            InitializeComponent();
            segmentButtons = new Button[] { middleSegmentBTN, topLeftSegmentBTN, bottomLeftSegmentBTN,
                bottomSegmentBTN, bottomRightSegmentBTN, topRightSegmentBTN, topSegmentBTN };
        }

        private Button[] GetOrderedSegmentButtonsArray()
        {
            Button[] orderedSegmentButtons = new Button[SEGMENT_NAMES.Length];
            for (int orderLB_Index = 0; orderLB_Index < SEGMENT_NAMES.Length; orderLB_Index++)
                orderedSegmentButtons[orderLB.Items.IndexOf(SEGMENT_NAMES[orderLB_Index])] = segmentButtons[orderLB_Index];
            return orderedSegmentButtons;
        }

        private void SegmentButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = clickedButton.BackColor == Color.Black ? Color.Red : Color.Black;
            SetOutputTB();
        }

        private void SetOutputTB()
        {
            string OutText = "";
            Button[] array = GetOrderedSegmentButtonsArray();
            for (int i = 0; i < array.Length; i++)
            {
                Button button = array[i];
                OutText += button.BackColor == Color.Red ? "1" : "0";
            }

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
            Button[] orderedSegmentButtons = GetOrderedSegmentButtonsArray();
            if (new System.Text.RegularExpressions.Regex(@"[01]{7}").Match(BinaryTB.Text).Success)
            {
                BinaryTB.ForeColor = Color.Black;
                for (int i = 0; i < BinaryTB.Text.Length; i++)
                    orderedSegmentButtons[i].BackColor = BinaryTB.Text[i] == '1' ? Color.Red : Color.Black;
            }
            else
            {
                foreach (Button button in orderedSegmentButtons)
                    button.BackColor = Color.Black;
                BinaryTB.ForeColor = Color.Red;
            }
        }

        private void OrderLB_MouseDown(object sender, MouseEventArgs e)
        {
            if (orderLB.SelectedItem == null) return;
            orderLB.DoDragDrop(orderLB.SelectedItem, DragDropEffects.Move);
        }

        private void OrderLB_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void OrderLB_DragDrop(object sender, DragEventArgs e)
        {
            Point point = orderLB.PointToClient(new Point(e.X, e.Y));
            int index = orderLB.IndexFromPoint(point);
            if (index < 0)
                index = orderLB.Items.Count - 1;
            object data = e.Data.GetData(typeof(string));
            orderLB.Items.Remove(data);
            orderLB.Items.Insert(index, data);
            SetOutputTB();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bool loadDefaultOrder = false;
            if (File.Exists(PATH_TO_SAVE))
            {
                string[] lines = File.ReadAllLines(PATH_TO_SAVE);
                if (lines.Length == SEGMENT_NAMES.Length)
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        // if the line exists in the segment names array
                        if (Array.IndexOf(SEGMENT_NAMES, lines[i]) >= 0)
                            orderLB.Items.Add(lines[i]);
                        else
                        {
                            File.Delete(PATH_TO_SAVE);
                            orderLB.Items.Clear();
                            loadDefaultOrder = true;
                            break;
                        }
                    }
                }
                else
                    loadDefaultOrder = true;
            }
            else
                loadDefaultOrder = true;
            if (loadDefaultOrder)
                orderLB.Items.AddRange(SEGMENT_NAMES);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string output = "";
            foreach (string orderItem in orderLB.Items)
                output += orderItem + "\n";
            File.WriteAllText(PATH_TO_SAVE, output);
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            BinaryTB.Text = "0000000";
        }
    }
}