using System;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMaster
{
    public static class ThemeManager
    {
        public static Theme CurrentTheme { get; private set; } = Theme.Purple;
        private static string themeFile = "theme.config";

        public static void LoadTheme()
        {
            if (File.Exists(themeFile))
            {
                string themeStr = File.ReadAllText(themeFile);
                if (Enum.TryParse(themeStr, out Theme savedTheme))
                {
                    CurrentTheme = savedTheme;
                }
            }
        }

        public static void ApplyTheme(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is ListBox || c is RichTextBox || c is PictureBox)
                {
                    c.BackColor = CurrentTheme == Theme.Dark ?
                        Color.FromArgb(45, 45, 45) : Color.White;
                    c.ForeColor = CurrentTheme == Theme.Dark ?
                        Color.White : Color.Black;
                }
                ApplyTheme(c);
            }
        }

        public static void SaveTheme()
        {
            File.WriteAllText(themeFile, CurrentTheme.ToString());
        }

        public static void SetTheme(Theme theme)
        {
            CurrentTheme = theme;
            SaveTheme();
        }

        public static void ApplyTheme(Form form)
        {
           // Color bg, fg, btnBg, txtBg, accent;
            Color bg = Color.Black, fg = Color.White, btnBg = Color.Gray, txtBg = Color.White, accent = Color.Blue;


            switch (CurrentTheme)
            {
                case Theme.Dark:
                    bg = ColorTranslator.FromHtml("#1E1E2F");
                    fg = ColorTranslator.FromHtml("#E0E0E0");
                    btnBg = ColorTranslator.FromHtml("#2C3E50");
                    txtBg = ColorTranslator.FromHtml("#2E2E3A");
                    accent = ColorTranslator.FromHtml("#9B59B6");
                    break;

                case Theme.Blue:
                    bg = ColorTranslator.FromHtml("#0D1B2A");
                    fg = ColorTranslator.FromHtml("#EAF6FF");
                    btnBg = ColorTranslator.FromHtml("#1B263B");
                    txtBg = ColorTranslator.FromHtml("#415A77");
                    accent = ColorTranslator.FromHtml("#00BFFF");
                    break;

                case Theme.Purple:
                    bg = ColorTranslator.FromHtml("#2C003E");
                    fg = ColorTranslator.FromHtml("#F8EAFB");
                    btnBg = ColorTranslator.FromHtml("#5D3FD3");
                    txtBg = ColorTranslator.FromHtml("#3D2C8D");
                    accent = ColorTranslator.FromHtml("#B388EB");
                    break;

            }

            form.BackgroundImage = null;  // Remove image if set
            form.BackColor = bg;

            foreach (Control c in form.Controls)
            {
                ApplyToControl(c, fg, btnBg, txtBg, accent);
            }
        }

        public static void ApplyToControl(Control c, Color fg, Color btnBg, Color txtBg, Color accent)
        {
            c.ForeColor = fg;

            if (c is Button btn)
            {
                string tag = btn.Tag?.ToString()?.ToLower();

                switch (tag)
                {
                    case "digit":
                        btn.BackColor = ColorTranslator.FromHtml("#16A085"); // teal
                        break;
                    case "operator":
                        btn.BackColor = ColorTranslator.FromHtml("#2980B9"); // blue
                        break;
                    case "equal":
                        btn.BackColor = ColorTranslator.FromHtml("#E67E22"); // orange
                        break;
                    case "utility":
                        btn.BackColor = ColorTranslator.FromHtml("#8E44AD"); // purple
                        break;
                    case "convert":
                        btn.BackColor = ColorTranslator.FromHtml("#F1C40F"); // yellow
                        break;
                    default:
                        btn.BackColor = btnBg;
                        break;
                }

                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = accent;
                btn.FlatAppearance.BorderSize = 1;
            }
            else if (c is TextBox || c is RichTextBox)
            {
                c.BackColor = txtBg;
                c.ForeColor = fg;
            }
            else if (c is ComboBox combo)
            {
                combo.BackColor = txtBg;
                combo.ForeColor = fg;
                combo.FlatStyle = FlatStyle.Flat;
            }

            foreach (Control child in c.Controls)
            {
                ApplyToControl(child, fg, btnBg, txtBg, accent);
            }
        }

    }
}

