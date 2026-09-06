using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class From_Edit_Grade2 : Form
    {
        string id;
        string grade_name;
        string grade_group;
        string grade_order;
        string colour;
        public From_Edit_Grade2(string id, string grade_name, string grade_group, string grade_order, string colour)
        {
            InitializeComponent();
            LoadNextGradeId();
            this.id = id;
            this.grade_name = grade_name;
            this.grade_group = grade_group;
            this.grade_order = grade_order;
            this.colour = colour;
        }

        private void From_Edit_Grade2_Load(object sender, EventArgs e)
        {
            txt_Gid.Text = id;
            txt_Grn.Text = grade_name;
            txt_Grg.Text = grade_group;
            txt_Gro.Text = grade_order;
          
            panel1.BackColor = ColorTranslator.FromHtml(colour);
            selectedColourHex = colour;


        }
        private string selectedColourHex; // add this field near the top with the others

        private void btn_Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color chosen = colorDialog1.Color;
                selectedColourHex = ColorTranslator.ToHtml(chosen);
                panel1.BackColor = chosen;
            }
        }

        private void LoadNextGradeId()
        {
            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(MAX(id), 0) + 1 FROM grades", conn);
                    object result = cmd.ExecuteScalar();
                    txt_Gid.Text = result.ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error generating grade ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"update grades set grade_name='{txt_Grn.Text}',grade_group='{txt_Grg.Text}',grade_order='{txt_Gro.Text}',colour='{selectedColourHex}' where id={this.id}", conn);

                string affectedRows = cmd.ExecuteNonQuery().ToString();
                MessageBox.Show("Update Successfully.Row affected" + affectedRows, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while connection to the database" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
