//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//using System;
//using System.Data;
//using System.Windows.Forms;

//namespace CalcMaster
//{
//    public partial class scientific : Form
//    {
//        // A string to hold the current input expression
//        private string currentInput = "";

//        public scientific()
//        {
//            InitializeComponent();
//        }

//        private void AddToInput(string number)
//        {
//            currentInput += number;
//            textBox1.Text = currentInput;
//        }

//        // Handle scientific functions (sin, cos, tan, etc.)
//        private void Sin_Click(object sender, EventArgs e) => AddScientificFunction("sin");
//        private void Cos_Click(object sender, EventArgs e) => AddScientificFunction("cos");
//        private void Tan_Click(object sender, EventArgs e) => AddScientificFunction("tan");
//        private void log_Click(object sender, EventArgs e) => AddScientificFunction("log");
//        private void ln_Click(object sender, EventArgs e) => AddScientificFunction("ln");
//        private void squareroot_Click(object sender, EventArgs e) => AddScientificFunction("√");
//        private void cuberoot_Click(object sender, EventArgs e) => AddScientificFunction("∛");
//        private void pie_Click(object sender, EventArgs e) => AddToInput("π");

//        // Helper function to append scientific functions with parentheses
//        private void AddScientificFunction(string function)
//        {
//            currentInput += function + "("; // Add function name and an open parenthesis
//            textBox1.Text = currentInput;
//        }

//        // Handle the 'equals' button click (evaluate the expression)
//        private void equal_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                var result = EvaluateExpression(currentInput);
//                textBox1.Text = result.ToString();
//                currentInput = result.ToString();  // Store the result as the new input
//            }
//            catch (Exception)
//            {
//                textBox1.Text = "Error";  // Display error if the expression is invalid
//                currentInput = "";
//            }
//        }
//        private double EvaluateExpression(string expression)
//        {
//            try
//            {
//                // Replace constants first
//                expression = expression.Replace("π", Math.PI.ToString())
//                                      .Replace("e", Math.E.ToString());

//                // First handle all root operations (they have special symbols)
//                expression = HandleSpecialSymbols(expression);

//                // Then handle regular functions and parentheses
//                while (expression.Contains("("))
//                {
//                    int open = expression.LastIndexOf('(');
//                    int close = expression.IndexOf(')', open);

//                    if (close == -1) throw new Exception("Mismatched parentheses");

//                    string inner = expression.Substring(open + 1, close - open - 1);
//                    double innerValue = EvaluateSimpleExpression(inner);

//                    // Check if this is a function call
//                    if (open > 0 && (char.IsLetter(expression[open - 1]) || expression[open - 1] == '√' || expression[open - 1] == '∛'))
//                    {
//                        int funcStart = FindFunctionStart(expression, open);
//                        string funcName = expression.Substring(funcStart, open - funcStart).Trim();

//                        innerValue = ApplyFunction(funcName, innerValue);
//                        expression = expression.Substring(0, funcStart) + innerValue.ToString() + expression.Substring(close + 1);
//                    }
//                    else
//                    {
//                        expression = expression.Substring(0, open) + innerValue.ToString() + expression.Substring(close + 1);
//                    }
//                }

//                // Evaluate the remaining simple expression
//                return EvaluateSimpleExpression(expression);
//            }
//            catch
//            {
//                throw new Exception("Invalid Expression");
//            }
//        }

//        private string HandleSpecialSymbols(string expression)
//        {
//            // Handle square roots (√)
//            while (expression.Contains("√"))
//            {
//                int sqrtPos = expression.IndexOf("√");
//                if (sqrtPos + 1 >= expression.Length) throw new Exception("Incomplete square root expression");

//                // Find the argument (could be in parentheses or a single number)
//                string remaining = expression.Substring(sqrtPos + 1);
//                string argument = GetArgument(remaining);

//                double argValue = EvaluateSimpleExpression(argument);
//                double result = Math.Sqrt(argValue);

//                expression = expression.Substring(0, sqrtPos) + result.ToString() + expression.Substring(sqrtPos + 1 + argument.Length);
//            }

//            // Handle cube roots (∛)
//            while (expression.Contains("∛"))
//            {
//                int cbrtPos = expression.IndexOf("∛");
//                if (cbrtPos + 1 >= expression.Length) throw new Exception("Incomplete cube root expression");

