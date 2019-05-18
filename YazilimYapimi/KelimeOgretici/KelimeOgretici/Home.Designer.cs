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
            this.lbl_RandomWord1 = new System.Windows.Forms.Label();
            this.lbl_RandomWord2 = new System.Windows.Forms.Label();
            this.lbl_RandomWord3 = new System.Windows.Forms.Label();
            this.btn_AddWord = new MetroFramework.Controls.MetroButton();
            this.btn_MyWord = new MetroFramework.Controls.MetroButton();
            this.btn_Test = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lbl_RandomWord1
            // 
            this.lbl_RandomWord1.AutoSize = true;
            this.lbl_RandomWord1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_RandomWord1.Location = new System.Drawing.Point(113, 52);
            this.lbl_RandomWord1.Name = "lbl_RandomWord1";
            this.lbl_RandomWord1.Size = new System.Drawing.Size(70, 25);
            this.lbl_RandomWord1.TabIndex = 0;
            this.lbl_RandomWord1.Text = "label1";
            // 
            // lbl_RandomWord2
            // 
            this.lbl_RandomWord2.AutoSize = true;
            this.lbl_RandomWord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_RandomWord2.Location = new System.Drawing.Point(321, 52);
            this.lbl_RandomWord2.Name = "lbl_RandomWord2";
            this.lbl_RandomWord2.Size = new System.Drawing.Size(70, 25);
            this.lbl_RandomWord2.TabIndex = 1;
            this.lbl_RandomWord2.Text = "label2";
            // 
            // lbl_RandomWord3
            // 
            this.lbl_RandomWord3.AutoSize = true;
            this.lbl_RandomWord3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_RandomWord3.Location = new System.Drawing.Point(542, 52);
            this.lbl_RandomWord3.Name = "lbl_RandomWord3";
            this.lbl_RandomWord3.Size = new System.Drawing.Size(70, 25);
            this.lbl_RandomWord3.TabIndex = 2;
            this.lbl_RandomWord3.Text = "label3";
            // 
            // btn_AddWord
            // 
            this.btn_AddWord.Location = new System.Drawing.Point(290, 143);
            this.btn_AddWord.Name = "btn_AddWord";
            this.btn_AddWord.Size = new System.Drawing.Size(128, 47);
            this.btn_AddWord.TabIndex = 3;
            this.btn_AddWord.Text = "Kelime Ekle";
            this.btn_AddWord.UseSelectable = true;
            // 
            // btn_MyWord
            // 
            this.btn_MyWord.Location = new System.Drawing.Point(290, 228);
            this.btn_MyWord.Name = "btn_MyWord";
            this.btn_MyWord.Size = new System.Drawing.Size(128, 47);
            this.btn_MyWord.TabIndex = 4;
            this.btn_MyWord.Text = "Kelimelerim";
            this.btn_MyWord.UseSelectable = true;
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(290, 304);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(128, 47);
            this.btn_Test.TabIndex = 5;
            this.btn_Test.Text = "Sınav";
            this.btn_Test.UseSelectable = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.btn_MyWord);
            this.Controls.Add(this.btn_AddWord);
            this.Controls.Add(this.lbl_RandomWord3);
            this.Controls.Add(this.lbl_RandomWord2);
            this.Controls.Add(this.lbl_RandomWord1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RandomWord1;
        private System.Windows.Forms.Label lbl_RandomWord2;
        private System.Windows.Forms.Label lbl_RandomWord3;
        private MetroFramework.Controls.MetroButton btn_AddWord;
        private MetroFramework.Controls.MetroButton btn_MyWord;
        private MetroFramework.Controls.MetroButton btn_Test;
    }
}