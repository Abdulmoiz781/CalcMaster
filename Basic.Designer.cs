/*
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
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            txtDisplay = new TextBox();
            richTextBoxHistory = new RichTextBox();
            SuspendLayout();

           // this.textBoxHistory = new System.Windows.Forms.TextBox();


            // 
            // textBoxHistory
            // 
            this.textBoxHistory.Multiline = true;
            this.textBoxHistory.ScrollBars = ScrollBars.Vertical;
            this.textBoxHistory.ReadOnly = true;
            this.textBoxHistory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxHistory.Location = new System.Drawing.Point(20, 300); // Adjust as needed
            this.textBoxHistory.Size = new System.Drawing.Size(260, 150);
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.TabIndex = 10;



            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = SystemColors.ControlLightLight;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Segoe UI", 9F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(31, 106);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(60, 44);
            button1.TabIndex = 0;
            button1.Tag = "digit";
            button1.Text = "9";
            button1.UseVisualStyleBackColor = false;
            button1.Click += DigitButton_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(120, 106);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(60, 44);
            button2.TabIndex = 1;
            button2.Tag = "digit";
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DigitButton_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(210, 106);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(60, 44);
            button3.TabIndex = 2;
            button3.Tag = "digit";
            button3.Text = "7";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DigitButton_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(31, 195);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(60, 44);
            button4.TabIndex = 3;
            button4.Tag = "digit";
            button4.Text = "6";
            button4.UseVisualStyleBackColor = true;
            button4.Click += DigitButton_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.Location = new Point(120, 195);
            button5.Margin = new Padding(2, 2, 2, 2);
            button5.Name = "button5";
            button5.Size = new Size(60, 44);
            button5.TabIndex = 4;
            button5.Tag = "digit";
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += DigitButton_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.Location = new Point(210, 195);
            button6.Margin = new Padding(2, 2, 2, 2);
            button6.Name = "button6";
            button6.Size = new Size(60, 44);
            button6.TabIndex = 5;
            button6.Tag = "digit";
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += DigitButton_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button7.Location = new Point(31, 283);
            button7.Margin = new Padding(2, 2, 2, 2);
            button7.Name = "button7";
            button7.Size = new Size(60, 44);
            button7.TabIndex = 6;
            button7.Tag = "digit";
            button7.Text = "3";
            button7.UseVisualStyleBackColor = true;
            button7.Click += DigitButton_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button8.Location = new Point(120, 283);
            button8.Margin = new Padding(2, 2, 2, 2);
            button8.Name = "button8";
            button8.Size = new Size(60, 44);
            button8.TabIndex = 7;
            button8.Tag = "digit";
            button8.Text = "2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += DigitButton_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button9.Location = new Point(210, 283);
            button9.Margin = new Padding(2, 2, 2, 2);
            button9.Name = "button9";
            button9.Size = new Size(60, 44);
            button9.TabIndex = 8;
            button9.Tag = "digit";
            button9.Text = "1";
            button9.UseVisualStyleBackColor = true;
            button9.Click += DigitButton_Click;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button10.Font = new Font("Segoe UI", 20F);
            button10.Location = new Point(31, 359);
            button10.Margin = new Padding(2, 2, 2, 2);
            button10.Name = "button10";
            button10.Size = new Size(60, 44);
            button10.TabIndex = 9;
            button10.Tag = "utility";
            button10.Text = "•";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = true;
            button10.Click += DigitButton_Click;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button11.Location = new Point(120, 359);
            button11.Margin = new Padding(2, 2, 2, 2);
            button11.Name = "button11";
            button11.Size = new Size(60, 44);
            button11.TabIndex = 10;
            button11.Tag = "digit";
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
            button12.Location = new Point(376, 355);
            button12.Margin = new Padding(2, 2, 2, 2);
            button12.Name = "button12";
            button12.Size = new Size(80, 48);
            button12.TabIndex = 11;
            button12.Tag = "equal";
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
            button13.Location = new Point(291, 279);
            button13.Margin = new Padding(2, 2, 2, 2);
            button13.Name = "button13";
            button13.Size = new Size(80, 48);
            button13.TabIndex = 12;
            button13.Tag = "utility";
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
            button14.Location = new Point(376, 199);
            button14.Margin = new Padding(2, 2, 2, 2);
            button14.Name = "button14";
            button14.Size = new Size(80, 48);
            button14.TabIndex = 13;
            button14.Tag = "operator";
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
            button15.Location = new Point(291, 199);
            button15.Margin = new Padding(2, 2, 2, 2);
            button15.Name = "button15";
            button15.Size = new Size(80, 48);
            button15.TabIndex = 14;
            button15.Tag = "operator";
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
            button16.Location = new Point(376, 127);
            button16.Margin = new Padding(2, 2, 2, 2);
            button16.Name = "button16";
            button16.Size = new Size(80, 48);
            button16.TabIndex = 15;
            button16.Tag = "operator";
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
            button17.Location = new Point(291, 126);
            button17.Margin = new Padding(2, 2, 2, 2);
            button17.Name = "button17";
            button17.Size = new Size(80, 48);
            button17.TabIndex = 16;
            button17.Tag = "operator";
            button17.Text = "*";
            button17.UseVisualStyleBackColor = false;
            button17.Click += OperatorButton_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.OrangeRed;
            button18.FlatStyle = FlatStyle.Flat;
            button18.ForeColor = Color.White;
            button18.Location = new Point(514, 1);
            button18.Margin = new Padding(2, 2, 2, 2);
            button18.Name = "button18";
            button18.Size = new Size(90, 27);
            button18.TabIndex = 18;
            button18.Tag = "utility";
            button18.Text = "🏠";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.OrangeRed;
            button19.FlatStyle = FlatStyle.Flat;
            button19.ForeColor = Color.White;
            button19.Location = new Point(291, 355);
            button19.Margin = new Padding(2, 2, 2, 2);
            button19.Name = "button19";
            button19.Size = new Size(80, 48);
            button19.TabIndex = 11;
            button19.Tag = "utility";
            button19.Text = "⌫";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.OrangeRed;
            button20.FlatStyle = FlatStyle.Flat;
            button20.ForeColor = Color.White;
            button20.Location = new Point(376, 279);
            button20.Margin = new Padding(2, 2, 2, 2);
            button20.Name = "button20";
            button20.Size = new Size(80, 48);
            button20.TabIndex = 20;
            button20.Tag = "convert";
            button20.Text = "🔄";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            //txtDisplay.BackColor = Color.FromArgb(30, 30, 45);
            //txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(-5, 1);
            txtDisplay.Margin = new Padding(2, 2, 2, 2);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(609, 94);
            txtDisplay.TabIndex = 17;
            // 
            // richTextBoxHistory
            // 
            richTextBoxHistory.Location = new Point(461, 98);
            richTextBoxHistory.Margin = new Padding(2, 2, 2, 2);
            richTextBoxHistory.Name = "richTextBoxHistory";
            richTextBoxHistory.Size = new Size(143, 334);
            richTextBoxHistory.TabIndex = 19;
            richTextBoxHistory.Text = "";
            // 
            // Basic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 45);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(606, 437);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "Basic";
            Text = "Basic";
            Load += Basic_Load;
            this.Controls.Add(this.textBoxHistory);

            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBoxHistory;


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
}*/



