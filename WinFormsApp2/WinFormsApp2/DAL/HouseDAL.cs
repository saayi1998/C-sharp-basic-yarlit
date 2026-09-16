using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace WinFormsApp2.DAL
{
    public class HouseDAL
    {
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString ?? string.Empty;
        public DataTable GetAllHouses()
        {
            
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM houses", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
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
