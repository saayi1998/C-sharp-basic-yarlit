namespace WinFormsApp2
{
    partial class Main_Menu
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
            btn_Student = new Button();
            btn_Grade = new Button();
            lbl_Title = new Label();
            SuspendLayout();
            // 
            // btn_Student
            // 
            btn_Student.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Student.Location = new Point(60, 119);
            btn_Student.Name = "btn_Student";
            btn_Student.Size = new Size(313, 72);
            btn_Student.TabIndex = 0;
            btn_Student.Text = "Student ";
            btn_Student.UseVisualStyleBackColor = true;
            btn_Student.Click += btn_Student_Click;
            // 
            // btn_Grade
            // 
            btn_Grade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Grade.Location = new Point(60, 247);
            btn_Grade.Name = "btn_Grade";
            btn_Grade.Size = new Size(313, 72);
            btn_Grade.TabIndex = 0;
            btn_Grade.Text = "Grade";
            btn_Grade.UseVisualStyleBackColor = true;
            btn_Grade.Click += btn_Grade_Click;
            // 
            // lbl_Title
            // 
            lbl_Title.BackColor = Color.IndianRed;
            lbl_Title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.Transparent;
            lbl_Title.Location = new Point(-3, 9);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(428, 66);
            lbl_Title.TabIndex = 1;
            lbl_Title.Text = "Main Menu";
            lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 371);
            Controls.Add(lbl_Title);
            Controls.Add(btn_Grade);
            Controls.Add(btn_Student);
            Name = "Main_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Student;
        private Button btn_Grade;
        private Label lbl_Title;
    }
}