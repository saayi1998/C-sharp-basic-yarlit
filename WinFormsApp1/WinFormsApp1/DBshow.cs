using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DBshow : Form
    {
        string studentId;
        public DBshow(string id)
        {
            InitializeComponent();
            this.studentId = id;
        }


        private void DBshow_Load(object sender, EventArgs e)
        {
            txtID.Text = studentId;

            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"select * from students where id = {this.studentId}", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow row = dt.Rows[0];

                txtID.Text = row["id"].ToString();
                txtF1.Text = row["first_name"].ToString();
                txtL.Text = row["last_name"].ToString();
                if (radioButton1.Checked = row["gender"].ToString() == "M")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                txtNIC.Text = row["nic_number"].ToString();
                txtTel.Text = row["tele_number"].ToString();
                txtADD.Text = row["per_address"].ToString();
                txtadn.Text = row["admission_number"].ToString();

                //----------Load grades into ComboBox------------
                string gradeQuery = "SELECT id, grade_name FROM grades";
                MySqlDataAdapter gradeAdapter = new MySqlDataAdapter(gradeQuery, conn);
                DataTable gradeTable = new DataTable();
                gradeAdapter.Fill(gradeTable);

                cmbGrr.DataSource = gradeTable;
                cmbGrr.DisplayMember = "grade_name";
                cmbGrr.ValueMember = "id";

                //-----------Load Houses into ComboBox--------------------
                string houseQuery = "SELECT id, house_name FROM houses";

                MySqlDataAdapter houseAdapter = new MySqlDataAdapter(houseQuery, conn);
                DataTable houseTable = new DataTable();
                houseAdapter.Fill(houseTable);

                cmbHid.DataSource = houseTable;
                cmbHid.DisplayMember = "house_name";
                cmbHid.ValueMember = "id";

                if (row["house_id"] != DBNull.Value)
                {
                    cmbHid.SelectedValue = Convert.ToInt32(row["house_id"]);
                }

                //-------------Load Medium into ComboBoxes-------------        
                if (row["medium"] != DBNull.Value)
                {
                    cmbM.Text = row["medium"].ToString();
                }
                else
                {
                    cmbM.Text = "N/A";
                }

                //-----------------Load Families into ComboBox-----------------

                string familyQuery = "SELECT id FROM families ";

                MySqlDataAdapter familyAdapter = new MySqlDataAdapter(familyQuery, conn);
                DataTable familyTable = new DataTable();
                familyAdapter.Fill(familyTable);

                cmbFid.DataSource = familyTable;
                cmbFid.DisplayMember = "family_name";
                cmbFid.ValueMember = "id";

                if (row["family_id"] != DBNull.Value)
                {
                    cmbFid.SelectedValue = Convert.ToInt32(row["family_id"]);
                }

                // -----------------Load Date of Birth into DateTimePicker-----------------

                if (row["date_of_birth"] != DBNull.Value)

                {
                    dtpDOB.Value =
                        Convert.ToDateTime(row["date_of_birth"]);
                }

                else
                {
                    dtpDOB.Value = DateTime.Now;
                }

                // -----------------Load Date of Admission into DateTimePicker-----------------

                if (row["date_of_admission"] != DBNull.Value)

                {
                    dtpDOA.Value =
                        Convert.ToDateTime(row["date_of_admission"]);
                }

                else
                {
                    dtpDOA.Value = DateTime.Now;
                }


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

        private void cmbM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbHid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

