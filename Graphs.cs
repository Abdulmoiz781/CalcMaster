using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using NCalc;
using System.Text.RegularExpressions;

namespace CalcMaster
{
    public partial class Graphs : Form
    {
        public Graphs()
        {
            InitializeComponent();
            InitializePlot();
            this.AcceptButton = button1;
        }

        private void InitializePlot()
        {
            var plotModel = new PlotModel
            {
                Title = "Enter equation",
                PlotAreaBorderColor = OxyColors.Black
            };

            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "x-axis",
                Minimum = -10,
                Maximum = 10,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColor.FromRgb(200, 200, 200),
                MinorGridlineColor = OxyColor.FromRgb(230, 230, 230),
            });

            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "y-axis",
                Minimum = -10,
                Maximum = 10,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColor.FromRgb(200, 200, 200),
                MinorGridlineColor = OxyColor.FromRgb(230, 230, 230),
            });

            plotView1.Model = plotModel;
        }

        private void txtEquation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PlotCurrentEquation();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void PlotCurrentEquation()
        {
            string equation = txtEquation.Text.Trim();

            if (string.IsNullOrWhiteSpace(equation))
            {
                MessageBox.Show("Please enter an equation");
                return;
            }

            if (equation.StartsWith("x="))
            {
                PlotVerticalLine(equation);
                return;
            }

            try
            {
                if (IsTrigonometricEquation(equation))
                {
                    PlotTrigonometricFunction(equation);
                }
                else
                {
                    string preparedEq = PrepareNormalEquation(equation);
                    PlotFunction(preparedEq);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nTry formats like: 'x^3', 'cos(x)', or 'x=5'");
            }
        }

        private bool IsTrigonometricEquation(string equation)
        {
            return equation.Contains("sin") || equation.Contains("cos") || equation.Contains("tan");
        }

        private string PrepareNormalEquation(string equation)
        {
            equation = equation.Replace("y=", "").Trim();
            equation = equation.Replace(" ", "");

            // Ensure multiplication between numbers and variables (e.g., 2x becomes 2*x)
            equation = Regex.Replace(equation, @"(\d)([a-zA-Z])", "$1*$2");
            equation = Regex.Replace(equation, @"([a-zA-Z])(\d)", "$1*$2");
            equation = Regex.Replace(equation, @"\)([a-zA-Z])", ")*$1");
            equation = Regex.Replace(equation, @"([a-zA-Z])\(", "$1*(");

            // Ensure multiplication between numbers and functions like sin, cos, tan (e.g., 2sin(x) becomes 2*sin(x))
            equation = Regex.Replace(equation, @"(\d)(sin|cos|tan)\(", "$1*$2(");

            // Convert ^ to Pow notation for exponents (e.g., x^2 becomes Pow(x, 2))
            equation = Regex.Replace(equation, @"([a-zA-Z0-9\)]+)\^([a-zA-Z0-9\(]+)", "Pow($1,$2)");

            return equation;
        }

        private void PlotFunction(string equation)
        {
            var plotModel = plotView1.Model ?? new PlotModel();
            plotModel.Series.Clear();
            plotModel.Title = $"f(x) = {equation}";

            var lineSeries = new LineSeries
            {
                Color = OxyColors.Blue,
                StrokeThickness = 2
            };

            if (double.TryParse(equation, out double constantValue))
            {
                for (double x = -1000; x <= 1000; x += 0.1)
                {
                    lineSeries.Points.Add(new DataPoint(x, constantValue));
                }
            }
            else
            {
                var expr = new Expression(equation, EvaluateOptions.IgnoreCase);
                expr.Parameters["pi"] = Math.PI;
                expr.Parameters["e"] = Math.E;

                expr.EvaluateFunction += (name, args) =>
                {
                    name = name.ToLower();
                    switch (name)
                    {
                        case "pow":
                            args.Result = Math.Pow(
                                Convert.ToDouble(args.Parameters[0].Evaluate()),
                                Convert.ToDouble(args.Parameters[1].Evaluate()));
                            break;
                        case "sqrt":
                            args.Result = Math.Sqrt(Convert.ToDouble(args.Parameters[0].Evaluate()));
                            break;
                        case "log":
                            args.Result = Math.Log(Convert.ToDouble(args.Parameters[0].Evaluate()));
                            break;
                    }
                };

                for (double x = -1000; x <= 1000; x += 0.1)
                {
                    try
                    {
                        expr.Parameters["x"] = x;
                        object result = expr.Evaluate();
                        if (result is double y && !double.IsNaN(y) && !double.IsInfinity(y))
                        {
                            lineSeries.Points.Add(new DataPoint(x, y));
                        }
                    }
                    catch { }
                }
            }

            plotModel.Series.Add(lineSeries);
            plotView1.Model = plotModel;
            plotView1.InvalidatePlot(true);
        }

        private void PlotTrigonometricFunction(string equation)
        {
            var plotModel = plotView1.Model ?? new PlotModel();
            plotModel.Series.Clear();
            plotModel.Title = $"f(x) = {equation}";

            TrigFunctionComponents components = ParseTrigFunction(equation);

            plotModel.Axes.Clear();
            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = -10,
                Maximum = 10,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            });

            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Minimum = -Math.Max(components.Amplitude * 1.5, 10),
                Maximum = Math.Max(components.Amplitude * 1.5, 10),
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            });

            if (components.IsTanFunction)
            {
                PlotTanFunction(plotModel, components);
            }
            else
            {
                PlotSinCosFunction(plotModel, components);
            }

            plotView1.Model = plotModel;
            plotView1.InvalidatePlot(true);
        }

        private TrigFunctionComponents ParseTrigFunction(string equation)
        {
            var components = new TrigFunctionComponents();

            // First remove "y=" if present and trim whitespace
            equation = equation.Replace("y=", "").Trim();

            // Match the complete trigonometric function pattern
            var match = Regex.Match(equation,
                @"^\s*([+-]?\d*\.?\d+)?\s*(sin|cos|tan)\s*\(\s*([+-]?\d*\.?\d+)?\s*[*xX]\s*([+-]\s*\d*\.?\d+)?\s*\)\s*$",
                RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                // Try simpler pattern if the complex one fails
                match = Regex.Match(equation,
                    @"^\s*([+-]?\d*\.?\d+)?\s*(sin|cos|tan)\s*\(\s*([+-]?\d*\.?\d+)?\s*[xX]\s*\)\s*$",
                    RegexOptions.IgnoreCase);
            }

            if (match.Success)
            {
                // Parse amplitude (coefficient before the function)
                if (!string.IsNullOrEmpty(match.Groups[1].Value))
                {
                    components.Amplitude = double.Parse(match.Groups[1].Value);
                }

                // Determine function type
                string funcType = match.Groups[2].Value.ToLower();
                if (funcType == "tan")
                {
                    components.IsTanFunction = true;
                    components.Function = x => Math.Tan(x);
                }
                else if (funcType == "sin")
                {
                    components.Function = x => Math.Sin(x);
                }
                else if (funcType == "cos")
                {
                    components.Function = x => Math.Cos(x);
                }

                // Parse frequency (coefficient of x inside the function)
                if (match.Groups.Count > 3 && !string.IsNullOrEmpty(match.Groups[3].Value))
                {
                    components.Frequency = double.Parse(match.Groups[3].Value);
                }

                // Parse phase shift (constant term inside the function)
                if (match.Groups.Count > 4 && !string.IsNullOrEmpty(match.Groups[4].Value))
                {
                    components.PhaseShift = double.Parse(match.Groups[4].Value.Replace(" ", ""));
                }
            }
            else
            {
                throw new FormatException("Invalid trigonometric function format. Use like: '2sin(x)' or 'cos(2x)'");
            }

            return components;
        }

        private void PlotSinCosFunction(PlotModel plotModel, TrigFunctionComponents components)
        {
            var lineSeries = new LineSeries
            {
                Color = OxyColors.Blue,
                StrokeThickness = 2,
                InterpolationAlgorithm = InterpolationAlgorithms.CanonicalSpline
            };

            for (double x = -1000; x <= 1000; x += 0.05)
            {
                try
                {
                    // Calculate the argument for the trig function
                    double arg = components.Frequency * x + components.PhaseShift;

                    // Calculate the y value with proper amplitude scaling
                    double y = components.Amplitude * components.Function(arg);

                    if (!double.IsNaN(y))
                    {
                        lineSeries.Points.Add(new DataPoint(x, y));
                    }
                }
                catch { }
            }

            plotModel.Series.Add(lineSeries);
        }


        private void PlotTanFunction(PlotModel plotModel, TrigFunctionComponents components)
        {
            List<DataPoint> currentSegment = new List<DataPoint>();

            for (double x = -1000; x <= 1000; x += 0.01)
            {
                try
                {
                    double transformedX = components.Frequency * x + components.PhaseShift;
                    double y = components.Amplitude * components.Function(transformedX);

                    bool nearAsymptote = Math.Abs((transformedX - Math.PI / 2) % Math.PI) < 0.1;

                    if (!nearAsymptote && !double.IsInfinity(y) && Math.Abs(y) < 100)
                    {
                        currentSegment.Add(new DataPoint(x, y));
                    }
                    else if (currentSegment.Count > 0)
                    {
                        plotModel.Series.Add(new LineSeries
                        {
                            Color = OxyColors.Blue,
                            StrokeThickness = 2,
                            ItemsSource = currentSegment
                        });
                        currentSegment = new List<DataPoint>();
                    }
                }
                catch { }
            }

            if (currentSegment.Count > 0)
            {
                plotModel.Series.Add(new LineSeries
                {
                    Color = OxyColors.Blue,
                    StrokeThickness = 2,
                    ItemsSource = currentSegment
                });
            }
        }

        private void PlotVerticalLine(string equation)
        {
            var parts = equation.Split('=');
            if (parts.Length == 2 && double.TryParse(parts[1], out double xValue))
            {
                var plotModel = new PlotModel
                {
                    Title = equation,
                    PlotAreaBorderColor = OxyColors.Black
                };

                plotModel.Axes.Add(new LinearAxis
                {
                    Position = AxisPosition.Bottom,
                    Minimum = -10,
                    Maximum = 10,
                    MajorGridlineStyle = LineStyle.Solid,
                    MinorGridlineStyle = LineStyle.Dot
                });

                plotModel.Axes.Add(new LinearAxis
                {
                    Position = AxisPosition.Left,
                    Minimum = -10,
                    Maximum = 10,
                    MajorGridlineStyle = LineStyle.Solid,
                    MinorGridlineStyle = LineStyle.Dot
                });

                var lineSeries = new LineSeries
                {
                    Color = OxyColors.Red,
                    StrokeThickness = 2,
                    MarkerType = MarkerType.None
                };

                for (double y = -1000; y <= 1000; y += 0.1)
                {
                    lineSeries.Points.Add(new DataPoint(xValue, y));
                }

                plotModel.Series.Add(lineSeries);
                plotView1.Model = plotModel;
                plotView1.InvalidatePlot(true);
            }
            else
            {
                MessageBox.Show("Please use format 'x=number' (e.g., 'x=5')");
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            PlotCurrentEquation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().ShowDialog();
            this.Close();
        }

        private class TrigFunctionComponents
        {
            public double Amplitude { get; set; } = 1;
            public double Frequency { get; set; } = 1;
            public double PhaseShift { get; set; } = 0;
            public Func<double, double> Function { get; set; }
            public bool IsTanFunction { get; set; } = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.ShowDialog();
            this.Close();
        }
    }
}