//////
///

/*
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CalcMaster
{
    partial class Basic
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Initialize controls
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
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            txtDisplay = new TextBox();
            textBoxHistory = new TextBox();
            richTextBoxHistory = new RichTextBox();

            SuspendLayout();

            // textBoxHistory
            textBoxHistory.Multiline = true;
            textBoxHistory.ScrollBars = ScrollBars.Vertical;
            textBoxHistory.ReadOnly = true;
            textBoxHistory.Font = new Font("Segoe UI", 10F);
            textBoxHistory.Location = new Point(20, 300);
            textBoxHistory.Size = new Size(260, 150);
            textBoxHistory.Name = "textBoxHistory";
            textBoxHistory.TabIndex = 99;

            // richTextBoxHistory
            richTextBoxHistory.Location = new Point(461, 98);
            richTextBoxHistory.Margin = new Padding(2);
            richTextBoxHistory.Name = "richTextBoxHistory";
            richTextBoxHistory.Size = new Size(143, 334);
            richTextBoxHistory.TabIndex = 19;
            richTextBoxHistory.Text = "";

            // txtDisplay
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.Location = new Point(-5, 1);
            txtDisplay.Margin = new Padding(2);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(609, 94);
            txtDisplay.TabIndex = 17;

            // Example for button1 (others follow same pattern)
            button1.Location = new Point(31, 106);
            button1.Size = new Size(60, 44);
            button1.Name = "button1";
            button1.Text = "9";
            button1.Tag = "digit";
            button1.Click += DigitButton_Click;

            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(120, 106);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(60, 44);
            button2.TabIndex = 1;
            button2.Tag = "digit";
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DigitButton_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(210, 106);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(60, 44);
            button3.TabIndex = 2;
            button3.Tag = "digit";
            button3.Text = "7";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DigitButton_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(31, 195);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(60, 44);
            button4.TabIndex = 3;
            button4.Tag = "digit";
            button4.Text = "6";
            button4.UseVisualStyleBackColor = true;
            button4.Click += DigitButton_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.Location = new Point(120, 195);
            button5.Margin = new Padding(2, 2, 2, 2);
            button5.Name = "button5";
            button5.Size = new Size(60, 44);
            button5.TabIndex = 4;
            button5.Tag = "digit";
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += DigitButton_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.Location = new Point(210, 195);
            button6.Margin = new Padding(2, 2, 2, 2);
            button6.Name = "button6";
            button6.Size = new Size(60, 44);
            button6.TabIndex = 5;
            button6.Tag = "digit";
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += DigitButton_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button7.Location = new Point(31, 283);
            button7.Margin = new Padding(2, 2, 2, 2);
            button7.Name = "button7";
            button7.Size = new Size(60, 44);
            button7.TabIndex = 6;
            button7.Tag = "digit";
            button7.Text = "3";
            button7.UseVisualStyleBackColor = true;
            button7.Click += DigitButton_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button8.Location = new Point(120, 283);
            button8.Margin = new Padding(2, 2, 2, 2);
            button8.Name = "button8";
            button8.Size = new Size(60, 44);
            button8.TabIndex = 7;
            button8.Tag = "digit";
            button8.Text = "2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += DigitButton_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button9.Location = new Point(210, 283);
            button9.Margin = new Padding(2, 2, 2, 2);
            button9.Name = "button9";
            button9.Size = new Size(60, 44);
            button9.TabIndex = 8;
            button9.Tag = "digit";
            button9.Text = "1";
            button9.UseVisualStyleBackColor = true;
            button9.Click += DigitButton_Click;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button10.Font = new Font("Segoe UI", 20F);
            button10.Location = new Point(31, 359);
            button10.Margin = new Padding(2, 2, 2, 2);
            button10.Name = "button10";
            button10.Size = new Size(60, 44);
            button10.TabIndex = 9;
            button10.Tag = "utility";
            button10.Text = "•";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = true;
            button10.Click += DigitButton_Click;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button11.Location = new Point(120, 359);
            button11.Margin = new Padding(2, 2, 2, 2);
            button11.Name = "button11";
            button11.Size = new Size(60, 44);
            button11.TabIndex = 10;
            button11.Tag = "digit";
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
            button12.Location = new Point(376, 355);
            button12.Margin = new Padding(2, 2, 2, 2);
            button12.Name = "button12";
            button12.Size = new Size(80, 48);
            button12.TabIndex = 11;
            button12.Tag = "equal";
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
            button13.Location = new Point(291, 279);
            button13.Margin = new Padding(2, 2, 2, 2);
            button13.Name = "button13";
            button13.Size = new Size(80, 48);
            button13.TabIndex = 12;
            button13.Tag = "utility";
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
            button14.Location = new Point(376, 199);
            button14.Margin = new Padding(2, 2, 2, 2);
            button14.Name = "button14";
            button14.Size = new Size(80, 48);
            button14.TabIndex = 13;
            button14.Tag = "operator";
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
            button15.Location = new Point(291, 199);
            button15.Margin = new Padding(2, 2, 2, 2);
            button15.Name = "button15";
            button15.Size = new Size(80, 48);
            button15.TabIndex = 14;
            button15.Tag = "operator";
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
            button16.Location = new Point(376, 127);
            button16.Margin = new Padding(2, 2, 2, 2);
            button16.Name = "button16";
            button16.Size = new Size(80, 48);
            button16.TabIndex = 15;
            button16.Tag = "operator";
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
            button17.Location = new Point(291, 126);
            button17.Margin = new Padding(2, 2, 2, 2);
            button17.Name = "button17";
            button17.Size = new Size(80, 48);
            button17.TabIndex = 16;
            button17.Tag = "operator";
            button17.Text = "*";
            button17.UseVisualStyleBackColor = false;
            button17.Click += OperatorButton_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.OrangeRed;
            button18.FlatStyle = FlatStyle.Flat;
            button18.ForeColor = Color.White;
            button18.Location = new Point(514, 1);
            button18.Margin = new Padding(2, 2, 2, 2);
            button18.Name = "button18";
            button18.Size = new Size(90, 27);
            button18.TabIndex = 18;
            button18.Tag = "utility";
            button18.Text = "🏠";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.OrangeRed;
            button19.FlatStyle = FlatStyle.Flat;
            button19.ForeColor = Color.White;
            button19.Location = new Point(291, 355);
            button19.Margin = new Padding(2, 2, 2, 2);
            button19.Name = "button19";
            button19.Size = new Size(80, 48);
            button19.TabIndex = 11;
            button19.Tag = "utility";
            button19.Text = "⌫";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.OrangeRed;
            button20.FlatStyle = FlatStyle.Flat;
            button20.ForeColor = Color.White;
            button20.Location = new Point(376, 279);
            button20.Margin = new Padding(2, 2, 2, 2);
            button20.Name = "button20";
            button20.Size = new Size(80, 48);
            button20.TabIndex = 20;
            button20.Tag = "convert";
            button20.Text = "🔄";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;

            // Basic form setup
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 45);
            ClientSize = new Size(606, 437);
            Name = "Basic";
            Text = "Basic";
            Load += Basic_Load;

            // Add controls to form
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(txtDisplay);
            Controls.Add(textBoxHistory);
            Controls.Add(richTextBoxHistory);

            ResumeLayout(false);
            PerformLayout();
        }

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
        private Button button18;
        private Button button19;
        private Button button20;
        private TextBox txtDisplay;
        private TextBox textBoxHistory;
        private RichTextBox richTextBoxHistory;
    }
}*/

