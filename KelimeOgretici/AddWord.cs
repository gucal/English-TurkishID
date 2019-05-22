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
    public partial class AddWord : MetroFramework.Forms.MetroForm
    {
        public AddWord()
        {
            InitializeComponent();
        }

        KelimeOgreticiEntities3 kelimeOgren = new KelimeOgreticiEntities3();
        private void Btn_NewWord_Click(object sender, EventArgs e)
        {
            addWord();
            girdileriSifirla();
        }

        void addWord() //KELIME EKLE METODU -> 
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
            }else { addTable.gramer = "Bilinmiyor"; }
            DateTime zaman = DateTime.Now; // -> Şimdiki zamanı SQL tabloya ekler.
            addTable.tarih = zaman;
            kelimeOgren.tbl_KelimeListesi.Add(addTable);
            kelimeOgren.SaveChanges();
            MessageBox.Show("Kelime Sisteme Başarıyla Kaydedildi!");


        }
        void girdileriSifirla() // Textboxları boşaltır.
        {
            txt_EnglishWord.Text = "";
            txt_TurkishWord.Text = "";
            txt_Sentence.Text = "";
            rb_Baglac.Checked = false; rb_Sifat.Checked = false; rb_Fiil.Checked = false; rb_Isim.Checked = false; rb_Zarf.Checked = false;
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();

        }

    }
}
