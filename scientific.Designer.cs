namespace CalcMaster
{
    partial class scientific
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBoxHistory = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearHistory = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // textBox1
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.textBox1.Location = new System.Drawing.Point(20, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.ReadOnly = true;
            this.textBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.ForeColor = System.Drawing.Color.White;

            // richTextBoxHistory
            this.richTextBoxHistory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.richTextBoxHistory.Location = new System.Drawing.Point(500, 20);
            this.richTextBoxHistory.Name = "richTextBoxHistory";
            this.richTextBoxHistory.ReadOnly = true;
            this.richTextBoxHistory.Size = new System.Drawing.Size(280, 400);
            this.richTextBoxHistory.TabIndex = 1;
            this.richTextBoxHistory.BackColor = System.Drawing.Color.MidnightBlue;
            this.richTextBoxHistory.ForeColor = System.Drawing.Color.White;

            // tableLayoutPanelButtons
            this.tableLayoutPanelButtons.ColumnCount = 5;
            this.tableLayoutPanelButtons.RowCount = 7;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(20, 70);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(460, 420);
            this.tableLayoutPanelButtons.TabIndex = 2;

            for (int i = 0; i < 5; i++)
                this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            for (int i = 0; i < 7; i++)
                this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));

            string[] buttonLabels = new string[] {
                "7", "8", "9", "/", "√",
                "4", "5", "6", "*", "∛",
                "1", "2", "3", "-", "^",
                "0", ".", "=", "+", "π",
                "C", "←", "(", ")", "Back",
                "sin", "cos", "tan", "log", "ln",
                "e", "%", "x^2", "x^3", "exp"
            };

            int btnIndex = 0;
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                    btn.Dock = System.Windows.Forms.DockStyle.Fill;
                    btn.Font = new System.Drawing.Font("Segoe UI", 10F);
                    btn.Text = buttonLabels[btnIndex];
                    btn.Name = "button" + buttonLabels[btnIndex];
                    btn.BackColor = System.Drawing.Color.MediumSlateBlue;
                    btn.ForeColor = System.Drawing.Color.White;
                    btn.Click += new System.EventHandler(this.DynamicButtonClick);
                    this.tableLayoutPanelButtons.Controls.Add(btn, col, row);
                    btnIndex++;
                }
            }

            // btnClearHistory
            this.btnClearHistory.Text = "🧹 Clear History";
            this.btnClearHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearHistory.Location = new System.Drawing.Point(500, 430);
            this.btnClearHistory.Size = new System.Drawing.Size(280, 40);
            this.btnClearHistory.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClearHistory.ForeColor = System.Drawing.Color.White;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);

            // scientific (Form)
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.tableLayoutPanelButtons);
            this.Controls.Add(this.richTextBoxHistory);
            this.Controls.Add(this.textBox1);
            this.Name = "scientific";
            this.Text = "Scientific Calculator";
            this.Load += new System.EventHandler(this.scientific_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBoxHistory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button btnClearHistory;
    }
}
