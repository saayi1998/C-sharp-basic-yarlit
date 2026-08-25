using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            try {
                if (cmbAO.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an operation from the dropdown.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                else if (cmbAO.SelectedIndex == 0)
                {
                    txtR.Text = (Convert.ToInt32(txtF.Text) + Convert.ToInt32(txtS.Text)).ToString();
                }
                else if (cmbAO.SelectedIndex == 1)
                {
                    txtR.Text = (Convert.ToInt32(txtF.Text) - Convert.ToInt32(txtS.Text)).ToString();
                }
                else if (cmbAO.SelectedIndex == 2)
                {
                    txtR.Text = (Convert.ToInt32(txtF.Text) * Convert.ToInt32(txtS.Text)).ToString();
                }
                else if (cmbAO.SelectedIndex == 3)
                {
                    txtR.Text = (Convert.ToInt32(txtF.Text) / Convert.ToInt32(txtS.Text)).ToString();
                }
                }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Please enter valid numbers and select an operation."); 
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero. Please enter a valid divisor.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                MessageBox.Show("Operation completed.");
            }   

        }
    }
}
