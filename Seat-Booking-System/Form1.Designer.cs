using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rowListBox = new System.Windows.Forms.ListBox();
            this.seatNumberListBox = new System.Windows.Forms.ListBox();
            this.bookButton = new System.Windows.Forms.Button();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.buttonCA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonFA = new System.Windows.Forms.Button();
            this.buttonWL = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonC4 = new System.Windows.Forms.Button();
            this.buttonB1 = new System.Windows.Forms.Button();
            this.buttonC1 = new System.Windows.Forms.Button();
            this.buttonC3 = new System.Windows.Forms.Button();
            this.buttonB4 = new System.Windows.Forms.Button();
            this.buttonC2 = new System.Windows.Forms.Button();
            this.buttonA4 = new System.Windows.Forms.Button();
            this.buttonB2 = new System.Windows.Forms.Button();
            this.buttonA3 = new System.Windows.Forms.Button();
            this.buttonB3 = new System.Windows.Forms.Button();
            this.buttonA2 = new System.Windows.Forms.Button();
            this.buttonA1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rowListBox
            // 
            this.rowListBox.FormattingEnabled = true;
            this.rowListBox.ItemHeight = 16;
            this.rowListBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.rowListBox.Location = new System.Drawing.Point(462, 69);
            this.rowListBox.Margin = new System.Windows.Forms.Padding(2);
            this.rowListBox.Name = "rowListBox";
            this.rowListBox.Size = new System.Drawing.Size(145, 116);
            this.rowListBox.TabIndex = 0;
            // 
            // seatNumberListBox
            // 
            this.seatNumberListBox.FormattingEnabled = true;
            this.seatNumberListBox.ItemHeight = 16;
            this.seatNumberListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.seatNumberListBox.Location = new System.Drawing.Point(636, 69);
            this.seatNumberListBox.Margin = new System.Windows.Forms.Padding(2);
            this.seatNumberListBox.Name = "seatNumberListBox";
            this.seatNumberListBox.Size = new System.Drawing.Size(145, 116);
            this.seatNumberListBox.TabIndex = 1;
            this.seatNumberListBox.SelectedIndexChanged += new System.EventHandler(this.seatNumberListBox_SelectedIndexChanged);
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(462, 235);
            this.bookButton.Margin = new System.Windows.Forms.Padding(2);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(83, 34);
            this.bookButton.TabIndex = 2;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(462, 207);
            this.customerNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(322, 22);
            this.customerNameTextBox.TabIndex = 3;
            // 
            // buttonCA
            // 
            this.buttonCA.Location = new System.Drawing.Point(619, 279);
            this.buttonCA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCA.Name = "buttonCA";
            this.buttonCA.Size = new System.Drawing.Size(163, 34);
            this.buttonCA.TabIndex = 19;
            this.buttonCA.Text = "Cancel all bookings";
            this.buttonCA.UseVisualStyleBackColor = true;
            this.buttonCA.Click += new System.EventHandler(this.buttonCA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Rows:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Columns:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(557, 235);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(86, 34);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonFA
            // 
            this.buttonFA.Location = new System.Drawing.Point(462, 279);
            this.buttonFA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFA.Name = "buttonFA";
            this.buttonFA.Size = new System.Drawing.Size(144, 34);
            this.buttonFA.TabIndex = 21;
            this.buttonFA.Text = "Fill all seats";
            this.buttonFA.UseVisualStyleBackColor = true;
            this.buttonFA.Click += new System.EventHandler(this.buttonFA_Click);
            // 
            // buttonWL
            // 
            this.buttonWL.Location = new System.Drawing.Point(657, 235);
            this.buttonWL.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWL.Name = "buttonWL";
            this.buttonWL.Size = new System.Drawing.Size(126, 34);
            this.buttonWL.TabIndex = 22;
            this.buttonWL.Text = "Add to wait list";
            this.buttonWL.UseVisualStyleBackColor = true;
            this.buttonWL.Click += new System.EventHandler(this.buttonWL_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 25;
            // 
            // buttonC4
            // 
            this.buttonC4.Location = new System.Drawing.Point(224, 212);
            this.buttonC4.Margin = new System.Windows.Forms.Padding(2);
            this.buttonC4.Name = "buttonC4";
            this.buttonC4.Size = new System.Drawing.Size(56, 43);
            this.buttonC4.TabIndex = 12;
            this.buttonC4.Text = "C4";
            this.buttonC4.UseVisualStyleBackColor = true;
            // 
            // buttonB1
            // 
            this.buttonB1.Location = new System.Drawing.Point(44, 137);
            this.buttonB1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonB1.Name = "buttonB1";
            this.buttonB1.Size = new System.Drawing.Size(56, 43);
            this.buttonB1.TabIndex = 11;
            this.buttonB1.Text = "B1";
            this.buttonB1.UseVisualStyleBackColor = true;
            // 
            // buttonC1
            // 
            this.buttonC1.Location = new System.Drawing.Point(44, 209);
            this.buttonC1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonC1.Name = "buttonC1";
            this.buttonC1.Size = new System.Drawing.Size(56, 43);
            this.buttonC1.TabIndex = 15;
            this.buttonC1.Text = "C1";
            this.buttonC1.UseVisualStyleBackColor = true;
            // 
            // buttonC3
            // 
            this.buttonC3.Location = new System.Drawing.Point(164, 209);
            this.buttonC3.Margin = new System.Windows.Forms.Padding(2);
            this.buttonC3.Name = "buttonC3";
            this.buttonC3.Size = new System.Drawing.Size(56, 43);
            this.buttonC3.TabIndex = 13;
            this.buttonC3.Text = "C3";
            this.buttonC3.UseVisualStyleBackColor = true;
            // 
            // buttonB4
            // 
            this.buttonB4.Location = new System.Drawing.Point(224, 137);
            this.buttonB4.Margin = new System.Windows.Forms.Padding(2);
            this.buttonB4.Name = "buttonB4";
            this.buttonB4.Size = new System.Drawing.Size(56, 43);
            this.buttonB4.TabIndex = 10;
            this.buttonB4.Text = "B4";
            this.buttonB4.UseVisualStyleBackColor = true;
            // 
            // buttonC2
            // 
            this.buttonC2.Location = new System.Drawing.Point(104, 209);
            this.buttonC2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonC2.Name = "buttonC2";
            this.buttonC2.Size = new System.Drawing.Size(56, 43);
            this.buttonC2.TabIndex = 14;
            this.buttonC2.Text = "C2";
            this.buttonC2.UseVisualStyleBackColor = true;
            // 
            // buttonA4
            // 
            this.buttonA4.Location = new System.Drawing.Point(224, 69);
            this.buttonA4.Margin = new System.Windows.Forms.Padding(2);
            this.buttonA4.Name = "buttonA4";
            this.buttonA4.Size = new System.Drawing.Size(56, 43);
            this.buttonA4.TabIndex = 7;
            this.buttonA4.Text = "A4";
            this.buttonA4.UseVisualStyleBackColor = true;
            // 
            // buttonB2
            // 
            this.buttonB2.Location = new System.Drawing.Point(104, 137);
            this.buttonB2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonB2.Name = "buttonB2";
            this.buttonB2.Size = new System.Drawing.Size(56, 43);
            this.buttonB2.TabIndex = 8;
            this.buttonB2.Text = "B2";
            this.buttonB2.UseVisualStyleBackColor = true;
            // 
            // buttonA3
            // 
            this.buttonA3.Location = new System.Drawing.Point(164, 69);
            this.buttonA3.Margin = new System.Windows.Forms.Padding(2);
            this.buttonA3.Name = "buttonA3";
            this.buttonA3.Size = new System.Drawing.Size(56, 43);
            this.buttonA3.TabIndex = 6;
            this.buttonA3.Text = "A3";
            this.buttonA3.UseVisualStyleBackColor = true;
            // 
            // buttonB3
            // 
            this.buttonB3.Location = new System.Drawing.Point(164, 137);
            this.buttonB3.Margin = new System.Windows.Forms.Padding(2);
            this.buttonB3.Name = "buttonB3";
            this.buttonB3.Size = new System.Drawing.Size(56, 43);
            this.buttonB3.TabIndex = 9;
            this.buttonB3.Text = "B3";
            this.buttonB3.UseVisualStyleBackColor = true;
            // 
            // buttonA2
            // 
            this.buttonA2.Location = new System.Drawing.Point(104, 69);
            this.buttonA2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonA2.Name = "buttonA2";
            this.buttonA2.Size = new System.Drawing.Size(56, 43);
            this.buttonA2.TabIndex = 5;
            this.buttonA2.Text = "A2";
            this.buttonA2.UseVisualStyleBackColor = true;
            // 
            // buttonA1
            // 
            this.buttonA1.Location = new System.Drawing.Point(44, 69);
            this.buttonA1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonA1.Name = "buttonA1";
            this.buttonA1.Size = new System.Drawing.Size(56, 43);
            this.buttonA1.TabIndex = 4;
            this.buttonA1.Text = "A1";
            this.buttonA1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 390);
            this.Controls.Add(this.buttonA1);
            this.Controls.Add(this.buttonA2);
            this.Controls.Add(this.buttonB3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonA3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonB2);
            this.Controls.Add(this.buttonWL);
            this.Controls.Add(this.buttonA4);
            this.Controls.Add(this.buttonFA);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonC2);
            this.Controls.Add(this.buttonCA);
            this.Controls.Add(this.buttonB4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonC3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonC1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonB1);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.buttonC4);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.seatNumberListBox);
            this.Controls.Add(this.rowListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox rowListBox;
        private ListBox seatNumberListBox;
        private Button bookButton;
        private TextBox customerNameTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonCA;
        private Button buttonCancel;
        private Button buttonFA;
        private Button buttonWL;
        private Label label4;
        private Label label5;
        private Button buttonC4;
        private Button buttonB1;
        private Button buttonC1;
        private Button buttonC3;
        private Button buttonB4;
        private Button buttonC2;
        private Button buttonA4;
        private Button buttonB2;
        private Button buttonA3;
        private Button buttonB3;
        private Button buttonA2;
        private Button buttonA1;
    }
}