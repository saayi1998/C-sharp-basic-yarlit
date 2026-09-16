using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using WinFormsApp2;

namespace WinFormsApp2.DAL
{
    public class GradeDAL
    {
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString ?? string.Empty;

        public DataTable GetAllGrade()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from grades", conn);
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

    }
}
