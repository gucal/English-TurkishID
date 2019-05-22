namespace KelimeOgretici
{
    partial class Scene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scene));
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_Izle = new MetroFramework.Controls.MetroButton();
            this.btn_Home = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Simple Past Tense",
            "Simple Present Tense",
            "Present Continuous Tense",
            "Simple Past Tense 2",
            "Simple Present Tense 2",
            "Present Continuous Tense 2 "});
            this.metroComboBox1.Location = new System.Drawing.Point(10, 189);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(198, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 152);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(185, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "İzlemek istediğiniz türü seçiniz.";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(242, 40);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(808, 478);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // btn_Izle
            // 
            this.btn_Izle.Location = new System.Drawing.Point(37, 251);
            this.btn_Izle.Name = "btn_Izle";
            this.btn_Izle.Size = new System.Drawing.Size(134, 55);
            this.btn_Izle.TabIndex = 3;
            this.btn_Izle.Text = "İzle";
            this.btn_Izle.UseSelectable = true;
            this.btn_Izle.Click += new System.EventHandler(this.Btn_Izle_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(10, 482);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(89, 36);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.Text = "Ana Sayfa";
            this.btn_Home.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Home.UseSelectable = true;
            this.btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // Scene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 527);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_Izle);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroComboBox1);
            this.Name = "Scene";
            this.Text = "Sahne";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private MetroFramework.Controls.MetroButton btn_Izle;
        private MetroFramework.Controls.MetroButton btn_Home;
    }
}