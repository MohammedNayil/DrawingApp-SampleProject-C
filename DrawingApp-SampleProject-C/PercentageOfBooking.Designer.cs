﻿namespace DrawingApp_SampleProject_C
{
    partial class PercentageOfBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PercentageOfBooking));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            listBox1 = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(971, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 100);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(54, 690);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 5;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(306, 193);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(394, 388);
            listBox1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(306, 113);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // PercentageOfBooking
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
            Name = "PercentageOfBooking";
            Text = "PercentageOfBooking";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private ListBox listBox1;
        private DateTimePicker dateTimePicker1;
    }
}