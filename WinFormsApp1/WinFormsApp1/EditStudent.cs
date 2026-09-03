using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace WinFormsApp1
{
    public partial class EditStudent : Form
    {
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

        public EditStudent(string fname, string lname, string gender, string DOB, string DOA, string nic, string tel, string address, string house, string family, string grade, string admission, string medium)
        {
            InitializeComponent();
            this.fname = fname;
            this.lname = lname;
            this.gender = gender;
            this.DOB = DOB;
            this.DOA = DOA;
            this.nic = nic;
            this.tel = tel;
            this.Address = address;
            this.admission = admission;
            this.house = house;
            this.family = family;
            this.grade = grade;
            this.medium = medium;   

        }

        private void ShowStudent_Load(object sender, EventArgs e)
        {
            txtF1.Text = fname;
            txtL.Text = lname;
            if (gender == "M")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            txtNIC.Text = nic;
            txtTel.Text = tel;
            txtADD.Text = Address;
            txtadn.Text = admission;    

            cmbGr.Text = grade;
            cmbFid.Text = family;
            cmbHid.Text = house;
            cmbM.Text = medium;


            // GRADE ID

            string connectionString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();


                string query = "SELECT * FROM grades";
                MySqlDataAdapter da =
                new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbGr.DataSource = dt;
                // what user sees
                cmbGr.DisplayMember = "grade_name";
                // hidden value
                cmbGr.ValueMember = "id";


                // select student's grade
                if (!string.IsNullOrEmpty(grade))
                {
                    cmbGr.SelectedValue =Convert.ToInt32(grade);
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
            

            // HOUSE ID
            if (house != "")
            { 
                cmbHid.SelectedValue = Convert.ToInt32(house);
            }
           

            // FAMILY ID
            if (family != "")
            {
                cmbFid.SelectedValue = Convert.ToInt32(family);
            }

            // MEDIUM
            if (medium != "")
            {
                cmbM.Text = medium;
            }

            // DATE OF BIRTH
            if (DOB != "") 
            {
                dtpDOB.Value = Convert.ToDateTime(DOB);
            }


            // DATE OF ADMISSION

            if (DOA != "")
            {
                dtpDOA.Value = Convert.ToDateTime(DOA);
            }
        }
             
    }
}