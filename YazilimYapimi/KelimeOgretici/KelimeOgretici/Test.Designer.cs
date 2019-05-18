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
            this.btn_SceneTest = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_WordTest
            // 
            this.btn_WordTest.Location = new System.Drawing.Point(135, 139);
            this.btn_WordTest.Name = "btn_WordTest";
            this.btn_WordTest.Size = new System.Drawing.Size(202, 105);
            this.btn_WordTest.TabIndex = 0;
            this.btn_WordTest.Text = "Kelime Sınavı";
            this.btn_WordTest.UseSelectable = true;
            this.btn_WordTest.Click += new System.EventHandler(this.Btn_WordTest_Click);
            // 
            // btn_SceneTest
            // 
            this.btn_SceneTest.Location = new System.Drawing.Point(556, 139);
            this.btn_SceneTest.Name = "btn_SceneTest";
            this.btn_SceneTest.Size = new System.Drawing.Size(202, 105);
            this.btn_SceneTest.TabIndex = 1;
            this.btn_SceneTest.Text = "Sahne Sınavı";
            this.btn_SceneTest.UseSelectable = true;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 471);
            this.Controls.Add(this.btn_SceneTest);
            this.Controls.Add(this.btn_WordTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_WordTest;
        private MetroFramework.Controls.MetroButton btn_SceneTest;
    }
}