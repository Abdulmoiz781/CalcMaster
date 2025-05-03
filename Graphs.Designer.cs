namespace CalcMaster
{
    partial class Graphs
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
            txtEquation = new TextBox();
            button1 = new Button();
            button2 = new Button();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtEquation
            // 
            txtEquation.Location = new Point(21, 37);
            txtEquation.Name = "txtEquation";
            txtEquation.Size = new Size(185, 31);
            txtEquation.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(21, 74);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonPlus_Click;
            // 
            // button2
            // 
            button2.Location = new Point(687, 0);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // plotView1
            // 
            plotView1.BackColor = Color.White;
            plotView1.Location = new Point(229, 0);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(570, 454);
            plotView1.TabIndex = 3;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // button3
            // 
            button3.BackColor = Color.OrangeRed;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(687, 0);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "🏠";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Graphs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 45);
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(plotView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtEquation);
            Name = "Graphs";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEquation;
        private Button button1;
        private Button button2;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private Button button3;
    }
}