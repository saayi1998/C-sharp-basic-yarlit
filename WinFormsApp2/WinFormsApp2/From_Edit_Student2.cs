using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using WinFormsApp2.DAL;

namespace WinFormsApp2
{
    public partial class From_Edit_Student2 : Form
    {
        string id;
        string fname;
        string lname;
        string gender;
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
            txt_Sid.ReadOnly = true;

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
                rbn_Male.Checked = true;
            else
                rbn_Female.Checked = true;

            txt_Nic.Text = nic;
            txt_Tel.Text = tel;
            txt_Add.Text = Address;
            txt_Adn.Text = admission;

            try
            {
                FamilyDAL familyDal = new FamilyDAL();
                txt_Fid.Text = familyDal.GetMobileByFamilyId(family);

                // --------------GRADE ID--------------------
                GradeDAL gradeDal = new GradeDAL();
                DataTable dt = gradeDal.GetAllGrade();
                cmb_Gn.DataSource = dt;
                cmb_Gn.DisplayMember = "grade_name";
                cmb_Gn.ValueMember = "id";

                if (!string.IsNullOrEmpty(grade))
                {
                    cmb_Gn.SelectedValue = Convert.ToInt32(grade);
                }

                // --------------HOUSE ID--------------------
                HouseDAL houseDal = new HouseDAL();
                DataTable dtt = houseDal.GetAllHouses();
                cmb_Hn.DataSource = dtt;
                cmb_Hn.DisplayMember = "house_name";
                cmb_Hn.ValueMember = "id";

                if (!string.IsNullOrEmpty(house))
                {
                    cmb_Hn.SelectedValue = Convert.ToInt32(house);
                }

                //-------------------MEDIUM-------------------
                cmb_Med.Items.Clear();
                cmb_Med.Items.AddRange(new string[] { "Sinhala", "Tamil", "English" });

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
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                FamilyDAL familyDal = new FamilyDAL();
                familyDal.UpdateFamilyMobile(family, txt_Fid.Text);

                StudentDAL studentDal = new StudentDAL();
                int affectedRows = studentDal.UpdateStudent(
                    id, txt_Adn.Text, txt_Fn.Text, txt_Ln.Text, txt_Add.Text,
                    dtp_Dob.Value.ToString("yyyy-MM-dd"),
                    dtp_Doa.Value.ToString("yyyy-MM-dd"),
                    txt_Nic.Text, txt_Tel.Text,
                    cmb_Gn.SelectedValue.ToString(), cmb_Hn.SelectedValue.ToString(),
                    cmb_Med.Text, family);

                MessageBox.Show("Update Successfully. Row affected: " + affectedRows, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
            }
        }
    }
}