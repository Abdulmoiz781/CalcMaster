/*
using system;
using system.collections.generic;
using system.componentmodel;
using system.data;
using system.drawing;
using system.linq;
using system.text;
using system.threading.tasks;
using system.windows.forms;

namespace calcmaster
{
    public partial class diff : form
    {
        public diff()
        {
            initializecomponent();
        }

        private void button2_click(object sender, eventargs e)
        {

        }
    }
}*/


using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CalcMaster
{
    public partial class diff : Form
    {
        public diff()
        {
            InitializeComponent();
            this.AcceptButton = btnSolve;
            ThemeManager.ApplyTheme(this);
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            string equation = txtEquation.Text.Trim();

            if (!ValidateInput(equation))
                return;

            try
            {
                string derivative = DifferentiateExpression(equation);
                txtResult.Text = $"d/dx ({equation}) = {derivative}";
            }
            catch (Exception ex)
            {
                txtResult.Text = $"Error: {ex.Message}";
                MessageBox.Show($"Could not differentiate.\n{ex.Message}",
                                "Differentiation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private bool ValidateInput(string equation)
        {
            if (string.IsNullOrWhiteSpace(equation))
            {
                MessageBox.Show("Please enter an equation first");
                return false;
            }
            return true;
        }

        private string DifferentiateExpression(string equation)
        {
            equation = equation.Replace(" ", "").ToLower();

            // Handle multiple terms
            if (equation.Contains("+") || equation.Contains("-"))
            {
                string[] terms = Regex.Split(equation, @"(?=[+-])");
                List<string> derivatives = new List<string>();

                foreach (string term in terms)
                {
                    if (string.IsNullOrEmpty(term)) continue;
                    string cleanTerm = term.TrimStart('+');
                    if (!string.IsNullOrEmpty(cleanTerm))
                    {
                        string derivative = DifferentiateTerm(cleanTerm);
                        if (!string.IsNullOrEmpty(derivative) && derivative != "0")
                            derivatives.Add(derivative);
                    }
                }

                if (derivatives.Count == 0) return "0";
                return string.Join(" + ", derivatives).Replace("+ -", "- ");
            }

            // Single term
            return DifferentiateTerm(equation);
        }

        private string DifferentiateTerm(string term)
        {
            // Constants
            if (Regex.IsMatch(term, @"^[+-]?\d+\.?\d*$"))
                return "0";

            // Basic variable
            if (term == "x") return "1";

            // Polynomial terms
            if (Regex.IsMatch(term, @"^[+-]?\d*x$")) // Linear terms
            {
                string coeff = term.Replace("x", "");
                return string.IsNullOrEmpty(coeff) ? "1" : coeff;
            }
            else if (Regex.IsMatch(term, @"^[+-]?\d*x\^[+-]?\d+$")) // Power terms
            {
                var match = Regex.Match(term, @"^([+-]?\d*)x\^([+-]?\d+)$");
                double coeff = string.IsNullOrEmpty(match.Groups[1].Value) ? 1 : double.Parse(match.Groups[1].Value);
                int power = int.Parse(match.Groups[2].Value);

                double newCoeff = coeff * power;
                int newPower = power - 1;

                string result = $"{newCoeff}";
                if (newPower == 1) result += "x";
                else if (newPower != 0) result += $"x^{newPower}";
                return result;
            }

            // Trigonometric functions - handle coefficients and powers
            var trigMatch = Regex.Match(term, @"^([+-]?\d*\.?\d*)(sin|cos|tan|csc|sec|cot)\(([+-]?\d*\.?\d*)x\)(\^[+-]?\d+)?$");
            if (trigMatch.Success)
            {
                string coeffStr = trigMatch.Groups[1].Value;
                string func = trigMatch.Groups[2].Value;
                string innerCoeffStr = trigMatch.Groups[3].Value;
                string powerStr = trigMatch.Groups[4].Value;

                double outerCoeff = string.IsNullOrEmpty(coeffStr) ? 1 : double.Parse(coeffStr);
                double innerCoeff = string.IsNullOrEmpty(innerCoeffStr) ? 1 : double.Parse(innerCoeffStr);
                int power = string.IsNullOrEmpty(powerStr) ? 1 : int.Parse(powerStr.Replace("^", ""));

                string derivative = DifferentiateTrigFunction(func, innerCoeff, power);
                double totalCoeff = outerCoeff * innerCoeff * power;

                if (power > 1)
                {
                    string remainingPower = power > 2 ? $"^{power - 1}" : "";
                    return $"{totalCoeff}{func}({innerCoeff}x){remainingPower} * {derivative}";
                }
                return $"{totalCoeff}{derivative}";
            }

            // Inverse trigonometric functions
            var invTrigMatch = Regex.Match(term, @"^([+-]?\d*\.?\d*)(arcsin|arccos|arctan|arccsc|arcsec|arccot)\(([+-]?\d*\.?\d*)x\)$");
            if (invTrigMatch.Success)
            {
                string coeffStr = invTrigMatch.Groups[1].Value;
                string func = invTrigMatch.Groups[2].Value;
                string innerCoeffStr = invTrigMatch.Groups[3].Value;

                double outerCoeff = string.IsNullOrEmpty(coeffStr) ? 1 : double.Parse(coeffStr);
                double innerCoeff = string.IsNullOrEmpty(innerCoeffStr) ? 1 : double.Parse(innerCoeffStr);

                string derivative = DifferentiateInverseTrigFunction(func, innerCoeff);
                return $"{outerCoeff * innerCoeff}{derivative}";
            }

            // Exponential and logarithmic
            if (Regex.IsMatch(term, @"^[+-]?\d*e\^[+-]?\d*x$"))
            {
                var match = Regex.Match(term, @"^([+-]?\d*)e\^([+-]?\d*)x$");
                double outerCoeff = string.IsNullOrEmpty(match.Groups[1].Value) ? 1 : double.Parse(match.Groups[1].Value);
                double innerCoeff = string.IsNullOrEmpty(match.Groups[2].Value) ? 1 : double.Parse(match.Groups[2].Value);
                return $"{outerCoeff * innerCoeff}e^{innerCoeff}x";
            }
            else if (Regex.IsMatch(term, @"^[+-]?\d*ln\([+-]?\d*x\)$"))
            {
                var match = Regex.Match(term, @"^([+-]?\d*)ln\(([+-]?\d*)x\)$");
                double outerCoeff = string.IsNullOrEmpty(match.Groups[1].Value) ? 1 : double.Parse(match.Groups[1].Value);
                double innerCoeff = string.IsNullOrEmpty(match.Groups[2].Value) ? 1 : double.Parse(match.Groups[2].Value);
                return $"{outerCoeff * innerCoeff}/{innerCoeff}x";
            }

            throw new NotImplementedException($"Term '{term}' not supported");
        }

        private string DifferentiateTrigFunction(string func, double innerCoeff, int power)
        {
            string derivativeBase = func switch
            {
                "sin" => $"cos({innerCoeff}x)",
                "cos" => $"-sin({innerCoeff}x)",
                "tan" => $"sec^2({innerCoeff}x)",
                "csc" => $"-csc({innerCoeff}x)cot({innerCoeff}x)",
                "sec" => $"sec({innerCoeff}x)tan({innerCoeff}x)",
                "cot" => $"-csc^2({innerCoeff}x)",
                _ => throw new NotImplementedException($"Function '{func}' not supported")
            };
            return derivativeBase;
        }

        private string DifferentiateInverseTrigFunction(string func, double innerCoeff)
        {
            string derivative = func switch
            {
                "arcsin" => $"1/√(1-({innerCoeff}x)^2)",
                "arccos" => $"-1/√(1-({innerCoeff}x)^2)",
                "arctan" => $"1/(1+({innerCoeff}x)^2)",
                "arccsc" => $"-1/(|{innerCoeff}x|√(({innerCoeff}x)^2-1))",
                "arcsec" => $"1/(|{innerCoeff}x|√(({innerCoeff}x)^2-1))",
                "arccot" => $"-1/(1+({innerCoeff}x)^2)",
                _ => throw new NotImplementedException($"Inverse function '{func}' not supported")
            };
            return derivative;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEquation.Clear();
            txtResult.Clear();
            txtEquation.Focus();
        }

        private void btnExamples_Click(object sender, EventArgs e)
        {
            string examples = "Supported formats:\n\n" +
                "• Polynomials:\n" +
                "  x^2+3x-5 → 2x + 3\n" +
                "  4x^3 → 12x^2\n\n" +
                "• Trigonometric:\n" +
                "  sin(2x) → 2cos(2x)\n" +
                "  3cos(x)^2 → -6cos(x)sin(x)\n" +
                "  tan(5x) → 5sec^2(5x)\n\n" +
                "• Inverse Trig:\n" +
                "  arctan(x) → 1/(1+x^2)\n" +
                "  arcsin(2x) → 2/√(1-4x^2)\n\n" +
                "• Exponential/Log:\n" +
                "  e^3x → 3e^3x\n" +
                "  2ln(x) → 2/x";

            MessageBox.Show(examples, "Differentiation Examples", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       private void button2_click(object sender, EventArgs e)
       {
            this.Hide();
            Home obj = new Home();
            obj.ShowDialog();
            this.Close();

        }
    }
}





