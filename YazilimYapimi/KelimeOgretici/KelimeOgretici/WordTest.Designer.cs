namespace KelimeOgretici
{
    partial class WordTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Soru = new MetroFramework.Controls.MetroLabel();
            this.rb_S1C2 = new MetroFramework.Controls.MetroRadioButton();
            this.rb_S1C1 = new MetroFramework.Controls.MetroRadioButton();
            this.lbl_Cevap = new MetroFramework.Controls.MetroLabel();
            this.btn_TestCevap = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Soru);
            this.groupBox1.Controls.Add(this.rb_S1C2);
            this.groupBox1.Controls.Add(this.rb_S1C1);
            this.groupBox1.Location = new System.Drawing.Point(30, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soru 1";
            // 
            // lbl_Soru
            // 
            this.lbl_Soru.AutoSize = true;
            this.lbl_Soru.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Soru.Location = new System.Drawing.Point(18, 20);
            this.lbl_Soru.Name = "lbl_Soru";
            this.lbl_Soru.Size = new System.Drawing.Size(81, 19);
            this.lbl_Soru.TabIndex = 2;
            this.lbl_Soru.Text = "metroLabel1";
            // 
            // rb_S1C2
            // 
            this.rb_S1C2.AutoSize = true;
            this.rb_S1C2.Location = new System.Drawing.Point(171, 61);
            this.rb_S1C2.Name = "rb_S1C2";
            this.rb_S1C2.Size = new System.Drawing.Size(49, 15);
            this.rb_S1C2.TabIndex = 1;
            this.rb_S1C2.Text = "Mavi";
            this.rb_S1C2.UseSelectable = true;
            // 
            // rb_S1C1
            // 
            this.rb_S1C1.AutoSize = true;
            this.rb_S1C1.Location = new System.Drawing.Point(18, 61);
            this.rb_S1C1.Name = "rb_S1C1";
            this.rb_S1C1.Size = new System.Drawing.Size(59, 15);
            this.rb_S1C1.TabIndex = 0;
            this.rb_S1C1.Text = "Kırmızı";
            this.rb_S1C1.UseSelectable = true;
            // 
            // lbl_Cevap
            // 
            this.lbl_Cevap.AutoSize = true;
            this.lbl_Cevap.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Cevap.Location = new System.Drawing.Point(90, 241);
            this.lbl_Cevap.Name = "lbl_Cevap";
            this.lbl_Cevap.Size = new System.Drawing.Size(71, 19);
            this.lbl_Cevap.TabIndex = 1;
            this.lbl_Cevap.Text = "S O N U Ç";
            // 
            // btn_TestCevap
            // 
            this.btn_TestCevap.Location = new System.Drawing.Point(72, 147);
            this.btn_TestCevap.Name = "btn_TestCevap";
            this.btn_TestCevap.Size = new System.Drawing.Size(134, 49);
            this.btn_TestCevap.TabIndex = 2;
            this.btn_TestCevap.Text = "Cevabı Kaydet";
            this.btn_TestCevap.UseSelectable = true;
            this.btn_TestCevap.Click += new System.EventHandler(this.Btn_TestCevap_Click);
            // 
            // WordTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 463);
            this.Controls.Add(this.btn_TestCevap);
            this.Controls.Add(this.lbl_Cevap);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WordTest";
            this.Text = "WordTest";
            this.Load += new System.EventHandler(this.WordTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rb_S1C1;
        private MetroFramework.Controls.MetroRadioButton rb_S1C2;
        private MetroFramework.Controls.MetroLabel lbl_Cevap;
        private MetroFramework.Controls.MetroButton btn_TestCevap;
        private MetroFramework.Controls.MetroLabel lbl_Soru;
    }
}