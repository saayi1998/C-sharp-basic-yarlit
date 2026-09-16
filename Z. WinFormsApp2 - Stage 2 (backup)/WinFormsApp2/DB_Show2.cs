using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class DB_Show2 : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString ?? string.Empty;
        string studentId;

        public DB_Show2(string id)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(connString))
            {
                MessageBox.Show("Connection string is not defined in the configuration file.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.studentId = id;
        }

        private void DB_Show2_Load(object sender, EventArgs e)
        {
            txt_Sid.Text = studentId;

            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Parameterized query - safer + avoids id-format issues
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM students WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", studentId);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No student found with ID: " + studentId);
                        return;
                    }

                    DataRow row = dt.Rows[0];

                    txt_Sid.Text = row["id"].ToString();
                    txt_Fn.Text = row["first_name"].ToString();
                    txt_Ln.Text = row["last_name"].ToString();

                    // fixed: no assignment-in-if, just a plain check
                    if (row["gender"].ToString() == "M")
                        rbn_Male.Checked = true;
                    else
                        rbn_Female.Checked = true;

                    txt_Nic.Text = row["nic_number"].ToString();
                    txt_Tel.Text = row["tele_number"].ToString();
                    txt_Add.Text = row["per_address"].ToString();
                    txt_Adn.Text = row["admission_number"].ToString();

                    //txt_Fid.Text = row["family_id"].ToString();
                    //txt_Fid.Text = GetMobileByFamilyId(txt_Fid.Text);
                    string familyId = row["family_id"].ToString();
                    txt_Fid.Text = GetMobileByFamilyId(familyId);

                    //----------Load grades into ComboBox------------
                    string gradeQuery = "SELECT id, grade_name FROM grades";
                    MySqlDataAdapter gradeAdapter = new MySqlDataAdapter(gradeQuery, conn);
                    DataTable gradeTable = new DataTable();
                    gradeAdapter.Fill(gradeTable);

                    cmb_Gn.DataSource = gradeTable;
                    cmb_Gn.DisplayMember = "grade_name";
                    cmb_Gn.ValueMember = "id";

                    // CHECK your actual column name here: grade_id? or something else?
                    if (dt.Columns.Contains("grade_id") && row["grade_id"] != DBNull.Value)
                    {
                        cmb_Gn.SelectedValue = Convert.ToInt32(row["grade_id"]);
                    }

                    //-----------Load Houses into ComboBox--------------------
                    string houseQuery = "SELECT id, house_name FROM houses";
                    MySqlDataAdapter houseAdapter = new MySqlDataAdapter(houseQuery, conn);
                    DataTable houseTable = new DataTable();
                    houseAdapter.Fill(houseTable);

                    cmb_Hn.DataSource = houseTable;
                    cmb_Hn.DisplayMember = "house_name";
                    cmb_Hn.ValueMember = "id";

                    if (row["house_id"] != DBNull.Value)
                    {
                        cmb_Hn.SelectedValue = Convert.ToInt32(row["house_id"]);
                    }

                    //-------------Load Medium-------------
                    cmb_Med.Text = row["medium"] != DBNull.Value ? row["medium"].ToString() : "N/A";

                    //-----------------Load Families into ComboBox-----------------
                    //string familyQuery = "SELECT id FROM families";
                    //MySqlDataAdapter familyAdapter = new MySqlDataAdapter(familyQuery, conn);
                    //DataTable familyTable = new DataTable();
                    //familyAdapter.Fill(familyTable);

                    //cmb_Fid.DataSource = familyTable;
                    //cmb_Fid.DisplayMember = "id";
                    //cmb_Fid.ValueMember = "id";

                    //if (row["family_id"] != DBNull.Value)
                    //{
                    //    cmb_Fid.SelectedValue = Convert.ToInt32(row["family_id"]);
                    //}

                    //-----------------Date of Birth-----------------
                    dtp_Dob.Value = row["date_of_birth"] != DBNull.Value
                        ? Convert.ToDateTime(row["date_of_birth"])
                        : DateTime.Now;

                    //-----------------Date of Admission-----------------
                    dtp_Doa.Value = row["date_of_admission"] != DBNull.Value
                        ? Convert.ToDateTime(row["date_of_admission"])
                        : DateTime.Now;
                }
                catch (Exception ex)   // broadened so hidden errors actually show up
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetMobileByFamilyId(string familyId)
        {
            string mobile = string.Empty;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT mobile_number FROM families WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", familyId);
                    object result = cmd.ExecuteScalar();
                    mobile = result != null ? result.ToString() : string.Empty;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error fetching guardian mobile number: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return mobile;
        }


    }
}