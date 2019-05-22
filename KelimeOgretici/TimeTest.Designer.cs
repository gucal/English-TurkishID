namespace KelimeOgretici
{
    partial class TimeTest
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_Answer = new MetroFramework.Controls.MetroTextBox();
            this.btn_Cevap = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(134, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // txt_Answer
            // 
            // 
            // 
            // 
            this.txt_Answer.CustomButton.Image = null;
            this.txt_Answer.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txt_Answer.CustomButton.Name = "";
            this.txt_Answer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Answer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Answer.CustomButton.TabIndex = 1;
            this.txt_Answer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Answer.CustomButton.UseSelectable = true;
            this.txt_Answer.CustomButton.Visible = false;
            this.txt_Answer.Lines = new string[0];
            this.txt_Answer.Location = new System.Drawing.Point(134, 122);
            this.txt_Answer.MaxLength = 32767;
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.PasswordChar = '\0';
            this.txt_Answer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Answer.SelectedText = "";
            this.txt_Answer.SelectionLength = 0;
            this.txt_Answer.SelectionStart = 0;
            this.txt_Answer.ShortcutsEnabled = true;
            this.txt_Answer.Size = new System.Drawing.Size(189, 23);
            this.txt_Answer.TabIndex = 1;
            this.txt_Answer.UseSelectable = true;
            this.txt_Answer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Answer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_Cevap
            // 
            this.btn_Cevap.Location = new System.Drawing.Point(165, 210);
            this.btn_Cevap.Name = "btn_Cevap";
            this.btn_Cevap.Size = new System.Drawing.Size(158, 58);
            this.btn_Cevap.TabIndex = 2;
            this.btn_Cevap.Text = "OKEY";
            this.btn_Cevap.UseSelectable = true;
            this.btn_Cevap.Click += new System.EventHandler(this.Btn_Cevap_Click);
            // 
            // TimeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cevap);
            this.Controls.Add(this.txt_Answer);
            this.Controls.Add(this.metroLabel1);
            this.Name = "TimeTest";
            this.Text = "Sınav";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_Answer;
        private MetroFramework.Controls.MetroButton btn_Cevap;
    }
}