using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalcMaster
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
            SetupFormulas();
            ApplyTheme();

            // Add event handler for home button
            btnReturnHome.Click += (sender, e) =>
            {
                this.Hide();
                var mainForm = new Home(); // Assuming your main form is called MainForm
                mainForm.Show();
            };
        }

        private void ApplyTheme()
        {
            // Main form styling
            this.BackColor = Color.FromArgb(34, 34, 34);
            this.ForeColor = Color.WhiteSmoke;
            this.AutoScroll = true;
            this.AutoScrollMargin = new Size(25, 25);

            // Button styling
            btnReturnHome.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            btnReturnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);

            // Custom tab drawing
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.ItemSize = new Size(120, 32);
            tabControl.DrawItem += TabControl_DrawItem;
        }

        private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tab = tabControl.TabPages[e.Index];
            var bounds = tabControl.GetTabRect(e.Index);

            // Background
            using (var brush = new SolidBrush(Color.FromArgb(60, 60, 60)))
            {
                e.Graphics.FillRectangle(brush, bounds);
            }

            // Text
            TextRenderer.DrawText(
                e.Graphics,
                tab.Text,
                new Font("Segoe UI", 10, FontStyle.Bold),
                bounds,
                e.State == DrawItemState.Selected ? Color.LightSkyBlue : Color.WhiteSmoke,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }

        private void SetupFormulas()
        {
            AddFormulaTab("📘 Algebra", new[]
            {
                "🔹 Quadratic Formula:\n" +
                "        −b ± ⎷b² − 4ac\n" +
                "x = ⎯⎯⎯⎯⎯⎯⎯⎯⎯⎯⎯⎯⎯⎯⎯\n" +
                "          2a\n\n" +
                "▸ Example:\n" +
                "   2x² + 4x − 6 = 0\n" +
                "   a=2, b=4, c=−6\n" +
                "   Δ = 16 + 48 = 64\n" +
                "   x = (−4 ± 8)/4\n" +
                "   → x=1 or x=−3",

                "🔹 Binomial Theorem:\n" +
                "(a + b)ⁿ = Σₖ₌₀ⁿ C(n,k)aⁿ⁻ᵏbᵏ\n\n" +
                "▸ Expansion Pattern:\n" +
                "   • Coefficients follow Pascal's Triangle\n" +
                "   • Symmetric pattern\n" +
                "   • Sum of exponents = n",

                "🔹 Logarithm Properties:\n" +
                "   ○ Product: logₐ(xy) = logₐx + logₐy\n" +
                "   ○ Quotient: logₐ(x/y) = logₐx − logₐy\n" +
                "   ○ Power: logₐ(xⁿ) = n·logₐx\n" +
                "   ○ Change of Base: logₐb = logₖb/logₖa\n\n" +
                "▸ Natural Log:\n" +
                "   • ln(eˣ) = x\n" +
                "   • eˡⁿ⁽ˣ⁾ = x"
            });

            AddFormulaTab("📐 Geometry", new[]
            {
                "🔹 Circle Formulas:\n" +
                "   ○ Area: A = πr²\n" +
                "   ○ Circumference: C = 2πr\n" +
                "   ○ Arc Length: L = rθ (θ in radians)\n" +
                "   ○ Sector Area: A = ½r²θ\n\n" +
                "🔹 Triangle Properties:\n" +
                "   ○ Area: A = ½bh\n" +
                "   ○ Pythagorean Theorem: a² + b² = c²\n" +
                "   ○ Law of Cosines: c² = a² + b² − 2ab·cos(C)\n" +
                "   ○ Law of Sines: a/sin(A) = b/sin(B) = c/sin(C)\n\n" +
                "▸ Special Triangles:\n" +
                "   • 30-60-90: 1:√3:2\n" +
                "   • 45-45-90: 1:1:√2"
            });

            AddFormulaTab("🧮 Calculus", new[]
            {
                "🔹 Fundamental Theorems:\n" +
                "   1. ∫ₐᵇ f(x)dx = F(b) − F(a)\n" +
                "   2. d/dx ∫ₐˣ f(t)dt = f(x)\n\n" +
                "▸ Common Derivatives:\n" +
                "   • d/dx eˣ = eˣ\n" +
                "   • d/dx ln(x) = 1/x\n" +
                "   • d/dx sin(x) = cos(x)\n" +
                "   • d/dx cos(x) = −sin(x)\n" +
                "   • d/dx tan(x) = sec²(x)\n\n" +
                "▸ Integration Techniques:\n" +
                "   • By Parts: ∫u dv = uv − ∫v du\n" +
                "   • Substitution: ∫f(g(x))g'(x)dx\n" +
                "   • Partial Fractions: ∫P(x)/Q(x)dx"
            });

            AddFormulaTab("📊 Statistics", new[]
            {
                "🔹 Descriptive Statistics:\n" +
                "   ○ Mean: μ = Σxᵢ/n\n" +
                "   ○ Variance: σ² = Σ(xᵢ−μ)²/n\n" +
                "   ○ Standard Deviation: σ = √σ²\n\n" +
                "🔹 Probability:\n" +
                "   ○ P(A∪B) = P(A) + P(B) − P(A∩B)\n" +
                "   ○ Conditional: P(A|B) = P(A∩B)/P(B)\n" +
                "   ○ Bayes' Theorem: P(A|B) = P(B|A)P(A)/P(B)\n\n" +
                "▸ Distributions:\n" +
                "   • Binomial: P(k) = C(n,k)pᵏ(1−p)ⁿ⁻ᵏ\n" +
                "   • Normal: f(x) = (1/σ√2π)e⁻⁽ˣ⁻μ⁾²/²σ²"
            });

            AddFormulaTab("⚡ Physics", new[]
            {
                "🔹 Kinematics:\n" +
                "   ○ v = u + at\n" +
                "   ○ s = ut + ½at²\n" +
                "   ○ v² = u² + 2as\n\n" +
                "🔹 Newton's Laws:\n" +
                "   1. F = ma\n" +
                "   2. F₁₂ = −F₂₁\n" +
                "   3. F = G(m₁m₂)/r²\n\n" +
                "▸ Energy:\n" +
                "   • KE = ½mv²\n" +
                "   • PE = mgh\n" +
                "   • Work: W = F·d·cosθ"
            });
        }

        private void AddFormulaTab(string tabName, string[] formulas)
        {
            var tabPage = new TabPage(tabName)
            {
                BackColor = Color.FromArgb(45, 45, 45),
                Padding = new Padding(10)
            };

            var flowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(15),
                BackColor = Color.FromArgb(50, 50, 50)
            };

            foreach (var formula in formulas)
            {
                var panel = new Panel
                {
                    Size = new Size(820, 220),
                    Margin = new Padding(15),
                    BackColor = Color.FromArgb(60, 60, 60),
                    BorderStyle = BorderStyle.FixedSingle
                };

                var formulaLabel = new RichTextBox
                {
                    Text = formula,
                    Font = new Font("Segoe UI", 11),
                    BackColor = panel.BackColor,
                    ForeColor = Color.WhiteSmoke,
                    BorderStyle = BorderStyle.None,
                    Location = new Point(20, 15),
                    Size = new Size(780, 190),
                    ReadOnly = true
                };

                FormatText(formulaLabel, "🔹", Color.LightSkyBlue, FontStyle.Bold);
                FormatText(formulaLabel, "▸", Color.LimeGreen, FontStyle.Bold);
                FormatText(formulaLabel, "○", Color.Gold, FontStyle.Regular);
                FormatText(formulaLabel, "•", Color.Wheat, FontStyle.Regular);

                panel.Controls.Add(formulaLabel);
                flowPanel.Controls.Add(panel);
            }

           tabPage.Controls.Add(flowPanel);
           tabControl.TabPages.Add(tabPage);
        }

        private void FormatText(RichTextBox box, string symbol, Color color, FontStyle style)
        {
            int index = box.Text.IndexOf(symbol);
            while (index >= 0)
            {
                box.Select(index, symbol.Length);
                box.SelectionColor = color;
                box.SelectionFont = new Font(box.Font, style);
                index = box.Text.IndexOf(symbol, index + symbol.Length);
            }
        }
    }
}