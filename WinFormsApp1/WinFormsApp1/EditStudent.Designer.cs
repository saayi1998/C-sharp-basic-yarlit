namespace WinFormsApp1
{
    partial class EditStudent
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
            cmbFid = new ComboBox();
            cmbHid = new ComboBox();
            cmbM = new ComboBox();
            cmbGr = new ComboBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txtadn = new TextBox();
            txtADD = new TextBox();
            txtTel = new TextBox();
            txtNIC = new TextBox();
            txtL = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lblH = new Label();
            lblADD = new Label();
            lblTel = new Label();
            lblDOA = new Label();
            lblMEE = new Label();
            label2 = new Label();
            lblNIC = new Label();
            lblGen = new Label();
            label1 = new Label();
            txtF1 = new TextBox();
            lblL = new Label();
            lblDOB = new Label();
            dtpDOB = new DateTimePicker();
            dtpDOA = new DateTimePicker();
            btn_Update = new Button();
            SuspendLayout();
            // 
            // cmbFid
            // 
            cmbFid.FormattingEnabled = true;
            cmbFid.Location = new Point(804, 328);
            cmbFid.Name = "cmbFid";
            cmbFid.Size = new Size(252, 28);
            cmbFid.TabIndex = 58;
            // 
            // cmbHid
            // 
            cmbHid.FormattingEnabled = true;
            cmbHid.Location = new Point(804, 269);
            cmbHid.Name = "cmbHid";
            cmbHid.Size = new Size(250, 28);
            cmbHid.TabIndex = 56;
            // 
            // cmbM
            // 
            cmbM.FormattingEnabled = true;
            cmbM.Items.AddRange(new object[] { "Tamil", "English " });
            cmbM.Location = new Point(234, 254);
            cmbM.Name = "cmbM";
            cmbM.Size = new Size(250, 28);
            cmbM.TabIndex = 55;
            // 
            // cmbGr
            // 
            cmbGr.FormattingEnabled = true;
            cmbGr.Location = new Point(236, 215);
            cmbGr.Name = "cmbGr";
            cmbGr.Size = new Size(248, 28);
            cmbGr.TabIndex = 57;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(408, 169);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 53;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(238, 169);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 54;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtadn
            // 
            txtadn.Location = new Point(236, 293);
            txtadn.Name = "txtadn";
            txtadn.Size = new Size(250, 27);
            txtadn.TabIndex = 46;
            // 
            // txtADD
            // 
            txtADD.Location = new Point(804, 220);
            txtADD.Name = "txtADD";
            txtADD.Size = new Size(252, 27);
            txtADD.TabIndex = 47;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(804, 168);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(250, 27);
            txtTel.TabIndex = 48;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(804, 121);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(250, 27);
            txtNIC.TabIndex = 49;
            // 
            // txtL
            // 
            txtL.Location = new Point(234, 124);
            txtL.Name = "txtL";
            txtL.Size = new Size(252, 27);
            txtL.TabIndex = 52;
            // 
            // label3
            // 
            label3.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 291);
            label3.Name = "label3";
            label3.Size = new Size(144, 27);
            label3.TabIndex = 36;
            label3.Text = "Admission No";
            label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            label4.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(624, 329);
            label4.Name = "label4";
            label4.Size = new Size(144, 27);
            label4.TabIndex = 37;
            label4.Text = "Family id";
            label4.UseCompatibleTextRendering = true;
            // 
            // lblH
            // 
            lblH.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblH.Location = new Point(624, 270);
            lblH.Name = "lblH";
            lblH.Size = new Size(144, 27);
            lblH.TabIndex = 35;
            lblH.Text = "House id ";
            lblH.UseCompatibleTextRendering = true;
            // 
            // lblADD
            // 
            lblADD.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblADD.Location = new Point(624, 220);
            lblADD.Name = "lblADD";
            lblADD.Size = new Size(144, 27);
            lblADD.TabIndex = 34;
            lblADD.Text = "Address";
            lblADD.UseCompatibleTextRendering = true;
            // 
            // lblTel
            // 
            lblTel.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTel.Location = new Point(620, 168);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(144, 34);
            lblTel.TabIndex = 38;
            lblTel.Text = "Tel Number";
            lblTel.UseCompatibleTextRendering = true;
            // 
            // lblDOA
            // 
            lblDOA.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOA.Location = new Point(620, 81);
            lblDOA.Name = "lblDOA";
            lblDOA.Size = new Size(178, 28);
            lblDOA.TabIndex = 39;
            lblDOA.Text = "Date of Admission";
            lblDOA.UseCompatibleTextRendering = true;
            // 
            // lblMEE
            // 
            lblMEE.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMEE.Location = new Point(43, 254);
            lblMEE.Name = "lblMEE";
            lblMEE.Size = new Size(144, 32);
            lblMEE.TabIndex = 43;
            lblMEE.Text = "Medium";
            lblMEE.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 211);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 42;
            label2.Text = "Grade";
            label2.UseCompatibleTextRendering = true;
            // 
            // lblNIC
            // 
            lblNIC.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNIC.Location = new Point(620, 121);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(144, 35);
            lblNIC.TabIndex = 40;
            lblNIC.Text = "NIC number";
            lblNIC.UseCompatibleTextRendering = true;
            // 
            // lblGen
            // 
            lblGen.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGen.Location = new Point(43, 170);
            lblGen.Name = "lblGen";
            lblGen.Size = new Size(110, 32);
            lblGen.TabIndex = 44;
            lblGen.Text = "Gender";
            lblGen.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            label1.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 124);
            label1.Name = "label1";
            label1.Size = new Size(142, 27);
            label1.TabIndex = 45;
            label1.Text = "Last Name ";
            label1.UseCompatibleTextRendering = true;
            // 
            // txtF1
            // 
            txtF1.Location = new Point(234, 80);
            txtF1.Name = "txtF1";
            txtF1.Size = new Size(252, 27);
            txtF1.TabIndex = 32;
            // 
            // lblL
            // 
            lblL.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblL.Location = new Point(43, 75);
            lblL.Name = "lblL";
            lblL.Size = new Size(110, 32);
            lblL.TabIndex = 30;
            lblL.Text = "First Name ";
            // 
            // lblDOB
            // 
            lblDOB.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(41, 329);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(144, 27);
            lblDOB.TabIndex = 59;
            lblDOB.Text = "Date of Birth";
            lblDOB.UseCompatibleTextRendering = true;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(234, 341);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(250, 27);
            dtpDOB.TabIndex = 60;
            // 
            // dtpDOA
            // 
            dtpDOA.Location = new Point(804, 80);
            dtpDOA.Name = "dtpDOA";
            dtpDOA.Size = new Size(250, 27);
            dtpDOA.TabIndex = 60;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = SystemColors.ActiveCaption;
            btn_Update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Update.Location = new Point(493, 421);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(111, 65);
            btn_Update.TabIndex = 63;
            btn_Update.Text = "UPDATE";
            btn_Update.UseVisualStyleBackColor = false;
            // 
            // EditStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 526);
            Controls.Add(btn_Update);
            Controls.Add(dtpDOA);
            Controls.Add(dtpDOB);
            Controls.Add(lblDOB);
            Controls.Add(cmbFid);
            Controls.Add(cmbHid);
            Controls.Add(cmbM);
            Controls.Add(cmbGr);
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
            Controls.Add(lblGen);
            Controls.Add(label1);
            Controls.Add(txtF1);
            Controls.Add(lblL);
            Name = "EditStudent";
            Text = "EditStudent";
            Load += ShowStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFid;
        private ComboBox cmbHid;
        private ComboBox cmbM;
        private ComboBox cmbGr;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox txtadn;
        private TextBox txtADD;
        private TextBox txtTel;
        private TextBox txtNIC;
        private TextBox txtL;
        private Label label3;
        private Label label4;
        private Label lblH;
        private Label lblADD;
        private Label lblTel;
        private Label lblDOA;
        private Label lblMEE;
        private Label label2;
        private Label lblNIC;
        private Label lblGen;
        private Label label1;
        private TextBox txtF1;
        private Label lblL;
        private Label lblDOB;
        private DateTimePicker dtpDOB;
        private DateTimePicker dtpDOA;
        private Button btn_Update;
    }
}