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
            txtAdd = new TextBox();
            SuspendLayout();
            // 
            // txtSL
            // 
            txtSL.Location = new Point(194, 115);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(247, 27);
            txtSL.TabIndex = 8;
            // 
            // txtSF
            // 
            txtSF.Location = new Point(194, 37);
            txtSF.Name = "txtSF";
            txtSF.Size = new Size(247, 27);
            txtSF.TabIndex = 9;
            // 
            // lblSL
            // 
            lblSL.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSL.Location = new Point(33, 111);
            lblSL.Name = "lblSL";
            lblSL.Size = new Size(110, 32);
            lblSL.TabIndex = 6;
            lblSL.Text = "Last Name ";
            // 
            // lblSF
            // 
            lblSF.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSF.Location = new Point(33, 36);
            lblSF.Name = "lblSF";
            lblSF.Size = new Size(110, 32);
            lblSF.TabIndex = 7;
            lblSF.Text = "First Name ";
            // 
            // lblGn
            // 
            lblGn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGn.Location = new Point(33, 186);
            lblGn.Name = "lblGn";
            lblGn.Size = new Size(110, 32);
            lblGn.TabIndex = 6;
            lblGn.Text = "Gender";
            lblGn.Click += label1_Click;
            // 
            // rbM
            // 
            rbM.AutoSize = true;
            rbM.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbM.Location = new Point(194, 191);
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
            rbF.Location = new Point(353, 194);
            rbF.Name = "rbF";
            rbF.Size = new Size(92, 29);
            rbF.TabIndex = 10;
            rbF.TabStop = true;
            rbF.Text = "Female";
            rbF.UseVisualStyleBackColor = true;
            // 
            // lblAdd
            // 
            lblAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdd.Location = new Point(33, 250);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(110, 32);
            lblAdd.TabIndex = 6;
            lblAdd.Text = "Address";
            lblAdd.Click += label1_Click;
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(198, 250);
            txtAdd.Multiline = true;
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(247, 27);
            txtAdd.TabIndex = 8;
            // 
            // ShowStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 308);
            Controls.Add(rbF);
            Controls.Add(rbM);
            Controls.Add(txtAdd);
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
        private TextBox txtAdd;
    }
}