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
            lblF = new Label();
            lblL = new Label();
            btnSW = new Button();
            txtF = new TextBox();
            txtL = new TextBox();
            lblGrd = new Label();
            cmbLG = new ComboBox();
            btnLG = new Button();
            button111 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStu).BeginInit();
            SuspendLayout();
            // 
            // btnC
            // 
            btnC.Location = new Point(48, 29);
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
            btnA.Location = new Point(244, 29);
            btnA.Name = "btnA";
            btnA.Size = new Size(171, 56);
            btnA.TabIndex = 0;
            btnA.Text = "All Students";
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
            // lblF
            // 
            lblF.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblF.Location = new Point(628, 130);
            lblF.Name = "lblF";
            lblF.Size = new Size(110, 32);
            lblF.TabIndex = 2;
            lblF.Text = "First Name ";
            lblF.Click += lblF_Click;
            // 
            // lblL
            // 
            lblL.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblL.Location = new Point(628, 190);
            lblL.Name = "lblL";
            lblL.Size = new Size(110, 32);
            lblL.TabIndex = 2;
            lblL.Text = "Last Name ";
            // 
            // btnSW
            // 
            btnSW.Location = new Point(761, 29);
            btnSW.Name = "btnSW";
            btnSW.Size = new Size(254, 56);
            btnSW.TabIndex = 3;
            btnSW.Text = "Show";
            btnSW.UseMnemonic = false;
            btnSW.UseVisualStyleBackColor = true;
            btnSW.Click += btnSW_Click;
            // 
            // txtF
            // 
            txtF.Location = new Point(776, 130);
            txtF.Name = "txtF";
            txtF.Size = new Size(239, 27);
            txtF.TabIndex = 5;
            // 
            // txtL
            // 
            txtL.Location = new Point(776, 190);
            txtL.Name = "txtL";
            txtL.Size = new Size(239, 27);
            txtL.TabIndex = 5;
            // 
            // lblGrd
            // 
            lblGrd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrd.Location = new Point(628, 254);
            lblGrd.Name = "lblGrd";
            lblGrd.Size = new Size(144, 32);
            lblGrd.TabIndex = 2;
            lblGrd.Text = "Grade Name";
            // 
            // cmbLG
            // 
            cmbLG.FormattingEnabled = true;
            cmbLG.Location = new Point(778, 254);
            cmbLG.Name = "cmbLG";
            cmbLG.Size = new Size(237, 28);
            cmbLG.TabIndex = 6;
            // 
            // btnLG
            // 
            btnLG.Location = new Point(449, 29);
            btnLG.Name = "btnLG";
            btnLG.Size = new Size(152, 56);
            btnLG.TabIndex = 3;
            btnLG.Text = "Load Grade";
            btnLG.UseMnemonic = false;
            btnLG.UseVisualStyleBackColor = true;
            btnLG.Click += btnLG_Click;
            // 
            // button111
            // 
            button111.Location = new Point(655, 334);
            button111.Name = "button111";
            button111.Size = new Size(117, 32);
            button111.TabIndex = 7;
            button111.Text = "button1";
            button111.UseVisualStyleBackColor = true;
            button111.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(850, 334);
            button1.Name = "button1";
            button1.Size = new Size(117, 32);
            button1.TabIndex = 7;
            button1.Text = "button2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button2_Click;
            // 
            // DBForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 509);
            Controls.Add(button1);
            Controls.Add(button111);
            Controls.Add(cmbLG);
            Controls.Add(txtL);
            Controls.Add(txtF);
            Controls.Add(btnLG);
            Controls.Add(btnSW);
            Controls.Add(lblGrd);
            Controls.Add(lblL);
            Controls.Add(lblF);
            Controls.Add(dgvStu);
            Controls.Add(btnA);
            Controls.Add(btnC);
            Name = "DBForm";
            Text = "DBForm";
            ((System.ComponentModel.ISupportInitialize)dgvStu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnC;
        private Button btnA;
        private DataGridView dgvStu;
        private Label lblF;
        private Label lblL;
        private Button btnSW;
        private TextBox txtF;
        private TextBox txtL;
        private Label lblGrd;
        private ComboBox cmbLG;
        private Button btnLG;
        private Button button111;
        private Button button1;
    }
}