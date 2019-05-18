namespace KelimeOgretici
{
    partial class StartApp
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Name = new MetroFramework.Controls.MetroTextBox();
            this.txt_Mail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btn_Login = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            // 
            // 
            // 
            this.txt_Name.CustomButton.Image = null;
            this.txt_Name.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txt_Name.CustomButton.Name = "";
            this.txt_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Name.CustomButton.TabIndex = 1;
            this.txt_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Name.CustomButton.UseSelectable = true;
            this.txt_Name.CustomButton.Visible = false;
            this.txt_Name.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_Name.Lines = new string[0];
            this.txt_Name.Location = new System.Drawing.Point(255, 172);
            this.txt_Name.MaxLength = 32767;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Name.SelectedText = "";
            this.txt_Name.SelectionLength = 0;
            this.txt_Name.SelectionStart = 0;
            this.txt_Name.ShortcutsEnabled = true;
            this.txt_Name.Size = new System.Drawing.Size(263, 23);
            this.txt_Name.TabIndex = 0;
            this.txt_Name.UseSelectable = true;
            this.txt_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Mail
            // 
            // 
            // 
            // 
            this.txt_Mail.CustomButton.Image = null;
            this.txt_Mail.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txt_Mail.CustomButton.Name = "";
            this.txt_Mail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Mail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Mail.CustomButton.TabIndex = 1;
            this.txt_Mail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Mail.CustomButton.UseSelectable = true;
            this.txt_Mail.CustomButton.Visible = false;
            this.txt_Mail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_Mail.Lines = new string[0];
            this.txt_Mail.Location = new System.Drawing.Point(255, 278);
            this.txt_Mail.MaxLength = 32767;
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.PasswordChar = '\0';
            this.txt_Mail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Mail.SelectedText = "";
            this.txt_Mail.SelectionLength = 0;
            this.txt_Mail.SelectionStart = 0;
            this.txt_Mail.ShortcutsEnabled = true;
            this.txt_Mail.Size = new System.Drawing.Size(263, 23);
            this.txt_Mail.TabIndex = 1;
            this.txt_Mail.UseSelectable = true;
            this.txt_Mail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Mail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(255, 137);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "AD-SOYAD";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(255, 247);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "E-POSTA";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(516, 331);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(143, 59);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "GİRİŞ";
            this.btn_Login.UseSelectable = true;
            // 
            // StartApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 495);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.txt_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartApp";
            this.Text = "KelimeOgretici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_Name;
        private MetroFramework.Controls.MetroTextBox txt_Mail;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btn_Login;
    }
}

