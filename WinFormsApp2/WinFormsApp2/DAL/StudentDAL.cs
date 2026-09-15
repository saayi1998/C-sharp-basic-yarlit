using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using WinFormsApp2.DAL;

namespace WinFormsApp2.DAL
{
    public class StudentDAL
    {
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString ?? string.Empty;
        public void studentConnect()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MessageBox.Show("Conncection Successful", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable GetAll()
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
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable DirectDBShow(string id)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM students WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while accessing the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt;
            }
            finally
            {
                conn.Close();
            }

        }

        public DataTable GetById(string id)
        {
            // Reuse existing DirectDBShow implementation to avoid duplicate code
            return DirectDBShow(id);
        }

        public DataTable GetAllGrades()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM grades", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while accessing the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }

        public int DeleteStudent(string id)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                // Delete student
                MySqlCommand cmd = new MySqlCommand("DELETE FROM students WHERE id = @id",conn);
                cmd.Parameters.AddWithValue("@id", id);
                int affectedRows = cmd.ExecuteNonQuery();

                return affectedRows;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while deleting data: " + ex.Message,"Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
