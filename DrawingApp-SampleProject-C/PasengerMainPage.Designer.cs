namespace DrawingApp_SampleProject_C
{
    partial class PasengerMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasengerMainPage));
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(233, 399);
            button1.Name = "button1";
            button1.Size = new Size(241, 62);
            button1.TabIndex = 0;
            button1.Text = "Search Flights";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(597, 399);
            button2.Name = "button2";
            button2.Size = new Size(229, 62);
            button2.TabIndex = 1;
            button2.Text = "Manage My Flights";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(972, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(98, 100);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(114, 175);
            label1.Name = "label1";
            label1.Size = new Size(841, 71);
            label1.TabIndex = 6;
            label1.Text = "Welcom To Airline Booking System";
            // 
            // PasengerMainPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_white_abstract_backgrounds_group_white_colour;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1070, 790);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "PasengerMainPage";
            Text = "Pasenger Main Page";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private Label label1;
    }
}