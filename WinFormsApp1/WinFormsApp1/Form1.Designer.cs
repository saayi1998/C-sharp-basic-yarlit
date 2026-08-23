namespace WinFormsApp1
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
            btn_save = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelf = new Label();
            labell = new Label();
            labelh = new Label();
            lblShow = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.Location = new Point(514, 280);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(126, 56);
            btn_save.TabIndex = 2;
            btn_save.Text = "save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(242, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(411, 52);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(242, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(411, 52);
            textBox2.TabIndex = 1;
            // 
            // labelf
            // 
            labelf.AutoSize = true;
            labelf.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold);
            labelf.Location = new Point(12, 98);
            labelf.Name = "labelf";
            labelf.Size = new Size(207, 48);
            labelf.TabIndex = 3;
            labelf.Text = "First Name";
            // 
            // labell
            // 
            labell.AutoSize = true;
            labell.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold);
            labell.Location = new Point(12, 162);
            labell.Name = "labell";
            labell.Size = new Size(198, 48);
            labell.TabIndex = 3;
            labell.Text = "Last Name";
            // 
            // labelh
            // 
            labelh.BackColor = SystemColors.ControlText;
            labelh.Font = new Font("Comic Sans MS", 25.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelh.ForeColor = SystemColors.ButtonFace;
            labelh.Location = new Point(12, 9);
            labelh.Name = "labelh";
            labelh.Size = new Size(648, 57);
            labelh.TabIndex = 3;
            labelh.Text = "FULL NAME";
            // 
            // lblShow
            // 
            lblShow.BackColor = Color.Transparent;
            lblShow.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShow.ForeColor = Color.Red;
            lblShow.Location = new Point(12, 290);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(450, 46);
            lblShow.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 370);
            Controls.Add(lblShow);
            Controls.Add(labell);
            Controls.Add(labelh);
            Controls.Add(labelf);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_save);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_save;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelf;
        private Label labell;
        private Label labelh;
        private TextBox textBox3;
        private Label lblShow;
        private System.Windows.Forms.Timer timer1;
    }
}
