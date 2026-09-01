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
    public partial class DBshow : Form
    {
        string studentId;
        public DBshow(string id)
        {
            InitializeComponent();
            this.studentId = id;
        }
    

    private void DBshow_Load(object sender, EventArgs e)
    {
        txtF1.Text = studentId;

            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connString);

            try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand($"select * from students where id = {this.studentId}", conn);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    txtF1.Text = row["id"].ToString();
                    txtL1.Text = row["first_name"].ToString();
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

