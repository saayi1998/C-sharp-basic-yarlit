namespace WinFormsApp3
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txt_Ln = new TextBox();
            txt_Fn = new TextBox();
            txt_Sid = new TextBox();
            lbl_Ln = new Label();
            lbl_Fn = new Label();
            lbl_Gid = new Label();
            lbl_Gn = new Label();
            cmb_Gn = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(577, 446);
            dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txt_Ln
            // 
            txt_Ln.Location = new Point(837, 261);
            txt_Ln.Name = "txt_Ln";
            txt_Ln.Size = new Size(260, 27);
            txt_Ln.TabIndex = 12;
            // 
            // txt_Fn
            // 
            txt_Fn.Location = new Point(837, 213);
            txt_Fn.Name = "txt_Fn";
            txt_Fn.Size = new Size(260, 27);
            txt_Fn.TabIndex = 13;
            // 
            // txt_Sid
            // 
            txt_Sid.Location = new Point(837, 91);
            txt_Sid.Name = "txt_Sid";
            txt_Sid.Size = new Size(260, 27);
            txt_Sid.TabIndex = 14;
            // 
            // lbl_Ln
            // 
            lbl_Ln.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Ln.Location = new Point(639, 260);
            lbl_Ln.Name = "lbl_Ln";
            lbl_Ln.Size = new Size(146, 23);
            lbl_Ln.TabIndex = 9;
            lbl_Ln.Text = "Last Name";
            lbl_Ln.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Fn
            // 
            lbl_Fn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Fn.Location = new Point(639, 212);
            lbl_Fn.Name = "lbl_Fn";
            lbl_Fn.Size = new Size(146, 23);
            lbl_Fn.TabIndex = 10;
            lbl_Fn.Text = "Grade Group";
            lbl_Fn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Gid
            // 
            lbl_Gid.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Gid.Location = new Point(639, 91);
            lbl_Gid.Name = "lbl_Gid";
            lbl_Gid.Size = new Size(146, 23);
            lbl_Gid.TabIndex = 11;
            lbl_Gid.Text = "Grade ID";
            lbl_Gid.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Gn
            // 
            lbl_Gn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Gn.Location = new Point(639, 152);
            lbl_Gn.Name = "lbl_Gn";
            lbl_Gn.Size = new Size(146, 23);
            lbl_Gn.TabIndex = 16;
            lbl_Gn.Text = "Grade Name";
            lbl_Gn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_Gn
            // 
            cmb_Gn.FormattingEnabled = true;
            cmb_Gn.Location = new Point(837, 152);
            cmb_Gn.Name = "cmb_Gn";
            cmb_Gn.Size = new Size(260, 28);
            cmb_Gn.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 623);
            Controls.Add(lbl_Gn);
            Controls.Add(cmb_Gn);
            Controls.Add(txt_Ln);
            Controls.Add(txt_Fn);
            Controls.Add(txt_Sid);
            Controls.Add(lbl_Ln);
            Controls.Add(lbl_Fn);
            Controls.Add(lbl_Gid);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txt_Ln;
        private TextBox txt_Fn;
        private TextBox txt_Sid;
        private Label lbl_Ln;
        private Label lbl_Fn;
        private Label lbl_Gid;
        private Label lbl_Gn;
        private ComboBox cmb_Gn;
    }
}
