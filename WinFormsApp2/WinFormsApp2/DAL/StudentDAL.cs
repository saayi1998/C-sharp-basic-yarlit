using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace WinFormsApp2.DAL
{
    public class StudentDAL
    {
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString ?? string.Empty;
        public string GetFamilyIdByStudentId(string studentId)   // <-- is this actually in the file?
        {
            string familyId = "";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT family_id FROM students WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", studentId);
                object result = cmd.ExecuteScalar();
                familyId = result != null ? result.ToString() : "";
            }
            finally
            {
                conn.Close();
            }

            return familyId;
        }

        public DataTable GetAllStudents()
        {

            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from students", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                return dt;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while accessing the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    

        public int DeleteStudent(string studentId)
        {
            int affectedRows = 0;
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM students WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", studentId);
                affectedRows = cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }

            return affectedRows;
        }

        public DataTable GetStudentById(string studentId)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM students WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", studentId);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public string GetNextStudentId()
        {
            string nextId = "";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(MAX(id),0)+1 FROM students", conn);
                object result = cmd.ExecuteScalar();
                nextId = result.ToString();
            }
            finally
            {
                conn.Close();
            }

            return nextId;
        }

        public int InsertStudent(string id, string fname, string lname, string gender,string gradeId, string dob, string doa, string admission, string nic, string tel, string address, string medium, string houseId, string familyId)
        {
            int affectedRows = 0;
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO students(id, first_name, last_name, gender, grade_id, date_of_birth, date_of_admission, admission_number, nic_number, tele_number, per_address, medium, house_id, family_id) " +
                    "VALUES(@id, @fname, @lname, @gender, @gradeId, @dob, @doa, @admission, @nic, @tel, @address, @medium, @houseId, @familyId)", conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@gradeId", gradeId);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@doa", doa);
                cmd.Parameters.AddWithValue("@admission", admission);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@medium", medium);
                cmd.Parameters.AddWithValue("@houseId", houseId);
                cmd.Parameters.AddWithValue("@familyId", familyId);

                affectedRows = cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }

            return affectedRows;
        }

        public int UpdateStudent(string id, string admission, string fname, string lname, string address, string dob, string doa, string nic, string tel, string gradeId, string houseId, string medium, string familyId)
        {
            int affectedRows = 0;
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE students SET admission_number=@admission, first_name=@fname, last_name=@lname, " +
                    "per_address=@address, date_of_birth=@dob, date_of_admission=@doa, nic_number=@nic, " +
                    "tele_number=@tel, grade_id=@gradeId, house_id=@houseId, medium=@medium, family_id=@familyId " +
                    "WHERE id=@id", conn);

                cmd.Parameters.AddWithValue("@admission", admission);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@doa", doa);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@gradeId", gradeId);
                cmd.Parameters.AddWithValue("@houseId", houseId);
                cmd.Parameters.AddWithValue("@medium", medium);
                cmd.Parameters.AddWithValue("@familyId", familyId);
                cmd.Parameters.AddWithValue("@id", id);

                affectedRows = cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }

            return affectedRows;
        }

    }
}