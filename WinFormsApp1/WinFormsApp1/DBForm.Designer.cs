namespace WinFormsApp1
{
    partial class DBForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnC = new Button();
            btnA = new Button();
            dgvStu = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStu).BeginInit();
            SuspendLayout();
            // 
            // btnC
            // 
            btnC.Location = new Point(102, 29);
            btnC.Name = "btnC";
            btnC.Size = new Size(171, 56);
            btnC.TabIndex = 0;
            btnC.Text = "Connect";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnA
            // 
            btnA.BackColor = Color.Transparent;
            btnA.Location = new Point(356, 29);
            btnA.Name = "btnA";
            btnA.Size = new Size(171, 56);
            btnA.TabIndex = 0;
            btnA.Text = "All Student";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnA_Click;
            // 
            // dgvStu
            // 
            dgvStu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStu.Location = new Point(48, 103);
            dgvStu.Name = "dgvStu";
            dgvStu.RowHeadersWidth = 51;
            dgvStu.Size = new Size(553, 335);
            dgvStu.TabIndex = 1;
            // 
            // DBForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 450);
            Controls.Add(dgvStu);
            Controls.Add(btnA);
            Controls.Add(btnC);
            Name = "DBForm";
            Text = "DBForm";
            ((System.ComponentModel.ISupportInitialize)dgvStu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnC;
        private Button btnA;
        private DataGridView dgvStu;
    }
}