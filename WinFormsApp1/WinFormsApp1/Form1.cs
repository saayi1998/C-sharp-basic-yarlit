using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = textBox1.Text;
            if (string.IsNullOrEmpty(fname))
            {
                MessageBox.Show("Please enter a first name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // lblShow.Text = "please enter your first name";
                textBox1.Focus();
                return;
            }
            string lname = textBox2.Text;
            if (string.IsNullOrEmpty(lname))
            {
                MessageBox.Show("Please enter a last name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //lblShow.Text = "please enter your last name";
                textBox2.Focus();
                return;
            }
            string fullname = $"{fname} {lname}";
            //lblShow.Text = fullname;
            MessageBox.Show($"fullname: {fullname}", "Full Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblShow.Text ="";
        }
    }
}
