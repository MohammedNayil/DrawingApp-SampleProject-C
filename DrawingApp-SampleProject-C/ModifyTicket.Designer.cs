namespace DrawingApp_SampleProject_C
{
    partial class ModifyTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyTicket));
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            comboBox3 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "0", "5", "10", "15", "20" });
            comboBox2.Location = new Point(102, 235);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 40);
            comboBox2.TabIndex = 23;
            comboBox2.Text = "Modify Weight";
            // 
            // button1
            // 
            button1.Location = new Point(372, 568);
            button1.Name = "button1";
            button1.Size = new Size(214, 59);
            button1.TabIndex = 14;
            button1.Text = "Confirm Changes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(372, 633);
            button2.Name = "button2";
            button2.Size = new Size(214, 59);
            button2.TabIndex = 25;
            button2.Text = "Delete Ticket";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(372, 506);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 37;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(621, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 744);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1A", "1B", "1C", "1D", "1E", "1F", "Wait List" });
            comboBox3.Location = new Point(102, 291);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(242, 40);
            comboBox3.TabIndex = 34;
            comboBox3.Text = "Choose Seat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(73, 612);
            label7.Name = "label7";
            label7.Size = new Size(208, 32);
            label7.TabIndex = 33;
            label7.Text = "Missing Flight Fee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 23);
            label6.Name = "label6";
            label6.Size = new Size(107, 32);
            label6.TabIndex = 32;
            label6.Text = "Ticket_id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 554);
            label5.Name = "label5";
            label5.Size = new Size(176, 32);
            label5.TabIndex = 31;
            label5.Text = "cancelation fee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 163);
            label4.Name = "label4";
            label4.Size = new Size(118, 32);
            label4.TabIndex = 30;
            label4.Text = "To Riyadh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 163);
            label3.Name = "label3";
            label3.Size = new Size(159, 32);
            label3.TabIndex = 29;
            label3.Text = "From Damam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 101);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 28;
            label2.Text = "June 1, 2024";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 101);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 27;
            label1.Text = "Flight 314";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(73, 660);
            label8.Name = "label8";
            label8.Size = new Size(65, 32);
            label8.TabIndex = 38;
            label8.Text = "Price";
            // 
            // ModifyTicket
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_white_abstract_backgrounds_group_white_colour;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1070, 790);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Name = "ModifyTicket";
            Text = "Modify Ticket";
            Load += ModifyTicket_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private ComboBox comboBox3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
    }
}