namespace CalcMaster
{
    partial class Notes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button btnReturnHome;

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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.btnReturnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // tabControl
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Size = new System.Drawing.Size(1000, 700);
            this.tabControl.Padding = new System.Drawing.Point(10, 5);

            // btnReturnHome
            this.btnReturnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnReturnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnHome.ForeColor = System.Drawing.Color.White;
            this.btnReturnHome.Location = new System.Drawing.Point(850, 10);
            this.btnReturnHome.Name = "btnReturnHome";
            this.btnReturnHome.Size = new System.Drawing.Size(130, 35);
            this.btnReturnHome.TabIndex = 1;
            this.btnReturnHome.Text = "← Return Home";
            this.btnReturnHome.UseVisualStyleBackColor = false;
            this.btnReturnHome.BringToFront();

            // Notes
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.btnReturnHome);
            this.Controls.Add(this.tabControl);
            this.Name = "Notes";
            this.Text = "Math Formula Reference";
            this.ResumeLayout(false);
        }
    }
}