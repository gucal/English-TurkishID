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
    public partial class AddWord : Form
    {

        DateTime zaman = new DateTime();
        public AddWord()
        {
            InitializeComponent();
        }

        KelimeOgreticiEntities1 kelimeOgren = new KelimeOgreticiEntities1();
        private void Btn_NewWord_Click(object sender, EventArgs e)
        {
            addWord();
        }

        void zamanIslemleri()
        {  
            lbl_Sure.Text = DateTime.Now.ToString();//ŞİMDİKİ ZAMAN            
            lbl_Sure2.Text = (Convert.ToDateTime(lbl_Sure.Text).AddHours(24)).ToString();//24 SAAT EKLENMİŞ HALİ -->> TO DO: Şimdiki Zamanı Al!
            TimeSpan gun1 = (Convert.ToDateTime(lbl_Sure.Text).AddHours(24)) - (Convert.ToDateTime(lbl_Sure.Text)); // IKI ZAMAN ARASI FARKI BULUR
            int a = Convert.ToInt32(gun1.TotalHours.ToString());
            if (a >= 1)
            {
                MessageBox.Show("1 Gün GEÇMİŞ");
            }
        }
        void addWord() //KELIME EKLE -> 
        {
            tbl_KelimeListesi addTable = new tbl_KelimeListesi();
            addTable.ingilizcekelime = txt_EnglishWord.Text;
            addTable.turkcekelime = txt_TurkishWord.Text;
            addTable.cumle = txt_Sentence.Text;

                if (rb_Sifat.Checked) 
                {
                    addTable.gramer = "Sıfat";
                }
                else if (rb_Fiil.Checked)
                {
                    addTable.gramer = "Fiil";
                }
                else if (rb_Isim.Checked)
                {
                    addTable.gramer = "Isim";
                }
                else if (rb_Zarf.Checked)
                {
                    addTable.gramer = "Edat";
                }
                else if (rb_Baglac.Checked)
                {
                    addTable.gramer = "Bağlaç";
                }

                 DateTime zaman = DateTime.Now;
                addTable.tarih = zaman;
                kelimeOgren.tbl_KelimeListesi.Add(addTable);
                kelimeOgren.SaveChanges();
                MessageBox.Show("Kelime Sisteme Başarıyla Kaydedildi!");            
        }

    }
}
