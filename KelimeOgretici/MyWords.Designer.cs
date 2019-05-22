namespace KelimeOgretici
{
    partial class MyWords
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
            this.dgw_MyWord = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_Home = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_MyWord)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_MyWord
            // 
            this.dgw_MyWord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_MyWord.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgw_MyWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_MyWord.Location = new System.Drawing.Point(9, 101);
            this.dgw_MyWord.Name = "dgw_MyWord";
            this.dgw_MyWord.ShowEditingIcon = false;
            this.dgw_MyWord.Size = new System.Drawing.Size(885, 285);
            this.dgw_MyWord.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(394, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(127, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Kelime Listesi";
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(774, 403);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(120, 53);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.Text = "Ana Sayfa";
            this.btn_Home.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Home.UseSelectable = true;
            this.btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // MyWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 468);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgw_MyWord);
            this.Name = "MyWords";
            this.Text = "Kelimelerim";
            this.Load += new System.EventHandler(this.MyWords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_MyWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_MyWord;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_Home;
    }
}