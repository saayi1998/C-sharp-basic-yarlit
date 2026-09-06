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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp2
{
    public partial class DB_Form2 : Form
    {
        public DB_Form2()
        {
            InitializeComponent();
            txt_Sid.ReadOnly = true;
            LoadNextStudentId();
            LoadDropdowns();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
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

        private void LoadNextStudentId()
        {
            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(MAX(id), 0) + 1 FROM students", conn);
                    object result = cmd.ExecuteScalar();
                    txt_Sid.Text = result.ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error generating student ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadDropdowns()
        {
            string connectionString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    //Grade ID
                    MySqlDataAdapter daGrade = new MySqlDataAdapter("SELECT * FROM grades", conn);
                    DataTable dtGrade = new DataTable();
                    daGrade.Fill(dtGrade);
                    cmb_Gn.DataSource = dtGrade;
                    cmb_Gn.DisplayMember = "grade_name";
                    cmb_Gn.ValueMember = "id";


                    // HOUSE ID
                    MySqlDataAdapter daHouse = new MySqlDataAdapter("SELECT * FROM houses", conn);
                    DataTable dtHouse = new DataTable();
                    daHouse.Fill(dtHouse);
                    cmb_Hn.DataSource = dtHouse;
                    cmb_Hn.DisplayMember = "house_name";
                    cmb_Hn.ValueMember = "id";

                    // FAMILY ID
                    MySqlDataAdapter daFamily = new MySqlDataAdapter("SELECT * FROM families", conn);
                    DataTable dtFamily = new DataTable();
                    daFamily.Fill(dtFamily);
                    cmb_Fid.DataSource = dtFamily;
                    cmb_Fid.DisplayMember = "family_name"; // adjust to your actual column name
                    cmb_Fid.ValueMember = "id";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error occurred while loading dropdown data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // MEDIUM — Option A: fixed list, no database table (most common case)
            cmb_Med.Items.Clear();
            cmb_Med.Items.AddRange(new string[] { "Sinhala", "Tamil", "English" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_AllStudent_Click(object sender, EventArgs e)
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
                dgv_Student.DataSource = dt;
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

        private void btn_AllGradeLoad_Click(object sender, EventArgs e)
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

                cmb_Gn.DataSource = dt;
                cmb_Gn.DisplayMember = "grade_name"; // column showing grade name in the dropdown
                cmb_Gn.ValueMember = "id";           // primary key column of the grades table
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
            MessageBox.Show(cmb_Gn.SelectedValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmb_Gn.SelectedValue = 10;
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                if (dgv_Student.Rows.Count == 0)
                {
                    MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string studentId = dgv_Student.CurrentRow.Cells["id"].Value.ToString();
                txt_Sid.Text = studentId;

                string fname = dgv_Student.CurrentRow.Cells["first_name"].Value.ToString();
                txt_Fn.Text = fname;

                string lname = dgv_Student.CurrentRow.Cells["last_name"].Value.ToString();
                txt_Ln.Text = lname;

                if (dgv_Student.CurrentRow.Cells["gender"].Value.ToString() == "M")
                {
                    rbn_Male.Checked = true;
                }
                else
                {
                    rbn_Female.Checked = true;
                }

                string dob = dgv_Student.CurrentRow.Cells["date_of_birth"].Value.ToString();
                if (!string.IsNullOrEmpty(dob) && DateTime.TryParse(dob, out DateTime dobValue) && dobValue >= dtp_Dob.MinDate)
                {
                    dtp_Dob.Value = dobValue;
                }
                else
                {
                    dtp_Dob.Value = DateTime.Now; // fallback for missing/invalid dates
                }

                string doa = dgv_Student.CurrentRow.Cells["date_of_admission"].Value.ToString();
                if (!string.IsNullOrEmpty(doa) && DateTime.TryParse(doa, out DateTime doaValue) && doaValue >= dtp_Doa.MinDate)
                {
                    dtp_Doa.Value = doaValue;
                }
                else
                {
                    dtp_Doa.Value = DateTime.Now; // fallback for missing/invalid dates
                }
                string nic = dgv_Student.CurrentRow.Cells["nic_number"].Value.ToString();
                txt_Nic.Text = nic;

                string tel = dgv_Student.CurrentRow.Cells["tele_number"].Value.ToString();
                txt_Tel.Text = tel;

                string address = dgv_Student.CurrentRow.Cells["per_address"].Value.ToString();
                txt_Add.Text = address;

                string admission = dgv_Student.CurrentRow.Cells["admission_number"].Value.ToString();
                txt_Adn.Text = admission;

                string grade = dgv_Student.CurrentRow.Cells["grade_id"].Value.ToString();

                string house = dgv_Student.CurrentRow.Cells["house_id"].Value.ToString();
                cmb_Hn.SelectedValue = house;

                string family = dgv_Student.CurrentRow.Cells["family_id"].Value.ToString();
                cmb_Fid.SelectedValue = family;

                string medium = dgv_Student.CurrentRow.Cells["medium"].Value.ToString();
                cmb_Med.SelectedValue = medium;



                // ---------------------GRADE ID---------------------------


                conn.Open();

                string query = "SELECT * FROM grades";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmb_Gn.DataSource = dt;
                // what user sees
                cmb_Gn.DisplayMember = "grade_name";
                // hidden value
                cmb_Gn.ValueMember = "id";


                // select student's grade
                if (!string.IsNullOrEmpty(grade))
                {
                    cmb_Gn.SelectedValue = Convert.ChangeType(grade, dt.Columns["id"].DataType);
                }


                //------------ HOUSE NAME---------------------------
                string queryy = "SELECT * FROM houses";
                MySqlDataAdapter daa = new MySqlDataAdapter(queryy, conn);
                DataTable dtt = new DataTable();
                daa.Fill(dtt);

                cmb_Hn.DataSource = dtt;
                // what user sees
                cmb_Hn.DisplayMember = "house_name";
                // hidden value
                cmb_Hn.ValueMember = "id";


                // select student's house
                if (!string.IsNullOrEmpty(house))
                {
                    cmb_Hn.SelectedValue = Convert.ToInt32(house);
                }


                // ---------------------FAMILY ID---------------------------
                string queryyyy = "SELECT * FROM families";
                MySqlDataAdapter daaa = new MySqlDataAdapter(queryyyy, conn);
                DataTable dttt = new DataTable();
                daaa.Fill(dttt);

                cmb_Fid.DataSource = dttt;
                // what user sees
                cmb_Fid.DisplayMember = "family_name";
                // hidden value
                cmb_Fid.ValueMember = "id";


                if (family != "")
                {
                    cmb_Fid.SelectedValue = Convert.ToInt32(family);
                }


                // ---------------------MEDIUM---------------------------

                if (medium != "")
                {
                    cmb_Med.Text = medium;
                }

                // MEDIUM — fixed list, no database table
                cmb_Med.Items.Clear();
                cmb_Med.Items.AddRange(new string[] { "Sinhala", "Tamil", "English" });

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error occurred while fetching student data.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                if (dgv_Student.Rows.Count == 0)
                {
                    MessageBox.Show("No records found.", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string studentId = dgv_Student.CurrentRow.Cells["id"].Value.ToString();

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

        private void btn_PopShow_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {

                string id = dgv_Student.CurrentRow.Cells["id"].Value.ToString();
                string fname = dgv_Student.CurrentRow.Cells["first_name"].Value.ToString();
                string lname = dgv_Student.CurrentRow.Cells["last_name"].Value.ToString();
                string gender = dgv_Student.CurrentRow.Cells["gender"].Value.ToString();
                string DOB = Convert.ToDateTime(dgv_Student.CurrentRow.Cells["date_of_birth"].Value).ToString("yyyy-MM-dd");
                string DOA = Convert.ToDateTime(dgv_Student.CurrentRow.Cells["date_of_admission"].Value).ToString("yyyy-MM-dd");
                string nic = dgv_Student.CurrentRow.Cells["nic_number"].Value.ToString();
                string tel = dgv_Student.CurrentRow.Cells["tele_number"].Value.ToString();
                string address = dgv_Student.CurrentRow.Cells["per_address"].Value.ToString();
                string grade = dgv_Student.CurrentRow.Cells["grade_id"].Value.ToString();
                string family = dgv_Student.CurrentRow.Cells["family_id"].Value.ToString();
                string house = dgv_Student.CurrentRow.Cells["house_id"].Value.ToString();
                string admission = dgv_Student.CurrentRow.Cells["admission_number"].Value.ToString();
                string medium = dgv_Student.CurrentRow.Cells["medium"].Value.ToString();


                From_Show_Student2 f = new From_Show_Student2(id, fname, lname, gender, DOB, DOA, nic, tel, admission, grade, medium, house, family, address);
                f.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_DirectDBShow_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {

                string id = dgv_Student.CurrentRow.Cells["id"].Value.ToString();
                string fname = dgv_Student.CurrentRow.Cells["first_name"].Value.ToString();
                string lname = dgv_Student.CurrentRow.Cells["last_name"].Value.ToString();
                string gender = dgv_Student.CurrentRow.Cells["gender"].Value.ToString();
                string DOB = Convert.ToDateTime(dgv_Student.CurrentRow.Cells["date_of_birth"].Value).ToString("yyyy-MM-dd");
                string DOA = Convert.ToDateTime(dgv_Student.CurrentRow.Cells["date_of_admission"].Value).ToString("yyyy-MM-dd");
                string nic = dgv_Student.CurrentRow.Cells["nic_number"].Value.ToString();
                string tel = dgv_Student.CurrentRow.Cells["tele_number"].Value.ToString();
                string address = dgv_Student.CurrentRow.Cells["per_address"].Value.ToString();
                string grade = dgv_Student.CurrentRow.Cells["grade_id"].Value.ToString();
                string family = dgv_Student.CurrentRow.Cells["family_id"].Value.ToString();
                string house = dgv_Student.CurrentRow.Cells["house_id"].Value.ToString();
                string admission = dgv_Student.CurrentRow.Cells["admission_number"].Value.ToString();
                string medium = dgv_Student.CurrentRow.Cells["medium"].Value.ToString();


                DB_Show2 ff = new DB_Show2(id);
                ff.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (cmb_Gn.SelectedValue == null || cmb_Hn.SelectedValue == null || cmb_Fid.SelectedValue == null)
            {
                MessageBox.Show("Please select Grade, House, and Family before inserting.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand($"INSERT INTO students(id,first_name, last_name, gender, grade_id,date_of_birth,date_of_admission,admission_number,nic_number,tele_number,per_address,medium,house_id,family_id) " + $"VALUES('{txt_Sid.Text}','{txt_Fn.Text}', '{txt_Ln.Text}', '{(rbn_Male.Checked ? "M" : "F")}', '{cmb_Gn.SelectedValue}', '{dtp_Dob.Value.ToString("yyyy-MM-dd")}', '{dtp_Doa.Value.ToString("yyyy-MM-dd")}', '{txt_Adn.Text}', '{txt_Nic.Text}', '{txt_Tel.Text}', '{txt_Add.Text}','{cmb_Med.Text}', '{cmb_Hn.SelectedValue}', '{cmb_Fid.SelectedValue}')", conn);

                string affectedRows = cmd.ExecuteNonQuery().ToString();

                MessageBox.Show($"Inserted successfully. Row(s) affected: {affectedRows}", "Insert Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while inserting the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (dgv_Student.CurrentRow == null)
                {
                    MessageBox.Show("Please select a student first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string id = dgv_Student.CurrentRow.Cells["id"].Value.ToString();
                string fname = dgv_Student.CurrentRow.Cells["first_name"].Value.ToString();
                string lname = dgv_Student.CurrentRow.Cells["last_name"].Value.ToString();
                string gender = dgv_Student.CurrentRow.Cells["gender"].Value.ToString();
                string DOB = Convert.ToDateTime(dgv_Student.CurrentRow.Cells["date_of_birth"].Value).ToString("yyyy-MM-dd");
                string DOA = Convert.ToDateTime(dgv_Student.CurrentRow.Cells["date_of_admission"].Value).ToString("yyyy-MM-dd");
                string nic = dgv_Student.CurrentRow.Cells["nic_number"].Value.ToString();
                string tel = dgv_Student.CurrentRow.Cells["tele_number"].Value.ToString();
                string address = dgv_Student.CurrentRow.Cells["per_address"].Value.ToString();
                string grade = dgv_Student.CurrentRow.Cells["grade_id"].Value.ToString();
                string family = dgv_Student.CurrentRow.Cells["family_id"].Value.ToString();
                string house = dgv_Student.CurrentRow.Cells["house_id"].Value.ToString();
                string admission = dgv_Student.CurrentRow.Cells["admission_number"].Value.ToString();
                string medium = dgv_Student.CurrentRow.Cells["medium"].Value.ToString();


                From_Edit_Student2 f = new From_Edit_Student2(id, fname, lname, gender, DOB, DOA, nic, tel, admission, grade, medium, house, family, address);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
