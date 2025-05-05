//using System;
//using System.Numerics;
//using System.Text.RegularExpressions;
//using System.Windows.Forms;
//using MathNet.Numerics;

//namespace CalcMaster
//{
//    public partial class Solver : Form
//    {
//        public Solver()
//        {
//            InitializeComponent();
//        }

//        private void btnSolve_Click(object sender, EventArgs e)
//        {
//            string input = txtEquation.Text.Trim();

//            try
//            {
//                if (string.IsNullOrEmpty(input))
//                {
//                    txtSolution.Text = "Please enter an equation";
//                    return;
//                }

//                // Normalize the equation (remove spaces, convert to lowercase)
//                string normalized = input.Replace(" ", "").ToLower();

//                // Determine equation type and solve
//                if (IsCubic(normalized))
//                {
//                    Complex[] roots = SolveCubic(normalized);
//                    txtSolution.Text = FormatComplexRoots(roots);
//                }
//                else if (IsQuadratic(normalized))
//                {
//                    Complex[] roots = SolveQuadratic(normalized);
//                    txtSolution.Text = FormatComplexRoots(roots);
//                }
//                else if (IsLinear(normalized))
//                {
//                    double root = SolveLinear(normalized);
//                    txtSolution.Text = $"x = {root}";
//                }
//                else
//                {
//                    txtSolution.Text = "Unsupported equation format. Supported types: linear, quadratic, cubic";
//                }
//            }
//            catch (Exception ex)
//            {
//                txtSolution.Text = $"Error: {ex.Message}";
//            }
//        }

//        private string FormatComplexRoots(Complex[] roots)
//        {
//            string result = "Roots: ";
//            for (int i = 0; i < roots.Length; i++)
//            {
//                var root = roots[i];
//                if (Math.Abs(root.Imaginary) < 1e-10)
//                {
//                    result += $"x{i + 1} = {Math.Round(root.Real, 4)}";
//                }
//                else
//                {
//                    string sign = root.Imaginary >= 0 ? "+" : "-";
//                    result += $"x{i + 1} = {Math.Round(root.Real, 4)} {sign} {Math.Round(Math.Abs(root.Imaginary), 4)}i";
//                }

//                if (i < roots.Length - 1) result += ", ";
//            }
//            return result;
//        }

//        private bool IsLinear(string input)
//        {
//            return input.Contains("x") && !input.Contains("x^2") && !input.Contains("x^3");
//        }

//        private bool IsQuadratic(string input)
//        {
//            return input.Contains("x^2") && !input.Contains("x^3");
//        }

//        private bool IsCubic(string input)
//        {
//            return input.Contains("x^3");
//        }

//        private double SolveLinear(string equation)
//        {
//            // Format: ax + b = c
//            var sides = equation.Split('=');
//            if (sides.Length != 2) throw new Exception("Invalid format.");

//            string left = sides[0];
//            double right = double.Parse(sides[1]);

//            var match = Regex.Match(left, @"([+-]?\d*\.?\d*)x([+-]?\d+\.?\d*)?");
//            if (!match.Success) throw new Exception("Can't parse linear equation.");

//            double a = match.Groups[1].Value == "" || match.Groups[1].Value == "+" ? 1 :
//                       match.Groups[1].Value == "-" ? -1 : double.Parse(match.Groups[1].Value);
//            double b = match.Groups[2].Success ? double.Parse(match.Groups[2].Value) : 0;

//            return (right - b) / a;
//        }

//        private Complex[] SolveQuadratic(string equation)
//        {
//            // Format: ax^2 + bx + c = 0
//            string expr = equation.Replace("=0", "").Replace("= 0", "");
//            var match = Regex.Match(expr, @"([+-]?\d*\.?\d*)x\^2([+-]?\d*\.?\d*)x?([+-]?\d*\.?\d*)");
//            if (!match.Success) throw new Exception("Can't parse quadratic equation.");

