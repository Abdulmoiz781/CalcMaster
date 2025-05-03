using System.Drawing.Drawing2D;

namespace CalcMaster
{
    partial class Basic
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            txtDisplay = new TextBox();
            button18 = new Button();
            button19 = new Button();
            richTextBoxHistory = new RichTextBox();
            button20 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = SystemColors.ControlLightLight;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Segoe UI", 9F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(39, 133);
            button1.Name = "button1";
            button1.Size = new Size(75, 55);
            button1.TabIndex = 0;
            button1.Text = "9";
            button1.UseVisualStyleBackColor = false;
            button1.Click += DigitButton_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(150, 133);
            button2.Name = "button2";
            button2.Size = new Size(75, 55);
            button2.TabIndex = 1;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DigitButton_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(262, 133);
            button3.Name = "button3";
            button3.Size = new Size(75, 55);
            button3.TabIndex = 2;
            button3.Text = "7";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DigitButton_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(39, 244);
            button4.Name = "button4";
            button4.Size = new Size(75, 55);
            button4.TabIndex = 3;
            button4.Text = "6";
            button4.UseVisualStyleBackColor = true;
            button4.Click += DigitButton_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.Location = new Point(150, 244);
            button5.Name = "button5";
            button5.Size = new Size(75, 55);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += DigitButton_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.Location = new Point(262, 244);
            button6.Name = "button6";
            button6.Size = new Size(75, 55);
            button6.TabIndex = 5;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += DigitButton_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button7.Location = new Point(39, 354);
            button7.Name = "button7";
            button7.Size = new Size(75, 55);
            button7.TabIndex = 6;
            button7.Text = "3";
            button7.UseVisualStyleBackColor = true;
            button7.Click += DigitButton_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button8.Location = new Point(150, 354);
            button8.Name = "button8";
            button8.Size = new Size(75, 55);
            button8.TabIndex = 7;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += DigitButton_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button9.Location = new Point(262, 354);
            button9.Name = "button9";
            button9.Size = new Size(75, 55);
            button9.TabIndex = 8;
            button9.Text = "1";
            button9.UseVisualStyleBackColor = true;
            button9.Click += DigitButton_Click;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button10.Font = new Font("Segoe UI", 20F);
            button10.Location = new Point(39, 449);
            button10.Name = "button10";
            button10.Size = new Size(75, 55);
            button10.TabIndex = 9;
            button10.Text = "•";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = true;
            button10.Click += DigitButton_Click;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button11.Location = new Point(150, 449);
            button11.Name = "button11";
            button11.Size = new Size(75, 55);
            button11.TabIndex = 10;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += DigitButton_Click;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button12.BackColor = Color.OrangeRed;
            button12.FlatStyle = FlatStyle.Flat;
            button12.ForeColor = Color.White;
            button12.Location = new Point(470, 444);
            button12.Name = "button12";
            button12.Size = new Size(100, 60);
            button12.TabIndex = 11;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = false;
            button12.Click += EqualButton_Click;
            // 
            // button13
            // 
            button13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button13.BackColor = Color.OrangeRed;
            button13.FlatStyle = FlatStyle.Flat;
            button13.ForeColor = Color.White;
            button13.Location = new Point(364, 349);
            button13.Name = "button13";
            button13.Size = new Size(100, 60);
            button13.TabIndex = 12;
            button13.Text = "🗑️";
            button13.UseVisualStyleBackColor = false;
            button13.Click += ClearButton_Click;
            // 
            // button14
            // 
            button14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button14.BackColor = SystemColors.Highlight;
            button14.BackgroundImageLayout = ImageLayout.Stretch;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI", 15F);
            button14.ForeColor = Color.White;
            button14.Location = new Point(470, 249);
            button14.Name = "button14";
            button14.Size = new Size(100, 60);
            button14.TabIndex = 13;
            button14.Text = "+";
            button14.UseVisualStyleBackColor = false;
            button14.Click += OperatorButton_Click;
            // 
            // button15
            // 
            button15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button15.BackColor = SystemColors.Highlight;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI", 20F);
            button15.ForeColor = Color.White;
            button15.Location = new Point(364, 249);
            button15.Name = "button15";
            button15.Size = new Size(100, 60);
            button15.TabIndex = 14;
            button15.Text = "-";
            button15.UseVisualStyleBackColor = false;
            button15.Click += OperatorButton_Click;
            // 
            // button16
            // 
            button16.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button16.BackColor = SystemColors.Highlight;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI", 15F);
            button16.ForeColor = Color.White;
            button16.Location = new Point(470, 159);
            button16.Name = "button16";
            button16.Size = new Size(100, 60);
            button16.TabIndex = 15;
            button16.Text = "÷";
            button16.UseVisualStyleBackColor = false;
            button16.Click += OperatorButton_Click;
            // 
            // button17
            // 
            button17.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button17.BackColor = SystemColors.Highlight;
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Segoe UI", 17F);
            button17.ForeColor = Color.White;
            button17.Location = new Point(364, 158);
            button17.Name = "button17";
            button17.Size = new Size(100, 60);
            button17.TabIndex = 16;
            button17.Text = "*";
            button17.UseVisualStyleBackColor = false;
            button17.Click += OperatorButton_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.FromArgb(30, 30, 45);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(-6, 1);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(760, 116);
            txtDisplay.TabIndex = 17;
            // 
            // button18
            // 
            button18.BackColor = Color.OrangeRed;
            button18.FlatStyle = FlatStyle.Flat;
            button18.ForeColor = Color.White;
            button18.Location = new Point(642, 1);
            button18.Name = "button18";
            button18.Size = new Size(112, 34);
            button18.TabIndex = 18;
            button18.Text = "🏠";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.OrangeRed;
            button19.FlatStyle = FlatStyle.Flat;
            button19.ForeColor = Color.White;
            button19.Location = new Point(364, 444);
            button19.Name = "button19";
            button19.Size = new Size(100, 60);
            button19.TabIndex = 11;
            button19.Text = "⌫";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // richTextBoxHistory
            // 
            richTextBoxHistory.Location = new Point(576, 123);
            richTextBoxHistory.Name = "richTextBoxHistory";
            richTextBoxHistory.Size = new Size(178, 417);
            richTextBoxHistory.TabIndex = 19;
            richTextBoxHistory.Text = "";
            // 
            // button20
            // 
            button20.BackColor = Color.OrangeRed;
            button20.FlatStyle = FlatStyle.Flat;
            button20.ForeColor = Color.White;
            button20.Location = new Point(470, 349);
            button20.Name = "button20";
            button20.Size = new Size(100, 60);
            button20.TabIndex = 20;
            button20.Text = "🔄";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // Basic
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 45);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(758, 546);
            Controls.Add(button20);
            Controls.Add(richTextBoxHistory);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(txtDisplay);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Basic";
            Text = "Basic";
            Load += Basic_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        //private void Form_Load(object sender, EventArgs e)
        //{
        //    foreach (Button btn in operatorButtons)  // Apply shadow effect to operator buttons
        //    {
        //        btn.FlatAppearance.MouseOverBackColor = Color.DarkOrange; // Hover effect
        //    }
        //}

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.DarkBlue, Color.LightBlue, 45);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            TextBox historyDisplay = new TextBox();
            historyDisplay.Dock = DockStyle.Top;
            historyDisplay.ReadOnly = true;
            historyDisplay.Font = new Font("Arial", 14, FontStyle.Italic);
            historyDisplay.BackColor = Color.LightGray;
            historyDisplay.Text = "History will appear here";  // Example text
            this.Controls.Add(historyDisplay);  // Add it above the buttons
        }

        //private void Form_Load(object sender, EventArgs e)
        //{
        //    foreach (Button btn in tableLayout.Controls)
        //    {
        //        btn.MouseDown += (s, e) => { btn.Size = new Size(btn.Width - 2, btn.Height - 2); };
        //        btn.MouseUp += (s, e) => { btn.Size = new Size(btn.Width + 2, btn.Height + 2); };
        //    }
        //}

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private TextBox txtDisplay;
        private Button button18;
        private Button button19;
        private RichTextBox richTextBoxHistory;
        private Button button20;
    }
}
