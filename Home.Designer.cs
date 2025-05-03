//namespace CalcMaster
//{
//    partial class Home
//    {
//        /// <summary>
//        ///  Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        ///  Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        ///  Required method for Designer support - do not modify
//        ///  the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
//            CalcMaster = new Label();
//            button2 = new Button();
//            button3 = new Button();
//            button4 = new Button();
//            button1 = new Button();
//            panel1 = new Panel();
//            label1 = new Label();
//            splitter1 = new Splitter();
//            panel1.SuspendLayout();
//            SuspendLayout();
//            // 
//            // CalcMaster
//            // 
//            CalcMaster.AutoSize = true;
//            CalcMaster.BackColor = Color.Transparent;
//            CalcMaster.FlatStyle = FlatStyle.Popup;
//            CalcMaster.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
//            CalcMaster.ForeColor = SystemColors.ActiveCaptionText;
//            CalcMaster.Location = new Point(12, 119);
//            CalcMaster.Name = "CalcMaster";
//            CalcMaster.Size = new Size(106, 21);
//            CalcMaster.TabIndex = 6;
//            CalcMaster.Text = "CalcMaster";
//            CalcMaster.Click += CalcMaster_Click;
//            // 
//            // button2
//            // 
//            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
//            button2.Location = new Point(5, 552);
//            button2.Margin = new Padding(3, 2, 3, 2);
//            button2.Name = "button2";
//            button2.Size = new Size(154, 30);
//            button2.TabIndex = 1;
//            button2.Text = "Scientific";
//            button2.UseVisualStyleBackColor = true;
//            button2.Click += button2_Click;
//            // 
//            // button3
//            // 
//            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
//            button3.Location = new Point(5, 618);
//            button3.Margin = new Padding(3, 2, 3, 2);
//            button3.Name = "button3";
//            button3.Size = new Size(172, 31);
//            button3.TabIndex = 2;
//            button3.Text = "Unit Converter";
//            button3.UseVisualStyleBackColor = true;
//            button3.Click += button3_Click;
//            // 
//            // button4
//            // 
//            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
//            button4.Location = new Point(5, 586);
//            button4.Margin = new Padding(3, 2, 3, 2);
//            button4.Name = "button4";
//            button4.Size = new Size(217, 28);
//            button4.TabIndex = 4;
//            button4.Text = "Equation Solver";
//            button4.UseVisualStyleBackColor = true;
//            button4.Click += button4_Click;
//            // 
//            // button1
//            // 
//            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
//            button1.BackgroundImageLayout = ImageLayout.Stretch;
//            button1.Location = new Point(6, 520);
//            button1.Margin = new Padding(3, 2, 3, 2);
//            button1.Name = "button1";
//            button1.Size = new Size(174, 28);
//            button1.TabIndex = 5;
//            button1.Text = "Basic";
//            button1.UseVisualStyleBackColor = true;
//            button1.Click += button1_Click_1;
//            // 
//            // panel1
//            // 
//            panel1.BackColor = Color.Transparent;
//            panel1.Controls.Add(label1);
//            panel1.Controls.Add(splitter1);
//            panel1.Controls.Add(button1);
//            panel1.Controls.Add(button3);
//            panel1.Controls.Add(button2);
//            panel1.Controls.Add(button4);
//            panel1.Dock = DockStyle.Fill;
//            panel1.Location = new Point(0, 0);
//            panel1.Name = "panel1";
//            panel1.Size = new Size(969, 695);
//            panel1.TabIndex = 8;
//            // 
//            // label1
//            // 
//            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
//            label1.AutoSize = true;
//            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
//            label1.Location = new Point(3, 467);
//            label1.Name = "label1";
//            label1.Size = new Size(166, 33);
//            label1.TabIndex = 7;
//            label1.Text = "CalcMaster";
//            label1.Click += label1_Click;
//            // 
//            // splitter1
//            // 
//            splitter1.Location = new Point(0, 0);
//            splitter1.Name = "splitter1";
//            splitter1.Size = new Size(4, 695);
//            splitter1.TabIndex = 6;
//            splitter1.TabStop = false;
//            // 
//            // Home
//            // 
//            AutoScaleDimensions = new SizeF(10F, 21F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = SystemColors.ActiveBorder;
//            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
//            BackgroundImageLayout = ImageLayout.Stretch;
//            ClientSize = new Size(969, 695);
//            Controls.Add(panel1);
//            Controls.Add(CalcMaster);
//            DoubleBuffered = true;
//            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            Margin = new Padding(3, 2, 3, 2);
//            Name = "Home";
//            Text = "CalcMaster";
//            Load += Form1_Load;
//            panel1.ResumeLayout(false);
//            panel1.PerformLayout();
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion
//        private Label CalcMaster;
//        private Button button2;
//        private Button button3;
//        private Button button4;
//        private Button button1;
//        private Panel panel1;
//        private Splitter splitter1;
//        private Label label1;
//    }
//}
namespace CalcMaster
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;

        private Label CalcMaster;
        private Button button1; // Basic
        private Button button2; // Scientific
        private Button button3; // Unit Converter
        private Button button4; // Equation Solver
        private Panel panel1;
        private Splitter splitter1;
        private Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            CalcMaster = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            button5 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            splitter1 = new Splitter();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // CalcMaster
            // 
            CalcMaster.AutoSize = true;
            CalcMaster.BackColor = Color.Transparent;
            CalcMaster.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            CalcMaster.ForeColor = Color.DeepSkyBlue;
            CalcMaster.Location = new Point(27, 20);
            CalcMaster.Name = "CalcMaster";
            CalcMaster.Size = new Size(368, 86);
            CalcMaster.TabIndex = 5;
            CalcMaster.Text = "CalcMaster";
            CalcMaster.Click += CalcMaster_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 120, 215);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(42, 347);
            button2.Name = "button2";
            button2.Size = new Size(260, 55);
            button2.TabIndex = 1;
            button2.Text = "Scientific Calculator";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 120, 215);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(42, 425);
            button3.Name = "button3";
            button3.Size = new Size(260, 55);
            button3.TabIndex = 3;
            button3.Text = "Unit Converter";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 120, 215);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(42, 270);
            button4.Name = "button4";
            button4.Size = new Size(260, 55);
            button4.TabIndex = 2;
            button4.Text = "Equation Solver";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 120, 215);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(42, 192);
            button1.Name = "button1";
            button1.Size = new Size(260, 55);
            button1.TabIndex = 0;
            button1.Text = "Basic Calculator";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 45);
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CalcMaster);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 600);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Highlight;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(42, 506);
            button5.Name = "button5";
            button5.Size = new Size(260, 55);
            button5.TabIndex = 8;
            button5.Text = "Graphs";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(618, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(370, 547);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(42, 106);
            label1.Name = "label1";
            label1.Size = new Size(281, 45);
            label1.TabIndex = 4;
            label1.Text = "Choose Your Tool";
            label1.Click += label1_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 695);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 30);
            ClientSize = new Size(1000, 600);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalcMaster";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        private PictureBox pictureBox2;
        private Button button5;
    }
}
