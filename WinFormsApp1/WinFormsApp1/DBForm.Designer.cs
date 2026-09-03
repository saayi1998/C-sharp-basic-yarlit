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
            dgvStu.Size = new Size(795, 593);
            dgvStu.TabIndex = 1;
            // 
            // lblF
            // 
            lblF.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblF.Location = new Point(849, 130);
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
            lblL.Location = new Point(849, 176);
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
            txtF.Location = new Point(999, 130);
            txtF.Name = "txtF";
            txtF.Size = new Size(243, 27);
            txtF.TabIndex = 5;
            // 
            // txtL
            // 
            txtL.Location = new Point(999, 176);
            txtL.Name = "txtL";
            txtL.Size = new Size(241, 27);
            txtL.TabIndex = 5;
            // 
            // lblGrd
            // 
            lblGrd.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrd.Location = new Point(858, 260);
            lblGrd.Name = "lblGrd";
            lblGrd.Size = new Size(144, 32);
            lblGrd.TabIndex = 2;
            lblGrd.Text = "Grade";
            lblGrd.UseCompatibleTextRendering = true;
            // 
            // cmbLG
            // 
            cmbLG.FormattingEnabled = true;
            cmbLG.Location = new Point(999, 260);
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
            button1.Location = new Point(999, 303);
            button1.Name = "button1";
            button1.Size = new Size(90, 32);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1145, 303);
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
            lblGen.Location = new Point(849, 217);
            lblGen.Name = "lblGen";
            lblGen.Size = new Size(110, 32);
            lblGen.TabIndex = 2;
            lblGen.Text = "Gender";
            lblGen.UseCompatibleTextRendering = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(999, 220);
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
            radioButton2.Location = new Point(1164, 217);
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
            lblDOB.Location = new Point(849, 352);
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
            lblNIC.Location = new Point(849, 434);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(144, 32);
            lblNIC.TabIndex = 2;
            lblNIC.Text = "NIC number";
            lblNIC.UseCompatibleTextRendering = true;
            lblNIC.Click += label1_Click;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(999, 436);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(255, 27);
            txtNIC.TabIndex = 5;
            // 
            // lblTel
            // 
            lblTel.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTel.Location = new Point(849, 481);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(144, 32);
            lblTel.TabIndex = 2;
            lblTel.Text = "Tel Number";
            lblTel.UseCompatibleTextRendering = true;
            lblTel.Click += label1_Click;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(999, 481);
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
            lblDOA.Location = new Point(827, 393);
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
            label3.Location = new Point(849, 533);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 2;
            label3.Text = "Address";
            label3.UseCompatibleTextRendering = true;
            label3.Click += label1_Click;
            // 
            // txtADD
            // 
            txtADD.Location = new Point(999, 533);
            txtADD.Name = "txtADD";
            txtADD.Size = new Size(255, 27);
            txtADD.TabIndex = 5;
            txtADD.TextChanged += txtADD_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(999, 352);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(999, 393);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // label1
            // 
            label1.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(849, 587);
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
            comboBox1.Location = new Point(999, 587);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 28);
            comboBox1.TabIndex = 6;
            // 
            // comboBox22
            // 
            comboBox22.FormattingEnabled = true;
            comboBox22.Location = new Point(999, 630);
            comboBox22.Name = "comboBox22";
            comboBox22.Size = new Size(255, 28);
            comboBox22.TabIndex = 6;
            // 
            // label2
            // 
            label2.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(847, 630);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 2;
            label2.Text = "House Name";
            label2.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            label4.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(849, 669);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 2;
            label4.Text = "Family id";
            label4.UseCompatibleTextRendering = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(999, 669);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(255, 28);
            comboBox3.TabIndex = 6;
            // 
            // DBForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 737);
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
    }
}