namespace YonatanMankovich.SevenSegmentToBinary
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.middleSegmentBTN = new System.Windows.Forms.Button();
            this.topLeftSegmentBTN = new System.Windows.Forms.Button();
            this.bottomLeftSegmentBTN = new System.Windows.Forms.Button();
            this.bottomSegmentBTN = new System.Windows.Forms.Button();
            this.bottomRightSegmentBTN = new System.Windows.Forms.Button();
            this.topRightSegmentBTN = new System.Windows.Forms.Button();
            this.topSegmentBTN = new System.Windows.Forms.Button();
            this.BinaryTB = new System.Windows.Forms.TextBox();
            this.CopyBTN = new System.Windows.Forms.Button();
            this.pasteBTN = new System.Windows.Forms.Button();
            this.ConstTB = new System.Windows.Forms.TextBox();
            this.orderLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // middleSegmentBTN
            // 
            this.middleSegmentBTN.BackColor = System.Drawing.Color.Black;
            this.middleSegmentBTN.Location = new System.Drawing.Point(28, 108);
            this.middleSegmentBTN.Name = "middleSegmentBTN";
            this.middleSegmentBTN.Size = new System.Drawing.Size(75, 20);
            this.middleSegmentBTN.TabIndex = 3;
            this.middleSegmentBTN.UseVisualStyleBackColor = false;
            this.middleSegmentBTN.Click += new System.EventHandler(this.SegmentButton_Click);
            // 
            // topLeftSegmentBTN
            // 
            this.topLeftSegmentBTN.BackColor = System.Drawing.Color.Black;
            this.topLeftSegmentBTN.Location = new System.Drawing.Point(8, 32);
            this.topLeftSegmentBTN.Name = "topLeftSegmentBTN";
            this.topLeftSegmentBTN.Size = new System.Drawing.Size(20, 75);
            this.topLeftSegmentBTN.TabIndex = 0;
            this.topLeftSegmentBTN.UseVisualStyleBackColor = false;
            this.topLeftSegmentBTN.Click += new System.EventHandler(this.SegmentButton_Click);
            // 
            // bottomLeftSegmentBTN
            // 
            this.bottomLeftSegmentBTN.BackColor = System.Drawing.Color.Black;
            this.bottomLeftSegmentBTN.Location = new System.Drawing.Point(8, 129);
            this.bottomLeftSegmentBTN.Name = "bottomLeftSegmentBTN";
            this.bottomLeftSegmentBTN.Size = new System.Drawing.Size(20, 75);
            this.bottomLeftSegmentBTN.TabIndex = 1;
            this.bottomLeftSegmentBTN.UseVisualStyleBackColor = false;
            this.bottomLeftSegmentBTN.Click += new System.EventHandler(this.SegmentButton_Click);
            // 
            // bottomSegmentBTN
            // 
            this.bottomSegmentBTN.BackColor = System.Drawing.Color.Black;
            this.bottomSegmentBTN.Location = new System.Drawing.Point(28, 204);
            this.bottomSegmentBTN.Name = "bottomSegmentBTN";
            this.bottomSegmentBTN.Size = new System.Drawing.Size(75, 20);
            this.bottomSegmentBTN.TabIndex = 4;
            this.bottomSegmentBTN.UseVisualStyleBackColor = false;
            this.bottomSegmentBTN.Click += new System.EventHandler(this.SegmentButton_Click);
            // 
            // bottomRightSegmentBTN
            // 
            this.bottomRightSegmentBTN.BackColor = System.Drawing.Color.Black;
            this.bottomRightSegmentBTN.Location = new System.Drawing.Point(103, 129);
            this.bottomRightSegmentBTN.Name = "bottomRightSegmentBTN";
            this.bottomRightSegmentBTN.Size = new System.Drawing.Size(20, 75);
            this.bottomRightSegmentBTN.TabIndex = 6;
            this.bottomRightSegmentBTN.UseVisualStyleBackColor = false;
            this.bottomRightSegmentBTN.Click += new System.EventHandler(this.SegmentButton_Click);
            // 
            // topRightSegmentBTN
            // 
            this.topRightSegmentBTN.BackColor = System.Drawing.Color.Black;
            this.topRightSegmentBTN.Location = new System.Drawing.Point(103, 32);
            this.topRightSegmentBTN.Name = "topRightSegmentBTN";
            this.topRightSegmentBTN.Size = new System.Drawing.Size(20, 75);
            this.topRightSegmentBTN.TabIndex = 5;
            this.topRightSegmentBTN.UseVisualStyleBackColor = false;
            this.topRightSegmentBTN.Click += new System.EventHandler(this.SegmentButton_Click);
            // 
            // topSegmentBTN
            // 
            this.topSegmentBTN.BackColor = System.Drawing.Color.Black;
            this.topSegmentBTN.Location = new System.Drawing.Point(28, 12);
            this.topSegmentBTN.Name = "topSegmentBTN";
            this.topSegmentBTN.Size = new System.Drawing.Size(75, 20);
            this.topSegmentBTN.TabIndex = 2;
            this.topSegmentBTN.UseVisualStyleBackColor = false;
            this.topSegmentBTN.Click += new System.EventHandler(this.SegmentButton_Click);
            // 
            // BinaryTB
            // 
            this.BinaryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinaryTB.Location = new System.Drawing.Point(165, 12);
            this.BinaryTB.MaxLength = 7;
            this.BinaryTB.Name = "BinaryTB";
            this.BinaryTB.Size = new System.Drawing.Size(79, 29);
            this.BinaryTB.TabIndex = 7;
            this.BinaryTB.Text = "0000000";
            this.BinaryTB.TextChanged += new System.EventHandler(this.BinaryTB_TextChanged);
            // 
            // CopyBTN
            // 
            this.CopyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyBTN.Location = new System.Drawing.Point(129, 47);
            this.CopyBTN.Name = "CopyBTN";
            this.CopyBTN.Size = new System.Drawing.Size(115, 24);
            this.CopyBTN.TabIndex = 8;
            this.CopyBTN.Text = "Copy";
            this.CopyBTN.UseVisualStyleBackColor = true;
            this.CopyBTN.Click += new System.EventHandler(this.CopyBTN_Click);
            // 
            // pasteBTN
            // 
            this.pasteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasteBTN.Location = new System.Drawing.Point(129, 77);
            this.pasteBTN.Name = "pasteBTN";
            this.pasteBTN.Size = new System.Drawing.Size(115, 24);
            this.pasteBTN.TabIndex = 9;
            this.pasteBTN.Text = "Paste";
            this.pasteBTN.UseVisualStyleBackColor = true;
            this.pasteBTN.Click += new System.EventHandler(this.PasteBTN_Click);
            // 
            // ConstTB
            // 
            this.ConstTB.Enabled = false;
            this.ConstTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstTB.Location = new System.Drawing.Point(129, 12);
            this.ConstTB.MaxLength = 10;
            this.ConstTB.Name = "ConstTB";
            this.ConstTB.Size = new System.Drawing.Size(37, 29);
            this.ConstTB.TabIndex = 10;
            this.ConstTB.Text = "0b0";
            // 
            // orderLB
            // 
            this.orderLB.AllowDrop = true;
            this.orderLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLB.FormattingEnabled = true;
            this.orderLB.ItemHeight = 16;
            this.orderLB.Location = new System.Drawing.Point(129, 108);
            this.orderLB.Name = "orderLB";
            this.orderLB.Size = new System.Drawing.Size(115, 116);
            this.orderLB.TabIndex = 12;
            this.orderLB.DragDrop += new System.Windows.Forms.DragEventHandler(this.OrderLB_DragDrop);
            this.orderLB.DragOver += new System.Windows.Forms.DragEventHandler(this.OrderLB_DragOver);
            this.orderLB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OrderLB_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 234);
            this.Controls.Add(this.orderLB);
            this.Controls.Add(this.ConstTB);
            this.Controls.Add(this.pasteBTN);
            this.Controls.Add(this.CopyBTN);
            this.Controls.Add(this.BinaryTB);
            this.Controls.Add(this.topSegmentBTN);
            this.Controls.Add(this.topRightSegmentBTN);
            this.Controls.Add(this.bottomRightSegmentBTN);
            this.Controls.Add(this.bottomSegmentBTN);
            this.Controls.Add(this.bottomLeftSegmentBTN);
            this.Controls.Add(this.topLeftSegmentBTN);
            this.Controls.Add(this.middleSegmentBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Seven-Segment to Binary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button middleSegmentBTN;
        private System.Windows.Forms.Button topLeftSegmentBTN;
        private System.Windows.Forms.Button bottomLeftSegmentBTN;
        private System.Windows.Forms.Button bottomSegmentBTN;
        private System.Windows.Forms.Button bottomRightSegmentBTN;
        private System.Windows.Forms.Button topRightSegmentBTN;
        private System.Windows.Forms.Button topSegmentBTN;
        private System.Windows.Forms.TextBox BinaryTB;
        private System.Windows.Forms.Button CopyBTN;
        private System.Windows.Forms.Button pasteBTN;
        private System.Windows.Forms.TextBox ConstTB;
        private System.Windows.Forms.ListBox orderLB;
    }
}