//                // Find the argument (could be in parentheses or a single number)
//                string remaining = expression.Substring(cbrtPos + 1);
//                string argument = GetArgument(remaining);

//                double argValue = EvaluateSimpleExpression(argument);
//                double result = Math.Pow(argValue, 1.0 / 3.0);

//                expression = expression.Substring(0, cbrtPos) + result.ToString() + expression.Substring(cbrtPos + 1 + argument.Length);
//            }

//            return expression;
//        }

//        private string GetArgument(string expression)
//        {
//            if (expression.StartsWith("("))
//            {
//                // Find matching closing parenthesis
//                int depth = 1;
//                for (int i = 1; i < expression.Length; i++)
//                {
//                    if (expression[i] == '(') depth++;
//                    else if (expression[i] == ')') depth--;

//                    if (depth == 0) return expression.Substring(0, i + 1);
//                }
//                throw new Exception("Unmatched parentheses in argument");
//            }
//            else
//            {
//                // Find the end of the number/expression
//                int end = 0;
//                while (end < expression.Length && (char.IsDigit(expression[end]) || expression[end] == '.' || expression[end] == '+' || expression[end] == '-'))
//                {
//                    end++;
//                }
//                return expression.Substring(0, end);
//            }
//        }



//        private int FindFunctionStart(string expression, int openParenPos)
//        {
//            // Walk backwards to find the start of the function name
//            int start = openParenPos - 1;
//            while (start >= 0 && char.IsLetter(expression[start]))
//            {
//                start--;
//            }
//            return start + 1;
//        }

//        private double EvaluateSimpleExpression(string expression)
//        {
//            if (string.IsNullOrWhiteSpace(expression))
//                return 0;

//            // Use DataTable.Compute for basic arithmetic
//            var dataTable = new DataTable();
//            return Convert.ToDouble(dataTable.Compute(expression, string.Empty));
//        }

//        private double ApplyFunction(string funcName, double value)
//        {
//            switch (funcName.ToLower())
//            {
//                case "sin": return Math.Sin(value * Math.PI / 180); // Convert degrees to radians
//                case "cos": return Math.Cos(value * Math.PI / 180);
//                case "tan": return Math.Tan(value * Math.PI / 180);
//                case "log": return value > 0 ? Math.Log10(value) : throw new Exception("Log of non-positive number");
//                case "ln": return value > 0 ? Math.Log(value) : throw new Exception("Ln of non-positive number");
//                case "√": return value >= 0 ? Math.Sqrt(value) : throw new Exception("Square root of negative number");
//                case "∛": return Math.Pow(value, 1.0 / 3.0); // Cube root works for negative numbers
//                default: throw new Exception($"Unknown function: {funcName}");
//            }
//        }

//        // Handle the 'clear' button click (clear the input)
//        private void clear_Click(object sender, EventArgs e)
//        {
//            currentInput = "";
//            textBox1.Text = currentInput;
//        }

//        // Handle parentheses
//        private void baracOpen_Click(object sender, EventArgs e) => AddToInput("(");
//        private void baracClose_Click(object sender, EventArgs e) => AddToInput(")");

//        // Handle negative numbers (for subtract)
//        private void negative_Click(object sender, EventArgs e)
//        {
//            if (currentInput.StartsWith("-"))
//                currentInput = currentInput.Substring(1);
//            else
//                currentInput = "-" + currentInput;
//            textBox1.Text = currentInput;
//        }

//        // Handle digit buttons (0-9)
//        private void button0_Click(object sender, EventArgs e) => AddToInput("0");
//        private void button1_Click(object sender, EventArgs e) => AddToInput("1");
//        private void button2_Click(object sender, EventArgs e) => AddToInput("2");
//        private void button3_Click(object sender, EventArgs e) => AddToInput("3");
//        private void button4_Click(object sender, EventArgs e) => AddToInput("4");
//        private void button5_Click(object sender, EventArgs e) => AddToInput("5");
//        private void button6_Click(object sender, EventArgs e) => AddToInput("6");
//        private void button7_Click(object sender, EventArgs e) => AddToInput("7");
//        private void button8_Click(object sender, EventArgs e) => AddToInput("8");
//        private void button9_Click(object sender, EventArgs e) => AddToInput("9");

