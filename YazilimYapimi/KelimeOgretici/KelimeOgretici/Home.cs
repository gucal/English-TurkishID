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
    public partial class Home : Form
    {
        KelimeOgreticiEntities1 kelimeOgren = new KelimeOgreticiEntities1();
        public Home()
        {
            InitializeComponent();
            randomKelimeListele();
        }
        
        // HOME CLASS TOP MENU UZERINE RASTGELE ONERILEN KELIMELERİ YAZAR!
        void randomKelimeListele() // TO-DO : CODE SMELLS VAR -- KISALTILACAK
        {
                Random rastgele = new Random();

              int sayi = rastgele.Next(1,12);
                var randomkelime1 = (from m in kelimeOgren.tbl_KelimeListesi
                                 where m.id == sayi
                                 select m).FirstOrDefault(); 
            lbl_RandomWord1.Text = randomkelime1.ingilizcekelime+ " : " +randomkelime1.turkcekelime;

            //----------------------------------

                sayi = rastgele.Next(1, 12); // TO-DO : Random değerlerin farklı olması gerekiyor

                var randomkelime2 = (from m in kelimeOgren.tbl_KelimeListesi
                             where m.id == sayi
                             select m).FirstOrDefault();
            lbl_RandomWord2.Text = randomkelime2.ingilizcekelime + " : " + randomkelime2.turkcekelime;
            
            //----------------------------------

            sayi = rastgele.Next(1, 12);
            var randomkelime3 = (from m in kelimeOgren.tbl_KelimeListesi
                             where m.id == sayi
                             select m).FirstOrDefault();
            lbl_RandomWord3.Text = randomkelime3.ingilizcekelime + " : " + randomkelime3.turkcekelime;
            
        }
    }

   
}
