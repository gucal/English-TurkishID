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
    public partial class WordTest : Form
    {

        KelimeOgreticiEntities1 kelimeOgren = new KelimeOgreticiEntities1();
        Random random = new Random();
        public WordTest()
        {
            InitializeComponent();
        }

        int dogruSayisi = 0, yanlisSayisi = 0;
        private void Btn_TestCevap_Click(object sender, EventArgs e)
        {
            mSonuclar(rb_S1C1);// TO-DO : Her soru için bu parametrenin değişmesi gerekiyor!
          //  soruSor();
        }

        public void soruSor()
        // TO-DO : Zamana bağlı çalıştır.
        {


            
            var query = kelimeOgren.tbl_KelimeListesi.OrderBy(x => x.id).Skip(random.Next(0, kelimeOgren.tbl_KelimeListesi.Count())).Take(1).FirstOrDefault();

        //    int soruRandSayi = random.Next(1, 40);
        //    var soruSorTr = (from m in kelimeOgren.tbl_KelimeListesi
        //                     where m.id == soruRandSayi
        //                     select m).FirstOrDefault();
        //    int soruRandSayi2 = random.Next(1, 40); //Yanlıs olan cevap buraya gelir.
        //    while (soruRandSayi == soruRandSayi2) { soruRandSayi2 = random.Next(1, 40); } //Aynı şıklar gelmemesi için!
        //    var soruSorTr2 = (from m in kelimeOgren.tbl_KelimeListesi
        //                      where m.id == soruRandSayi2
        //                      select m).FirstOrDefault();
        //    lbl_Soru.Text = soruSorTr.ingilizcekelime.ToString() + " Kelimesinin Türkçe Karşılığı Nedir? ";
        //    rb_S1C1.Text = soruSorTr.turkcekelime.ToString();
        //    rb_S1C2.Text = soruSorTr2.turkcekelime.ToString();
        //}
        }
        private void WordTest_Load(object sender, EventArgs e)
        {
          //  soruSor();
        }

        public void mSonuclar(RadioButton isaretlenmisCevap)
        {
            if (isaretlenmisCevap.Checked == true)
            {
                dogruSayisi++;
                isaretlenmisCevap.BackColor = Color.Green;//TO-DO: ÇALIŞMIYOR | GUI DUZENI ICIN ONEMLİ
                lbl_Cevap.Text = "CEVAP DOĞRU! ";

            }
            else if (isaretlenmisCevap.Checked == false)
            {
                yanlisSayisi++;
                isaretlenmisCevap.BackColor = Color.Red; // TO-DO : ŞU AN ÇALIŞMIYOR | GUI DUZENI ICIN ONEMLİ
                lbl_Cevap.Text = "CEVAP YANLIŞ! ";
            }
            rb_S1C1.Checked = false;
            rb_S1C2.Checked = false;
        }


        /*void Test()
        {
            
            var soruSorTr = (from m in kelimeOgren.tbl_KelimeListesi
                             where m.id == soruRandSayi
                             select m).FirstOrDefault();
            int cevapRandSayi = random.Next(1, 3);
            if(cevapRandSayi == 1)
            {
                rb_S1C1.Text = soruSorTr.turkcekelime.ToString();
                mSonuclar(rb_S1C1);
            }
            else { rb_S1C2.Text = soruSorTr.turkcekelime.ToString();
                mSonuclar(rb_S1C2);
            }
        }*/

        
    }
}
