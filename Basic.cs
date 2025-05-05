//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace CalcMaster
//{
//    public partial class Basic : Form
//    {
//        string input = "";
//        string operand1 = "";
//        string operand2 = "";
//        char operation;
//        bool isResultShown = false;

//        public Basic()
//        {
//            InitializeComponent();
//        }

//        private void Basic_Load(object sender, EventArgs e)
//        {
//            // You can leave this empty or add startup code here
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {

//        }

//        private void DigitButton_Click(object sender, EventArgs e)
//        {
//            Button btn = (Button)sender;

//            // Only clear if a result was just shown (like after "=")
//            if (isResultShown)
//            {
//                txtDisplay.Text = "";
//                input = "";
//                operand1 = "";
//                operand2 = "";
//                isResultShown = false;
//            }

//            input += btn.Text;
//            txtDisplay.Text += btn.Text;  // ✅ Append to textbox, not replace
//        }


//        private void OperatorButton_Click(object sender, EventArgs e)
//        {
//            Button btn = (Button)sender;
//            if (input != "")
//            {
//                operand1 = input;
//                operation = btn.Text[0];  // '+', '-', '*', '/'
//                input = "";
//               // txtDisplay.Text = operand1 + " " + operation + " ";
//                txtDisplay.Text += " " + operation + " "; // ✅

//            }
//        }

//        private void EqualButton_Click(object sender, EventArgs e)
//        {
//            if (input != "")
//            {
//                operand2 = input;
//                double num1 = double.Parse(operand1);
//                double num2 = double.Parse(operand2);
//                double result = 0;

//                switch (operation)
//                {
//                    case '+': result = num1 + num2; break;
//                    case '-': result = num1 - num2; break;
//                    case '*': result = num1 * num2; break;
//                    case '/': result = num2 != 0 ? num1 / num2 : 0; break;
//                }

//                txtDisplay.Text = result.ToString();
//                input = result.ToString();
//                isResultShown = true;
//            }
//        }

//        private void ClearButton_Click(object sender, EventArgs e)
//        {
//            input = "";
//            operand1 = "";
//            operand2 = "";
//            txtDisplay.Text = "";
//            isResultShown = false;
//        }


//    }
//}
//using System;
//using System.Windows.Forms;

//namespace CalcMaster
//{
//    public partial class Basic : Form
//    {
//        string operand1 = "";
//        string operand2 = "";
//        char operation;
//        bool isResultShown = false;

//        public Basic()
//        {
//            InitializeComponent();
//            txtDisplay.ReadOnly = false;
//            txtDisplay.WordWrap = false;
//        }

//        private void Basic_Load(object sender, EventArgs e)
//        {
//            // You can leave this empty or add startup code here
//        }

//        private void DigitButton_Click(object sender, EventArgs e)
//        {
//            Button btn = (Button)sender;
//            string toInsert = btn.Text;

//            if (isResultShown)
//            {
//                txtDisplay.Text = "";
//                isResultShown = false;
//            }

//            int cursorPos = txtDisplay.SelectionStart;
//            txtDisplay.Text = txtDisplay.Text.Insert(cursorPos, toInsert);
//            txtDisplay.SelectionStart = cursorPos + toInsert.Length;
//        }

//        private void OperatorButton_Click(object sender, EventArgs e)
//        {
//            Button btn = (Button)sender;
//            string toInsert = " " + btn.Text + " ";

//            if (isResultShown)
//            {
//                txtDisplay.Text = "";
//                isResultShown = false;
//            }

//            int cursorPos = txtDisplay.SelectionStart;
//            txtDisplay.Text = txtDisplay.Text.Insert(cursorPos, toInsert);
//            txtDisplay.SelectionStart = cursorPos + toInsert.Length;
//        }

//        private void EqualButton_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                string expression = txtDisplay.Text.Replace(" ", ""); // clean spaces
//                double result = EvaluateSimpleExpression(expression);
//                txtDisplay.Text = result.ToString();
//                isResultShown = true;
//            }
//            catch (Exception ex)
//            {
//                txtDisplay.Text = "Error";
//                isResultShown = true;
//            }
//        }

//        private double EvaluateSimpleExpression(string expr)
//        {
//            // This supports only 1 operator: e.g., 4+5, 9*3
//            char[] ops = { '+', '-', '*', '/' };
//            foreach (char op in ops)
//            {
//                int index = expr.IndexOf(op);
//                if (index > 0)
//                {
//                    operand1 = expr.Substring(0, index);
//                    operand2 = expr.Substring(index + 1);
//                    double num1 = double.Parse(operand1);
//                    double num2 = double.Parse(operand2);

//                    switch (op)
//                    {
//                        case '+': return num1 + num2;
//                        case '-': return num1 - num2;
//                        case '*': return num1 * num2;
//                        case '/': return num2 != 0 ? num1 / num2 : 0;
//                    }
//                }
//            }
//            throw new Exception("Invalid expression");
//        }

//        private void ClearButton_Click(object sender, EventArgs e)
//        {
//            txtDisplay.Text = "";
//            operand1 = "";
//            operand2 = "";
//            isResultShown = false;
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {

//        }

//    }
//}

using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace CalcMaster
{
    public partial class Basic : Form
    {
        bool isResultShown = false;

        public Basic()
        {
            InitializeComponent();
            txtDisplay.ReadOnly = false;
            txtDisplay.WordWrap = false;
            txtDisplay.Multiline = true;
            ThemeManager.ApplyTheme(this);
        }

        private void Basic_Load(object sender, EventArgs e)
        {
            ThemeManager.LoadTheme();                // Load saved theme
            ThemeManager.ApplyTheme(this);           // Apply to full form
            LoadCalculationHistory(); // Show last calculations when form opens
        
        }

        private void LoadCalculationHistory()
        {
            List<CalculationEntry> history = HistoryDatabase.GetRecentHistory(10);

            richTextBoxHistory.Clear();

            foreach (var entry in history)
            {
                richTextBoxHistory.AppendText($"{entry.Timestamp.ToShortTimeString()} - {entry.Expression} = {entry.Result}\n");
            }
        }

        //private void DigitButton_Click(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    string toInsert = btn.Text;

        //    if (isResultShown)
        //    {
        //        txtDisplay.Text = "";
        //        isResultShown = false;
        //    }

        //    int cursorPos = txtDisplay.SelectionStart;
        //    txtDisplay.Text = txtDisplay.Text.Insert(cursorPos, toInsert);
        //    txtDisplay.SelectionStart = cursorPos + toInsert.Length;
        //}
        //private void DigitButton_Click(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    string toInsert = btn.Text;

        //    if (toInsert == ".")
        //    {
        //        // Prevent multiple decimals in the current number
        //        int lastOp = txtDisplay.Text.LastIndexOfAny(new char[] { '+', '-', '*', '/' });
        //        string lastNumber = lastOp == -1 ? txtDisplay.Text : txtDisplay.Text.Substring(lastOp + 1);

        //        if (lastNumber.Contains(".")) return;
        //        if (string.IsNullOrEmpty(lastNumber)) toInsert = "0.";
        //    }

        //    if (isResultShown)
        //    {
        //        txtDisplay.Text = "";
        //        isResultShown = false;
        //    }

        //    int cursorPos = txtDisplay.SelectionStart;
        //    txtDisplay.Text = txtDisplay.Text.Insert(cursorPos, toInsert);
        //    txtDisplay.SelectionStart = cursorPos + toInsert.Length;
        //}
        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string toInsert;

            // ✅ Always force correct ASCII period for decimal
            if (btn.Text == "." || btn.Text == "•" || btn.Name.ToLower().Contains("decimal"))
            {
                // Prevent multiple decimals in the current number
                int lastOp = txtDisplay.Text.LastIndexOfAny(new char[] { '+', '-', '*', '/' });
                string lastNumber = lastOp == -1 ? txtDisplay.Text : txtDisplay.Text.Substring(lastOp + 1);

                if (lastNumber.Contains(".")) return;

                toInsert = string.IsNullOrEmpty(lastNumber) ? "0." : ".";
            }
            else
            {
                toInsert = btn.Text;
            }

            if (isResultShown)
            {
                txtDisplay.Text = "";
                isResultShown = false;
            }

            int cursorPos = txtDisplay.SelectionStart;
            txtDisplay.Text = txtDisplay.Text.Insert(cursorPos, toInsert);
            txtDisplay.SelectionStart = cursorPos + toInsert.Length;
        }




        //private void OperatorButton_Click(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    string toInsert = " " + btn.Text + " ";

        //    if (isResultShown)
        //    {
        //        txtDisplay.Text = "";
        //        isResultShown = false;
        //    }

        //    int cursorPos = txtDisplay.SelectionStart;
        //    txtDisplay.Text = txtDisplay.Text.Insert(cursorPos, toInsert);
        //    txtDisplay.SelectionStart = cursorPos + toInsert.Length;
        //}
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Normalize symbols
            string symbol = btn.Text switch
            {
                "×" => "*",
                "÷" => "/",
                _ => btn.Text
            };

            string toInsert = " " + symbol + " ";

            if (isResultShown)
            {
                txtDisplay.Text = "";
                isResultShown = false;
            }

            int cursorPos = txtDisplay.SelectionStart;
            txtDisplay.Text = txtDisplay.Text.Insert(cursorPos, toInsert);
            txtDisplay.SelectionStart = cursorPos + toInsert.Length;
        }


        //private void EqualButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string expression = txtDisplay.Text.Replace(" ", "");
        //        double result = EvaluateExpression(expression);
        //        txtDisplay.Text = result.ToString();
        //        isResultShown = true;
        //    }
        //    catch
        //    {
        //        txtDisplay.Text = "Error";
        //        isResultShown = true;
        //    }
        //}
        private void EqualButton_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = txtDisplay.Text.Replace(" ", "");
                double result = EvaluateExpression(expression);
                txtDisplay.Text = result.ToString();

                HistoryDatabase.SaveCalculation(expression, result.ToString());

                // ✅ Do NOT append here manually; the history will load from DB
                LoadCalculationHistory(); // refresh right-side history
                isResultShown = true;
            }
            catch
            {
                txtDisplay.Text = "Error";
                isResultShown = true;
            }
        }



        //private double EvaluateExpression(string expression)
        //{
        //    var table = new DataTable();
        //    object result = table.Compute(expression, "");
        //    return Convert.ToDouble(result);
        //}

        private double EvaluateExpression(string expression)
        {
            var table = new DataTable();

            // ✅ Force evaluation using invariant culture (dot as decimal)
            table.Locale = CultureInfo.InvariantCulture;

            object result = table.Compute(expression, "");
            List<CalculationEntry> history = HistoryDatabase.GetRecentHistory();

            return Convert.ToDouble(result, CultureInfo.InvariantCulture); // ✅ ensure correct conversion
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            isResultShown = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.ShowDialog();
            this.Close();
        }

        private void button20_Click(object sender, EventArgs e) //clear history button
        {
            richTextBoxHistory.Clear();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            richTextBoxHistory.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Don't do anything if textbox is empty or result is being shown
            if (string.IsNullOrEmpty(txtDisplay.Text) || isResultShown)
                return;

            int cursorPos = txtDisplay.SelectionStart;

            // If something is selected, delete the selection
            if (txtDisplay.SelectionLength > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(cursorPos, txtDisplay.SelectionLength);
            }
            else if (cursorPos > 0)
            {
                // Remove character before the cursor
                txtDisplay.Text = txtDisplay.Text.Remove(cursorPos - 1, 1);
                txtDisplay.SelectionStart = cursorPos - 1;
            }
        }

        private void ClearDatabase_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to clear all history?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                HistoryDatabase.ClearAllHistory(); // You will create this method
                richTextBoxHistory.Clear();
                MessageBox.Show("All history has been cleared from the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void ClearHistoryDatabase_Click(object sender, EventArgs e)
        {
            HistoryDatabase.ClearAllHistory();
            LoadCalculationHistory(); // Refresh UI
        }


    }
}


