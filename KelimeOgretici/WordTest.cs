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
    public partial class WordTest : MetroFramework.Forms.MetroForm
    {

        KelimeOgreticiEntities3 kelimeOgren = new KelimeOgreticiEntities3();
        Random random = new Random();
        public WordTest()
        {
            InitializeComponent();
        }

        int dogruSayisi = 0, yanlisSayisi = 0;
        private void Btn_TestCevap_Click(object sender, EventArgs e)
        {
            mSonuclar(rb_S1C1);// TO-DO : Her soru için bu parametrenin değişmesi gerekiyor!
            soruSor();
        }
        private void WordTest_Load(object sender, EventArgs e)
        {
            metroLabel1.Text = "DOĞRU SAYISI";
            metroLabel2.Text = "YANLIŞ SAYISI";
            soruSor();
        }

        public void soruSor()
        {
            int maxID = kelimeOgren.tbl_KelimeListesi.Max(u => u.id); //> Son ID sayısını bulan sorgu.


            int i = random.Next(1, maxID);
            var item = (from m in kelimeOgren.tbl_KelimeListesi
                        where m.id == i
                        select m).FirstOrDefault();

            lbl_Soru.Text = item.ingilizcekelime + "Kelimesinin Türkçe Karışılığı Nedir?";

            int a = random.Next(1, maxID); //Yanlıs olan cevap buraya gelir.
            while (i == a) { a = random.Next(1, maxID); } //Aynı şıklar gelmemesi için!
            var soruSorTr2 = (from m in kelimeOgren.tbl_KelimeListesi
                              where m.id == a
                              select m).FirstOrDefault();
            lbl_Soru.Text = item.ingilizcekelime.ToString() + " Kelimesinin Türkçe Karşılığı Nedir? ";
            rb_S1C1.Text = item.turkcekelime.ToString();
            rb_S1C2.Text = soruSorTr2.turkcekelime.ToString();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        public void mSonuclar(RadioButton isaretlenmisCevap)
        {
            if (isaretlenmisCevap.Checked == true)
            {
                dogruSayisi++;
                lbl_Cevap.Text = "CEVAP DOĞRU! ";
                metroLabel1.Text = "DOĞRU SAYISI: "+ dogruSayisi.ToString();
                

            }
            else if (isaretlenmisCevap.Checked == false)
            {
                yanlisSayisi++;
                lbl_Cevap.Text = "CEVAP YANLIŞ! ";
                metroLabel2.Text = "YANLIŞ SAYISI: " + yanlisSayisi.ToString();
            }
            rb_S1C1.Checked = false;
            rb_S1C2.Checked = false;
        }
    }
}
