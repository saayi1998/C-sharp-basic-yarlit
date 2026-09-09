using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class From_Insert_Student2 : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString ?? string.Empty;


        public From_Insert_Student2()
        {
            InitializeComponent();
            ClearFields();
        }

        private void From_Insert_Student2_Load(object sender, EventArgs e)
        {
            LoadNextStudentId();
            LoadDropdowns();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (cmb_Gn.SelectedValue == null || cmb_Hn.SelectedValue == null)
            {
                MessageBox.Show("Please select Grade and House before inserting.");
                return;
            }

            string connectionString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                string familyId = "";

                // 1. Create new family record using mobile number
                MySqlCommand familyCmd = new MySqlCommand("INSERT INTO families(mobile_number) VALUES('" + txt_Fid.Text + "')",conn);
                familyCmd.ExecuteNonQuery();

                // 2. Get newly created family id
                MySqlCommand getFamilyIdCmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);
                familyId = getFamilyIdCmd.ExecuteScalar().ToString();

                // 3. Insert student with generated family id
                MySqlCommand cmd = new MySqlCommand("INSERT INTO students(id, first_name, last_name, gender, grade_id, date_of_birth, date_of_admission, admission_number, nic_number, tele_number, per_address, medium, house_id, family_id) VALUES('" + txt_Sid.Text + "','" + txt_Fn.Text + "','" + txt_Ln.Text + "','" + (rbn_Male.Checked ? "M" : "F") + "','" + cmb_Gn.SelectedValue + "','" + dtp_Dob.Value.ToString("yyyy-MM-dd") + "','" + dtp_Doa.Value.ToString("yyyy-MM-dd") + "','" + txt_Adn.Text + "','" + txt_Nic.Text + "','" + txt_Tel.Text + "','" + txt_Add.Text + "','" + cmb_Med.Text + "','" + cmb_Hn.SelectedValue + "','" + familyId + "')", conn);
                int affectedRows = cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted successfully. Row(s) affected: " + affectedRows,"Insert Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);

                ClearFields();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while inserting the data: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ClearFields()
        {

            txt_Sid.Text = "";
            txt_Fn.Text = "";
            txt_Ln.Text = "";
            txt_Nic.Text = "";
            txt_Tel.Text = "";
            txt_Fid.Text = "";
            txt_Add.Text = "";
            txt_Adn.Text = "";   

            dtp_Doa.Value = DateTime.Now;
            dtp_Dob.Value = DateTime.Now;
            cmb_Med.SelectedIndex = -1;
            cmb_Gn.SelectedIndex = -1;
            cmb_Hn.SelectedIndex = -1;
        }

        private void LoadNextStudentId()
        {

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(MAX(id),0)+1 FROM students",conn);
                    object result = cmd.ExecuteScalar();
                    txt_Sid.Text = result.ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error generating student ID: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

        }

        private void LoadDropdowns()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
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


                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error occurred while loading dropdown data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}