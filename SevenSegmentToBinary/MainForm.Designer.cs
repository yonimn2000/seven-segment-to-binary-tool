﻿namespace _7_Segment_to_Binary
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.BinaryTB = new System.Windows.Forms.TextBox();
            this.CopyBTN = new System.Windows.Forms.Button();
            this.pasteBTN = new System.Windows.Forms.Button();
            this.ConstTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(38, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 27);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(12, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 162);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(12, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 162);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(38, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 27);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(194, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 162);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(194, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 162);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(38, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(159, 27);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // BinaryTB
            // 
            this.BinaryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinaryTB.Location = new System.Drawing.Point(74, 447);
            this.BinaryTB.MaxLength = 7;
            this.BinaryTB.Name = "BinaryTB";
            this.BinaryTB.Size = new System.Drawing.Size(147, 47);
            this.BinaryTB.TabIndex = 7;
            this.BinaryTB.Text = "0000000";
            this.BinaryTB.TextChanged += new System.EventHandler(this.BinaryTB_TextChanged);
            // 
            // CopyBTN
            // 
            this.CopyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyBTN.Location = new System.Drawing.Point(12, 500);
            this.CopyBTN.Name = "CopyBTN";
            this.CopyBTN.Size = new System.Drawing.Size(106, 33);
            this.CopyBTN.TabIndex = 8;
            this.CopyBTN.Text = "Copy";
            this.CopyBTN.UseVisualStyleBackColor = true;
            this.CopyBTN.Click += new System.EventHandler(this.CopyBTN_Click);
            // 
            // pasteBTN
            // 
            this.pasteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasteBTN.Location = new System.Drawing.Point(124, 500);
            this.pasteBTN.Name = "pasteBTN";
            this.pasteBTN.Size = new System.Drawing.Size(97, 32);
            this.pasteBTN.TabIndex = 9;
            this.pasteBTN.Text = "Paste";
            this.pasteBTN.UseVisualStyleBackColor = true;
            this.pasteBTN.Click += new System.EventHandler(this.PasteBTN_Click);
            // 
            // ConstTB
            // 
            this.ConstTB.Enabled = false;
            this.ConstTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.ConstTB.Location = new System.Drawing.Point(12, 447);
            this.ConstTB.MaxLength = 10;
            this.ConstTB.Name = "ConstTB";
            this.ConstTB.Size = new System.Drawing.Size(65, 47);
            this.ConstTB.TabIndex = 10;
            this.ConstTB.Text = "0b0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 544);
            this.Controls.Add(this.ConstTB);
            this.Controls.Add(this.pasteBTN);
            this.Controls.Add(this.CopyBTN);
            this.Controls.Add(this.BinaryTB);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Seven Segment to Binary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox BinaryTB;
        private System.Windows.Forms.Button CopyBTN;
        private System.Windows.Forms.Button pasteBTN;
        private System.Windows.Forms.TextBox ConstTB;
    }
}
