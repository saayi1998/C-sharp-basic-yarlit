namespace WinFormsApp1
{
    partial class ShowStudent
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
            txtSL = new TextBox();
            txtSF = new TextBox();
            lblSL = new Label();
            lblSF = new Label();
            lblGn = new Label();
            rbM = new RadioButton();
            rbF = new RadioButton();
            lblAdd = new Label();
            txtAdd1 = new TextBox();
            txtTel1 = new TextBox();
            txtNIC1 = new TextBox();
            txtDOB1 = new TextBox();
            lblTel = new Label();
            lblNIC = new Label();
            lblDOB = new Label();
            label1 = new Label();
            txtDOA1 = new TextBox();
            SuspendLayout();
            // 
            // txtSL
            // 
            txtSL.Location = new Point(220, 91);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(251, 27);
            txtSL.TabIndex = 8;
            // 
            // txtSF
            // 
            txtSF.Location = new Point(220, 37);
            txtSF.Name = "txtSF";
            txtSF.Size = new Size(251, 27);
            txtSF.TabIndex = 9;
            // 
            // lblSL
            // 
            lblSL.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSL.Location = new Point(33, 91);
            lblSL.Name = "lblSL";
            lblSL.Size = new Size(110, 32);
            lblSL.TabIndex = 6;
            lblSL.Text = "Last Name ";
            lblSL.UseCompatibleTextRendering = true;
            // 
            // lblSF
            // 
            lblSF.Font = new Font("Cambria Math", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSF.Location = new Point(33, 37);
            lblSF.Name = "lblSF";
            lblSF.Size = new Size(110, 32);
            lblSF.TabIndex = 7;
            lblSF.Text = "First Name ";
            lblSF.UseCompatibleTextRendering = true;
            // 
            // lblGn
            // 
            lblGn.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGn.Location = new Point(33, 138);
            lblGn.Name = "lblGn";
            lblGn.Size = new Size(110, 32);
            lblGn.TabIndex = 6;
            lblGn.Text = "Gender";
            lblGn.UseCompatibleTextRendering = true;
            lblGn.Click += label1_Click;
            // 
            // rbM
            // 
            rbM.AutoSize = true;
            rbM.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbM.Location = new Point(220, 138);
            rbM.Name = "rbM";
            rbM.Size = new Size(74, 29);
            rbM.TabIndex = 10;
            rbM.TabStop = true;
            rbM.Text = "Male";
            rbM.UseVisualStyleBackColor = true;
            // 
            // rbF
            // 
            rbF.AutoSize = true;
            rbF.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbF.Location = new Point(379, 138);
            rbF.Name = "rbF";
            rbF.Size = new Size(92, 29);
            rbF.TabIndex = 10;
            rbF.TabStop = true;
            rbF.Text = "Female";
            rbF.UseVisualStyleBackColor = true;
            // 
            // lblAdd
            // 
            lblAdd.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdd.Location = new Point(33, 375);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(110, 32);
            lblAdd.TabIndex = 6;
            lblAdd.Text = "Address";
            lblAdd.UseCompatibleTextRendering = true;
            lblAdd.Click += label1_Click;
            // 
            // txtAdd1
            // 
            txtAdd1.Location = new Point(220, 375);
            txtAdd1.Multiline = true;
            txtAdd1.Name = "txtAdd1";
            txtAdd1.Size = new Size(251, 27);
            txtAdd1.TabIndex = 8;
            // 
            // txtTel1
            // 
            txtTel1.Location = new Point(220, 327);
            txtTel1.Name = "txtTel1";
            txtTel1.Size = new Size(251, 27);
            txtTel1.TabIndex = 16;
            // 
            // txtNIC1
            // 
            txtNIC1.Location = new Point(220, 275);
            txtNIC1.Name = "txtNIC1";
            txtNIC1.Size = new Size(251, 27);
            txtNIC1.TabIndex = 17;
            // 
            // txtDOB1
            // 
            txtDOB1.Location = new Point(220, 183);
            txtDOB1.Name = "txtDOB1";
            txtDOB1.Size = new Size(251, 27);
            txtDOB1.TabIndex = 18;
            // 
            // lblTel
            // 
            lblTel.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTel.Location = new Point(33, 322);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(144, 32);
            lblTel.TabIndex = 12;
            lblTel.Text = "Tel Number";
            lblTel.UseCompatibleTextRendering = true;
            // 
            // lblNIC
            // 
            lblNIC.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNIC.Location = new Point(33, 275);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(144, 32);
            lblNIC.TabIndex = 13;
            lblNIC.Text = "NIC number";
            lblNIC.UseCompatibleTextRendering = true;
            // 
            // lblDOB
            // 
            lblDOB.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(33, 183);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(144, 32);
            lblDOB.TabIndex = 14;
            lblDOB.Text = "Date of Birth";
            lblDOB.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            label1.Font = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 226);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 14;
            label1.Text = "Date of Admission";
            label1.UseCompatibleTextRendering = true;
            // 
            // txtDOA1
            // 
            txtDOA1.Location = new Point(220, 226);
            txtDOA1.Name = "txtDOA1";
            txtDOA1.Size = new Size(251, 27);
            txtDOA1.TabIndex = 18;
            // 
            // ShowStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 425);
            Controls.Add(txtTel1);
            Controls.Add(txtNIC1);
            Controls.Add(txtDOA1);
            Controls.Add(txtDOB1);
            Controls.Add(lblTel);
            Controls.Add(label1);
            Controls.Add(lblNIC);
            Controls.Add(lblDOB);
            Controls.Add(rbF);
            Controls.Add(rbM);
            Controls.Add(txtAdd1);
            Controls.Add(txtSL);
            Controls.Add(txtSF);
            Controls.Add(lblAdd);
            Controls.Add(lblGn);
            Controls.Add(lblSL);
            Controls.Add(lblSF);
            Name = "ShowStudent";
            Text = "ShowStudent";
            Load += ShowStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSL;
        private TextBox txtSF;
        private Label lblSL;
        private Label lblSF;
        private Label lblGn;
        private RadioButton rbM;
        private RadioButton rbF;
        private Label lblAdd;
        private TextBox txtAdd1;
        private TextBox txtTel1;
        private TextBox txtNIC1;
        private TextBox txtDOB1;
        private Label lblTel;
        private Label lblNIC;
        private Label lblDOB;
        private Label label1;
        private TextBox txtDOA1;
    }
}