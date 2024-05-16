namespace DrawingApp_SampleProject_C
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(186, 368);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 333);
            label4.Name = "label4";
            label4.Size = new Size(163, 32);
            label4.TabIndex = 23;
            label4.Text = "Card Number:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(186, 284);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 249);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 21;
            label3.Text = "Name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(478, 370);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(88, 39);
            textBox2.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 335);
            label2.Name = "label2";
            label2.Size = new Size(63, 32);
            label2.TabIndex = 19;
            label2.Text = "CVC:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(478, 284);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(478, 249);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 17;
            label1.Text = "Expiration Date:";
            // 
            // button1
            // 
            button1.Location = new Point(693, 636);
            button1.Name = "button1";
            button1.Size = new Size(213, 49);
            button1.TabIndex = 25;
            button1.Text = "Confirm Payment";
            button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(186, 469);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(297, 32);
            linkLabel1.TabIndex = 26;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Save payment information";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(186, 154);
            label5.Name = "label5";
            label5.Size = new Size(243, 32);
            label5.TabIndex = 27;
            label5.Text = "Payment Information:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(975, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 100);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(92, 639);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 29;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_white_abstract_backgrounds_group_white_colour;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1070, 790);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Payment";
            Text = "Payment";
            Load += Form13_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label5;
        private PictureBox pictureBox1;
        private Button button2;
    }
}