//            double a = match.Groups[1].Value == "" || match.Groups[1].Value == "+" ? 1 :
//                       match.Groups[1].Value == "-" ? -1 : double.Parse(match.Groups[1].Value);
//            double b = match.Groups[2].Value == "" || match.Groups[2].Value == "+" ? 0 :
//                       match.Groups[2].Value == "-" ? -1 : double.Parse(match.Groups[2].Value);
//            double c = match.Groups[3].Value == "" ? 0 : double.Parse(match.Groups[3].Value);

//            double discriminant = b * b - 4 * a * c;

//            if (discriminant >= 0)
//            {
//                double sqrtD = Math.Sqrt(discriminant);
//                return new Complex[]
//                {
//                    (-b + sqrtD) / (2 * a),
//                    (-b - sqrtD) / (2 * a)
//                };
//            }
//            else
//            {
//                double sqrtD = Math.Sqrt(-discriminant);
//                return new Complex[]
//                {
//                    new Complex(-b / (2 * a), sqrtD / (2 * a)),
//                    new Complex(-b / (2 * a), -sqrtD / (2 * a))
//                };
//            }
//        }

//        //private Complex[] SolveCubic(string equation)
//        //{
//        //    // Format: ax^3 + bx^2 + cx + d = 0
//        //    string expr = equation.Replace("=0", "").Replace("= 0", "");
//        //    var match = Regex.Match(expr, @"([+-]?\d*\.?\d*)x\^3([+-]?\d*\.?\d*)x\^2([+-]?\d*\.?\d*)x?([+-]?\d*\.?\d*)");

//        //    if (!match.Success)
//        //    {
//        //        match = Regex.Match(expr, @"([+-]?\d*\.?\d*)x\^3\s*([+-]?\d*\.?\d*)x\^2\s*([+-]?\d*\.?\d*)x\s*([+-]?\d*\.?\d*)");
//        //    }

//        //    if (!match.Success)
//        //        throw new Exception("Can't parse cubic equation.");

//        //    // Extract coefficients for cubic equation ax^3 + bx^2 + cx + d = 0
//        //    double a = match.Groups[1].Value == "" || match.Groups[1].Value == "+" ? 1 :
//        //               match.Groups[1].Value == "-" ? -1 : double.Parse(match.Groups[1].Value);

//        //    double b = match.Groups[2].Value == "" || match.Groups[2].Value == "+" ? 0 :
//        //               match.Groups[2].Value == "-" ? -1 : double.Parse(match.Groups[2].Value);

//        //    double c = match.Groups[3].Value == "" || match.Groups[3].Value == "+" ? 0 :
//        //               match.Groups[3].Value == "-" ? -1 : double.Parse(match.Groups[3].Value);

//        //    double d = match.Groups[4].Value == "" ? 0 : double.Parse(match.Groups[4].Value);

//        //    return FindCubicRoots(a, b, c, d);
//        //}

//        private Complex[] SolveCubic(string equation)
//        {
//            try
//            {
//                // First normalize the equation to standard form
//                string normalized = equation.Replace(" ", "").ToLower();

//                // Handle the case where it's just x^3=0
//                if (normalized == "x^3=0")
//                {
//                    return new Complex[] { 0, 0, 0 }; // Triple root at 0
//                }

//                // Split into left and right sides
//                var sides = normalized.Split('=');
//                if (sides.Length != 2) throw new Exception("Equation must have one equals sign");

//                string left = sides[0];
//                string right = sides[1];

//                // Move all terms to left side
//                if (right != "0")
//                {
//                    left = $"{left}-({right})";
//                    right = "0";
//                }

//                // Now parse the left side
//                double a = 0, b = 0, c = 0, d = 0;

//                // Handle x^3 term
//                var x3Match = Regex.Match(left, @"([+-]?\d*)x\^3");
//                a = x3Match.Success ?
//                    (string.IsNullOrEmpty(x3Match.Groups[1].Value) ? 1 :
//                     x3Match.Groups[1].Value == "+" ? 1 :
//                     x3Match.Groups[1].Value == "-" ? -1 :
//                     double.Parse(x3Match.Groups[1].Value)) : 0;

