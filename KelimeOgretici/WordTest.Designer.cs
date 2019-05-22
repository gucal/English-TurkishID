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
            this.lbl_Soru = new MetroFramework.Controls.MetroLabel();
            this.rb_S1C2 = new MetroFramework.Controls.MetroRadioButton();
            this.rb_S1C1 = new MetroFramework.Controls.MetroRadioButton();
            this.lbl_Cevap = new MetroFramework.Controls.MetroLabel();
            this.btn_TestCevap = new MetroFramework.Controls.MetroButton();
            this.btn_Home = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lbl_Soru
            // 
            this.lbl_Soru.AutoSize = true;
            this.lbl_Soru.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Soru.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_Soru.Location = new System.Drawing.Point(133, 120);
            this.lbl_Soru.MinimumSize = new System.Drawing.Size(30, 30);
            this.lbl_Soru.Name = "lbl_Soru";
            this.lbl_Soru.Size = new System.Drawing.Size(94, 19);
            this.lbl_Soru.TabIndex = 2;
            this.lbl_Soru.Text = "metroLabel1";
            // 
            // rb_S1C2
            // 
            this.rb_S1C2.AutoSize = true;
            this.rb_S1C2.Location = new System.Drawing.Point(241, 172);
            this.rb_S1C2.MinimumSize = new System.Drawing.Size(20, 20);
            this.rb_S1C2.Name = "rb_S1C2";
            this.rb_S1C2.Size = new System.Drawing.Size(49, 20);
            this.rb_S1C2.TabIndex = 1;
            this.rb_S1C2.Text = "Mavi";
            this.rb_S1C2.UseSelectable = true;
            // 
            // rb_S1C1
            // 
            this.rb_S1C1.AutoSize = true;
            this.rb_S1C1.Location = new System.Drawing.Point(133, 172);
            this.rb_S1C1.MinimumSize = new System.Drawing.Size(20, 20);
            this.rb_S1C1.Name = "rb_S1C1";
            this.rb_S1C1.Size = new System.Drawing.Size(59, 20);
            this.rb_S1C1.TabIndex = 0;
            this.rb_S1C1.Text = "Kırmızı";
            this.rb_S1C1.UseSelectable = true;
            // 
            // lbl_Cevap
            // 
            this.lbl_Cevap.AutoSize = true;
            this.lbl_Cevap.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_Cevap.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Cevap.Location = new System.Drawing.Point(350, 261);
            this.lbl_Cevap.Name = "lbl_Cevap";
            this.lbl_Cevap.Size = new System.Drawing.Size(91, 25);
            this.lbl_Cevap.TabIndex = 1;
            this.lbl_Cevap.Text = "S O N U Ç";
            // 
            // btn_TestCevap
            // 
            this.btn_TestCevap.Location = new System.Drawing.Point(133, 246);
            this.btn_TestCevap.Name = "btn_TestCevap";
            this.btn_TestCevap.Size = new System.Drawing.Size(141, 50);
            this.btn_TestCevap.TabIndex = 2;
            this.btn_TestCevap.Text = "Cevabı Kaydet";
            this.btn_TestCevap.UseSelectable = true;
            this.btn_TestCevap.Click += new System.EventHandler(this.Btn_TestCevap_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(673, 352);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(96, 44);
            this.btn_Home.TabIndex = 3;
            this.btn_Home.Text = "Ana Sayfa";
            this.btn_Home.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Home.UseSelectable = true;
            this.btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(615, 131);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(615, 172);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "metroLabel2";
            // 
            // WordTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 419);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lbl_Soru);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.rb_S1C2);
            this.Controls.Add(this.btn_TestCevap);
            this.Controls.Add(this.rb_S1C1);
            this.Controls.Add(this.lbl_Cevap);
            this.Name = "WordTest";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Kelime Testi";
            this.Load += new System.EventHandler(this.WordTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroRadioButton rb_S1C1;
        private MetroFramework.Controls.MetroRadioButton rb_S1C2;
        private MetroFramework.Controls.MetroLabel lbl_Cevap;
        private MetroFramework.Controls.MetroButton btn_TestCevap;
        private MetroFramework.Controls.MetroLabel lbl_Soru;
        private MetroFramework.Controls.MetroButton btn_Home;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}