namespace CalcMaster
{
    partial class UC
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
            comboBoxFromUnit = new ComboBox();
            comboBoxToUnit = new ComboBox();
            textBoxInput = new TextBox();
            textBoxOutput = new TextBox();
            comboBoxConversionType = new ComboBox();
            button1 = new Button();
            buttonConvert = new Button();
            buttonClear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBoxFromUnit
            // 
            comboBoxFromUnit.FormattingEnabled = true;
            comboBoxFromUnit.Location = new Point(27, 212);
            comboBoxFromUnit.Name = "comboBoxFromUnit";
            comboBoxFromUnit.Size = new Size(182, 33);
            comboBoxFromUnit.TabIndex = 0;
            // 
            // comboBoxToUnit
            // 
            comboBoxToUnit.FormattingEnabled = true;
            comboBoxToUnit.Location = new Point(559, 212);
            comboBoxToUnit.Name = "comboBoxToUnit";
            comboBoxToUnit.Size = new Size(182, 33);
            comboBoxToUnit.TabIndex = 1;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(46, 175);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(150, 31);
            textBoxInput.TabIndex = 2;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(578, 175);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(150, 31);
            textBoxOutput.TabIndex = 3;
            // 
            // comboBoxConversionType
            // 
            comboBoxConversionType.FormattingEnabled = true;
            comboBoxConversionType.Location = new Point(178, 37);
            comboBoxConversionType.Name = "comboBoxConversionType";
            comboBoxConversionType.Size = new Size(182, 33);
            comboBoxConversionType.TabIndex = 4;
            comboBoxConversionType.SelectedIndexChanged += comboBoxConversionType_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(676, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "🏠";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonConvert
            // 
            buttonConvert.BackColor = SystemColors.Highlight;
            buttonConvert.FlatStyle = FlatStyle.Flat;
            buttonConvert.ForeColor = Color.White;
            buttonConvert.Location = new Point(46, 309);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(112, 34);
            buttonConvert.TabIndex = 6;
            buttonConvert.Text = "Convert";
            buttonConvert.UseVisualStyleBackColor = false;
            buttonConvert.Click += buttonConvert_Click_1;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.OrangeRed;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(46, 367);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(112, 34);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "🗑️";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 8;
            label1.Text = "Choose a quantity:";
            // 
            // UC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 45);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonClear);
            Controls.Add(buttonConvert);
            Controls.Add(button1);
            Controls.Add(comboBoxConversionType);
            Controls.Add(textBoxOutput);
            Controls.Add(textBoxInput);
            Controls.Add(comboBoxToUnit);
            Controls.Add(comboBoxFromUnit);
            Name = "UC";
            Text = "Form1";
            Load += UC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFromUnit;
        private ComboBox comboBoxToUnit;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
        private ComboBox comboBoxConversionType;
        private Button button1;
        private Button buttonConvert;
        private Button buttonClear;
        private Label label1;
    }
}