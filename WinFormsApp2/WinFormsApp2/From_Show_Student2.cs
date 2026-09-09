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
    public partial class From_Show_Student2 : Form
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
        public From_Show_Student2(string id, string fname, string lname, string gender, string DOB, string DOA, string nic, string tel, string admission, string grade, string medium, string house, string family, string Address)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(connString))
            {
                MessageBox.Show("Connection string is not defined in the configuration file.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            dtp_Doa.Value = Convert.ToDateTime(DOA);
            dtp_Dob.Value = Convert.ToDateTime(DOB);
            txt_Tel.Text = tel;
            txt_Add.Text = Address;
            txt_Adn.Text = admission;

            cmb_Gn.Text = grade;
            txt_Fid.Text = GetMobileByFamilyId(family);
            //txt_Fid.Text = family;
            cmb_Hn.Text = house;
            cmb_Med.Text = medium;


            // --------------GRADE ID--------------------

            string connectionString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connectionString);

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
                //string quer2 = "SELECT * FROM families";
                //MySqlDataAdapter daa = new MySqlDataAdapter(quer2, conn);
                //DataTable dtt = new DataTable();
                //daa.Fill(dtt);

                //cmb_Fid.DataSource = dtt;
                //// what user sees
                //cmb_Fid.DisplayMember = "mobile_number";
                //// hidden value
                //cmb_Fid.ValueMember = "id";
                //// what user sees
                //cmb_Hn.DisplayMember = "house_name";
                //// hidden value
                //cmb_Hn.ValueMember = "id";


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

        private void txt_Fn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
