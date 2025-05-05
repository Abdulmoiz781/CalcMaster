namespace CalcMaster
{
    partial class diff
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
            txtResult = new TextBox();
            btnSolve = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtEquation
            // 
            txtEquation.Location = new Point(10, 30);
            txtEquation.Margin = new Padding(2, 2, 2, 2);
            txtEquation.Multiline = true;
            txtEquation.Name = "txtEquation";
            txtEquation.Size = new Size(622, 56);
            txtEquation.TabIndex = 0;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(10, 145);
            txtResult.Margin = new Padding(2, 2, 2, 2);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(622, 54);
            txtResult.TabIndex = 1;
            // 
            // btnSolve
            // 
            btnSolve.Location = new Point(10, 310);
            btnSolve.Margin = new Padding(2, 2, 2, 2);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(90, 27);
            btnSolve.TabIndex = 2;
            btnSolve.Text = "Solve";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += btnSolve_Click;
            // 
            // button2
            // 
            button2.Location = new Point(534, 310);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(90, 27);
            button2.TabIndex = 3;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_click;
            // 
            // diff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 45);
            ClientSize = new Size(640, 360);
            Controls.Add(button2);
            Controls.Add(btnSolve);
            Controls.Add(txtResult);
            Controls.Add(txtEquation);
            Margin = new Padding(2, 2, 2, 2);
            Name = "diff";
            Text = "diff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEquation;
        private TextBox txtResult;
        private Button btnSolve;
        private Button button2;
    }
}