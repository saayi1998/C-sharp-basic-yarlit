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
            lblNIC = new Label();
            txtNIC = new TextBox();
            lblTel = new Label();
            txtTel = new TextBox();
            btnDiaSW = new Button();
            lblDOA = new Label();
            label3 = new Label();
            txtADD = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox22 = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            comboBox3 = new ComboBox();
            btn_Insert = new Button();
            btn_Delete = new Button();
            btn_Edit = new Button();
            txt_AdM = new TextBox();
            txt_F1 = new TextBox();
            lbl_F1 = new Label();
            lbl_AdM = new Label();
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
            dgvStu.Size = new Size(795, 779);
            dgvStu.TabIndex = 1;
            // 
            // lblF
            // 
            lblF.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblF.Location = new Point(857, 181);
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
            lblL.Location = new Point(857, 227);
            lblL.Name = "lblL";
            lblL.Size = new Size(142, 27);
            lblL.TabIndex = 2;
            lblL.Text = "Last Name ";
            lblL.UseCompatibleTextRendering = true;
            // 
            // btnSW
            // 
            btnSW.Location = new Point(757, 29);
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
            txtF.Location = new Point(1007, 181);
            txtF.Name = "txtF";
            txtF.Size = new Size(243, 27);
            txtF.TabIndex = 5;
            // 
            // txtL
            // 
            txtL.Location = new Point(1007, 227);
            txtL.Name = "txtL";
            txtL.Size = new Size(241, 27);
            txtL.TabIndex = 5;
            // 
            // lblGrd
            // 
            lblGrd.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrd.Location = new Point(866, 311);
            lblGrd.Name = "lblGrd";
            lblGrd.Size = new Size(144, 32);
            lblGrd.TabIndex = 2;
            lblGrd.Text = "Grade";
            lblGrd.UseCompatibleTextRendering = true;
            // 
            // cmbLG
            // 
            cmbLG.FormattingEnabled = true;
            cmbLG.Location = new Point(1007, 311);
            cmbLG.Name = "cmbLG";
            cmbLG.Size = new Size(250, 28);
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
            button1.Location = new Point(1007, 354);
            button1.Name = "button1";
            button1.Size = new Size(90, 32);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1153, 354);
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
            lblGen.Location = new Point(857, 268);
            lblGen.Name = "lblGen";
            lblGen.Size = new Size(110, 32);
            lblGen.TabIndex = 2;
            lblGen.Text = "Gender";
            lblGen.UseCompatibleTextRendering = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(1007, 271);
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
            radioButton2.Location = new Point(1172, 268);
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
            lblDOB.Location = new Point(857, 403);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(144, 32);
            lblDOB.TabIndex = 2;
            lblDOB.Text = "Date of Birth";
            lblDOB.UseCompatibleTextRendering = true;
            lblDOB.Click += label1_Click;
            // 
            // lblNIC
            // 
            lblNIC.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNIC.Location = new Point(857, 485);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(144, 32);
            lblNIC.TabIndex = 2;
            lblNIC.Text = "NIC number";
            lblNIC.UseCompatibleTextRendering = true;
            lblNIC.Click += label1_Click;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(1007, 487);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(255, 27);
            txtNIC.TabIndex = 5;
            // 
            // lblTel
            // 
            lblTel.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTel.Location = new Point(857, 532);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(144, 32);
            lblTel.TabIndex = 2;
            lblTel.Text = "Tel Number";
            lblTel.UseCompatibleTextRendering = true;
            lblTel.Click += label1_Click;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(1007, 532);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(250, 27);
            txtTel.TabIndex = 5;
            // 
            // btnDiaSW
            // 
            btnDiaSW.AccessibleDescription = "";
            btnDiaSW.Location = new Point(894, 29);
            btnDiaSW.Name = "btnDiaSW";
            btnDiaSW.Size = new Size(108, 56);
            btnDiaSW.TabIndex = 3;
            btnDiaSW.Text = "PopUp Show";
            btnDiaSW.UseMnemonic = false;
            btnDiaSW.UseVisualStyleBackColor = true;
            btnDiaSW.Click += btnDiaSW_Click;
            // 
            // lblDOA
            // 
            lblDOA.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOA.Location = new Point(835, 444);
            lblDOA.Name = "lblDOA";
            lblDOA.Size = new Size(181, 32);
            lblDOA.TabIndex = 2;
            lblDOA.Text = "Date of Admission";
            lblDOA.UseCompatibleTextRendering = true;
            lblDOA.Click += label1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(827, 636);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 2;
            label3.Text = "Address";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseCompatibleTextRendering = true;
            label3.Click += label1_Click;
            // 
            // txtADD
            // 
            txtADD.Location = new Point(1007, 636);
            txtADD.Name = "txtADD";
            txtADD.Size = new Size(250, 27);
            txtADD.TabIndex = 5;
            txtADD.TextChanged += txtADD_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1007, 403);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(1007, 444);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // label1
            // 
            label1.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(857, 679);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 2;
            label1.Text = "Medium";
            label1.UseCompatibleTextRendering = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tamil ", "English" });
            comboBox1.Location = new Point(1007, 679);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 28);
            comboBox1.TabIndex = 6;
            // 
            // comboBox22
            // 
            comboBox22.FormattingEnabled = true;
            comboBox22.Location = new Point(1007, 722);
            comboBox22.Name = "comboBox22";
            comboBox22.Size = new Size(255, 28);
            comboBox22.TabIndex = 6;
            // 
            // label2
            // 
            label2.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(855, 722);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 2;
            label2.Text = "House Name";
            label2.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            label4.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(857, 761);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 2;
            label4.Text = "Family id";
            label4.UseCompatibleTextRendering = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(1007, 761);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(255, 28);
            comboBox3.TabIndex = 6;
            // 
            // btn_Insert
            // 
            btn_Insert.BackColor = Color.Lime;
            btn_Insert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Insert.Location = new Point(864, 822);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(172, 65);
            btn_Insert.TabIndex = 63;
            btn_Insert.Text = "INSERT";
            btn_Insert.UseVisualStyleBackColor = false;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.IndianRed;
            btn_Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Delete.Location = new Point(1080, 822);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(168, 65);
            btn_Delete.TabIndex = 64;
            btn_Delete.Text = "DELETE";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.PowderBlue;
            btn_Edit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Edit.Location = new Point(1070, 25);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(172, 65);
            btn_Edit.TabIndex = 65;
            btn_Edit.Text = "EDIT";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // txt_AdM
            // 
            txt_AdM.Location = new Point(1007, 584);
            txt_AdM.Name = "txt_AdM";
            txt_AdM.Size = new Size(245, 27);
            txt_AdM.TabIndex = 68;
            // 
            // txt_F1
            // 
            txt_F1.Location = new Point(1007, 119);
            txt_F1.Name = "txt_F1";
            txt_F1.Size = new Size(235, 27);
            txt_F1.TabIndex = 70;
            // 
            // lbl_F1
            // 
            lbl_F1.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_F1.Location = new Point(858, 119);
            lbl_F1.Name = "lbl_F1";
            lbl_F1.Size = new Size(110, 32);
            lbl_F1.TabIndex = 2;
            lbl_F1.Text = "Student Id";
            lbl_F1.UseCompatibleTextRendering = true;
            lbl_F1.Click += lblF_Click;
            // 
            // lbl_AdM
            // 
            lbl_AdM.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdM.Location = new Point(852, 584);
            lbl_AdM.Name = "lbl_AdM";
            lbl_AdM.Size = new Size(144, 32);
            lbl_AdM.TabIndex = 2;
            lbl_AdM.Text = "Admission No";
            lbl_AdM.UseCompatibleTextRendering = true;
            lbl_AdM.Click += label1_Click;
            // 
            // DBForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 894);
            Controls.Add(txt_F1);
            Controls.Add(txt_AdM);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Insert);
            Controls.Add(btn_Delete);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox22);
            Controls.Add(comboBox1);
            Controls.Add(cmbLG);
            Controls.Add(txtADD);
            Controls.Add(txtTel);
            Controls.Add(txtNIC);
            Controls.Add(txtL);
            Controls.Add(txtF);
            Controls.Add(btnLG);
            Controls.Add(button21);
            Controls.Add(btnDiaSW);
            Controls.Add(btnSW);
            Controls.Add(lbl_AdM);
            Controls.Add(label3);
            Controls.Add(lblTel);
            Controls.Add(lblDOA);
            Controls.Add(lblNIC);
            Controls.Add(lblDOB);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblGrd);
            Controls.Add(lblGen);
            Controls.Add(lblL);
            Controls.Add(lbl_F1);
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
        private Label lblNIC;
        private TextBox txtNIC;
        private Label lblTel;
        private TextBox txtTel;
        private Label lblDOA;
        private Label label3;
        private TextBox txtADD;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox22;
        private Label label2;
        private Label label4;
        private ComboBox comboBox3;
        private Button btn_Insert;
        private Button btn_Delete;
        private Button btn_Edit;
        private TextBox txt_AdM;
        private TextBox txt_F1;
        private Label lbl_F1;
        private Label lbl_AdM;
    }
}