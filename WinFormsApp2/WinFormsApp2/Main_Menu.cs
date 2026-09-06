using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            DB_Form2 dbForm2 = new DB_Form2();
            dbForm2.ShowDialog();
        }

        private void btn_Grade_Click(object sender, EventArgs e)
        {
            Gd_Form2 gdForm2 = new Gd_Form2();
            gdForm2.ShowDialog();
        }
    }
}