//                // Handle x^2 term
//                var x2Match = Regex.Match(left, @"([+-]?\d*)x\^2");
//                b = x2Match.Success ?
//                    (string.IsNullOrEmpty(x2Match.Groups[1].Value) ? 1 :
//                     x2Match.Groups[1].Value == "+" ? 1 :
//                     x2Match.Groups[1].Value == "-" ? -1 :
//                     double.Parse(x2Match.Groups[1].Value)) : 0;

//                // Handle x term
//                var xMatch = Regex.Match(left, @"([+-]?\d*)x(?!\^)");
//                c = xMatch.Success ?
//                    (string.IsNullOrEmpty(xMatch.Groups[1].Value) ? 1 :
//                     xMatch.Groups[1].Value == "+" ? 1 :
//                     xMatch.Groups[1].Value == "-" ? -1 :
//                     double.Parse(xMatch.Groups[1].Value)) : 0;

//                // Handle constant term (must come after all x terms)
//                var constMatch = Regex.Match(left, @"([+-]?\d+)(?!.*x)");
//                d = constMatch.Success ? double.Parse(constMatch.Groups[1].Value) : 0;

//                // Special case: if we got nothing, check for simple x^3
//                if (a == 0 && b == 0 && c == 0 && d == 0 && left.Contains("x^3"))
//                {
//                    a = 1;
//                }

//                return FindCubicRoots(a, b, c, d);
//            }
//            catch (Exception ex)
//            {
//                throw new Exception($"Failed to solve cubic equation: {ex.Message}");
//            }
//        }

//        private double[] ExtractCoefficients(string equation)
//        {
//            // Expected format: ax^3 + bx^2 + cx + d = 0
//            string pattern = @"^(?<a>[+-]?\d*\.?\d*)x\^3(?<b>[+-]?\d*\.?\d*)x\^2(?<c>[+-]?\d*\.?\d*)x(?<d>[+-]?\d*\.?\d*)=0$";
//            var match = Regex.Match(equation, pattern);

//            if (!match.Success)
//            {
//                // Try alternative patterns for missing terms
//                pattern = @"^(?<a>[+-]?\d*\.?\d*)x\^3(?<b>[+-]?\d*\.?\d*)x\^2(?<d>[+-]?\d*\.?\d*)=0$";
//                match = Regex.Match(equation, pattern);
//                if (match.Success)
//                {
//                    return new double[] {
//                ParseCoefficient(match.Groups["a"].Value, 1),
//                ParseCoefficient(match.Groups["b"].Value, 0),
//                0, // c is missing
//                ParseCoefficient(match.Groups["d"].Value, 0)
//            };
//                }

//                pattern = @"^(?<a>[+-]?\d*\.?\d*)x\^3(?<d>[+-]?\d*\.?\d*)=0$";
//                match = Regex.Match(equation, pattern);
//                if (match.Success)
//                {
//                    return new double[] {
//                ParseCoefficient(match.Groups["a"].Value, 1),
//                0, // b is missing
//                0, // c is missing
//                ParseCoefficient(match.Groups["d"].Value, 0)
//            };
//                }

//                throw new Exception("Equation doesn't match expected cubic pattern");
//            }

//            return new double[] {
//        ParseCoefficient(match.Groups["a"].Value, 1),
//        ParseCoefficient(match.Groups["b"].Value, 0),
//        ParseCoefficient(match.Groups["c"].Value, 0),
//        ParseCoefficient(match.Groups["d"].Value, 0)
//    };
//        }

//        private string NormalizeEquation(string equation)
//        {
//            // Remove all whitespace
//            equation = equation.Replace(" ", "");

//            // Split into left and right sides
//            var sides = equation.Split('=');
//            if (sides.Length != 2) throw new Exception("Equation must have exactly one equals sign");

