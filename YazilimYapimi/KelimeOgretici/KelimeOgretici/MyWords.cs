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
    public partial class MyWords : Form
    {
        public MyWords()
        {
            InitializeComponent();
        }

        KelimeOgreticiEntities1 kelimeOgren = new KelimeOgreticiEntities1();

        private void MyWords_Load(object sender, EventArgs e)
        {
           kelimeListele();
        }
        void kelimeListele() // Daha önce kullanıcının kaydettiği ya da veri tabanında bulunan kelimeleri listeler.                    
        {
            dgw_MyWord.DataSource = kelimeOgren.tbl_KelimeListesi.ToList();             
        }
    }
}
