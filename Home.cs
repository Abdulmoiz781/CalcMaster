namespace CalcMaster
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalcMaster_Click(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 5 clicked!");
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

        //back ground img
        private void frm1_Load(object sender, EventArgs e)
        {
            // Set the background image for the form
            this.BackgroundImage = Image.FromFile("path_to_your_image");

            // Set the image layout to stretch
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Optionally adjust the size if required
            this.ClientSize = new Size(800, 600);  // Set the desired size for the form
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Graphs obj = new Graphs();
            obj.ShowDialog();
            this.Close();
        }
    }
}
