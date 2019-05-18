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
            ((System.ComponentModel.ISupportInitialize)(this.dgw_MyWord)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_MyWord
            // 
            this.dgw_MyWord.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgw_MyWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_MyWord.Location = new System.Drawing.Point(7, 122);
            this.dgw_MyWord.Name = "dgw_MyWord";
            this.dgw_MyWord.ShowEditingIcon = false;
            this.dgw_MyWord.Size = new System.Drawing.Size(898, 334);
            this.dgw_MyWord.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(397, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "KELİMELERİM";
            // 
            // MyWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 468);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgw_MyWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MyWords";
            this.Text = "MyWords";
            this.Load += new System.EventHandler(this.MyWords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_MyWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_MyWord;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}