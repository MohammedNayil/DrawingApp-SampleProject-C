/*namespace DrawingApp_SampleProject_C
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DrawingPanel = new Panel();
            drawLineButton = new Button();
            drawSquareButton = new Button();
            drawCircleButton = new Button();
            drawTriangleButton = new Button();
            drawRectangleButton = new Button();
            shapesListBox = new ListBox();
            infoModeButton = new Button();
            drawModeButton = new Button();
            SuspendLayout();
            // 
            // DrawingPanel
            // 
            DrawingPanel.BackColor = Color.White;
            DrawingPanel.BorderStyle = BorderStyle.FixedSingle;
            DrawingPanel.Location = new Point(251, 118);
            DrawingPanel.Margin = new Padding(4, 5, 4, 5);
            DrawingPanel.Name = "DrawingPanel";
            DrawingPanel.Size = new Size(816, 532);
            DrawingPanel.TabIndex = 0;
            DrawingPanel.Click += DrawingPanel_Click;
            DrawingPanel.Paint += DrawingPanel_Paint;
            DrawingPanel.MouseClick += DrawingPanel_MouseDown;
            // 
            // drawLineButton
            // 
            drawLineButton.Location = new Point(49, 505);
            drawLineButton.Margin = new Padding(4, 5, 4, 5);
            drawLineButton.Name = "drawLineButton";
            drawLineButton.Size = new Size(150, 50);
            drawLineButton.TabIndex = 2;
            drawLineButton.Text = "Line";
            drawLineButton.UseVisualStyleBackColor = true;
            drawLineButton.Click += drawLineButton_Click;
            // 
            // drawSquareButton
            // 
            drawSquareButton.Location = new Point(49, 431);
            drawSquareButton.Margin = new Padding(4, 5, 4, 5);
            drawSquareButton.Name = "drawSquareButton";
            drawSquareButton.Size = new Size(150, 50);
            drawSquareButton.TabIndex = 3;
            drawSquareButton.Text = "Square";
            drawSquareButton.UseVisualStyleBackColor = true;
            drawSquareButton.Click += drawSquareButton_Click;
            // 
            // drawCircleButton
            // 
            drawCircleButton.Location = new Point(49, 358);
            drawCircleButton.Margin = new Padding(4, 5, 4, 5);
            drawCircleButton.Name = "drawCircleButton";
            drawCircleButton.Size = new Size(150, 50);
            drawCircleButton.TabIndex = 4;
            drawCircleButton.Text = "Circle";
            drawCircleButton.UseVisualStyleBackColor = true;
            drawCircleButton.Click += drawCircleButton_Click;
            // 
            // drawTriangleButton
            // 
            drawTriangleButton.BackColor = SystemColors.ControlLight;
            drawTriangleButton.BackgroundImageLayout = ImageLayout.Center;
            drawTriangleButton.Location = new Point(49, 288);
            drawTriangleButton.Margin = new Padding(4, 5, 4, 5);
            drawTriangleButton.Name = "drawTriangleButton";
            drawTriangleButton.Size = new Size(150, 50);
            drawTriangleButton.TabIndex = 5;
            drawTriangleButton.Text = "Triangle";
            drawTriangleButton.UseVisualStyleBackColor = false;
            drawTriangleButton.Click += drawTriangleButton_Click;
            // 
            // drawRectangleButton
            // 
            drawRectangleButton.BackColor = SystemColors.ControlLight;
            drawRectangleButton.BackgroundImageLayout = ImageLayout.Stretch;
            drawRectangleButton.Location = new Point(49, 214);
            drawRectangleButton.Margin = new Padding(4, 5, 4, 5);
            drawRectangleButton.Name = "drawRectangleButton";
            drawRectangleButton.Size = new Size(150, 50);
            drawRectangleButton.TabIndex = 6;
            drawRectangleButton.Text = "Rectangle";
            drawRectangleButton.UseVisualStyleBackColor = false;
            drawRectangleButton.Click += drawRectangleButton_Click;
            // 
            // shapesListBox
            // 
            shapesListBox.FormattingEnabled = true;
            shapesListBox.ItemHeight = 25;
            shapesListBox.Location = new Point(1179, 109);
            shapesListBox.Name = "shapesListBox";
            shapesListBox.Size = new Size(281, 554);
            shapesListBox.TabIndex = 9;
            shapesListBox.SelectedIndexChanged += shapesListBox_SelectedIndexChanged;
            // 
            // infoModeButton
            // 
            infoModeButton.Location = new Point(261, 24);
            infoModeButton.Margin = new Padding(4, 5, 4, 5);
            infoModeButton.Name = "infoModeButton";
            infoModeButton.Size = new Size(150, 50);
            infoModeButton.TabIndex = 10;
            infoModeButton.Text = "Info Mode";
            infoModeButton.UseVisualStyleBackColor = true;
            infoModeButton.Click += infoModeButton_Click;
            // 
            // drawModeButton
            // 
            drawModeButton.Location = new Point(60, 24);
            drawModeButton.Margin = new Padding(4, 5, 4, 5);
            drawModeButton.Name = "drawModeButton";
            drawModeButton.Size = new Size(150, 50);
            drawModeButton.TabIndex = 11;
            drawModeButton.Text = "Draw Mode";
            drawModeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1578, 753);
            Controls.Add(drawModeButton);
            Controls.Add(infoModeButton);
            Controls.Add(shapesListBox);
            Controls.Add(drawRectangleButton);
            Controls.Add(drawTriangleButton);
            Controls.Add(drawCircleButton);
            Controls.Add(drawSquareButton);
            Controls.Add(drawLineButton);
            Controls.Add(DrawingPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel DrawingPanel;
        private Button drawLineButton;
        private Button drawSquareButton;
        private Button drawCircleButton;
        private Button drawTriangleButton;
        private Button drawRectangleButton;
        private ListBox shapesListBox;
        private Button infoModeButton;
        private Button drawModeButton;
    }
}*/