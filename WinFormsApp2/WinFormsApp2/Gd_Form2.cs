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
    public partial class Gd_Form2 : Form
    {
        private string selectedColourHex = "#000000"; // holds the picked color's hex value

        public Gd_Form2()
        {
            InitializeComponent();
            LoadNextGradeId();
        }

        private void btn_Allgrade_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from grades", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_Grade.DataSource = dt;
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


        private void Gd_Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Grade.CurrentRow == null)
                {
                    MessageBox.Show("Please select a grade first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txt_Gid.Text = dgv_Grade.CurrentRow.Cells["id"].Value.ToString();
                txt_Grn.Text = dgv_Grade.CurrentRow.Cells["grade_name"].Value.ToString();
                txt_Grg.Text = dgv_Grade.CurrentRow.Cells["grade_group"].Value.ToString();
                txt_Gro.Text = dgv_Grade.CurrentRow.Cells["grade_order"].Value.ToString();

               

                try
                {
                    string colourFromGrid = dgv_Grade.CurrentRow.Cells["colour"].Value.ToString();

                    Color loadedColor = ColorTranslator.FromHtml(colourFromGrid);
                    panel1.BackColor = loadedColor;
                    selectedColourHex = colourFromGrid;
                }
                catch
                {
                    panel1.BackColor = Color.White;
                    selectedColourHex = "#000000";
                }

                btn_Color.Enabled = false; // lock color picker after Show/view
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Grn.Text )) 
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Grade.CurrentRow == null)
                {
                    MessageBox.Show("Please select a grade first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string id = dgv_Grade.CurrentRow.Cells["id"].Value.ToString();
                string gradeName = dgv_Grade.CurrentRow.Cells["grade_name"].Value.ToString();
                string gradeGroup = dgv_Grade.CurrentRow.Cells["grade_group"].Value.ToString();
                string gradeOrder = dgv_Grade.CurrentRow.Cells["grade_order"].Value.ToString();
                string colour = dgv_Grade.CurrentRow.Cells["colour"].Value.ToString();


                From_Edit_Grade2 f = new From_Edit_Grade2(id, gradeName, gradeGroup, gradeOrder, colour);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            string connString = "Server=localhost;Port=3307;Database=school;Uid=root;Pwd=;";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                if (dgv_Grade.Rows.Count == 0)
                {
                    MessageBox.Show("No records found.", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string Gradeid = dgv_Grade.CurrentRow.Cells["id"].Value.ToString();
                string gradeName = dgv_Grade.CurrentRow.Cells["grade_name"].Value.ToString();

                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete grade '{gradeName}' (ID: {Gradeid})?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                {
                    return; // user clicked No, cancel the delete
                }


                conn.Open();

                MySqlCommand cmd = new MySqlCommand($"DELETE FROM grades WHERE id = '{Gradeid}'", conn);
                string affectedRows = cmd.ExecuteNonQuery().ToString();

                MessageBox.Show($"Deleted successfully. Row(s) affected: {affectedRows}", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while deleting the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }

}
