using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frm_students_detail : Form
    {
        public frm_students_detail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = txtFn.Text;
            txtFn1.Text = fname;
            if (string.IsNullOrEmpty(fname))
            {
                // MessageBox.Show("Please enter a first name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelshow.Text = "Please enter a first name.";
                txtFn.Focus();
                return;
            }
            string lname = txtLn.Text;
            txtLn1.Text = lname;
            if (string.IsNullOrEmpty(lname))
            {
                // MessageBox.Show("Please enter a last name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelshow.Text = "Please enter a last name.";
                txtLn.Focus();
                return;
            }
            DateTime dob = dateTimePicker.Value;
            dateTimePicker1.Value = dob;
            if (dob > DateTime.Now)
            {
                // MessageBox.Show("Please enter a valid date of birth.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelshow.Text = "Please enter a valid date of birth.";
                dateTimePicker.Focus();
                return;
            }

            string add = txtAdd.Text;
            txtAdd1.Text = add;
            if (string.IsNullOrEmpty(add))
            {
                // MessageBox.Show("Please enter an address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelshow.Text = "Please enter an address.";
                txtAdd.Focus();
                return;
            }
            string nic = txtNIC.Text;
            txtNIC1.Text = nic;
            if (string.IsNullOrEmpty(nic))
            {
                // MessageBox.Show("Please enter a NIC number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelshow.Text = "Please enter a NIC number.";
                txtNIC.Focus();
                return;
            }
            else if (nic.Length != 9 || (!nic.EndsWith("V") && !nic.EndsWith("X")))
            {
                // MessageBox.Show("Please enter a valid NIC number (9 characters, ending with 'V' or 'X').", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelshow.Text = "Please enter a valid NIC number (9 characters, ending with 'V' or 'X').";
                txtNIC.Focus();
                return;
            }

            string gen = "";
            if (rbtnM.Checked)
            {
                gen = "Male";
                rbtnM1.Checked = true;
            }
            else if (rbtnF.Checked)
            {
                gen = "Female";
                rbtnF1.Checked = true;
            }
            if (string.IsNullOrEmpty(gen))
            {
                // MessageBox.Show("Please select a gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelshow.Text = "Please select a gender.";
                return;
            }
            string tp = txtTp.Text;
            txtTp1.Text = tp;
            if (string.IsNullOrEmpty(tp))
            {
                // MessageBox.Show("Please enter a telephone number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelshow.Text = "Please enter a telephone number.";
                txtTp.Focus();
                return;
            }
            else if (tp.Length != 10 || !tp.StartsWith("07"))
            {
                // MessageBox.Show("Please enter a valid telephone number (10 digits, starting with '07').", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelshow.Text = "Please enter a valid telephone number (10 digits, starting with '07').";
                txtTp.Focus();
                return;
            }

            MessageBox.Show("Student details submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelshow.Text = "";
        }
    }
}
