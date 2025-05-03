//namespace CalcMaster
//{
//    partial class Solver
//    {
//        private System.ComponentModel.IContainer components = null;
//        private System.Windows.Forms.TextBox txtEquation;
//        private System.Windows.Forms.Button btnSolve;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null)) components.Dispose();
//            base.Dispose(disposing);
//        }

//        //    private void InitializeComponent()
//        //    {
//        //        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solver));
//        //        txtEquation = new TextBox();
//        //        btnSolve = new Button();
//        //        label1 = new Label();
//        //        button1 = new Button();
//        //        btnClear = new Button();
//        //        SuspendLayout();
//        //        // 
//        //        // txtEquation
//        //        // 
//        //        txtEquation.Font = new Font("Segoe UI", 12F);
//        //        txtEquation.Location = new Point(12, 85);
//        //        txtEquation.Multiline = true;
//        //        txtEquation.Name = "txtEquation";
//        //        txtEquation.Size = new Size(400, 113);
//        //        txtEquation.TabIndex = 0;
//        //        // 
//        //        // btnSolve
//        //        // 
//        //        btnSolve.BackColor = Color.Orange;
//        //        btnSolve.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
//        //        btnSolve.Location = new Point(12, 226);
//        //        btnSolve.Name = "btnSolve";
//        //        btnSolve.Size = new Size(120, 40);
//        //        btnSolve.TabIndex = 1;
//        //        btnSolve.Text = "Solve";
//        //        btnSolve.UseVisualStyleBackColor = false;
//        //        btnSolve.Click += btnSolve_Click;
//        //        // 
//        //        // label1
//        //        // 
//        //        label1.AutoSize = true;
//        //        label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//        //        label1.Location = new Point(12, 39);
//        //        label1.Name = "label1";
//        //        label1.Size = new Size(239, 22);
//        //        label1.TabIndex = 2;
//        //        label1.Text = "What do u want to solve?";
//        //        // 
//        //        // button1
//        //        // 
//        //        button1.BackColor = Color.Orange;
//        //        button1.FlatStyle = FlatStyle.Flat;
//        //        button1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//        //        button1.ForeColor = SystemColors.ControlText;
//        //        button1.Location = new Point(398, 230);
//        //        button1.Name = "button1";
//        //        button1.Size = new Size(112, 34);
//        //        button1.TabIndex = 3;
//        //        button1.Text = "Home";
//        //        button1.UseVisualStyleBackColor = false;
//        //        button1.Click += button1_Click;
//        //        // 
//        //        // btnClear
//        //        // 
//        //        btnClear.BackColor = Color.Orange;
//        //        btnClear.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
//        //        btnClear.Location = new Point(12, 292);
//        //        btnClear.Name = "btnClear";
//        //        btnClear.Size = new Size(120, 40);
//        //        btnClear.TabIndex = 4;
//        //        btnClear.Text = "Clear";
//        //        btnClear.UseVisualStyleBackColor = false;
//        //        btnClear.Click += button2_Click;
//        //        // 
//        //        // Solver
//        //        // 
//        //        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
//        //        ClientSize = new Size(634, 412);
//        //        Controls.Add(btnClear);
//        //        Controls.Add(button1);
//        //        Controls.Add(label1);
//        //        Controls.Add(txtEquation);
//        //        Controls.Add(btnSolve);
//        //        Name = "Solver";
//        //        Text = "Equation Solver";
//        //        Load += Solver_Load;
//        //        ResumeLayout(false);
//        //        PerformLayout();
//        //    }

//        //    private Label label1;
//        //    private Button button1;
//        //    private Button btnClear;
//        //}


//    }
//}
namespace CalcMaster
{
    partial class Solver
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtEquation;
        private Button btnSolve;
        private Label labelEquation;
        private Button btnBack; // ✅ properly declared

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtEquation = new TextBox();
            btnSolve = new Button();
            btnBack = new Button();
            labelEquation = new Label();
            btnClear = new Button();
            txtSolution = new TextBox();
            SuspendLayout();
            // 
            // txtEquation
            // 
            txtEquation.BackColor = Color.FromArgb(40, 42, 54);
            txtEquation.BorderStyle = BorderStyle.FixedSingle;
            txtEquation.Font = new Font("Consolas", 12F);
            txtEquation.ForeColor = Color.White;
            txtEquation.Location = new Point(12, 77);
            txtEquation.Multiline = true;
            txtEquation.Name = "txtEquation";
            txtEquation.Size = new Size(643, 105);
            txtEquation.TabIndex = 1;
            // 
            // btnSolve
            // 
            btnSolve.BackColor = Color.DeepSkyBlue;
            btnSolve.FlatAppearance.BorderSize = 0;
            btnSolve.FlatStyle = FlatStyle.Flat;
            btnSolve.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSolve.ForeColor = Color.White;
            btnSolve.Location = new Point(25, 439);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(100, 40);
            btnSolve.TabIndex = 2;
            btnSolve.Text = "Solve";
            btnSolve.UseVisualStyleBackColor = false;
            btnSolve.Click += btnSolve_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DeepSkyBlue;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(668, 468);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 40);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += button1_Click;
            // 
            // labelEquation
            // 
            labelEquation.AutoSize = true;
            labelEquation.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelEquation.ForeColor = Color.White;
            labelEquation.Location = new Point(12, 27);
            labelEquation.Name = "labelEquation";
            labelEquation.Size = new Size(172, 30);
            labelEquation.TabIndex = 0;
            labelEquation.Text = "Enter Equation:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DeepSkyBlue;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(157, 439);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtSolution
            // 
            txtSolution.BackColor = Color.FromArgb(40, 42, 54);
            txtSolution.BorderStyle = BorderStyle.FixedSingle;
            txtSolution.Font = new Font("Consolas", 12F);
            txtSolution.ForeColor = Color.White;
            txtSolution.Location = new Point(12, 210);
            txtSolution.Multiline = true;
            txtSolution.Name = "txtSolution";
            txtSolution.ScrollBars = ScrollBars.Vertical;
            txtSolution.Size = new Size(643, 105);
            txtSolution.TabIndex = 5;
            // 
            // Solver
            // 
            BackColor = Color.FromArgb(24, 26, 36);
            ClientSize = new Size(780, 520);
            Controls.Add(txtSolution);
            Controls.Add(btnClear);
            Controls.Add(labelEquation);
            Controls.Add(txtEquation);
            Controls.Add(btnSolve);
            Controls.Add(btnBack);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Solver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equation Solver";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnClear;
        private TextBox txtSolution;
    }
}
