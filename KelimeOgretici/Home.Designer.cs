namespace KelimeOgretici
{
    partial class Home
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
            this.btn_AddWord = new MetroFramework.Controls.MetroButton();
            this.btn_MyWords = new MetroFramework.Controls.MetroButton();
            this.btn_Test = new MetroFramework.Controls.MetroButton();
            this.btn_Istatistik = new MetroFramework.Controls.MetroButton();
            this.btn_Sahne = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_AddWord
            // 
            this.btn_AddWord.Location = new System.Drawing.Point(266, 223);
            this.btn_AddWord.Name = "btn_AddWord";
            this.btn_AddWord.Size = new System.Drawing.Size(168, 81);
            this.btn_AddWord.TabIndex = 8;
            this.btn_AddWord.Text = "Kelime Ekle";
            this.btn_AddWord.UseSelectable = true;
            this.btn_AddWord.Click += new System.EventHandler(this.Btn_AddWord_Click);
            // 
            // btn_MyWords
            // 
            this.btn_MyWords.Location = new System.Drawing.Point(103, 127);
            this.btn_MyWords.Name = "btn_MyWords";
            this.btn_MyWords.Size = new System.Drawing.Size(168, 81);
            this.btn_MyWords.TabIndex = 9;
            this.btn_MyWords.Text = "Kelimelerim";
            this.btn_MyWords.UseSelectable = true;
            this.btn_MyWords.Click += new System.EventHandler(this.Btn_MyWords_Click);
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(103, 319);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(168, 81);
            this.btn_Test.TabIndex = 10;
            this.btn_Test.Text = "Sınav";
            this.btn_Test.UseSelectable = true;
            this.btn_Test.Click += new System.EventHandler(this.Btn_Test_Click_1);
            // 
            // btn_Istatistik
            // 
            this.btn_Istatistik.Location = new System.Drawing.Point(430, 319);
            this.btn_Istatistik.Name = "btn_Istatistik";
            this.btn_Istatistik.Size = new System.Drawing.Size(168, 81);
            this.btn_Istatistik.TabIndex = 11;
            this.btn_Istatistik.Text = "İstatistik Görüntüle";
            this.btn_Istatistik.UseSelectable = true;
            this.btn_Istatistik.Click += new System.EventHandler(this.Btn_Istatistik_Click_1);
            // 
            // btn_Sahne
            // 
            this.btn_Sahne.Location = new System.Drawing.Point(430, 127);
            this.btn_Sahne.Name = "btn_Sahne";
            this.btn_Sahne.Size = new System.Drawing.Size(168, 81);
            this.btn_Sahne.TabIndex = 12;
            this.btn_Sahne.Text = "Sahne İzle";
            this.btn_Sahne.UseSelectable = true;
            this.btn_Sahne.Click += new System.EventHandler(this.Btn_Sahne_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 512);
            this.Controls.Add(this.btn_Sahne);
            this.Controls.Add(this.btn_Istatistik);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.btn_MyWords);
            this.Controls.Add(this.btn_AddWord);
            this.Name = "Home";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_AddWord;
        private MetroFramework.Controls.MetroButton btn_MyWords;
        private MetroFramework.Controls.MetroButton btn_Test;
        private MetroFramework.Controls.MetroButton btn_Istatistik;
        private MetroFramework.Controls.MetroButton btn_Sahne;
    }
}