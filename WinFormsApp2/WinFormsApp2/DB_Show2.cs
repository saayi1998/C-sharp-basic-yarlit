using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using WinFormsApp2.DAL;

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

            try
            {
                StudentDAL studentDal = new StudentDAL();
                DataTable dt = studentDal.GetStudentById(studentId);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No student found with ID: " + studentId);
                    return;
                }

                DataRow row = dt.Rows[0];

                txt_Sid.Text = row["id"].ToString();
                txt_Fn.Text = row["first_name"].ToString();
                txt_Ln.Text = row["last_name"].ToString();

                if (row["gender"].ToString() == "M")
                    rbn_Male.Checked = true;
                else
                    rbn_Female.Checked = true;

                txt_Nic.Text = row["nic_number"].ToString();
                txt_Tel.Text = row["tele_number"].ToString();
                txt_Add.Text = row["per_address"].ToString();
                txt_Adn.Text = row["admission_number"].ToString();

                string familyId = row["family_id"].ToString();
                FamilyDAL familyDal = new FamilyDAL();
                txt_Fid.Text = familyDal.GetMobileByFamilyId(familyId);

                //----------Load grades into ComboBox------------
                GradeDAL gradeDal = new GradeDAL();
                DataTable gradeTable = gradeDal.GetAllGrade();

                cmb_Gn.DataSource = gradeTable;
                cmb_Gn.DisplayMember = "grade_name";
                cmb_Gn.ValueMember = "id";

                if (dt.Columns.Contains("grade_id") && row["grade_id"] != DBNull.Value)
                {
                    cmb_Gn.SelectedValue = Convert.ToInt32(row["grade_id"]);
                }

                //-----------Load Houses into ComboBox--------------------
                HouseDAL houseDal = new HouseDAL();
                DataTable houseTable = houseDal.GetAllHouses();

                cmb_Hn.DataSource = houseTable;
                cmb_Hn.DisplayMember = "house_name";
                cmb_Hn.ValueMember = "id";

                if (row["house_id"] != DBNull.Value)
                {
                    cmb_Hn.SelectedValue = Convert.ToInt32(row["house_id"]);
                }

                //-------------Load Medium-------------
                cmb_Med.Text = row["medium"] != DBNull.Value ? row["medium"].ToString() : "N/A";

                //-----------------Date of Birth-----------------
                dtp_Dob.Value = row["date_of_birth"] != DBNull.Value
                    ? Convert.ToDateTime(row["date_of_birth"])
                    : DateTime.Now;

                //-----------------Date of Admission-----------------
                dtp_Doa.Value = row["date_of_admission"] != DBNull.Value
                    ? Convert.ToDateTime(row["date_of_admission"])
                    : DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}