using System.Drawing.Drawing2D;

namespace CalcMaster
{
    partial class Basic
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
            components = new System.ComponentModel.Container();
            txtDisplay = new TextBox();
            richTextBoxHistory = new RichTextBox();
            tableLayoutPanel = new TableLayoutPanel();

            SuspendLayout();

            // txtDisplay
            txtDisplay.Location = new Point(20, 15);
            txtDisplay.Size = new Size(400, 40);
            txtDisplay.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            txtDisplay.BackColor = Color.FromArgb(40, 40, 60);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.BorderStyle = BorderStyle.FixedSingle;
            txtDisplay.TextAlign = HorizontalAlignment.Right;

            // richTextBoxHistory
            richTextBoxHistory.Location = new Point(440, 15);
            richTextBoxHistory.Size = new Size(230, 360);
            richTextBoxHistory.Font = new Font("Segoe UI", 10);
            richTextBoxHistory.ReadOnly = true;
            richTextBoxHistory.BackColor = Color.FromArgb(24, 24, 36);
            richTextBoxHistory.ForeColor = Color.White;
            richTextBoxHistory.BorderStyle = BorderStyle.FixedSingle;

            var clearHistoryBtn = new Button();
            clearHistoryBtn.Text = "🧹 Clear History";
            clearHistoryBtn.Dock = DockStyle.Fill;
            clearHistoryBtn.Height = 50;
            clearHistoryBtn.FlatStyle = FlatStyle.Flat;
            clearHistoryBtn.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            clearHistoryBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            clearHistoryBtn.BackColor = Color.FromArgb(50, 60, 100);
            clearHistoryBtn.ForeColor = Color.White;
            clearHistoryBtn.Click += ClearHistoryDatabase_Click;

