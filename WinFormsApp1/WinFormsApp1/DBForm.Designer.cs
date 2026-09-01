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
            button1 = new Button();
            button2 = new Button();
            button21 = new Button();
            lblGen = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            lblDOB = new Label();
            txtDOB = new TextBox();
            lblNIC = new Label();
            txtNIC = new TextBox();
            lblTel = new Label();
            txtTel = new TextBox();
            lblADD = new Label();
            txtADD = new TextBox();
            btnDiaSW = new Button();
            lblDOA = new Label();
            txtDOA = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStu).BeginInit();
            SuspendLayout();
            // 
            // btnC
            // 
            btnC.Location = new Point(26, 29);
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
            btnA.Location = new Point(219, 29);
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
            dgvStu.Location = new Point(26, 108);
            dgvStu.Name = "dgvStu";
            dgvStu.RowHeadersWidth = 51;
            dgvStu.Size = new Size(540, 418);
            dgvStu.TabIndex = 1;
            // 
            // lblF
            // 
            lblF.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblF.Location = new Point(628, 130);
            lblF.Name = "lblF";
            lblF.Size = new Size(110, 32);
            lblF.TabIndex = 2;
            lblF.Text = "First Name ";
            lblF.UseCompatibleTextRendering = true;
            lblF.Click += lblF_Click;
            // 
            // lblL
            // 
            lblL.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblL.Location = new Point(628, 176);
            lblL.Name = "lblL";
            lblL.Size = new Size(142, 27);
            lblL.TabIndex = 2;
            lblL.Text = "Last Name ";
            lblL.UseCompatibleTextRendering = true;
            // 
            // btnSW
            // 
            btnSW.Location = new Point(758, 29);
            btnSW.Name = "btnSW";
            btnSW.Size = new Size(125, 56);
            btnSW.TabIndex = 3;
            btnSW.Text = "Show";
            btnSW.UseMnemonic = false;
            btnSW.UseVisualStyleBackColor = true;
            btnSW.Click += btnSW_Click;
            // 
            // txtF
            // 
            txtF.Location = new Point(800, 130);
            txtF.Name = "txtF";
            txtF.Size = new Size(221, 27);
            txtF.TabIndex = 5;
            // 
            // txtL
            // 
            txtL.Location = new Point(800, 176);
            txtL.Name = "txtL";
            txtL.Size = new Size(219, 27);
            txtL.TabIndex = 5;
            // 
            // lblGrd
            // 
            lblGrd.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrd.Location = new Point(628, 255);
            lblGrd.Name = "lblGrd";
            lblGrd.Size = new Size(144, 32);
            lblGrd.TabIndex = 2;
            lblGrd.Text = "Grade Name";
            lblGrd.UseCompatibleTextRendering = true;
            // 
            // cmbLG
            // 
            cmbLG.FormattingEnabled = true;
            cmbLG.Location = new Point(800, 259);
            cmbLG.Name = "cmbLG";
            cmbLG.Size = new Size(219, 28);
            cmbLG.TabIndex = 6;
            // 
            // btnLG
            // 
            btnLG.Location = new Point(414, 29);
            btnLG.Name = "btnLG";
            btnLG.Size = new Size(152, 56);
            btnLG.TabIndex = 3;
            btnLG.Text = "Load Grade";
            btnLG.UseMnemonic = false;
            btnLG.UseVisualStyleBackColor = true;
            btnLG.Click += btnLG_Click;
            // 
            // button1
            // 
            button1.Location = new Point(800, 303);
            button1.Name = "button1";
            button1.Size = new Size(90, 32);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(924, 303);
            button2.Name = "button2";
            button2.Size = new Size(95, 32);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button21
            // 
            button21.Location = new Point(606, 29);
            button21.Name = "button21";
            button21.Size = new Size(132, 56);
            button21.TabIndex = 3;
            button21.Text = "Direct DB Show";
            button21.UseMnemonic = false;
            button21.UseVisualStyleBackColor = true;
            button21.Click += button21_Click;
            // 
            // lblGen
            // 
            lblGen.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGen.Location = new Point(628, 217);
            lblGen.Name = "lblGen";
            lblGen.Size = new Size(110, 32);
            lblGen.TabIndex = 2;
            lblGen.Text = "Gender";
            lblGen.UseCompatibleTextRendering = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(800, 217);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(943, 217);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // lblDOB
            // 
            lblDOB.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(628, 352);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(144, 32);
            lblDOB.TabIndex = 2;
            lblDOB.Text = "Date of Birth";
            lblDOB.UseCompatibleTextRendering = true;
            lblDOB.Click += label1_Click;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(800, 352);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(221, 27);
            txtDOB.TabIndex = 5;
            // 
            // lblNIC
            // 
            lblNIC.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNIC.Location = new Point(628, 434);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(144, 32);
            lblNIC.TabIndex = 2;
            lblNIC.Text = "NIC number";
            lblNIC.UseCompatibleTextRendering = true;
            lblNIC.Click += label1_Click;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(800, 434);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(219, 27);
            txtNIC.TabIndex = 5;
            // 
            // lblTel
            // 
            lblTel.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTel.Location = new Point(628, 481);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(144, 32);
            lblTel.TabIndex = 2;
            lblTel.Text = "Tel Number";
            lblTel.UseCompatibleTextRendering = true;
            lblTel.Click += label1_Click;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(800, 481);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(221, 27);
            txtTel.TabIndex = 5;
            // 
            // lblADD
            // 
            lblADD.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblADD.Location = new Point(632, 533);
            lblADD.Name = "lblADD";
            lblADD.Size = new Size(144, 32);
            lblADD.TabIndex = 2;
            lblADD.Text = "Address";
            lblADD.UseCompatibleTextRendering = true;
            lblADD.Click += label1_Click;
            // 
            // txtADD
            // 
            txtADD.Location = new Point(800, 533);
            txtADD.Name = "txtADD";
            txtADD.Size = new Size(221, 27);
            txtADD.TabIndex = 5;
            // 
            // btnDiaSW
            // 
            btnDiaSW.AccessibleDescription = "";
            btnDiaSW.Location = new Point(907, 29);
            btnDiaSW.Name = "btnDiaSW";
            btnDiaSW.Size = new Size(108, 56);
            btnDiaSW.TabIndex = 3;
            btnDiaSW.Text = "Dialog Box Show";
            btnDiaSW.UseMnemonic = false;
            btnDiaSW.UseVisualStyleBackColor = true;
            btnDiaSW.Click += btnDiaSW_Click;
            // 
            // lblDOA
            // 
            lblDOA.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOA.Location = new Point(628, 394);
            lblDOA.Name = "lblDOA";
            lblDOA.Size = new Size(181, 32);
            lblDOA.TabIndex = 2;
            lblDOA.Text = "Date of Admission";
            lblDOA.UseCompatibleTextRendering = true;
            lblDOA.Click += label1_Click;
            // 
            // txtDOA
            // 
            txtDOA.Location = new Point(800, 394);
            txtDOA.Name = "txtDOA";
            txtDOA.Size = new Size(221, 27);
            txtDOA.TabIndex = 5;
            // 
            // DBForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 601);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbLG);
            Controls.Add(txtADD);
            Controls.Add(txtTel);
            Controls.Add(txtNIC);
            Controls.Add(txtDOA);
            Controls.Add(txtDOB);
            Controls.Add(txtL);
            Controls.Add(txtF);
            Controls.Add(btnLG);
            Controls.Add(button21);
            Controls.Add(btnDiaSW);
            Controls.Add(btnSW);
            Controls.Add(lblADD);
            Controls.Add(lblTel);
            Controls.Add(lblDOA);
            Controls.Add(lblNIC);
            Controls.Add(lblDOB);
            Controls.Add(lblGrd);
            Controls.Add(lblGen);
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
        private Button button1;
        private Button button2;
        private Button btnDiaSW;
        private Button button21;
        private Label lblGen;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label lblDOB;
        private TextBox txtDOB;
        private Label lblNIC;
        private TextBox txtNIC;
        private Label lblTel;
        private TextBox txtTel;
        private Label lblADD;
        private TextBox txtADD;
        private Label lblDOA;
        private TextBox txtDOA;
    }
}