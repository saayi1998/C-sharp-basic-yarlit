namespace WinFormsApp2
{
    partial class Gd_Form2
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
            lbl_Gid = new Label();
            dgv_Grade = new DataGridView();
            txt_Gid = new TextBox();
            lbl_Grn = new Label();
            txt_Grn = new TextBox();
            lbl_Grg = new Label();
            lbl_Gro = new Label();
            lbl_GrC = new Label();
            btn_Insert = new Button();
            btn_Delete = new Button();
            btn_Edit = new Button();
            btn_Show = new Button();
            btn_Allgrade = new Button();
            btn_Color = new Button();
            panel1 = new Panel();
            txt_Grg = new TextBox();
            txt_Gro = new TextBox();
            btn_Clear = new Button();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)dgv_Grade).BeginInit();
            SuspendLayout();
            // 
            // lbl_Gid
            // 
            lbl_Gid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Gid.Location = new Point(757, 103);
            lbl_Gid.Name = "lbl_Gid";
            lbl_Gid.Size = new Size(90, 43);
            lbl_Gid.TabIndex = 1;
            lbl_Gid.Text = "Grade ID";
            // 
            // dgv_Grade
            // 
            dgv_Grade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Grade.Location = new Point(12, 92);
            dgv_Grade.Name = "dgv_Grade";
            dgv_Grade.RowHeadersWidth = 51;
            dgv_Grade.Size = new Size(723, 311);
            dgv_Grade.TabIndex = 2;
            // 
            // txt_Gid
            // 
            txt_Gid.Location = new Point(922, 103);
            txt_Gid.Name = "txt_Gid";
            txt_Gid.ReadOnly = true;
            txt_Gid.Size = new Size(273, 27);
            txt_Gid.TabIndex = 3;
            // 
            // lbl_Grn
            // 
            lbl_Grn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Grn.Location = new Point(757, 150);
            lbl_Grn.Name = "lbl_Grn";
            lbl_Grn.Size = new Size(144, 43);
            lbl_Grn.TabIndex = 1;
            lbl_Grn.Text = "Grade Name";
            // 
            // txt_Grn
            // 
            txt_Grn.Location = new Point(922, 150);
            txt_Grn.Name = "txt_Grn";
            txt_Grn.Size = new Size(273, 27);
            txt_Grn.TabIndex = 3;
            // 
            // lbl_Grg
            // 
            lbl_Grg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Grg.Location = new Point(757, 197);
            lbl_Grg.Name = "lbl_Grg";
            lbl_Grg.Size = new Size(144, 43);
            lbl_Grg.TabIndex = 1;
            lbl_Grg.Text = "Grade Group";
            // 
            // lbl_Gro
            // 
            lbl_Gro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Gro.Location = new Point(757, 248);
            lbl_Gro.Name = "lbl_Gro";
            lbl_Gro.Size = new Size(144, 43);
            lbl_Gro.TabIndex = 1;
            lbl_Gro.Text = "Grade Order";
            // 
            // lbl_GrC
            // 
            lbl_GrC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_GrC.Location = new Point(757, 291);
            lbl_GrC.Name = "lbl_GrC";
            lbl_GrC.Size = new Size(144, 43);
            lbl_GrC.TabIndex = 1;
            lbl_GrC.Text = "Grade Color";
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(766, 354);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(176, 49);
            btn_Insert.TabIndex = 4;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(1019, 354);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(176, 49);
            btn_Delete.TabIndex = 4;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(1019, 12);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(176, 49);
            btn_Edit.TabIndex = 4;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Show
            // 
            btn_Show.Location = new Point(757, 12);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new Size(176, 49);
            btn_Show.TabIndex = 4;
            btn_Show.Text = "Show";
            btn_Show.UseVisualStyleBackColor = true;
            btn_Show.Click += btn_Show_Click;
            // 
            // btn_Allgrade
            // 
            btn_Allgrade.Location = new Point(12, 12);
            btn_Allgrade.Name = "btn_Allgrade";
            btn_Allgrade.Size = new Size(176, 49);
            btn_Allgrade.TabIndex = 4;
            btn_Allgrade.Text = "All Grade";
            btn_Allgrade.UseVisualStyleBackColor = true;
            btn_Allgrade.Click += btn_Allgrade_Click;
            // 
            // btn_Color
            // 
            btn_Color.Location = new Point(922, 294);
            btn_Color.Name = "btn_Color";
            btn_Color.Size = new Size(141, 29);
            btn_Color.TabIndex = 7;
            btn_Color.Text = "Pick Color";
            btn_Color.UseVisualStyleBackColor = true;
            btn_Color.Click += btn_Color_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(1091, 294);
            panel1.Name = "panel1";
            panel1.Size = new Size(95, 29);
            panel1.TabIndex = 9;
            // 
            // txt_Grg
            // 
            txt_Grg.Location = new Point(922, 201);
            txt_Grg.Name = "txt_Grg";
            txt_Grg.Size = new Size(273, 27);
            txt_Grg.TabIndex = 3;
            // 
            // txt_Gro
            // 
            txt_Gro.Location = new Point(922, 252);
            txt_Gro.Name = "txt_Gro";
            txt_Gro.Size = new Size(273, 27);
            txt_Gro.TabIndex = 3;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(229, 12);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(167, 49);
            btn_Clear.TabIndex = 10;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // Gd_Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 459);
            Controls.Add(btn_Clear);
            Controls.Add(panel1);
            Controls.Add(btn_Color);
            Controls.Add(btn_Allgrade);
            Controls.Add(btn_Show);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Insert);
            Controls.Add(txt_Gro);
            Controls.Add(txt_Grg);
            Controls.Add(txt_Grn);
            Controls.Add(txt_Gid);
            Controls.Add(dgv_Grade);
            Controls.Add(lbl_GrC);
            Controls.Add(lbl_Gro);
            Controls.Add(lbl_Grg);
            Controls.Add(lbl_Grn);
            Controls.Add(lbl_Gid);
            Name = "Gd_Form2";
            Text = "Gd_Form2";
            Load += Gd_Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Grade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Gid;
        private DataGridView dgv_Grade;
        private TextBox txt_Gid;
        private Label lbl_Grn;
        private TextBox txt_Grn;
        private Label lbl_Grg;
        private Label lbl_Gro;
        private Label lbl_GrC;
        private Button btn_Insert;
        private Button btn_Delete;
        private Button btn_Edit;
        private Button btn_Show;
        private Button btn_Allgrade;
        private Button btn_Color;
        private Panel panel1;
        private TextBox txt_Grg;
        private TextBox txt_Gro;
        private Button btn_Clear;
        private ColorDialog colorDialog1;
    }
}