//            string left = sides[0];
//            string right = sides[1];

//            // Move all terms to left side
//            if (right != "0")
//            {
//                if (string.IsNullOrEmpty(left))
//                {
//                    left = "-(" + right + ")";
//                }
//                else
//                {
//                    left = left + "-(" + right + ")";
//                }
//                right = "0";
//            }

//            // Add implicit coefficients of 1
//            left = Regex.Replace(left, @"(?<=^|[+-])x\^3", "1x^3");
//            left = Regex.Replace(left, @"(?<=^|[+-])x\^2", "1x^2");
//            left = Regex.Replace(left, @"(?<=^|[+-])x(?!\^)", "1x");

//            // Ensure all terms are properly formed
//            left = Regex.Replace(left, @"(?<=\d)x", "*x");
//            left = left.Replace(" ", "");

//            return left + "=" + right;
//        }

//        private double ParseCoefficient(string coeff, double defaultValue)
//        {
//            if (string.IsNullOrEmpty(coeff)) return defaultValue;
//            if (coeff == "+") return 1;
//            if (coeff == "-") return -1;
//            return double.Parse(coeff);
//        }

//        private Complex[] FindCubicRoots(double a, double b, double c, double d)
//        {
//            // Normalize the equation: x^3 + (b/a)x^2 + (c/a)x + (d/a) = 0
//            if (Math.Abs(a) < 1e-10) throw new Exception("Coefficient 'a' cannot be zero in a cubic equation.");

//            b /= a;
//            c /= a;
//            d /= a;
//            a = 1;

//            // Use Cardano's formula
//            double q = (3.0 * c - b * b) / 9.0;
//            double r = (9.0 * b * c - 27.0 * d - 2.0 * b * b * b) / 54.0;
//            double discriminant = q * q * q + r * r;

//            Complex[] roots = new Complex[3];

//            if (discriminant > 0) // One real root and two complex roots
//            {
//                double s = r + Math.Sqrt(discriminant);
//                s = s < 0 ? -Math.Pow(-s, 1.0 / 3.0) : Math.Pow(s, 1.0 / 3.0);
//                double t = r - Math.Sqrt(discriminant);
//                t = t < 0 ? -Math.Pow(-t, 1.0 / 3.0) : Math.Pow(t, 1.0 / 3.0);

//                roots[0] = (s + t) - b / 3.0;
//                roots[1] = new Complex(-(s + t) / 2.0 - b / 3.0, (s - t) * Math.Sqrt(3.0) / 2.0);
//                roots[2] = new Complex(-(s + t) / 2.0 - b / 3.0, -(s - t) * Math.Sqrt(3.0) / 2.0);
//            }
//            else if (Math.Abs(discriminant) < 1e-10) // All roots are real and at least two are equal
//            {
//                double sqrtQ = q < 0 ? -Math.Pow(-q, 1.0 / 3.0) : Math.Pow(q, 1.0 / 3.0);
//                roots[0] = 2.0 * sqrtQ - b / 3.0;
//                roots[1] = -sqrtQ - b / 3.0;
//                roots[2] = roots[1];
//            }
//            else // Three distinct real roots
//            {
//                double theta = Math.Acos(r / Math.Sqrt(-q * q * q));
//                double sqrtQ = 2.0 * Math.Sqrt(-q);
//                roots[0] = sqrtQ * Math.Cos(theta / 3.0) - b / 3.0;
//                roots[1] = sqrtQ * Math.Cos((theta + 2.0 * Math.PI) / 3.0) - b / 3.0;
//                roots[2] = sqrtQ * Math.Cos((theta + 4.0 * Math.PI) / 3.0) - b / 3.0;
//            }

//            return roots;
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            Home obj = new Home();
//            obj.ShowDialog();
//            this.Close();
//        }

//        private void Solver_Load(object sender, EventArgs e)
//        {
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            txtEquation.Clear();
//            txtEquation.Focus();
//        }

