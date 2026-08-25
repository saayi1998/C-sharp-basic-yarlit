using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DBForm : Form
    {
        public DBForm()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3307;Database=school_system;Uid=root;Pwd=;";
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

        private void btnA_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3307;Database=school_system;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from students", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStu.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while accessing the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            { 
                conn.Close(); 
            }
           
        }
    }
}
