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
    public partial class Form_Insert_Grade2 : Form
    {
        string gradeid;
        string gradename;
        string gradegroup;
        string gradeorder;
        private string selectedColourHex;
        public Form_Insert_Grade2(string gradeid, string gradename, string gradegroup, string gradeorder, string selectedColourHex)
        {
            InitializeComponent();
            ClearFields();
            this.gradeid = gradeid;
            this.gradename = gradename;
            this.gradegroup = gradegroup;
            this.gradeorder = gradeorder;
            this.selectedColourHex = selectedColourHex;
        }

        private void Form_Insert_Grade2_Load(object sender, EventArgs e)
        {
            txt_Gid.Text = gradeid;
            txt_Grn.Text = gradename;
            txt_Grg.Text = gradegroup;
            txt_Gro.Text = gradeorder;
            panel1.BackColor = ColorTranslator.FromHtml(selectedColourHex);

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Grn.Text))
            {
                MessageBox.Show("Please enter a grade name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand($"insert into grades(grade_name, grade_group, grade_order, colour) " +
                    $"VALUES('{txt_Grn.Text}', '{txt_Grg.Text}', '{txt_Gro.Text}', '{selectedColourHex}')", conn);

                string affectedRows = cmd.ExecuteNonQuery().ToString();

                MessageBox.Show($"Inserted successfully. Row(s) affected: {affectedRows}", "Insert Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while inserting the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ClearFields()
        {
            txt_Gid.Text = "";
            txt_Grn.Text = "";
            txt_Grg.Text = "";
            txt_Gro.Text = "";
            panel1.BackColor = Color.White;
            selectedColourHex = "#000000";
            btn_Color.Enabled = true;
        }

        private void btn_Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color chosen = colorDialog1.Color;
                selectedColourHex = ColorTranslator.ToHtml(chosen);
                panel1.BackColor = chosen;
            }
        }
    }
}
