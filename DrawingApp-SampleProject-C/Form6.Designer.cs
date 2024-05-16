namespace DrawingApp_SampleProject_C
{
    partial class Form6
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
            components = new System.ComponentModel.Container();
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            checkedListBox3 = new CheckedListBox();
            checkedListBox5 = new CheckedListBox();
            checkedListBox6 = new CheckedListBox();
            imageList1 = new ImageList(components);
            checkedListBox4 = new CheckedListBox();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "A", "A", "A", "A", "A", "A", "A", "A", "A", "A" });
            checkedListBox1.Location = new Point(246, 149);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(60, 364);
            checkedListBox1.TabIndex = 1;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "B", "B", "B", "B", "B", "B", "B", "B", "B", "B" });
            checkedListBox2.Location = new Point(312, 149);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(60, 364);
            checkedListBox2.TabIndex = 2;
            // 
            // checkedListBox3
            // 
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Items.AddRange(new object[] { "C", "C", "C", "C", "C", "C", "C", "C", "C", "C" });
            checkedListBox3.Location = new Point(378, 149);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(60, 364);
            checkedListBox3.TabIndex = 3;
            // 
            // checkedListBox5
            // 
            checkedListBox5.FormattingEnabled = true;
            checkedListBox5.Items.AddRange(new object[] { "E", "E", "E", "E", "E", "E", "E", "E", "E", "E" });
            checkedListBox5.Location = new Point(588, 149);
            checkedListBox5.Name = "checkedListBox5";
            checkedListBox5.Size = new Size(60, 364);
            checkedListBox5.TabIndex = 5;
            // 
            // checkedListBox6
            // 
            checkedListBox6.FormattingEnabled = true;
            checkedListBox6.Items.AddRange(new object[] { "D", "D", "D", "D", "D", "D", "D", "D", "D", "D" });
            checkedListBox6.Location = new Point(522, 149);
            checkedListBox6.Name = "checkedListBox6";
            checkedListBox6.Size = new Size(60, 364);
            checkedListBox6.TabIndex = 4;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // checkedListBox4
            // 
            checkedListBox4.FormattingEnabled = true;
            checkedListBox4.Items.AddRange(new object[] { "F", "F", "F", "F", "F", "F", "F", "F", "F", "F" });
            checkedListBox4.Location = new Point(654, 149);
            checkedListBox4.Name = "checkedListBox4";
            checkedListBox4.Size = new Size(60, 364);
            checkedListBox4.TabIndex = 6;
            checkedListBox4.SelectedIndexChanged += checkedListBox4_SelectedIndexChanged_1;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 758);
            Controls.Add(checkedListBox4);
            Controls.Add(checkedListBox5);
            Controls.Add(checkedListBox6);
            Controls.Add(checkedListBox3);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
        }

        #endregion
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox3;
        private CheckedListBox checkedListBox5;
        private CheckedListBox checkedListBox6;
        private ImageList imageList1;
        private CheckedListBox checkedListBox4;
    }
}