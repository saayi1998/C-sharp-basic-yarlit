namespace WinFormsApp2
{
    partial class DB_Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Connect = new Button();
            btn_AllStudent = new Button();
            btn_AllGradeLoad = new Button();
            btn_DirectDBShow = new Button();
            btn_Show = new Button();
            btn_PopShow = new Button();
            btn_Edit = new Button();
            btn_Delete = new Button();
            btn_Insert = new Button();
            dgv_Student = new DataGridView();
            rbn_Male = new RadioButton();
            rbn_Female = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            dtp_Dob = new DateTimePicker();
            dtp_Doa = new DateTimePicker();
            cmb_Hn = new ComboBox();
            cmb_Fid = new ComboBox();
            cmb_Med = new ComboBox();
            lbl_Sid = new Label();
            lbl_Fn = new Label();
            lbl_Ln = new Label();
            lbl_Gender = new Label();
            lbl_Dob = new Label();
            lbl_Doa = new Label();
            lbl_Nic = new Label();
            lbl_Tel = new Label();
            lbl_Adn = new Label();
            lbl_Add = new Label();
            lbl_Med = new Label();
            lbl_Hn = new Label();
            lbl_Fid = new Label();
            txt_Sid = new TextBox();
            txt_Fn = new TextBox();
            txt_Ln = new TextBox();
            txt_Adn = new TextBox();
            txt_Nic = new TextBox();
            txt_Tel = new TextBox();
            txt_Add = new TextBox();
            lbl_Gn = new Label();
            cmb_Gn = new ComboBox();
            btn_Clear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Student).BeginInit();
            SuspendLayout();
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(23, 28);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(146, 47);
            btn_Connect.TabIndex = 0;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // btn_AllStudent
            // 
            btn_AllStudent.Location = new Point(184, 28);
            btn_AllStudent.Name = "btn_AllStudent";
            btn_AllStudent.Size = new Size(146, 47);
            btn_AllStudent.TabIndex = 0;
            btn_AllStudent.Text = "All Student";
            btn_AllStudent.UseVisualStyleBackColor = true;
            btn_AllStudent.Click += btn_AllStudent_Click;
            // 
            // btn_AllGradeLoad
            // 
            btn_AllGradeLoad.Location = new Point(347, 28);
            btn_AllGradeLoad.Name = "btn_AllGradeLoad";
            btn_AllGradeLoad.Size = new Size(146, 47);
            btn_AllGradeLoad.TabIndex = 0;
            btn_AllGradeLoad.Text = "All Grade Load";
            btn_AllGradeLoad.UseVisualStyleBackColor = true;
            btn_AllGradeLoad.Click += btn_AllGradeLoad_Click;
            // 
            // btn_DirectDBShow
            // 
            btn_DirectDBShow.Location = new Point(513, 28);
            btn_DirectDBShow.Name = "btn_DirectDBShow";
            btn_DirectDBShow.Size = new Size(146, 47);
            btn_DirectDBShow.TabIndex = 0;
            btn_DirectDBShow.Text = "Direct DB Show";
            btn_DirectDBShow.UseVisualStyleBackColor = true;
            btn_DirectDBShow.Click += btn_DirectDBShow_Click;
            // 
            // btn_Show
            // 
            btn_Show.Location = new Point(681, 28);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new Size(146, 47);
            btn_Show.TabIndex = 0;
            btn_Show.Text = "Show";
            btn_Show.UseVisualStyleBackColor = true;
            btn_Show.Click += btn_Show_Click;
            // 
            // btn_PopShow
            // 
            btn_PopShow.Location = new Point(833, 28);
            btn_PopShow.Name = "btn_PopShow";
            btn_PopShow.Size = new Size(146, 47);
            btn_PopShow.TabIndex = 0;
            btn_PopShow.Text = "Pop Show";
            btn_PopShow.UseVisualStyleBackColor = true;
            btn_PopShow.Click += btn_PopShow_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.Yellow;
            btn_Edit.Location = new Point(1145, 28);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(146, 47);
            btn_Edit.TabIndex = 0;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.IndianRed;
            btn_Delete.Location = new Point(1145, 829);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(146, 47);
            btn_Delete.TabIndex = 0;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Insert
            // 
            btn_Insert.BackColor = Color.LightSalmon;
            btn_Insert.Location = new Point(833, 829);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(146, 47);
            btn_Insert.TabIndex = 0;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = false;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // dgv_Student
            // 
            dgv_Student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Student.Location = new Point(23, 98);
            dgv_Student.Name = "dgv_Student";
            dgv_Student.RowHeadersWidth = 51;
            dgv_Student.Size = new Size(786, 778);
            dgv_Student.TabIndex = 1;
            // 
            // rbn_Male
            // 
            rbn_Male.AutoSize = true;
            rbn_Male.Location = new Point(1035, 265);
            rbn_Male.Name = "rbn_Male";
            rbn_Male.Size = new Size(63, 24);
            rbn_Male.TabIndex = 3;
            rbn_Male.TabStop = true;
            rbn_Male.Text = "Male";
            rbn_Male.UseVisualStyleBackColor = true;
            // 
            // rbn_Female
            // 
            rbn_Female.AutoSize = true;
            rbn_Female.Location = new Point(1221, 265);
            rbn_Female.Name = "rbn_Female";
            rbn_Female.Size = new Size(78, 24);
            rbn_Female.TabIndex = 3;
            rbn_Female.TabStop = true;
            rbn_Female.Text = "Female";
            rbn_Female.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1031, 358);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1201, 358);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dtp_Dob
            // 
            dtp_Dob.Format = DateTimePickerFormat.Short;
            dtp_Dob.Location = new Point(1031, 400);
            dtp_Dob.Name = "dtp_Dob";
            dtp_Dob.Size = new Size(264, 27);
            dtp_Dob.TabIndex = 5;
            // 
            // dtp_Doa
            // 
            dtp_Doa.Format = DateTimePickerFormat.Short;
            dtp_Doa.Location = new Point(1031, 445);
            dtp_Doa.Name = "dtp_Doa";
            dtp_Doa.Size = new Size(264, 27);
            dtp_Doa.TabIndex = 5;
            // 
            // cmb_Hn
            // 
            cmb_Hn.FormattingEnabled = true;
            cmb_Hn.Location = new Point(1035, 725);
            cmb_Hn.Name = "cmb_Hn";
            cmb_Hn.Size = new Size(260, 28);
            cmb_Hn.TabIndex = 6;
            // 
            // cmb_Fid
            // 
            cmb_Fid.FormattingEnabled = true;
            cmb_Fid.Location = new Point(1035, 777);
            cmb_Fid.Name = "cmb_Fid";
            cmb_Fid.Size = new Size(260, 28);
            cmb_Fid.TabIndex = 6;
            // 
            // cmb_Med
            // 
            cmb_Med.FormattingEnabled = true;
            cmb_Med.Items.AddRange(new object[] { "Tamil", "English ", "Sinhala" });
            cmb_Med.Location = new Point(1035, 676);
            cmb_Med.Name = "cmb_Med";
            cmb_Med.Size = new Size(260, 28);
            cmb_Med.TabIndex = 6;
            // 
            // lbl_Sid
            // 
            lbl_Sid.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Sid.Location = new Point(833, 118);
            lbl_Sid.Name = "lbl_Sid";
            lbl_Sid.Size = new Size(146, 23);
            lbl_Sid.TabIndex = 7;
            lbl_Sid.Text = "Student ID";
            lbl_Sid.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Fn
            // 
            lbl_Fn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Fn.Location = new Point(833, 164);
            lbl_Fn.Name = "lbl_Fn";
            lbl_Fn.Size = new Size(146, 23);
            lbl_Fn.TabIndex = 7;
            lbl_Fn.Text = "First Name";
            lbl_Fn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Ln
            // 
            lbl_Ln.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Ln.Location = new Point(833, 212);
            lbl_Ln.Name = "lbl_Ln";
            lbl_Ln.Size = new Size(146, 23);
            lbl_Ln.TabIndex = 7;
            lbl_Ln.Text = "Last Name";
            lbl_Ln.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Ln.Click += lbl_Ln_Click;
            // 
            // lbl_Gender
            // 
            lbl_Gender.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Gender.Location = new Point(833, 266);
            lbl_Gender.Name = "lbl_Gender";
            lbl_Gender.Size = new Size(146, 23);
            lbl_Gender.TabIndex = 7;
            lbl_Gender.Text = "Gender";
            lbl_Gender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Dob
            // 
            lbl_Dob.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Dob.Location = new Point(833, 400);
            lbl_Dob.Name = "lbl_Dob";
            lbl_Dob.Size = new Size(146, 23);
            lbl_Dob.TabIndex = 7;
            lbl_Dob.Text = "Date Of Birth";
            lbl_Dob.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Doa
            // 
            lbl_Doa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Doa.Location = new Point(833, 449);
            lbl_Doa.Name = "lbl_Doa";
            lbl_Doa.Size = new Size(177, 23);
            lbl_Doa.TabIndex = 7;
            lbl_Doa.Text = "Date Of Admission";
            lbl_Doa.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Nic
            // 
            lbl_Nic.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Nic.Location = new Point(833, 539);
            lbl_Nic.Name = "lbl_Nic";
            lbl_Nic.Size = new Size(146, 23);
            lbl_Nic.TabIndex = 7;
            lbl_Nic.Text = "NIC Number";
            lbl_Nic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Tel
            // 
            lbl_Tel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Tel.Location = new Point(833, 592);
            lbl_Tel.Name = "lbl_Tel";
            lbl_Tel.Size = new Size(146, 23);
            lbl_Tel.TabIndex = 7;
            lbl_Tel.Text = "TEL Number";
            lbl_Tel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Adn
            // 
            lbl_Adn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Adn.Location = new Point(833, 500);
            lbl_Adn.Name = "lbl_Adn";
            lbl_Adn.Size = new Size(146, 23);
            lbl_Adn.TabIndex = 7;
            lbl_Adn.Text = "Admission No";
            lbl_Adn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Add
            // 
            lbl_Add.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Add.Location = new Point(833, 637);
            lbl_Add.Name = "lbl_Add";
            lbl_Add.Size = new Size(146, 23);
            lbl_Add.TabIndex = 7;
            lbl_Add.Text = "Address";
            lbl_Add.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Med
            // 
            lbl_Med.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Med.Location = new Point(833, 681);
            lbl_Med.Name = "lbl_Med";
            lbl_Med.Size = new Size(146, 23);
            lbl_Med.TabIndex = 7;
            lbl_Med.Text = "Medium";
            lbl_Med.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Hn
            // 
            lbl_Hn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Hn.Location = new Point(833, 730);
            lbl_Hn.Name = "lbl_Hn";
            lbl_Hn.Size = new Size(146, 23);
            lbl_Hn.TabIndex = 7;
            lbl_Hn.Text = "House Name";
            lbl_Hn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Fid
            // 
            lbl_Fid.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Fid.Location = new Point(833, 782);
            lbl_Fid.Name = "lbl_Fid";
            lbl_Fid.Size = new Size(146, 23);
            lbl_Fid.TabIndex = 7;
            lbl_Fid.Text = "Family ID";
            lbl_Fid.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_Sid
            // 
            txt_Sid.Location = new Point(1031, 118);
            txt_Sid.Name = "txt_Sid";
            txt_Sid.Size = new Size(260, 27);
            txt_Sid.TabIndex = 8;
            // 
            // txt_Fn
            // 
            txt_Fn.Location = new Point(1031, 165);
            txt_Fn.Name = "txt_Fn";
            txt_Fn.Size = new Size(260, 27);
            txt_Fn.TabIndex = 8;
            // 
            // txt_Ln
            // 
            txt_Ln.Location = new Point(1031, 213);
            txt_Ln.Name = "txt_Ln";
            txt_Ln.Size = new Size(260, 27);
            txt_Ln.TabIndex = 8;
            // 
            // txt_Adn
            // 
            txt_Adn.Location = new Point(1035, 501);
            txt_Adn.Name = "txt_Adn";
            txt_Adn.Size = new Size(260, 27);
            txt_Adn.TabIndex = 8;
            // 
            // txt_Nic
            // 
            txt_Nic.Location = new Point(1035, 540);
            txt_Nic.Name = "txt_Nic";
            txt_Nic.Size = new Size(260, 27);
            txt_Nic.TabIndex = 8;
            // 
            // txt_Tel
            // 
            txt_Tel.Location = new Point(1035, 588);
            txt_Tel.Name = "txt_Tel";
            txt_Tel.Size = new Size(260, 27);
            txt_Tel.TabIndex = 8;
            // 
            // txt_Add
            // 
            txt_Add.Location = new Point(1035, 637);
            txt_Add.Name = "txt_Add";
            txt_Add.Size = new Size(260, 27);
            txt_Add.TabIndex = 8;
            // 
            // lbl_Gn
            // 
            lbl_Gn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Gn.Location = new Point(833, 318);
            lbl_Gn.Name = "lbl_Gn";
            lbl_Gn.Size = new Size(146, 23);
            lbl_Gn.TabIndex = 7;
            lbl_Gn.Text = "Grade Name";
            lbl_Gn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_Gn
            // 
            cmb_Gn.FormattingEnabled = true;
            cmb_Gn.Location = new Point(1031, 313);
            cmb_Gn.Name = "cmb_Gn";
            cmb_Gn.Size = new Size(260, 28);
            cmb_Gn.TabIndex = 6;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(998, 32);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(100, 43);
            btn_Clear.TabIndex = 9;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // DB_Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 888);
            Controls.Add(btn_Clear);
            Controls.Add(txt_Add);
            Controls.Add(txt_Tel);
            Controls.Add(txt_Nic);
            Controls.Add(txt_Adn);
            Controls.Add(txt_Ln);
            Controls.Add(txt_Fn);
            Controls.Add(txt_Sid);
            Controls.Add(lbl_Fid);
            Controls.Add(lbl_Hn);
            Controls.Add(lbl_Med);
            Controls.Add(lbl_Add);
            Controls.Add(lbl_Adn);
            Controls.Add(lbl_Tel);
            Controls.Add(lbl_Nic);
            Controls.Add(lbl_Doa);
            Controls.Add(lbl_Dob);
            Controls.Add(lbl_Gender);
            Controls.Add(lbl_Gn);
            Controls.Add(lbl_Ln);
            Controls.Add(lbl_Fn);
            Controls.Add(lbl_Sid);
            Controls.Add(cmb_Gn);
            Controls.Add(cmb_Med);
            Controls.Add(cmb_Fid);
            Controls.Add(cmb_Hn);
            Controls.Add(dtp_Doa);
            Controls.Add(dtp_Dob);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(rbn_Female);
            Controls.Add(rbn_Male);
            Controls.Add(dgv_Student);
            Controls.Add(btn_Insert);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Edit);
            Controls.Add(btn_PopShow);
            Controls.Add(btn_Show);
            Controls.Add(btn_DirectDBShow);
            Controls.Add(btn_AllGradeLoad);
            Controls.Add(btn_AllStudent);
            Controls.Add(btn_Connect);
            Name = "DB_Form2";
            Text = "DB_Form2";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Connect;
        private Button btn_AllStudent;
        private Button btn_AllGradeLoad;
        private Button btn_DirectDBShow;
        private Button btn_Show;
        private Button btn_PopShow;
        private Button btn_Edit;
        private Button btn_Delete;
        private Button btn_Insert;
        private DataGridView dgv_Student;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private RadioButton rbn_Male;
        private RadioButton rbn_Female;
        private Button button1;
        private Button button2;
        private DateTimePicker dtp_Dob;
        private DateTimePicker dtp_Doa;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox5;
        private MaskedTextBox maskedTextBox6;
        private MaskedTextBox maskedTextBox7;
        private ComboBox cmb_Hn;
        private ComboBox cmb_Fid;
        private ComboBox cmb_Med;
        private Label lbl_Sid;
        private Label lbl_Fn;
        private Label lbl_Ln;
        private Label lbl_Gender;
        private Label lbl_Dob;
        private Label lbl_Doa;
        private Label lbl_Nic;
        private Label lbl_Tel;
        private Label lbl_Adn;
        private Label lbl_Add;
        private Label lbl_Med;
        private Label lbl_Hn;
        private Label lbl_Fid;
        private TextBox txt_Sid;
        private TextBox txt_Fn;
        private TextBox txt_Ln;
        private TextBox txt_Adn;
        private TextBox txt_Nic;
        private TextBox txt_Tel;
        private TextBox txt_Add;
        private Label lbl_Gn;
        private ComboBox cmb_Gn;
        private Button btn_Clear;
    }
}