//        private void btnClear_Click(object sender, EventArgs e)
//        {
//            txtEquation.Clear();
//            //txtSolution.Clear();
//            txtEquation.Focus();
//        }
//    }
//}
using System;
using System.Numerics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Text;


namespace CalcMaster
{
    public partial class Solver : Form
    {
        public Solver()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void Basic_Load(object sender, EventArgs e)
        {
            ThemeManager.LoadTheme();       // Line 1 ✅ Load from file
            ThemeManager.ApplyTheme(this);  // Line 2 ✅ Apply to this form
        }


        //private void btnSolve_Click(object sender, EventArgs e)
        //{
        //    string input = txtEquation.Text.Trim();

        //    try
        //    {
        //        if (string.IsNullOrEmpty(input))
        //        {
        //            txtSolution.Text = "Please enter an equation";
        //            return;
        //        }

        //        string normalized = NormalizeEquation(input);
        //        int degree = GetPolynomialDegree(normalized);

        //        if (degree > 5)
        //        {
        //            txtSolution.Text = "Unsupported: Polynomial degree > 5";
        //            return;
        //        }

        //        Complex[] roots = SolvePolynomial(normalized, degree);
        //        txtSolution.Text = FormatRoots(roots);
        //    }
        //    catch (Exception ex)
        //    {
        //        txtSolution.Text = $"Error: {ex.Message}";
        //    }
        //}
        private void btnSolve_Click(object sender, EventArgs e)
        {
            string input = txtEquation.Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(input))
                {
                    txtSolution.Text = "Please enter an equation";
                    return;
                }

                string normalized = NormalizeEquation(input);
                int degree = GetPolynomialDegree(normalized);

                if (degree > 5)
                {
                    txtSolution.Text = "Unsupported: Polynomial degree > 5";
                    return;
                }

