using System;
using System.Drawing;
using System.Windows.Forms;

namespace YonatanMankovich.SevenSegmentToBinary
{
    public partial class MainForm : Form
    {
        private readonly Button[] segmentButtons;
        private readonly static string[] segmentNames = { "Middle", "Top left", "Bottom left", "Bottom", "Bottom right", "Top right", "Top" };

        public MainForm()
        {
            InitializeComponent();
            segmentButtons = new Button[] { middleSegmentBTN, topLeftSegmentBTN, bottomLeftSegmentBTN,
                bottomSegmentBTN, bottomRightSegmentBTN, topRightSegmentBTN, topSegmentBTN };
            orderLB.Items.AddRange(segmentNames);
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(orderLB, "Drag and drop items to reorder the binary mapping.");
        }

        private Button[] GetOrderedSegmentButtonsArray()
        {
            Button[] orderedSegmentButtons = new Button[segmentNames.Length];
            for (int orderLB_Index = 0; orderLB_Index < segmentNames.Length; orderLB_Index++)
                orderedSegmentButtons[orderLB.Items.IndexOf(segmentNames[orderLB_Index])] = segmentButtons[orderLB_Index];
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
        }
    }
}