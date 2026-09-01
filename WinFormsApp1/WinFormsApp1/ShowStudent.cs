using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace WinFormsApp1
{
    public partial class ShowStudent : Form
    {
        string fname;
        string lname;
        String gender;
        string Address;

        public ShowStudent(string fname, string lname, string gender, string address)
        {
            InitializeComponent();
            this.fname = fname;
            this.lname = lname;
            this.gender = gender;
            this.Address = address; 
        }

        private void ShowStudent_Load(object sender, EventArgs e)
        {
            txtSF.Text = fname;
            txtSL.Text = lname;
            if (gender == "M")
            {
                rbM.Checked = true;
            }
            else
            {
                rbF.Checked = true;
            }
            txtAdd.Text = Address;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
