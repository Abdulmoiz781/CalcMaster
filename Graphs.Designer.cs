/*
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
            button1 = new Button();
            button2 = new Button();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            button3 = new Button();
            btnClearAll = new Button();
            btnClearLast = new Button();
            panelEquationContainer = new Panel();
            panelEquationContainer.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 234);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 1;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonPlus_Click;
            // 
            // button2
            // 
            button2.Location = new Point(550, 0);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(90, 27);
            button2.TabIndex = 2;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // plotView1
            // 
            plotView1.BackColor = Color.White;
            plotView1.Location = new Point(183, 0);
            plotView1.Margin = new Padding(2);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(456, 363);
            plotView1.TabIndex = 3;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            plotView1.Click += plotView1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.OrangeRed;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(550, 0);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(90, 27);
            button3.TabIndex = 4;
            button3.Text = "🏠";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(0, 266);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(94, 29);
            btnClearAll.TabIndex = 5;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnClearLast
            // 
            btnClearLast.Location = new Point(0, 301);
            btnClearLast.Name = "btnClearLast";
            btnClearLast.Size = new Size(94, 29);
            btnClearLast.TabIndex = 6;
            btnClearLast.Text = "Clear Last";
            btnClearLast.UseVisualStyleBackColor = true;
            btnClearLast.Click += btnClearLast_Click;
            // 
            // panelEquationContainer
            // 
            panelEquationContainer.Controls.Add(btnClearLast);
            panelEquationContainer.Controls.Add(btnClearAll);
            panelEquationContainer.Controls.Add(button1);
            panelEquationContainer.Location = new Point(2, 12);
            panelEquationContainer.Name = "panelEquationContainer";
            panelEquationContainer.Size = new Size(176, 351);
            panelEquationContainer.TabIndex = 7;
            // 
            // Graphs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 45);
            ClientSize = new Size(640, 360);
            Controls.Add(panelEquationContainer);
            Controls.Add(button3);
            Controls.Add(plotView1);
            Controls.Add(button2);
            Margin = new Padding(2);
            Name = "Graphs";
            Text = "Form1";
            panelEquationContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private Button button3;
        private Button btnClearAll;
        private Button btnClearLast;
        private Panel panelEquationContainer;
    }
}
*/

