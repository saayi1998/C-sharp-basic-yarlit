using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DBForm : Form
    {
        public DBForm()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MessageBox.Show("Conncection Successful", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from students", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStu.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while accessing the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

        private void lblF_Click(object sender, EventArgs e)
        {

        }

        private void btnSW_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStu.Rows.Count == 0)
                {
                    MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string fname = dgvStu.CurrentRow.Cells["first_name"].Value.ToString();
                txtF.Text = fname;

                string lname = dgvStu.CurrentRow.Cells["last_name"].Value.ToString();
                txtL.Text = lname;

                if (dgvStu.CurrentRow.Cells["gender"].Value.ToString() == "M")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                string DOB = dgvStu.CurrentRow.Cells["date_of_birth"].Value.ToString();
                txtDOB.Text = Convert.ToDateTime(DOB).ToString("yyyy-MM-dd");

                string DOA = dgvStu.CurrentRow.Cells["date_of_admission"].Value.ToString();
                txtDOA.Text = Convert.ToDateTime(DOA).ToString("yyyy-MM-dd");

                string nic = dgvStu.CurrentRow.Cells["nic_number"].Value.ToString();
                txtNIC.Text = nic;

                string tel = dgvStu.CurrentRow.Cells["tele_number"].Value.ToString();
                txtTel.Text = tel;

                string address = dgvStu.CurrentRow.Cells["per_address"].Value.ToString();
                txtADD.Text = address;
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLG_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from grades", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbLG.DataSource = dt;
                cmbLG.DisplayMember = "grade_name"; // column showing grade name in the dropdown
                cmbLG.ValueMember = "id";           // primary key column of the grades table
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while accessing the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbLG.SelectedValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbLG.SelectedValue = 10;
        }

        private void button21_Click(object sender, EventArgs e)
        {
        
            try
            {
                string id = dgvStu.CurrentRow.Cells["id"].Value.ToString();
                DBshow f = new DBshow(id);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDiaSW_Click(object sender, EventArgs e)
        {

        try
        {
            
            string fname = dgvStu.CurrentRow.Cells["first_name"].Value.ToString();
            string lname = dgvStu.CurrentRow.Cells["last_name"].Value.ToString();
            string gender = dgvStu.CurrentRow.Cells["gender"].Value.ToString();
            string DOB = Convert.ToDateTime(dgvStu.CurrentRow.Cells["date_of_birth"].Value).ToString("yyyy-MM-dd");
            string DOA = Convert.ToDateTime(dgvStu.CurrentRow.Cells["date_of_admission"].Value).ToString("yyyy-MM-dd");
            string nic = dgvStu.CurrentRow.Cells["nic_number"].Value.ToString();
            string tel = dgvStu.CurrentRow.Cells["tele_number"].Value.ToString();
            string address = dgvStu.CurrentRow.Cells["per_address"].Value.ToString();
            ShowStudent f = new ShowStudent(fname, lname, gender, DOB, DOA, nic, tel, address);
            f.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred while retrieving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        }
    }
}
