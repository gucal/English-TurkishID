using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOgretici
{
    public partial class MyWords : MetroFramework.Forms.MetroForm
    {
        public MyWords()
        {
            InitializeComponent();
        }

        KelimeOgreticiEntities3 kelimeOgren = new KelimeOgreticiEntities3();

        private void MyWords_Load(object sender, EventArgs e)
        {
            kelimeListele();
        }
        void kelimeListele() // Daha önce kullanıcının kaydettiği ya da veri tabanında bulunan kelimeleri listeler.                    
        {
            dgw_MyWord.DataSource = kelimeOgren.tbl_KelimeListesi.ToList();          
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
