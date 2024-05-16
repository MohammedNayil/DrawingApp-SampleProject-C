namespace DrawingApp_SampleProject_C
{
    partial class AdminMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainPage));
            button2 = new Button();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(241, 358);
            button2.Name = "button2";
            button2.Size = new Size(234, 83);
            button2.TabIndex = 2;
            button2.Text = "Manage Tickets";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Current active flight", "Percentage of booking", "Confirmed payments", "Waitlisted passengers", "Average load factor", "Ticket cancelled" });
            comboBox1.Location = new Point(586, 358);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 40);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Generate Rerport";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(972, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 100);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(124, 165);
            label1.Name = "label1";
            label1.Size = new Size(841, 71);
            label1.TabIndex = 7;
            label1.Text = "Welcom To Airline Booking System";
            // 
            // AdminMainPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_white_abstract_backgrounds_group_white_colour;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1070, 790);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Name = "AdminMainPage";
            Text = "Admin Main Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}