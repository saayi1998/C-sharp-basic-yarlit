namespace WinFormsApp1
{
    partial class DBshow
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
            txtF1 = new TextBox();
            txtID = new TextBox();
            lblL = new Label();
            lblID = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txtADD = new TextBox();
            txtTel = new TextBox();
            txtNIC = new TextBox();
            txtL = new TextBox();
            lblADD = new Label();
            lblTel = new Label();
            lblDOA = new Label();
            lblNIC = new Label();
            lblDOB = new Label();
            lblGen = new Label();
            label1 = new Label();
            label2 = new Label();
            cmbGrr = new ComboBox();
            lblMEE = new Label();
            cmbM = new ComboBox();
            lblH = new Label();
            cmbHid = new ComboBox();
            label3 = new Label();
            txtadn = new TextBox();
            label4 = new Label();
            cmbFid = new ComboBox();
            dtpDOA = new DateTimePicker();
            dtpDOB = new DateTimePicker();
            SuspendLayout();
            // 
            // txtF1
            // 
            txtF1.Location = new Point(229, 87);
            txtF1.Name = "txtF1";
            txtF1.Size = new Size(219, 27);
            txtF1.TabIndex = 12;
            // 
            // txtID
            // 
            txtID.Location = new Point(229, 41);
            txtID.Name = "txtID";
            txtID.Size = new Size(221, 27);
            txtID.TabIndex = 13;
            // 
            // lblL
            // 
            lblL.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblL.Location = new Point(34, 87);
            lblL.Name = "lblL";
            lblL.Size = new Size(110, 32);
            lblL.TabIndex = 9;
            lblL.Text = "First Name ";
            // 
            // lblID
            // 
            lblID.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(38, 36);
            lblID.Name = "lblID";
            lblID.Size = new Size(110, 32);
            lblID.TabIndex = 10;
            lblID.Text = "ID NO";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(372, 182);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 27;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(229, 182);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 28;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtADD
            // 
            txtADD.Location = new Point(792, 225);
            txtADD.Name = "txtADD";
            txtADD.Size = new Size(253, 27);
            txtADD.TabIndex = 21;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(792, 167);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(253, 27);
            txtTel.TabIndex = 22;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(792, 124);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(253, 27);
            txtNIC.TabIndex = 23;
            // 
            // txtL
            // 
            txtL.Location = new Point(229, 141);
            txtL.Name = "txtL";
            txtL.Size = new Size(219, 27);
            txtL.TabIndex = 26;
            // 
            // lblADD
            // 
            lblADD.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblADD.Location = new Point(612, 223);
            lblADD.Name = "lblADD";
            lblADD.Size = new Size(144, 27);
            lblADD.TabIndex = 14;
            lblADD.Text = "Address";
            lblADD.UseCompatibleTextRendering = true;
            // 
            // lblTel
            // 
            lblTel.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTel.Location = new Point(608, 171);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(144, 34);
            lblTel.TabIndex = 15;
            lblTel.Text = "Tel Number";
            lblTel.UseCompatibleTextRendering = true;
            // 
            // lblDOA
            // 
            lblDOA.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOA.Location = new Point(608, 84);
            lblDOA.Name = "lblDOA";
            lblDOA.Size = new Size(178, 28);
            lblDOA.TabIndex = 16;
            lblDOA.Text = "Date of Admission";
            lblDOA.UseCompatibleTextRendering = true;
            // 
            // lblNIC
            // 
            lblNIC.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNIC.Location = new Point(608, 124);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(144, 35);
            lblNIC.TabIndex = 17;
            lblNIC.Text = "NIC number";
            lblNIC.UseCompatibleTextRendering = true;
            // 
            // lblDOB
            // 
            lblDOB.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(608, 42);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(144, 27);
            lblDOB.TabIndex = 18;
            lblDOB.Text = "Date of Birth";
            lblDOB.UseCompatibleTextRendering = true;
            // 
            // lblGen
            // 
            lblGen.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGen.Location = new Point(34, 182);
            lblGen.Name = "lblGen";
            lblGen.Size = new Size(110, 32);
            lblGen.TabIndex = 19;
            lblGen.Text = "Gender";
            lblGen.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            label1.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 141);
            label1.Name = "label1";
            label1.Size = new Size(142, 27);
            label1.TabIndex = 20;
            label1.Text = "Last Name ";
            label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 225);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 18;
            label2.Text = "Grade";
            label2.UseCompatibleTextRendering = true;
            // 
            // cmbGrr
            // 
            cmbGrr.FormattingEnabled = true;
            cmbGrr.Location = new Point(229, 225);
            cmbGrr.Name = "cmbGrr";
            cmbGrr.Size = new Size(221, 28);
            cmbGrr.TabIndex = 29;
            // 
            // lblMEE
            // 
            lblMEE.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMEE.Location = new Point(32, 268);
            lblMEE.Name = "lblMEE";
            lblMEE.Size = new Size(144, 32);
            lblMEE.TabIndex = 18;
            lblMEE.Text = "Medium";
            lblMEE.UseCompatibleTextRendering = true;
            // 
            // cmbM
            // 
            cmbM.FormattingEnabled = true;
            cmbM.Items.AddRange(new object[] { "Tamil", "English" });
            cmbM.Location = new Point(227, 268);
            cmbM.Name = "cmbM";
            cmbM.Size = new Size(221, 28);
            cmbM.TabIndex = 29;
            cmbM.SelectedIndexChanged += cmbM_SelectedIndexChanged;
            // 
            // lblH
            // 
            lblH.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblH.Location = new Point(612, 273);
            lblH.Name = "lblH";
            lblH.Size = new Size(144, 27);
            lblH.TabIndex = 14;
            lblH.Text = "House Name";
            lblH.UseCompatibleTextRendering = true;
            // 
            // cmbHid
            // 
            cmbHid.FormattingEnabled = true;
            cmbHid.Location = new Point(793, 268);
            cmbHid.Name = "cmbHid";
            cmbHid.Size = new Size(252, 28);
            cmbHid.TabIndex = 29;
            cmbHid.SelectedIndexChanged += cmbHid_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 315);
            label3.Name = "label3";
            label3.Size = new Size(144, 27);
            label3.TabIndex = 14;
            label3.Text = "Admission No";
            label3.UseCompatibleTextRendering = true;
            // 
            // txtadn
            // 
            txtadn.Location = new Point(227, 316);
            txtadn.Name = "txtadn";
            txtadn.Size = new Size(221, 27);
            txtadn.TabIndex = 21;
            // 
            // label4
            // 
            label4.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(612, 315);
            label4.Name = "label4";
            label4.Size = new Size(144, 27);
            label4.TabIndex = 14;
            label4.Text = "Family id";
            label4.UseCompatibleTextRendering = true;
            // 
            // cmbFid
            // 
            cmbFid.FormattingEnabled = true;
            cmbFid.Location = new Point(792, 316);
            cmbFid.Name = "cmbFid";
            cmbFid.Size = new Size(253, 28);
            cmbFid.TabIndex = 29;
            // 
            // dtpDOA
            // 
            dtpDOA.Location = new Point(792, 83);
            dtpDOA.Name = "dtpDOA";
            dtpDOA.Size = new Size(253, 27);
            dtpDOA.TabIndex = 30;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(793, 35);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(252, 27);
            dtpDOB.TabIndex = 30;
            // 
            // DBshow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 383);
            Controls.Add(dtpDOB);
            Controls.Add(dtpDOA);
            Controls.Add(cmbFid);
            Controls.Add(cmbHid);
            Controls.Add(cmbM);
            Controls.Add(cmbGrr);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtadn);
            Controls.Add(txtADD);
            Controls.Add(txtTel);
            Controls.Add(txtNIC);
            Controls.Add(txtL);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(lblH);
            Controls.Add(lblADD);
            Controls.Add(lblTel);
            Controls.Add(lblDOA);
            Controls.Add(lblMEE);
            Controls.Add(label2);
            Controls.Add(lblNIC);
            Controls.Add(lblDOB);
            Controls.Add(lblGen);
            Controls.Add(label1);
            Controls.Add(txtF1);
            Controls.Add(txtID);
            Controls.Add(lblL);
            Controls.Add(lblID);
            Name = "DBshow";
            Text = "DBshow";
            Load += DBshow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtF1;
        private TextBox txtID;
        private Label lblL;
        private Label lblID;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox txtADD;
        private TextBox txtTel;
        private TextBox txtNIC;
        private TextBox txtL;
        private Label lblADD;
        private Label lblTel;
        private Label lblDOA;
        private Label lblNIC;
        private Label lblDOB;
        private Label lblGen;
        private Label label1;
        private Label label2;
        private ComboBox cmbGrr;
        private Label lblMEE;
        private ComboBox cmbM;
        private Label lblH;
        private ComboBox cmbHid;
        private Label label3;
        private TextBox txtadn;
        private Label label4;
        private ComboBox cmbFid;
        private DateTimePicker dtpDOA;
        private DateTimePicker dtpDOB;
    }
}