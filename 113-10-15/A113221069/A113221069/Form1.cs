namespace A113221069
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string output;

            output = "����" + txtyear.Text + "�~" + txtmonth.Text + "��" + txtday.Text + "��" + "�P��" + txtdayofweek.Text;

            lblShow.Text = output;
         }

        private void btnshowday_Click(object sender, EventArgs e)
        {
            txtdayofweek.Text = "";
            txtday.Text = "";
            txtmonth.text = "";
            txtyear.text = "";
            lblshow.text = "";
        
        }
    }
}