            // Add a new row for it
            tableLayoutPanel.RowCount += 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel.Controls.Add(clearHistoryBtn);
            tableLayoutPanel.SetColumnSpan(clearHistoryBtn, 4);  // Span all columns



            // tableLayoutPanel
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.Location = new Point(20, 70);
            tableLayoutPanel.Size = new Size(400, 300);
            tableLayoutPanel.BackColor = Color.FromArgb(24, 24, 36);
            tableLayoutPanel.Padding = new Padding(5);
            tableLayoutPanel.ColumnStyles.Clear();
            tableLayoutPanel.RowStyles.Clear();

            for (int i = 0; i < 4; i++)
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            for (int i = 0; i < 5; i++)
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));

            string[,] buttons =
            {
                { "9", "8", "7", "*" },
                { "6", "5", "4", "/" },
                { "3", "2", "1", "-" },
                { ".", "0", "=", "+" },
                { "🗑️", "⌫", "🔄", "🏠" }
            };

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    var btn = new Button();
                    btn.Text = buttons[row, col];
                    btn.Dock = DockStyle.Fill;
                    btn.Margin = new Padding(4);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.DeepSkyBlue;
                    btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                    btn.BackColor = Color.FromArgb(60, 70, 100);
                    btn.ForeColor = Color.White;

                    if (btn.Text == "=")
                        btn.Click += EqualButton_Click;
                    else if (btn.Text == "+" || btn.Text == "-" || btn.Text == "*" || btn.Text == "/")
                        btn.Click += OperatorButton_Click;

                    else if (btn.Text == "🗑️")
                        btn.Click += ClearButton_Click;
                    else if (btn.Text == "🔄")
                        btn.Click += button20_Click;
                    else if (btn.Text == "🏠")
                        btn.Click += button18_Click;
                    else if (btn.Text == "⌫")
                        btn.Click += button19_Click;
                    else if (btn.Text == "=")
                        btn.Click += EqualButton_Click;
                    else
                        btn.Click += DigitButton_Click;

                    tableLayoutPanel.Controls.Add(btn, col, row);
                }
            }

            // Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 28);
            ClientSize = new Size(700, 400);
            Controls.Add(txtDisplay);
            Controls.Add(richTextBoxHistory);
            Controls.Add(tableLayoutPanel);
            Name = "Basic";
            Text = "Basic";
            Load += Basic_Load;
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private TextBox txtDisplay;
        private RichTextBox richTextBoxHistory;
        private TableLayoutPanel tableLayoutPanel;
    }
}