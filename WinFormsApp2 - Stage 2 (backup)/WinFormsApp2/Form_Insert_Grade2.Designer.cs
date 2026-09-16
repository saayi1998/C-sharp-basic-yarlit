namespace WinFormsApp2
{
    partial class Form_Insert_Grade2
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
            panel1 = new Panel();
            btn_Color = new Button();
            txt_Gro = new TextBox();
            txt_Grg = new TextBox();
            txt_Grn = new TextBox();
            txt_Gid = new TextBox();
            lbl_GrC = new Label();
            lbl_Gro = new Label();
            lbl_Grg = new Label();
            lbl_Grn = new Label();
            lbl_Gid = new Label();
            btn_Create = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(186, 258);
            panel1.Name = "panel1";
            panel1.Size = new Size(159, 29);
            panel1.TabIndex = 20;
            // 
            // btn_Color
            // 
            btn_Color.Location = new Point(362, 261);
            btn_Color.Name = "btn_Color";
            btn_Color.Size = new Size(97, 29);
            btn_Color.TabIndex = 19;
            btn_Color.Text = "Pick Color";
            btn_Color.UseVisualStyleBackColor = true;
            btn_Color.Click += btn_Color_Click;
            // 
            // txt_Gro
            // 
            txt_Gro.Location = new Point(186, 219);
            txt_Gro.Name = "txt_Gro";
            txt_Gro.Size = new Size(273, 27);
            txt_Gro.TabIndex = 15;
            // 
            // txt_Grg
            // 
            txt_Grg.Location = new Point(186, 168);
            txt_Grg.Name = "txt_Grg";
            txt_Grg.Size = new Size(273, 27);
            txt_Grg.TabIndex = 16;
            // 
            // txt_Grn
            // 
            txt_Grn.Location = new Point(186, 117);
            txt_Grn.Name = "txt_Grn";
            txt_Grn.Size = new Size(273, 27);
            txt_Grn.TabIndex = 17;
            // 
            // txt_Gid
            // 
            txt_Gid.Location = new Point(186, 70);
            txt_Gid.Name = "txt_Gid";
            txt_Gid.ReadOnly = true;
            txt_Gid.Size = new Size(273, 27);
            txt_Gid.TabIndex = 18;
            // 
            // lbl_GrC
            // 
            lbl_GrC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_GrC.Location = new Point(21, 258);
            lbl_GrC.Name = "lbl_GrC";
            lbl_GrC.Size = new Size(144, 43);
            lbl_GrC.TabIndex = 10;
            lbl_GrC.Text = "Grade Color";
            // 
            // lbl_Gro
            // 
            lbl_Gro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Gro.Location = new Point(21, 215);
            lbl_Gro.Name = "lbl_Gro";
            lbl_Gro.Size = new Size(144, 43);
            lbl_Gro.TabIndex = 11;
            lbl_Gro.Text = "Grade Order";
            // 
            // lbl_Grg
            // 
            lbl_Grg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Grg.Location = new Point(21, 164);
            lbl_Grg.Name = "lbl_Grg";
            lbl_Grg.Size = new Size(144, 43);
            lbl_Grg.TabIndex = 12;
            lbl_Grg.Text = "Grade Group";
            // 
            // lbl_Grn
            // 
            lbl_Grn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Grn.Location = new Point(21, 117);
            lbl_Grn.Name = "lbl_Grn";
            lbl_Grn.Size = new Size(144, 43);
            lbl_Grn.TabIndex = 13;
            lbl_Grn.Text = "Grade Name";
            // 
            // lbl_Gid
            // 
            lbl_Gid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Gid.Location = new Point(21, 70);
            lbl_Gid.Name = "lbl_Gid";
            lbl_Gid.Size = new Size(90, 43);
            lbl_Gid.TabIndex = 14;
            lbl_Gid.Text = "Grade ID";
            // 
            // btn_Create
            // 
            btn_Create.Location = new Point(140, 336);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(176, 49);
            btn_Create.TabIndex = 21;
            btn_Create.Text = "Create";
            btn_Create.UseVisualStyleBackColor = true;
            btn_Create.Click += btn_Create_Click;
            // 
            // Form_Insert_Grade2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 407);
            Controls.Add(btn_Create);
            Controls.Add(panel1);
            Controls.Add(btn_Color);
            Controls.Add(txt_Gro);
            Controls.Add(txt_Grg);
            Controls.Add(txt_Grn);
            Controls.Add(txt_Gid);
            Controls.Add(lbl_GrC);
            Controls.Add(lbl_Gro);
            Controls.Add(lbl_Grg);
            Controls.Add(lbl_Grn);
            Controls.Add(lbl_Gid);
            Name = "Form_Insert_Grade2";
            Text = "Form_Insert_Grade2";
            Load += Form_Insert_Grade2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_Color;
        private TextBox txt_Gro;
        private TextBox txt_Grg;
        private TextBox txt_Grn;
        private TextBox txt_Gid;
        private Label lbl_GrC;
        private Label lbl_Gro;
        private Label lbl_Grg;
        private Label lbl_Grn;
        private Label lbl_Gid;
        private Button btn_Create;
        private ColorDialog colorDialog1;
    }
}