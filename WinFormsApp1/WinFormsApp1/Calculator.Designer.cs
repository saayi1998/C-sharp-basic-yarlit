namespace WinFormsApp1
{
    partial class Calculator
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
            lblF = new Label();
            lblS = new Label();
            lblR = new Label();
            txtF = new TextBox();
            txtS = new TextBox();
            txtR = new TextBox();
            cmbAO = new ComboBox();
            btnC = new Button();
            SuspendLayout();
            // 
            // lblF
            // 
            lblF.BackColor = Color.Transparent;
            lblF.Location = new Point(35, 38);
            lblF.Name = "lblF";
            lblF.Size = new Size(121, 27);
            lblF.TabIndex = 0;
            lblF.Text = "First Number";
            lblF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblS
            // 
            lblS.BackColor = Color.Transparent;
            lblS.Location = new Point(35, 92);
            lblS.Name = "lblS";
            lblS.Size = new Size(121, 27);
            lblS.TabIndex = 0;
            lblS.Text = "Second Number";
            // 
            // lblR
            // 
            lblR.BackColor = Color.Transparent;
            lblR.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblR.Location = new Point(35, 151);
            lblR.Name = "lblR";
            lblR.Size = new Size(121, 27);
            lblR.TabIndex = 0;
            lblR.Text = "Select Operators";
            lblR.TextAlign = ContentAlignment.MiddleCenter;
            lblR.UseWaitCursor = true;
            // 
            // txtF
            // 
            txtF.Location = new Point(183, 35);
            txtF.Name = "txtF";
            txtF.Size = new Size(245, 27);
            txtF.TabIndex = 1;
            // 
            // txtS
            // 
            txtS.Location = new Point(183, 92);
            txtS.Name = "txtS";
            txtS.Size = new Size(245, 27);
            txtS.TabIndex = 1;
            // 
            // txtR
            // 
            txtR.Location = new Point(183, 208);
            txtR.Name = "txtR";
            txtR.Size = new Size(245, 27);
            txtR.TabIndex = 1;
            // 
            // cmbAO
            // 
            cmbAO.FormattingEnabled = true;
            cmbAO.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbAO.Location = new Point(183, 150);
            cmbAO.Name = "cmbAO";
            cmbAO.Size = new Size(245, 28);
            cmbAO.TabIndex = 2;
            // 
            // btnC
            // 
            btnC.BackColor = SystemColors.Highlight;
            btnC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnC.ForeColor = Color.White;
            btnC.Location = new Point(35, 208);
            btnC.Name = "btnC";
            btnC.Size = new Size(130, 37);
            btnC.TabIndex = 3;
            btnC.Text = "Calculate";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 278);
            Controls.Add(btnC);
            Controls.Add(cmbAO);
            Controls.Add(txtR);
            Controls.Add(txtS);
            Controls.Add(txtF);
            Controls.Add(lblR);
            Controls.Add(lblS);
            Controls.Add(lblF);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblF;
        private Label lblS;
        private Label lblR;
        private TextBox txtF;
        private TextBox txtS;
        private TextBox txtR;
        private ComboBox cmbAO;
        private Button btnC;
    }
}