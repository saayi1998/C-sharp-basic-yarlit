namespace WinFormsApp1
{
    partial class frm_students_detail
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
            components = new System.ComponentModel.Container();
            txtFn = new TextBox();
            txtLn = new TextBox();
            txtAdd = new TextBox();
            txtNIC = new TextBox();
            txtTp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            rbtnM = new RadioButton();
            rbtnF = new RadioButton();
            txtFn1 = new TextBox();
            txtLn1 = new TextBox();
            txtAdd1 = new TextBox();
            txtNIC1 = new TextBox();
            txtTp1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            rbtnM1 = new RadioButton();
            rbtnF1 = new RadioButton();
            button1 = new Button();
            labelh = new Label();
            labelshow = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txtFn
            // 
            txtFn.Location = new Point(180, 85);
            txtFn.Name = "txtFn";
            txtFn.Size = new Size(275, 27);
            txtFn.TabIndex = 0;
            // 
            // txtLn
            // 
            txtLn.Location = new Point(180, 132);
            txtLn.Name = "txtLn";
            txtLn.Size = new Size(275, 27);
            txtLn.TabIndex = 1;
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(180, 243);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(275, 27);
            txtAdd.TabIndex = 3;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(180, 305);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(275, 27);
            txtNIC.TabIndex = 4;
            // 
            // txtTp
            // 
            txtTp.Location = new Point(180, 412);
            txtTp.Name = "txtTp";
            txtTp.Size = new Size(275, 27);
            txtTp.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 80);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "First Name ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 180);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 132);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 1;
            label3.Text = "Last Name ";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(180, 182);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(275, 27);
            dateTimePicker.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 244);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 1;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(57, 305);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 1;
            label5.Text = "NIC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(57, 368);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 1;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(54, 419);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 1;
            label7.Text = "Tel Number";
            // 
            // rbtnM
            // 
            rbtnM.AutoSize = true;
            rbtnM.Location = new Point(180, 364);
            rbtnM.Name = "rbtnM";
            rbtnM.Size = new Size(63, 24);
            rbtnM.TabIndex = 5;
            rbtnM.TabStop = true;
            rbtnM.Text = "Male";
            rbtnM.UseVisualStyleBackColor = true;
            // 
            // rbtnF
            // 
            rbtnF.AutoSize = true;
            rbtnF.Location = new Point(347, 364);
            rbtnF.Name = "rbtnF";
            rbtnF.Size = new Size(78, 24);
            rbtnF.TabIndex = 3;
            rbtnF.TabStop = true;
            rbtnF.Text = "Female";
            rbtnF.UseVisualStyleBackColor = true;
            // 
            // txtFn1
            // 
            txtFn1.Location = new Point(575, 83);
            txtFn1.Name = "txtFn1";
            txtFn1.Size = new Size(275, 27);
            txtFn1.TabIndex = 0;
            // 
            // txtLn1
            // 
            txtLn1.Location = new Point(575, 131);
            txtLn1.Name = "txtLn1";
            txtLn1.Size = new Size(275, 27);
            txtLn1.TabIndex = 0;
            // 
            // txtAdd1
            // 
            txtAdd1.Location = new Point(575, 243);
            txtAdd1.Name = "txtAdd1";
            txtAdd1.Size = new Size(275, 27);
            txtAdd1.TabIndex = 0;
            // 
            // txtNIC1
            // 
            txtNIC1.Location = new Point(575, 304);
            txtNIC1.Name = "txtNIC1";
            txtNIC1.Size = new Size(275, 27);
            txtNIC1.TabIndex = 0;
            // 
            // txtTp1
            // 
            txtTp1.Location = new Point(575, 412);
            txtTp1.Name = "txtTp1";
            txtTp1.Size = new Size(275, 27);
            txtTp1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(575, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(275, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // rbtnM1
            // 
            rbtnM1.AutoSize = true;
            rbtnM1.Location = new Point(575, 366);
            rbtnM1.Name = "rbtnM1";
            rbtnM1.Size = new Size(63, 24);
            rbtnM1.TabIndex = 3;
            rbtnM1.TabStop = true;
            rbtnM1.Text = "Male";
            rbtnM1.UseVisualStyleBackColor = true;
            // 
            // rbtnF1
            // 
            rbtnF1.AutoSize = true;
            rbtnF1.Location = new Point(733, 366);
            rbtnF1.Name = "rbtnF1";
            rbtnF1.Size = new Size(78, 24);
            rbtnF1.TabIndex = 3;
            rbtnF1.TabStop = true;
            rbtnF1.Text = "Female";
            rbtnF1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(575, 472);
            button1.Name = "button1";
            button1.Size = new Size(275, 37);
            button1.TabIndex = 7;
            button1.Text = "Transfer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelh
            // 
            labelh.BackColor = SystemColors.ActiveCaptionText;
            labelh.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelh.ForeColor = SystemColors.ButtonHighlight;
            labelh.Location = new Point(37, 21);
            labelh.Name = "labelh";
            labelh.Size = new Size(846, 38);
            labelh.TabIndex = 1;
            labelh.Text = "STUDENT DETAILS";
            labelh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelshow
            // 
            labelshow.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelshow.ForeColor = Color.Red;
            labelshow.Location = new Point(67, 461);
            labelshow.Name = "labelshow";
            labelshow.Size = new Size(449, 68);
            labelshow.TabIndex = 5;
            labelshow.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // frm_students_detail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 538);
            Controls.Add(rbtnF);
            Controls.Add(rbtnM);
            Controls.Add(labelshow);
            Controls.Add(button1);
            Controls.Add(rbtnF1);
            Controls.Add(rbtnM1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimePicker);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(labelh);
            Controls.Add(label1);
            Controls.Add(txtTp1);
            Controls.Add(txtNIC1);
            Controls.Add(txtTp);
            Controls.Add(txtAdd1);
            Controls.Add(txtNIC);
            Controls.Add(txtLn1);
            Controls.Add(txtAdd);
            Controls.Add(txtFn1);
            Controls.Add(txtLn);
            Controls.Add(txtFn);
            Name = "frm_students_detail";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFn;
        private TextBox txtLn;
        private TextBox txtAdd;
        private TextBox txtNIC;
        private TextBox txtTp;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RadioButton rbtnM;
        private RadioButton rbtnF;
        private TextBox txtFn1;
        private TextBox txtLn1;
        private TextBox txtAdd1;
        private TextBox txtNIC1;
        private TextBox txtTp1;
        private DateTimePicker dateTimePicker1;
        private RadioButton rbtnM1;
        private RadioButton rbtnF1;
        private Button button1;
        private Label labelh;
        private Label labelshow;
        private System.Windows.Forms.Timer timer1;
    }
}