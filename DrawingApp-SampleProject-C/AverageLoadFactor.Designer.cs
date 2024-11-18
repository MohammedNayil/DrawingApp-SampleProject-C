namespace DrawingApp_SampleProject_C
{
    partial class AverageLoadFactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AverageLoadFactor));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(972, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 100);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.desktop_wallpaper_white_abstract_backgrounds_group_white_colour;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(48, 642);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 8;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(281, 89);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(281, 169);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(394, 388);
            listBox1.TabIndex = 10;
            // 
            // AverageLoadFactor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_white_abstract_backgrounds_group_white_colour;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1070, 790);
            Controls.Add(listBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "AverageLoadFactor";
            Text = "AverageLoadFactor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox1;
    }
}