                Complex[] roots = SolvePolynomial(normalized, degree);
                txtSolution.Text = FormatRoots(roots);
            }
            catch (Exception ex)
            {
                txtSolution.Text = $"Error: {ex.Message}";
            }
        }

        private string NormalizeEquation(string equation)
        {
            // Remove all whitespace and convert to lowercase
            equation = equation.Replace(" ", "").ToLower();

            // Handle cases like "x^5 = 32" by moving terms to left side
            var sides = equation.Split('=');
            if (sides.Length != 2) throw new Exception("Equation must have exactly one '='");

            string left = sides[0];
            string right = sides[1];

            if (right != "0")
            {
                left = $"{left}-({right})";
                right = "0";
            }

            // Add implicit coefficients of 1
            for (int i = 5; i >= 1; i--)
            {
                left = Regex.Replace(left, $@"(?<=^|[+-])x\^{i}", $"1x^{i}");
            }
            left = Regex.Replace(left, @"(?<=^|[+-])x(?!\^)", "1x");

            return left + "=" + right;
        }

        private int GetPolynomialDegree(string equation)
        {
            for (int i = 5; i >= 1; i--)
            {
                if (equation.Contains($"x^{i}")) return i;
            }
            return equation.Contains("x") ? 1 : 0;
        }

        private Complex[] SolvePolynomial(string equation, int degree)
        {
            double[] coefficients = ExtractCoefficients(equation, degree);

            switch (degree)
            {
                case 1: return SolveLinear(coefficients);
                case 2: return SolveQuadratic(coefficients);
                case 3: return SolveCubic(coefficients);
                case 4: return SolveQuartic(coefficients);
                case 5: return SolveQuintic(coefficients);
                default: throw new Exception("Unsupported polynomial degree");
            }
        }

        private double[] ExtractCoefficients(string equation, int degree)
        {
            string leftSide = equation.Split('=')[0];
            double[] coefficients = new double[degree + 1];

            for (int i = degree; i >= 0; i--)
            {
                if (i > 1)
                {
                    var match = Regex.Match(leftSide, $@"([+-]?\d*\.?\d*)x\^{i}");
                    coefficients[i] = ParseCoefficient(match.Groups[1].Value);
                }
                else if (i == 1)
                {
                    var match = Regex.Match(leftSide, @"([+-]?\d*\.?\d*)x(?!\^)");
                    coefficients[i] = ParseCoefficient(match.Groups[1].Value);
                }
                else // constant term
                {
                    var match = Regex.Matches(leftSide, @"([+-]?\d+\.?\d*)(?!.*x)");
                    coefficients[i] = match.Count > 0 ? double.Parse(match[^1].Value) : 0;
                }
            }

            return coefficients;
        }

        private double ParseCoefficient(string coeff)
        {
            if (string.IsNullOrEmpty(coeff)) return 1;
            if (coeff == "+") return 1;
            if (coeff == "-") return -1;
            return double.Parse(coeff);
        }

        // Solving methods for each degree
        private Complex[] SolveLinear(double[] coeffs)
        {
            double a = coeffs[1];
            double b = coeffs[0];
            return new Complex[] { -b / a };
        }

        private Complex[] SolveQuadratic(double[] coeffs)
        {
            double a = coeffs[2];
            double b = coeffs[1];
            double c = coeffs[0];

            double discriminant = b * b - 4 * a * c;

            if (discriminant >= 0)
            {
                double sqrtD = Math.Sqrt(discriminant);
                return new Complex[]
                {
                    (-b + sqrtD) / (2 * a),
                    (-b - sqrtD) / (2 * a)
                };
            }
            else
            {
                double sqrtD = Math.Sqrt(-discriminant);
                return new Complex[]
                {
                    new Complex(-b / (2 * a), sqrtD / (2 * a)),
                    new Complex(-b / (2 * a), -sqrtD / (2 * a))
                };
            }
        }

        private Complex[] SolveCubic(double[] coeffs)
        {
            // Implementation using Cardano's formula
            double a = coeffs[3];
            double b = coeffs[2];
            double c = coeffs[1];
            double d = coeffs[0];

            // Normalize coefficients
            b /= a;
            c /= a;
            d /= a;
            a = 1;

            double q = (3 * c - b * b) / 9;
            double r = (9 * b * c - 27 * d - 2 * b * b * b) / 54;
            double discriminant = q * q * q + r * r;

            Complex[] roots = new Complex[3];

            if (discriminant > 0) // One real root
            {
                double s = r + Math.Sqrt(discriminant);
                s = s < 0 ? -Math.Pow(-s, 1.0 / 3) : Math.Pow(s, 1.0 / 3);
                double t = r - Math.Sqrt(discriminant);
                t = t < 0 ? -Math.Pow(-t, 1.0 / 3) : Math.Pow(t, 1.0 / 3);

                roots[0] = (s + t) - b / 3;
                roots[1] = new Complex(-(s + t) / 2 - b / 3, (s - t) * Math.Sqrt(3) / 2);
                roots[2] = Complex.Conjugate(roots[1]);
            }
            else if (Math.Abs(discriminant) < 1e-10) // Multiple roots
            {
                double sqrtQ = q < 0 ? -Math.Pow(-q, 1.0 / 3) : Math.Pow(q, 1.0 / 3);
                roots[0] = 2 * sqrtQ - b / 3;
                roots[1] = -sqrtQ - b / 3;
                roots[2] = roots[1];
            }
            else // Three real roots
            {
                double theta = Math.Acos(r / Math.Sqrt(-q * q * q));
                double sqrtQ = 2 * Math.Sqrt(-q);
                roots[0] = sqrtQ * Math.Cos(theta / 3) - b / 3;
                roots[1] = sqrtQ * Math.Cos((theta + 2 * Math.PI) / 3) - b / 3;
                roots[2] = sqrtQ * Math.Cos((theta + 4 * Math.PI) / 3) - b / 3;
            }

            return roots;
        }

        private Complex[] SolveQuartic(double[] coeffs)
        {
            // Implementation using Ferrari's method
            double a = coeffs[4];
            double b = coeffs[3];
            double c = coeffs[2];
            double d = coeffs[1];
            double e = coeffs[0];

            // Normalize coefficients
            b /= a;
            c /= a;
            d /= a;
            e /= a;
            a = 1;

            // Solve the resolvent cubic
            double p = c - (3 * b * b / 8);
            double q = d + (b * b * b / 8) - (b * c / 2);
            double r = e - (3 * b * b * b * b / 256) + (b * b * c / 16) - (b * d / 4);

            Complex[] cubicRoots = SolveCubic(new double[] { r, q, p, 1 });
            Complex y = cubicRoots[0]; // Take any real root

            Complex sqrtTerm = Complex.Sqrt(2 * y - p);
            Complex sqrtTerm2 = Complex.Sqrt(y * y - r);

            Complex[] roots = new Complex[4];
            roots[0] = (-b / 4) + (sqrtTerm + sqrtTerm2) / 2;
            roots[1] = (-b / 4) + (sqrtTerm - sqrtTerm2) / 2;
            roots[2] = (-b / 4) - (sqrtTerm + sqrtTerm2) / 2;
            roots[3] = (-b / 4) - (sqrtTerm - sqrtTerm2) / 2;

            return roots;
        }

        private Complex[] SolveQuintic(double[] coeffs)
        {
            // For quintic equations, we'll use numerical methods since there's no general algebraic solution
            // This implementation uses the Durand-Kerner method
            int degree = 5;
            Complex[] roots = new Complex[degree];

            // Initial guesses (roots of unity)
            for (int i = 0; i < degree; i++)
            {
                double angle = 2 * Math.PI * i / degree;
                roots[i] = new Complex(0.5 * Math.Cos(angle), 0.5 * Math.Sin(angle));
            }

            // Iterative refinement
            for (int iter = 0; iter < 100; iter++)
            {
                Complex[] newRoots = new Complex[degree];
                for (int i = 0; i < degree; i++)
                {
                    Complex numerator = EvaluatePolynomial(coeffs, roots[i]);
                    Complex denominator = Complex.One;

                    for (int j = 0; j < degree; j++)
                    {
                        if (i != j)
                        {
                            denominator *= (roots[i] - roots[j]);
                        }
                    }

                    newRoots[i] = roots[i] - (numerator / denominator);
                }

                // Check for convergence
                bool converged = true;
                for (int i = 0; i < degree; i++)
                {
                    if (Complex.Abs(newRoots[i] - roots[i]) > 1e-10)
                    {
                        converged = false;
                        break;
                    }
                }

                roots = newRoots;
                if (converged) break;
            }

            return roots;
        }

        private Complex EvaluatePolynomial(double[] coeffs, Complex x)
        {
            Complex result = 0;
            for (int i = 0; i < coeffs.Length; i++)
            {
                result += coeffs[i] * Complex.Pow(x, i);
            }
            return result;
        }

        private string FormatRoots(Complex[] roots)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Roots (degree {roots.Length}):");
            //result.AppendLine(); // Blank line after header

            for (int i = 0; i < roots.Length; i++)
            {
                Complex root = roots[i];
                if (Math.Abs(root.Imaginary) < 1e-10)
                {
                    result.AppendLine($"x{i + 1} = {root.Real:0.#####}");
                }
                else
                {
                    string sign = root.Imaginary >= 0 ? "+" : "-";
                    result.AppendLine($"x{i + 1} = {root.Real:0.#####} {sign} {Math.Abs(root.Imaginary):0.#####}i");
                }
                //result.AppendLine(); // Blank line after each root
            }

            return result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEquation.Clear();
            txtSolution.Clear();
            txtEquation.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtEquation.Clear();
            //txtEquation.Focus();
            this.Hide();
            Home obj = new Home();
            obj.ShowDialog();
            this.Close();
        }

        private void txtEquation_TextChanged(object sender, EventArgs e)
        {

        }

        private void Solver_Load(object sender, EventArgs e)
        {

        }
    }
}