//namespace CalcMaster
//{
//    partial class Graphs
//    {
//        private System.ComponentModel.IContainer components = null;
//        private System.Windows.Forms.TextBox txtEquation;
//        private System.Windows.Forms.Button button1;
//        private System.Windows.Forms.Button button2;
//        private OxyPlot.WindowsForms.PlotView plotView1;
//        private System.Windows.Forms.Button button3;
//
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//                components.Dispose();
//            base.Dispose(disposing);
//        }
//
//        private void InitializeComponent()
//        {
//            this.txtEquation = new System.Windows.Forms.TextBox();
//            this.button1 = new System.Windows.Forms.Button();
//            this.button2 = new System.Windows.Forms.Button();
//            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
//            this.button3 = new System.Windows.Forms.Button();
//            this.SuspendLayout();
//            // 
//            // txtEquation
//            // 
//            this.txtEquation.Location = new System.Drawing.Point(17, 30);
//            this.txtEquation.Name = "txtEquation";
//            this.txtEquation.Size = new System.Drawing.Size(149, 27);
//            this.txtEquation.TabIndex = 0;
//            // 
//            // button1
//            // 
//            this.button1.Location = new System.Drawing.Point(17, 59);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(90, 27);
//            this.button1.TabIndex = 1;
//            this.button1.Text = "+";
//            this.button1.UseVisualStyleBackColor = true;
//            this.button1.Click += new System.EventHandler(this.buttonPlus_Click);
//            // 
//            // button2
//            // 
//            this.button2.Location = new System.Drawing.Point(550, 0);
//            this.button2.Name = "button2";
//            this.button2.Size = new System.Drawing.Size(90, 27);
//            this.button2.TabIndex = 2;
//            this.button2.Text = "Home";
//            this.button2.UseVisualStyleBackColor = true;
//            this.button2.Click += new System.EventHandler(this.button2_Click);
//            // 
//            // plotView1
//            // 
//            this.plotView1.BackColor = System.Drawing.Color.White;
//            this.plotView1.Location = new System.Drawing.Point(183, 0);
//            this.plotView1.Name = "plotView1";
//            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
//            this.plotView1.Size = new System.Drawing.Size(456, 363);
//            this.plotView1.TabIndex = 3;
//            this.plotView1.Text = "plotView1";
//            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
//            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
//            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
//            this.plotView1.Click += new System.EventHandler(this.plotView1_Click);
//            // 
//            // button3
//            // 
//            this.button3.BackColor = System.Drawing.Color.OrangeRed;
//            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.button3.ForeColor = System.Drawing.Color.White;
//            this.button3.Location = new System.Drawing.Point(550, 0);
//            this.button3.Name = "button3";
//            this.button3.Size = new System.Drawing.Size(90, 27);
//            this.button3.TabIndex = 4;
//            this.button3.Text = "🏠";
//            this.button3.UseVisualStyleBackColor = false;
//            this.button3.Click += new System.EventHandler(this.button3_Click);
//            // 
//            // Graphs
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 45);
//            this.ClientSize = new System.Drawing.Size(640, 360);
//            this.Controls.Add(this.button3);
//            this.Controls.Add(this.plotView1);
//            this.Controls.Add(this.button2);
//            this.Controls.Add(this.button1);
//            this.Controls.Add(this.txtEquation);
//            this.Name = "Graphs";
//            this.Text = "Graphs";
//            this.ResumeLayout(false);
//            this.PerformLayout();
//        }
//    }
//}
//

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
            btnAddEquation = new Button();
            button2 = new Button();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            button3 = new Button();
            btnClearAll = new Button();
            btnClearLast = new Button();
            panelEquationContainer = new Panel();
            panelEquationContainer.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddEquation
            // 
            btnAddEquation.Location = new Point(0, 404);
            btnAddEquation.Name = "btnAddEquation";
            btnAddEquation.Size = new Size(112, 34);
            btnAddEquation.TabIndex = 1;
            btnAddEquation.Text = "+";
            btnAddEquation.UseVisualStyleBackColor = true;
            btnAddEquation.Click += buttonPlus_Click;
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
            plotView1.Size = new Size(838, 632);
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
            button3.Location = new Point(955, 0);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "🏠";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(-7, 474);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(112, 34);
            btnClearAll.TabIndex = 5;
            btnClearAll.Text = "C";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnClearLast
            // 
            btnClearLast.Location = new Point(111, 474);
            btnClearLast.Name = "btnClearLast";
            btnClearLast.Size = new Size(112, 34);
            btnClearLast.TabIndex = 6;
            btnClearLast.Text = "Clear Last";
            btnClearLast.UseVisualStyleBackColor = true;
            btnClearLast.Click += btnClearLast_Click;
            // 
            // panelEquationContainer
            // 
            panelEquationContainer.Controls.Add(btnClearLast);
            panelEquationContainer.Controls.Add(btnClearAll);
            panelEquationContainer.Controls.Add(btnAddEquation);
            panelEquationContainer.Location = new Point(0, 0);
            panelEquationContainer.Name = "panelEquationContainer";
            panelEquationContainer.Size = new Size(223, 632);
            panelEquationContainer.TabIndex = 8;
            // 
            // Graphs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 45);
            ClientSize = new Size(1062, 629);
            Controls.Add(panelEquationContainer);
            Controls.Add(button3);
            Controls.Add(plotView1);
            Controls.Add(button2);
            Name = "Graphs";
            Text = "Form1";
            panelEquationContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnAddEquation;
        private Button button2;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private Button button3;
        private Button btnClearAll;
        private Button btnClearLast;
        private Panel panelEquationContainer;
    }
}