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
            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                if (dgvStu.Rows.Count == 0)
                {
                    MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string studentId = dgvStu.CurrentRow.Cells["id"].Value.ToString();
                txt_F1.Text = studentId;

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

                string nic = dgvStu.CurrentRow.Cells["nic_number"].Value.ToString();
                txtNIC.Text = nic;

                string tel = dgvStu.CurrentRow.Cells["tele_number"].Value.ToString();
                txtTel.Text = tel;

                string address = dgvStu.CurrentRow.Cells["per_address"].Value.ToString();
                txtADD.Text = address;

                string grade = dgvStu.CurrentRow.Cells["grade_id"].Value.ToString();

                string house = dgvStu.CurrentRow.Cells["house_id"].Value.ToString();
                comboBox22.Text = house;

                string family = dgvStu.CurrentRow.Cells["family_id"].Value.ToString();
                comboBox3.Text = family;

                string admission = dgvStu.CurrentRow.Cells["admission_number"].Value.ToString();
                txt_AdM.Text = admission;

                string medium = dgvStu.CurrentRow.Cells["medium"].Value.ToString();
                comboBox1.Text = medium;



                // GRADE ID


                conn.Open();

                string query = "SELECT * FROM grades";
                MySqlDataAdapter da =
                new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbLG.DataSource = dt;
                // what user sees
                cmbLG.DisplayMember = "grade_name";
                // hidden value
                cmbLG.ValueMember = "id";


                // select student's grade
                if (!string.IsNullOrEmpty(grade))
                {
                    cmbLG.SelectedValue = Convert.ToInt32(grade);
                }

                // HOUSE ID
                string queryy = "SELECT * FROM houses";
                MySqlDataAdapter daa = new MySqlDataAdapter(queryy, conn);
                DataTable dtt = new DataTable();
                daa.Fill(dtt);

                comboBox22.DataSource = dtt;
                // what user sees
                comboBox22.DisplayMember = "house_name";
                // hidden value
                comboBox22.ValueMember = "id";


                // select student's house
                if (!string.IsNullOrEmpty(house))
                {
                    comboBox22.SelectedValue = Convert.ToInt32(house);
                }

                // FAMILY ID
                if (family != "")
                {
                    comboBox3.SelectedValue = Convert.ToInt32(family);
                }

                // MEDIUM
                if (medium != "")
                {
                    comboBox1.Text = medium;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error occurred while fetching student data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
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
                string grade = dgvStu.CurrentRow.Cells["grade_id"].Value.ToString();
                string family = dgvStu.CurrentRow.Cells["family_id"].Value.ToString();
                string house = dgvStu.CurrentRow.Cells["house_id"].Value.ToString();
                string admission = dgvStu.CurrentRow.Cells["admission_number"].Value.ToString();
                string medium = dgvStu.CurrentRow.Cells["medium"].Value.ToString();


                ShowStudent f = new ShowStudent(fname, lname, gender, DOB, DOA, nic, tel, address, house, family, grade, admission, medium);
                f.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txtADD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            //string id = dgvStu.CurrentRow.Cells["id"].Value.ToString();

            //EditStudent f = new EditStudent(id);

            //f.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                if (dgvStu.Rows.Count == 0)
                {
                    MessageBox.Show("No records found.", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string studentId = dgvStu.CurrentRow.Cells["id"].Value.ToString();

                conn.Open();

                MySqlCommand cmd = new MySqlCommand($"DELETE FROM students WHERE id = '{studentId}'", conn);
                string affectedRows = cmd.ExecuteNonQuery().ToString();

                MessageBox.Show($"Deleted successfully. Row(s) affected: {affectedRows}", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while deleting the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvStu.CurrentRow.Cells["id"].Value.ToString();
                string fname = dgvStu.CurrentRow.Cells["first_name"].Value.ToString();
                string lname = dgvStu.CurrentRow.Cells["last_name"].Value.ToString();
                string gender = dgvStu.CurrentRow.Cells["gender"].Value.ToString();
                string DOB = Convert.ToDateTime(dgvStu.CurrentRow.Cells["date_of_birth"].Value).ToString("yyyy-MM-dd");
                string DOA = Convert.ToDateTime(dgvStu.CurrentRow.Cells["date_of_admission"].Value).ToString("yyyy-MM-dd");
                string nic = dgvStu.CurrentRow.Cells["nic_number"].Value.ToString();
                string tel = dgvStu.CurrentRow.Cells["tele_number"].Value.ToString();
                string address = dgvStu.CurrentRow.Cells["per_address"].Value.ToString();
                string grade = dgvStu.CurrentRow.Cells["grade_id"].Value.ToString();
                string family = dgvStu.CurrentRow.Cells["family_id"].Value.ToString();
                string house = dgvStu.CurrentRow.Cells["house_id"].Value.ToString();
                string admission = dgvStu.CurrentRow.Cells["admission_number"].Value.ToString();
                string medium = dgvStu.CurrentRow.Cells["medium"].Value.ToString();

                EditStudent f = new EditStudent(id, fname, lname, gender, DOB, DOA, nic, tel, address, house, family, grade, admission, medium);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
