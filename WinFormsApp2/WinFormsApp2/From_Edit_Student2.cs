using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp2
{
    public partial class From_Edit_Student2 : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString ?? string.Empty;
        string id;
        string fname;
        string lname;
        String gender;
        string DOB;
        string DOA;
        string nic;
        string tel;
        string admission;
        string grade;
        string medium;
        string house;
        string family;
        string Address;
        public From_Edit_Student2(string id, string fname, string lname, string gender, string DOB, string DOA, string nic, string tel, string admission, string grade, string medium, string house, string family, string Address)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(connString))
            {
                MessageBox.Show("Connection string is not defined in the configuration file.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_Sid.ReadOnly = true;
            LoadDropdowns();

            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.gender = gender;
            this.DOB = DOB;
            this.DOA = DOA;
            this.nic = nic;
            this.tel = tel;
            this.admission = admission;
            this.grade = grade;
            this.medium = medium;
            this.house = house;
            this.family = family;
            this.Address = Address;
        }

        private void From_Show_Student_Load(object sender, EventArgs e)
        {
            txt_Sid.Text = id;
            txt_Fn.Text = fname;
            txt_Ln.Text = lname;
            if (gender == "M")
            {
                rbn_Male.Checked = true;
            }
            else
            {
                rbn_Female.Checked = true;
            }
            txt_Nic.Text = nic;
            txt_Tel.Text = tel;
            txt_Add.Text = Address;
            txt_Adn.Text = admission;

            txt_Fid.Text = GetMobileByFamilyId(family);

            dtp_Doa.Value = Convert.ToDateTime(DOA);
            dtp_Dob.Value = Convert.ToDateTime(DOB);

            cmb_Gn.Text = grade;
            cmb_Hn.Text = house;
            cmb_Med.Text = medium;


            // --------------GRADE ID--------------------

            //string connectionString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
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
                    cmb_Gn.SelectedValue = Convert.ToInt32(grade);
                }


                // --------------HOUSE ID--------------------
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

                //----------- FAMILY ID----------------
                //if (family != "")
                //{
                //    cmb_Fid.SelectedValue = Convert.ToInt32(family);
                //}

                //-------------------MEDIUM-------------------
                if (medium != "")
                {
                    cmb_Med.Text = medium;
                }

                // ----------------DATE OF BIRTH--------------------
                if (DOB != "")
                {
                    dtp_Dob.Value = Convert.ToDateTime(DOB);
                }


                // ------------DATE OF ADMISSION--------------------

                if (DOA != "")
                {
                    dtp_Doa.Value = Convert.ToDateTime(DOA);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
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

        private void LoadDropdowns()
        {
           // string connectionString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // HOUSE ID
                    MySqlDataAdapter daHouse = new MySqlDataAdapter("SELECT * FROM houses", conn);
                    DataTable dtHouse = new DataTable();
                    daHouse.Fill(dtHouse);
                    cmb_Hn.DataSource = dtHouse;
                    cmb_Hn.DisplayMember = "house_name";
                    cmb_Hn.ValueMember = "id";

                    // FAMILY ID
                    //MySqlDataAdapter daFamily = new MySqlDataAdapter("SELECT * FROM families", conn);
                    //DataTable dtFamily = new DataTable();
                    //daFamily.Fill(dtFamily);
                    //cmb_Fid.DataSource = dtFamily;
                    //cmb_Fid.DisplayMember = "family_name"; // adjust to your actual column name
                    //cmb_Fid.ValueMember = "id";
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                // 1. Update the family's mobile number directly (family_id doesn't change)
                MySqlCommand updateFamilyCmd = new MySqlCommand($"update families set mobile_number='{txt_Fid.Text}' where id='{family}'", conn);
                updateFamilyCmd.ExecuteNonQuery();

                // 2. Update student record (family_id stays the same as before)
                MySqlCommand cmd = new MySqlCommand($"update students set admission_number='{txt_Adn.Text}',first_name='{txt_Fn.Text}',last_name='{txt_Ln.Text}',per_address='{txt_Add.Text}',date_of_birth='{dtp_Dob.Value.ToString("yyyy-MM-dd")}',date_of_admission='{dtp_Doa.Value.ToString("yyyy-MM-dd")}',nic_number='{txt_Nic.Text}',tele_number='{txt_Tel.Text}',grade_id='{cmb_Gn.SelectedValue}',house_id='{cmb_Hn.SelectedValue}',medium='{cmb_Med.Text}',family_id='{family}' where id={this.id}", conn);

                string affectedRows = cmd.ExecuteNonQuery().ToString();
                MessageBox.Show("Update Successfully.Row affected" + affectedRows, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while connection to the database" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            //string connectionString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            //MySqlConnection conn = new MySqlConnection(connString);

            //try
            //{
            //    conn.Open();
            //    MySqlCommand cmd = new MySqlCommand($"update students set admission_number='{txt_Adn.Text}',first_name='{txt_Fn.Text}',last_name='{txt_Ln.Text}',per_address='{txt_Add.Text}',date_of_birth='{dtp_Dob.Value.ToString("yyyy-MM-dd")}',date_of_admission='{dtp_Doa.Value.ToString("yyyy-MM-dd")  }',nic_number='{txt_Nic.Text}',tele_number='{txt_Tel.Text}',grade_id='{cmb_Gn.SelectedValue}',house_id='{cmb_Hn.SelectedValue}',medium='{cmb_Med.Text}',family_id='{family}' where id={this.id}", conn);

            //    string affectedRows = cmd.ExecuteNonQuery().ToString();
            //    MessageBox.Show("Update Successfully.Row affected" + affectedRows, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
            //catch (MySqlException ex)
            //{
            //    MessageBox.Show("An error occurred while connection to the database" + ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }
    }
}
