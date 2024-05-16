namespace DrawingApp_SampleProject_C
{
    partial class PassengerFlightInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengerFlightInfo));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(347, 648);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "Book Flight";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 103);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 1;
            label1.Text = "Flight 314";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 103);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 2;
            label2.Text = "June 1, 2024";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 165);
            label3.Name = "label3";
            label3.Size = new Size(159, 32);
            label3.TabIndex = 3;
            label3.Text = "From Damam";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 165);
            label4.Name = "label4";
            label4.Size = new Size(118, 32);
            label4.TabIndex = 4;
            label4.Text = "To Riyadh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 662);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 5;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 569);
            label6.Name = "label6";
            label6.Size = new Size(184, 32);
            label6.TabIndex = 6;
            label6.Text = "Cancelation Fee";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 614);
            label7.Name = "label7";
            label7.Size = new Size(208, 32);
            label7.TabIndex = 7;
            label7.Text = "Missing Flight Fee";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1A", "1B", "1C", "1D", "1E", "1F", "Wait List" });
            comboBox1.Location = new Point(85, 293);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "Choose Seat";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1A", "1B", "1C", "1D", "1E", "1F" });
            comboBox2.Location = new Point(85, 233);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 40);
            comboBox2.TabIndex = 12;
            comboBox2.Text = "Add Weight";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(604, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 744);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(347, 584);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 14;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PassengerFlightInfo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_white_abstract_backgrounds_group_white_colour;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1070, 790);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "PassengerFlightInfo";
            Text = "Flight Information";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private PictureBox pictureBox1;
        private Button button2;
    }
}