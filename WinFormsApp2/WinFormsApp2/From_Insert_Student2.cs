using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using WinFormsApp2.DAL;

namespace WinFormsApp2
{
    public partial class From_Insert_Student2 : Form
    {
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

            try
            {
                FamilyDAL familyDal = new FamilyDAL();
                string familyId = familyDal.InsertFamily(txt_Fid.Text);

                StudentDAL studentDal = new StudentDAL();
                int affectedRows = studentDal.InsertStudent(
                    txt_Sid.Text, txt_Fn.Text, txt_Ln.Text,
                    rbn_Male.Checked ? "M" : "F",
                    cmb_Gn.SelectedValue.ToString(),
                    dtp_Dob.Value.ToString("yyyy-MM-dd"),
                    dtp_Doa.Value.ToString("yyyy-MM-dd"),
                    txt_Adn.Text, txt_Nic.Text, txt_Tel.Text, txt_Add.Text,
                    cmb_Med.Text, cmb_Hn.SelectedValue.ToString(), familyId);

                MessageBox.Show("Inserted successfully. Row(s) affected: " + affectedRows, "Insert Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while inserting the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                StudentDAL studentDal = new StudentDAL();
                txt_Sid.Text = studentDal.GetNextStudentId();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error generating student ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDropdowns()
        {
            try
            {
                GradeDAL gradeDal = new GradeDAL();
                DataTable dtGrade = gradeDal.GetAllGrade();
                cmb_Gn.DataSource = dtGrade;
                cmb_Gn.DisplayMember = "grade_name";
                cmb_Gn.ValueMember = "id";

                HouseDAL houseDal = new HouseDAL();
                DataTable dtHouse = houseDal.GetAllHouses();
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