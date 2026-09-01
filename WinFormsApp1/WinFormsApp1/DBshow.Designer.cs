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
            txtL1 = new TextBox();
            txtF1 = new TextBox();
            lblL = new Label();
            lblF = new Label();
            SuspendLayout();
            // 
            // txtL1
            // 
            txtL1.Location = new Point(188, 101);
            txtL1.Name = "txtL1";
            txtL1.Size = new Size(239, 27);
            txtL1.TabIndex = 12;
            // 
            // txtF1
            // 
            txtF1.Location = new Point(188, 41);
            txtF1.Name = "txtF1";
            txtF1.Size = new Size(239, 27);
            txtF1.TabIndex = 13;
            // 
            // lblL
            // 
            lblL.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblL.Location = new Point(40, 101);
            lblL.Name = "lblL";
            lblL.Size = new Size(110, 32);
            lblL.TabIndex = 9;
            lblL.Text = "First Name ";
            // 
            // lblF
            // 
            lblF.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblF.Location = new Point(40, 41);
            lblF.Name = "lblF";
            lblF.Size = new Size(110, 32);
            lblF.TabIndex = 10;
            lblF.Text = "ID NO";
            // 
            // DBshow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 187);
            Controls.Add(txtL1);
            Controls.Add(txtF1);
            Controls.Add(lblL);
            Controls.Add(lblF);
            Name = "DBshow";
            Text = "DBshow";
            Load += DBshow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtL1;
        private TextBox txtF1;
        private Label lblL;
        private Label lblF;
    }
}