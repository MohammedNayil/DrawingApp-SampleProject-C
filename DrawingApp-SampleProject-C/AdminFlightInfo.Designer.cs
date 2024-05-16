namespace DrawingApp_SampleProject_C
{
    partial class AdminFlightInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFlightInfo));
            listBox1 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Items.AddRange(new object[] { "Ali", "Mohammed", "Omar", "Saif", "Hamed", "Abdullah" });
            listBox1.Location = new Point(553, 122);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(344, 356);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 221);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 23;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(553, 87);
            label6.Name = "label6";
            label6.Size = new Size(162, 32);
            label6.TabIndex = 24;
            label6.Text = "Passenger List";
            // 
            // button1
            // 
            button1.Location = new Point(77, 654);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 25;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(972, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 100);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 149);
            label4.Name = "label4";
            label4.Size = new Size(118, 32);
            label4.TabIndex = 34;
            label4.Text = "To Riyadh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 149);
            label3.Name = "label3";
            label3.Size = new Size(159, 32);
            label3.TabIndex = 33;
            label3.Text = "From Damam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 87);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 32;
            label2.Text = "June 1, 2024";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 87);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 31;
            label1.Text = "Flight 314";
            // 
            // AdminFlightInfo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_white_abstract_backgrounds_group_white_colour;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1070, 790);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Name = "AdminFlightInfo";
            Text = "Flight Information (Admin View)";
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label5;
        private Label label6;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}