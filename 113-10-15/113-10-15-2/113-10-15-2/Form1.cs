namespace _113_10_15_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kms;
            double liters;
            double ave;

            kms = double.Parse(km_box.Text);
            liters = double.Parse(oil_box.Text);
            ave = kms / liters;

            lblshow.Text = ave.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
