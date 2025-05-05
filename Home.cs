//namespace CalcMaster
//{
//    public partial class Home : Form
//    {
//        public Home()
//        {
//            InitializeComponent();
//        }
//
//        private void Form1_Load(object sender, EventArgs e)
//        {
//
//        }
//
//        private void label1_Click(object sender, EventArgs e)
//        {
//
//        }
//
//        private void CalcMaster_Click(object sender, EventArgs e)
//        {
//
//        }
//
//        private void button1_Click_1(object sender, EventArgs e)
//        {
//            this.Hide();
//            Basic obj = new Basic();
//            obj.ShowDialog();
//            this.Close();
//        }
//
//        private void button2_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            scientific obj = new scientific();
//            obj.ShowDialog();
//            this.Close();
//        }
//
//        private void button5_Click(object sender, EventArgs e)
//        {
//            MessageBox.Show("Button 5 clicked!");
//        }
//
//        private void button3_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            UC obj = new UC();
//            obj.ShowDialog();
//            this.Close();
//        }
//
//        private void button4_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            Solver obj = new Solver();
//            obj.ShowDialog();
//            this.Close();
//        }
//
//        //back ground img
//        private void frm1_Load(object sender, EventArgs e)
//        {
//            // Set the background image for the form
//            this.BackgroundImage = Image.FromFile("path_to_your_image");
//
//            // Set the image layout to stretch
//            this.BackgroundImageLayout = ImageLayout.Stretch;
//
//            // Optionally adjust the size if required
//            this.ClientSize = new Size(800, 600);  // Set the desired size for the form
//        }
//
//        private void pictureBox2_Click(object sender, EventArgs e)
//        {
//
//        }
//
//        private void panel1_Paint(object sender, PaintEventArgs e)
//        {
//
//        }
//
//        private void button5_Click_1(object sender, EventArgs e)
//        {
//            this.Hide();
//            Graphs obj = new Graphs();
//            obj.ShowDialog();
//            this.Close();
//        }
//
//        private void pictureBox1_Click(object sender, EventArgs e)
//        {
//
//        }
//    }
//}
//

using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalcMaster
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            // Apply the selected theme on load
            ThemeManager.ApplyTheme(this);

            // Set selected item in ComboBox to current theme
            comboBoxTheme.SelectedItem = ThemeManager.CurrentTheme.ToString();

            // In Home constructor
            this.MinimumSize = new Size(1000, 700); // Prevent window from getting too small
        }

        private void ToggleTheme()
        {
            // Example cycle: Light -> Dark -> Blue -> Light
            switch (ThemeManager.CurrentTheme)
            {
                case Theme.Purple:
                    ThemeManager.SetTheme(Theme.Dark);
                    break;
                case Theme.Dark:
                    ThemeManager.SetTheme(Theme.Blue);
                    break;
                case Theme.Blue:
                    ThemeManager.SetTheme(Theme.Purple);
                    break;
            }

            // ✅ Apply theme to ALL open forms
            foreach (Form form in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(form);
            }
        }

        private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTheme.SelectedItem is string selected)
            {
                if (Enum.TryParse(selected, out Theme selectedTheme))
                {
                    ThemeManager.SetTheme(selectedTheme);

                    // Apply theme to all open forms
                    foreach (Form openForm in Application.OpenForms)
                    {
                        ThemeManager.ApplyTheme(openForm);
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Basic obj = new Basic();
            obj.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            scientific obj = new scientific();
            obj.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UC obj = new UC();
            obj.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Solver obj = new Solver();
            obj.ShowDialog();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Graphs obj = new Graphs();
            obj.ShowDialog();
            this.Close();
        }

        private void CalcMaster_Click(object sender, EventArgs e)
        {
            // Optional: Action when title label is clicked
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Action when sub-label is clicked
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Custom drawing for panel (can leave empty)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Actions to perform on form load
        }

        private void btnToggleTheme_Click(object sender, EventArgs e)
        {
            ToggleTheme();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            var notesForm = new Notes();
            notesForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            diff obj = new diff();
            obj.ShowDialog();
            this.Close();
            
        }
    }
}