//        // Handle operators (+, -, *, /)
//        private void plus_Click(object sender, EventArgs e) => AddOperator("+");
//        private void minus_Click(object sender, EventArgs e) => AddOperator("-");
//        private void multiply_Click(object sender, EventArgs e) => AddOperator("*");
//        private void divide_Click(object sender, EventArgs e) => AddOperator("/");

//        // Helper function to append operators to the input
//        private void AddOperator(string op)
//        {
//            currentInput += op;
//            textBox1.Text = currentInput;
//        }

//        // Handle the decimal point button click
//        private void dot_Click(object sender, EventArgs e)
//        {
//            if (!currentInput.Contains("."))
//            {
//                currentInput += ".";
//                textBox1.Text = currentInput;
//            }
//        }

//        // Handle the 'Back' button click (close the form or go back)
//        private void back_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void scientific_Load(object sender, EventArgs e)
//        {
//            //currentInput = "";
//            //textBox1.Text = currentInput;
//        }

//        private void button11_Click(object sender, EventArgs e)
//        {

//        }
//        private void backSpace_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrEmpty(currentInput))
//                return;

//            // Special handling for multi-character functions
//            if (currentInput.EndsWith("sin(") || currentInput.EndsWith("cos(") || currentInput.EndsWith("tan(") ||
//                currentInput.EndsWith("log(") || currentInput.EndsWith("ln("))
//            {
//                // Remove the entire function name (4 chars for sin/cos/tan/log, 3 for ln)
//                int removeLength = currentInput.EndsWith("ln(") ? 3 : 4;
//                currentInput = currentInput.Substring(0, currentInput.Length - removeLength);
//            }
//            // Special handling for root symbols
//            else if (currentInput.EndsWith("√") || currentInput.EndsWith("∛"))
//            {
//                currentInput = currentInput.Substring(0, currentInput.Length - 1);
//            }
//            else
//            {
//                // Regular single character removal
//                currentInput = currentInput.Substring(0, currentInput.Length - 1);
//            }

//            textBox1.Text = currentInput;
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using System;
using System.Data;
using System.Windows.Forms;

namespace CalcMaster
{
    public partial class scientific : Form
    {
        // A string to hold the current input expression
        private string currentInput = "";

        public scientific()
        {
            InitializeComponent();
            textBox1.KeyDown += TextBox1_KeyDown;  // Add keyboard handler
            this.KeyPreview = true;  // Allow form to see key presses first
            textBox1.ShortcutsEnabled = false;  // Disable default shortcuts
            textBox1.ReadOnly = false;          // Allow direct typing
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Update currentInput when user types directly
            currentInput = textBox1.Text;
        }

        private void AddToInput(string text)
        {
            int cursorPos = textBox1.SelectionStart;
            currentInput = currentInput.Insert(cursorPos, text);
            textBox1.Text = currentInput;
            textBox1.SelectionStart = cursorPos + text.Length;
        }

