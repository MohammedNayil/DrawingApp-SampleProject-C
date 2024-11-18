namespace DrawingApp_SampleProject_C
{
    partial class CanceledTicketInfo
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
            button3 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(35, 681);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 50;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(816, 633);
            label7.Name = "label7";
            label7.Size = new Size(208, 32);
            label7.TabIndex = 47;
            label7.Text = "Missing Flight Fee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(816, 588);
            label6.Name = "label6";
            label6.Size = new Size(184, 32);
            label6.TabIndex = 46;
            label6.Text = "Cancelation Fee";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(816, 681);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 45;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 285);
            label4.Name = "label4";
            label4.Size = new Size(118, 32);
            label4.TabIndex = 44;
            label4.Text = "To Riyadh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 285);
            label3.Name = "label3";
            label3.Size = new Size(159, 32);
            label3.TabIndex = 43;
            label3.Text = "From Damam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(546, 223);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 42;
            label2.Text = "June 1, 2024";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 223);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 41;
            label1.Text = "Flight 314";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(314, 358);
            label8.Name = "label8";
            label8.Size = new Size(90, 32);
            label8.TabIndex = 51;
            label8.Text = "Weight";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(544, 358);
            label9.Name = "label9";
            label9.Size = new Size(60, 32);
            label9.TabIndex = 52;
            label9.Text = "Seat";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(794, 47);
            label10.Name = "label10";
            label10.Size = new Size(181, 45);
            label10.TabIndex = 53;
            label10.Text = "TimeIssued";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(59, 47);
            label11.Name = "label11";
            label11.Size = new Size(135, 45);
            label11.TabIndex = 54;
            label11.Text = "TicketID";
            // 
            // CanceledTicketInfo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_white_abstract_backgrounds_group_white_colour;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1070, 790);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CanceledTicketInfo";
            Text = "CanceledTicketInfo";
            Load += CanceledTicketInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}