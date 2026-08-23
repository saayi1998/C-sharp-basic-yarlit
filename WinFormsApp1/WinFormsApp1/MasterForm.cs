using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void btnM1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnM2_Click(object sender, EventArgs e)
        {
            frm_students_detail frmStudentsDetail = new frm_students_detail();
            DialogResult result = frmStudentsDetail.ShowDialog();   
        }
    }
}
