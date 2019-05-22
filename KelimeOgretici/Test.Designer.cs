namespace KelimeOgretici
{
    partial class Test
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
            this.btn_WordTest = new MetroFramework.Controls.MetroButton();
            this.btn_Home = new MetroFramework.Controls.MetroButton();
            this.btn_TimeTest = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_WordTest
            // 
            this.btn_WordTest.Location = new System.Drawing.Point(523, 137);
            this.btn_WordTest.Name = "btn_WordTest";
            this.btn_WordTest.Size = new System.Drawing.Size(202, 105);
            this.btn_WordTest.TabIndex = 0;
            this.btn_WordTest.Text = "İsteğe Bağlı Sınav";
            this.btn_WordTest.UseSelectable = true;
            this.btn_WordTest.Click += new System.EventHandler(this.Btn_WordTest_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(733, 397);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(127, 51);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.Text = "Ana Sayfa";
            this.btn_Home.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Home.UseSelectable = true;
            this.btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // btn_TimeTest
            // 
            this.btn_TimeTest.Location = new System.Drawing.Point(166, 137);
            this.btn_TimeTest.Name = "btn_TimeTest";
            this.btn_TimeTest.Size = new System.Drawing.Size(202, 105);
            this.btn_TimeTest.TabIndex = 3;
            this.btn_TimeTest.Text = "Zamana Bağlı Sınav";
            this.btn_TimeTest.UseSelectable = true;
            this.btn_TimeTest.Click += new System.EventHandler(this.Btn_TimeTest_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 471);
            this.Controls.Add(this.btn_TimeTest);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_WordTest);
            this.Name = "Test";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_WordTest;
        private MetroFramework.Controls.MetroButton btn_Home;
        private MetroFramework.Controls.MetroButton btn_TimeTest;
    }
}