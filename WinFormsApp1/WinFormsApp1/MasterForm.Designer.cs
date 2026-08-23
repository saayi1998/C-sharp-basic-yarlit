namespace WinFormsApp1
{
    partial class MasterForm
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
            btnM2 = new Button();
            btnM1 = new Button();
            SuspendLayout();
            // 
            // btnM2
            // 
            btnM2.BackColor = SystemColors.ActiveCaption;
            btnM2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnM2.Location = new Point(33, 189);
            btnM2.Name = "btnM2";
            btnM2.Size = new Size(370, 49);
            btnM2.TabIndex = 0;
            btnM2.Text = "Student Details Form       ->";
            btnM2.TextAlign = ContentAlignment.MiddleLeft;
            btnM2.TextImageRelation = TextImageRelation.ImageAboveText;
            btnM2.UseVisualStyleBackColor = false;
            btnM2.Click += btnM2_Click;
            // 
            // btnM1
            // 
            btnM1.BackColor = SystemColors.ActiveCaption;
            btnM1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnM1.Location = new Point(33, 105);
            btnM1.Name = "btnM1";
            btnM1.Size = new Size(370, 49);
            btnM1.TabIndex = 0;
            btnM1.Text = "Full Name Form              ->";
            btnM1.TextAlign = ContentAlignment.MiddleLeft;
            btnM1.UseMnemonic = false;
            btnM1.UseVisualStyleBackColor = false;
            btnM1.Click += btnM1_Click;
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 350);
            Controls.Add(btnM1);
            Controls.Add(btnM2);
            Name = "MasterForm";
            Text = "MasterForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnM2;
        protected Button btnM1;
    }
}