namespace WinFormsApp2
{
    partial class From_Edit_Grade2
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
            btn_Update = new Button();
            txt_Gro = new TextBox();
            txt_Grg = new TextBox();
            txt_Grn = new TextBox();
            txt_Gid = new TextBox();
            lbl_GrC = new Label();
            lbl_Gro = new Label();
            lbl_Grg = new Label();
            lbl_Grn = new Label();
            lbl_Gid = new Label();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(367, 266);
            panel1.Name = "panel1";
            panel1.Size = new Size(95, 29);
            panel1.TabIndex = 22;
            // 
            // btn_Color
            // 
            btn_Color.Location = new Point(198, 266);
            btn_Color.Name = "btn_Color";
            btn_Color.Size = new Size(141, 29);
            btn_Color.TabIndex = 21;
            btn_Color.Text = "Pick Color";
            btn_Color.UseVisualStyleBackColor = true;
            btn_Color.Click += btn_Color_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(152, 327);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(176, 49);
            btn_Update.TabIndex = 20;
            btn_Update.Text = "Update";
            btn_Update.UseCompatibleTextRendering = true;
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // txt_Gro
            // 
            txt_Gro.Location = new Point(198, 224);
            txt_Gro.Name = "txt_Gro";
            txt_Gro.Size = new Size(273, 27);
            txt_Gro.TabIndex = 15;
            // 
            // txt_Grg
            // 
            txt_Grg.Location = new Point(198, 173);
            txt_Grg.Name = "txt_Grg";
            txt_Grg.Size = new Size(273, 27);
            txt_Grg.TabIndex = 16;
            // 
            // txt_Grn
            // 
            txt_Grn.Location = new Point(198, 122);
            txt_Grn.Name = "txt_Grn";
            txt_Grn.Size = new Size(273, 27);
            txt_Grn.TabIndex = 17;
            // 
            // txt_Gid
            // 
            txt_Gid.Location = new Point(198, 75);
            txt_Gid.Name = "txt_Gid";
            txt_Gid.ReadOnly = true;
            txt_Gid.Size = new Size(273, 27);
            txt_Gid.TabIndex = 18;
            // 
            // lbl_GrC
            // 
            lbl_GrC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_GrC.Location = new Point(33, 263);
            lbl_GrC.Name = "lbl_GrC";
            lbl_GrC.Size = new Size(144, 43);
            lbl_GrC.TabIndex = 10;
            lbl_GrC.Text = "Grade Color";
            // 
            // lbl_Gro
            // 
            lbl_Gro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Gro.Location = new Point(33, 220);
            lbl_Gro.Name = "lbl_Gro";
            lbl_Gro.Size = new Size(144, 43);
            lbl_Gro.TabIndex = 11;
            lbl_Gro.Text = "Grade Order";
            // 
            // lbl_Grg
            // 
            lbl_Grg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Grg.Location = new Point(33, 169);
            lbl_Grg.Name = "lbl_Grg";
            lbl_Grg.Size = new Size(144, 43);
            lbl_Grg.TabIndex = 12;
            lbl_Grg.Text = "Grade Group";
            // 
            // lbl_Grn
            // 
            lbl_Grn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Grn.Location = new Point(33, 122);
            lbl_Grn.Name = "lbl_Grn";
            lbl_Grn.Size = new Size(144, 43);
            lbl_Grn.TabIndex = 13;
            lbl_Grn.Text = "Grade Name";
            // 
            // lbl_Gid
            // 
            lbl_Gid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Gid.Location = new Point(33, 75);
            lbl_Gid.Name = "lbl_Gid";
            lbl_Gid.Size = new Size(90, 43);
            lbl_Gid.TabIndex = 14;
            lbl_Gid.Text = "Grade ID";
            // 
            // From_Edit_Grade2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 450);
            Controls.Add(panel1);
            Controls.Add(btn_Color);
            Controls.Add(btn_Update);
            Controls.Add(txt_Gro);
            Controls.Add(txt_Grg);
            Controls.Add(txt_Grn);
            Controls.Add(txt_Gid);
            Controls.Add(lbl_GrC);
            Controls.Add(lbl_Gro);
            Controls.Add(lbl_Grg);
            Controls.Add(lbl_Grn);
            Controls.Add(lbl_Gid);
            Name = "From_Edit_Grade2";
            Text = "From_Edit_Grade2";
            Load += From_Edit_Grade2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_Color;
        private Button btn_Update;
        private TextBox txt_Gro;
        private TextBox txt_Grg;
        private TextBox txt_Grn;
        private TextBox txt_Gid;
        private Label lbl_GrC;
        private Label lbl_Gro;
        private Label lbl_Grg;
        private Label lbl_Grn;
        private Label lbl_Gid;
        private ColorDialog colorDialog1;
    }
}