        private void AddOperator(string op)
        {
            int cursorPos = textBox1.SelectionStart;
            currentInput = currentInput.Insert(cursorPos, op);
            textBox1.Text = currentInput;
            textBox1.SelectionStart = cursorPos + op.Length;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle number keys
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                AddToInput(e.KeyCode.ToString().Substring(1));
                e.Handled = true;
            }
            // Handle numpad numbers
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                AddToInput(e.KeyCode.ToString().Substring(6));
                e.Handled = true;
            }
            // Handle operators and functions
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Add:
                        AddOperator("+");
                        e.Handled = true;
                        break;
                    case Keys.Subtract:
                        AddOperator("-");
                        e.Handled = true;
                        break;
                    case Keys.Multiply:
                        AddOperator("*");
                        e.Handled = true;
                        break;
                    case Keys.Divide:
                        AddOperator("/");
                        e.Handled = true;
                        break;
                    case Keys.Decimal:
                        dot_Click(sender, e);
                        e.Handled = true;
                        break;
                    case Keys.Enter:
                        equal_Click(sender, e);
                        e.Handled = true;
                        break;
                    case Keys.Back:
                        backSpace_Click(sender, e);
                        e.Handled = true;
                        break;
                    case Keys.Escape:
                        clear_Click(sender, e);
                        e.Handled = true;
                        break;
                    case Keys.P:
                        if (e.Control)  // Ctrl+P for π
                        {
                            pie_Click(sender, e);
                            e.Handled = true;
                        }
                        break;
                    case Keys.S:
                        if (e.Control)  // Ctrl+S for sin
                        {
                            Sin_Click(sender, e);
                            e.Handled = true;
                        }
                        break;
                    case Keys.C:
                        if (e.Control)  // Ctrl+C for cos
                        {
                            Cos_Click(sender, e);
                            e.Handled = true;
                        }
                        break;
                    case Keys.T:
                        if (e.Control)  // Ctrl+T for tan
                        {
                            Tan_Click(sender, e);
                            e.Handled = true;
                        }
                        break;
                    case Keys.L:
                        if (e.Control)  // Ctrl+L for log
                        {
                            log_Click(sender, e);
                            e.Handled = true;
                        }
                        break;
                    case Keys.N:
                        if (e.Control)  // Ctrl+N for ln
                        {
                            ln_Click(sender, e);
                            e.Handled = true;
                        }
                        break;
                    case Keys.OemOpenBrackets:
                        if (e.Shift)  // Shift+[ for √
                        {
                            squareroot_Click(sender, e);
                            e.Handled = true;
                        }
                        break;
                    case Keys.OemCloseBrackets:
                        if (e.Shift)  // Shift+] for ∛
                        {
                            cuberoot_Click(sender, e);
                            e.Handled = true;
                        }
                        break;
                }
            }
        }

        // Handle scientific functions (sin, cos, tan, etc.)
        private void Sin_Click(object sender, EventArgs e) => AddScientificFunction("sin");
        private void Cos_Click(object sender, EventArgs e) => AddScientificFunction("cos");
        private void Tan_Click(object sender, EventArgs e) => AddScientificFunction("tan");
        private void log_Click(object sender, EventArgs e) => AddScientificFunction("log");
        private void ln_Click(object sender, EventArgs e) => AddScientificFunction("ln");
        private void squareroot_Click(object sender, EventArgs e) => AddScientificFunction("√");
        private void cuberoot_Click(object sender, EventArgs e) => AddScientificFunction("∛");
        private void pie_Click(object sender, EventArgs e) => AddToInput("π");

        // Helper function to append scientific functions with parentheses
        //private void AddScientificFunction(string function)
        //{
        //    currentInput += function + "("; // Add function name and an open parenthesis
        //    textBox1.Text = currentInput;
        //}
        private void AddScientificFunction(string function)
        {
            int cursorPos = textBox1.SelectionStart;
            currentInput = currentInput.Insert(cursorPos, function + "()");
            textBox1.Text = currentInput;
            textBox1.SelectionStart = cursorPos + function.Length + 1; // Position cursor between parentheses
        }

        // Handle the 'equals' button click (evaluate the expression)
        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                var result = EvaluateExpression(currentInput);
                textBox1.Text = result.ToString();
                currentInput = result.ToString();  // Store the result as the new input
            }
            catch (Exception)
            {
                textBox1.Text = "Error";  // Display error if the expression is invalid
                currentInput = "";
            }
        }
        private double EvaluateExpression(string expression)
        {
            try
            {
                // Replace constants first
                expression = expression.Replace("π", Math.PI.ToString())
                                      .Replace("e", Math.E.ToString());

                // First handle all root operations (they have special symbols)
                expression = HandleSpecialSymbols(expression);

                // Then handle regular functions and parentheses
                while (expression.Contains("("))
                {
                    int open = expression.LastIndexOf('(');
                    int close = expression.IndexOf(')', open);

                    if (close == -1) throw new Exception("Mismatched parentheses");

                    string inner = expression.Substring(open + 1, close - open - 1);
                    double innerValue = EvaluateSimpleExpression(inner);

                    // Check if this is a function call
                    if (open > 0 && (char.IsLetter(expression[open - 1]) || expression[open - 1] == '√' || expression[open - 1] == '∛'))
                    {
                        int funcStart = FindFunctionStart(expression, open);
                        string funcName = expression.Substring(funcStart, open - funcStart).Trim();

                        innerValue = ApplyFunction(funcName, innerValue);
                        expression = expression.Substring(0, funcStart) + innerValue.ToString() + expression.Substring(close + 1);
                    }
                    else
                    {
                        expression = expression.Substring(0, open) + innerValue.ToString() + expression.Substring(close + 1);
                    }
                }

                // Evaluate the remaining simple expression
                return EvaluateSimpleExpression(expression);
            }
            catch
            {
                throw new Exception("Invalid Expression");
            }
        }

        private string GetLeftOperand(string expression, int operatorPos)
        {
            int start = operatorPos - 1;
            while (start >= 0 &&
                  (char.IsDigit(expression[start]) || expression[start] == '.' ||
                   expression[start] == ')' || expression[start] == '('))
            {
                start--;
            }
            return expression.Substring(start + 1, operatorPos - start - 1);
        }

        private string GetRightOperand(string expression, int operatorPos)
        {
            int end = operatorPos + 1;
            while (end < expression.Length &&
                  (char.IsDigit(expression[end]) || expression[end] == '.' ||
                   expression[end] == '(' || expression[end] == ')'))
            {
                end++;
            }
            return expression.Substring(operatorPos + 1, end - operatorPos - 1);
        }
        private string HandleSpecialSymbols(string expression)
        {
            // Handle exponents first (since they have higher precedence)
            while (expression.Contains("^"))
            {
                int expPos = expression.IndexOf("^");
                if (expPos == 0 || expPos == expression.Length - 1)
                    throw new Exception("Incomplete exponent expression");

                // Find the base (left operand)
                string left = GetLeftOperand(expression, expPos);
                // Find the exponent (right operand)
                string right = GetRightOperand(expression, expPos);

                double baseValue = EvaluateSimpleExpression(left);
                double expValue = EvaluateSimpleExpression(right);
                double result = Math.Pow(baseValue, expValue);

                expression = expression.Substring(0, expPos - left.Length) +
                            result.ToString() +
                            expression.Substring(expPos + 1 + right.Length);
            }

            // Handle square roots (√)
            while (expression.Contains("√"))
            {
                int sqrtPos = expression.IndexOf("√");
                if (sqrtPos + 1 >= expression.Length) throw new Exception("Incomplete square root expression");

                // Find the argument (could be in parentheses or a single number)
                string remaining = expression.Substring(sqrtPos + 1);
                string argument = GetArgument(remaining);

                double argValue = EvaluateSimpleExpression(argument);
                double result = Math.Sqrt(argValue);

                expression = expression.Substring(0, sqrtPos) + result.ToString() + expression.Substring(sqrtPos + 1 + argument.Length);
            }

            // Handle cube roots (∛)
            while (expression.Contains("∛"))
            {
                int cbrtPos = expression.IndexOf("∛");
                if (cbrtPos + 1 >= expression.Length) throw new Exception("Incomplete cube root expression");

                // Find the argument (could be in parentheses or a single number)
                string remaining = expression.Substring(cbrtPos + 1);
                string argument = GetArgument(remaining);

                double argValue = EvaluateSimpleExpression(argument);
                double result = Math.Pow(argValue, 1.0 / 3.0);

                expression = expression.Substring(0, cbrtPos) + result.ToString() + expression.Substring(cbrtPos + 1 + argument.Length);
            }

            return expression;
        }

        private string GetArgument(string expression)
        {
            if (expression.StartsWith("("))
            {
                // Find matching closing parenthesis
                int depth = 1;
                for (int i = 1; i < expression.Length; i++)
                {
                    if (expression[i] == '(') depth++;
                    else if (expression[i] == ')') depth--;

                    if (depth == 0) return expression.Substring(0, i + 1);
                }
                throw new Exception("Unmatched parentheses in argument");
            }
            else
            {
                // Find the end of the number/expression
                int end = 0;
                while (end < expression.Length && (char.IsDigit(expression[end]) || expression[end] == '.' || expression[end] == '+' || expression[end] == '-'))
                {
                    end++;
                }
                return expression.Substring(0, end);
            }
        }



        private int FindFunctionStart(string expression, int openParenPos)
        {
            // Walk backwards to find the start of the function name
            int start = openParenPos - 1;
            while (start >= 0 && char.IsLetter(expression[start]))
            {
                start--;
            }
            return start + 1;
        }

        private double EvaluateSimpleExpression(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                return 0;

            // Use DataTable.Compute for basic arithmetic
            var dataTable = new DataTable();
            return Convert.ToDouble(dataTable.Compute(expression, string.Empty));
        }

        private double ApplyFunction(string funcName, double value)
        {
            switch (funcName.ToLower())
            {
                case "sin": return Math.Sin(value * Math.PI / 180); // Convert degrees to radians
                case "cos": return Math.Cos(value * Math.PI / 180);
                case "tan": return Math.Tan(value * Math.PI / 180);
                case "log": return value > 0 ? Math.Log10(value) : throw new Exception("Log of non-positive number");
                case "ln": return value > 0 ? Math.Log(value) : throw new Exception("Ln of non-positive number");
                case "√": return value >= 0 ? Math.Sqrt(value) : throw new Exception("Square root of negative number");
                case "∛": return Math.Pow(value, 1.0 / 3.0); // Cube root works for negative numbers
                default: throw new Exception($"Unknown function: {funcName}");
            }
        }

        // Handle the 'clear' button click (clear the input)
        private void clear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            textBox1.Text = currentInput;
        }

        // Handle parentheses
        private void baracOpen_Click(object sender, EventArgs e) => AddToInput("(");
        private void baracClose_Click(object sender, EventArgs e) => AddToInput(")");

        // Handle negative numbers (for subtract)
        private void negative_Click(object sender, EventArgs e)
        {
            if (currentInput.StartsWith("-"))
                currentInput = currentInput.Substring(1);
            else
                currentInput = "-" + currentInput;
            textBox1.Text = currentInput;
        }

        // Handle digit buttons (0-9)
        private void button0_Click(object sender, EventArgs e) => AddToInput("0");
        private void button1_Click(object sender, EventArgs e) => AddToInput("1");
        private void button2_Click(object sender, EventArgs e) => AddToInput("2");
        private void button3_Click(object sender, EventArgs e) => AddToInput("3");
        private void button4_Click(object sender, EventArgs e) => AddToInput("4");
        private void button5_Click(object sender, EventArgs e) => AddToInput("5");
        private void button6_Click(object sender, EventArgs e) => AddToInput("6");
        private void button7_Click(object sender, EventArgs e) => AddToInput("7");
        private void button8_Click(object sender, EventArgs e) => AddToInput("8");
        private void button9_Click(object sender, EventArgs e) => AddToInput("9");

        // Handle operators (+, -, *, /)
        private void plus_Click(object sender, EventArgs e) => AddOperator("+");
        private void minus_Click(object sender, EventArgs e) => AddOperator("-");
        private void multiply_Click(object sender, EventArgs e) => AddOperator("*");
        private void divide_Click(object sender, EventArgs e) => AddOperator("/");

        // Helper function to append operators to the input

        // Handle the decimal point button click
        private void dot_Click(object sender, EventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                currentInput += ".";
                textBox1.Text = currentInput;
            }
        }

        // Handle the 'Back' button click (close the form or go back)
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.ShowDialog();
            this.Close();
        }

        private void scientific_Load(object sender, EventArgs e)
        {
            //currentInput = "";
            //textBox1.Text = currentInput;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
        private void backSpace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentInput))
                return;

            // Special handling for multi-character functions
            if (currentInput.EndsWith("sin(") || currentInput.EndsWith("cos(") || currentInput.EndsWith("tan(") ||
                currentInput.EndsWith("log(") || currentInput.EndsWith("ln("))
            {
                // Remove the entire function name (4 chars for sin/cos/tan/log, 3 for ln)
                int removeLength = currentInput.EndsWith("ln(") ? 3 : 4;
                currentInput = currentInput.Substring(0, currentInput.Length - removeLength);
            }
            // Special handling for root symbols
            else if (currentInput.EndsWith("√") || currentInput.EndsWith("∛"))
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
            }
            else
            {
                // Regular single character removal
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
            }

            textBox1.Text = currentInput;
        }

        private void button12_Click(object sender, EventArgs e)
        {


        }
        private void exponent_Click(object sender, EventArgs e)
        {
            AddOperator("^");  // Using caret (^) as the exponent operator
        }
    }
}



