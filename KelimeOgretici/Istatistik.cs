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
    public partial class Istatistik : MetroFramework.Forms.MetroForm
    {

        KelimeOgreticiEntities3 kelimeOgren = new KelimeOgreticiEntities3();
        //tbl_Gun30 gun30 = new tbl_Gun30();
        int dogruSayisi = 0;

        public Istatistik()
        {
            InitializeComponent();
           
        }
        void sorgu()
        {
            int maxID = kelimeOgren.tbl_KelimeListesi.Max(u => u.id);
            int i = 1;

            while (i < maxID)
            {
                var item = (from m in kelimeOgren.tbl_KelimeListesi
                            where m.id == i
                            select m).FirstOrDefault();
                TimeSpan gun1fark = DateTime.Now - Convert.ToDateTime(item.tarih.Value); // Şimdiki zaman ile Veri Tabanı Arasındaki
                if (gun1fark.TotalSeconds >= 30)
                {
                    var item2 = (from m in kelimeOgren.tbl_Gun1
                                 where m.id == i
                                 select m).FirstOrDefault();
                    dogruSayisi++;
                    i++;
                }
                else { i++; }

            }
        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Anasayfa_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        void bar()
        {
            metroProgressBar1.Maximum = 100;
            if (dogruSayisi >= 1)
            {
                int dogru1 = dogruSayisi + 1;
                metroProgressBar1.Value = dogru1;
                metroLabel3.Text = metroComboBox1.Text +" ayında " + dogru1.ToString() + " kelime öğrenildi!";
            }
            else
            {
                metroProgressBar1.Value = 0;
                metroLabel3.Text = metroComboBox1.Text+ " ayında hiç kelime öğrenilmedi!";
            }
        }

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox1.Text)
            {
                case "Ocak":
                    OcakIstatistik(); break;
                case "Şubat":
                    SubatIstatistik(); break;
                case "Mart":
                    MartIstatistik(); break;
                case "Nisan":
                    NisanIstatistik(); break;
                case "Mayıs":
                    MayisIstatistik(); break;
                case "Haziran":
                    HaziranIstatistik(); break;
                case "Temmuz":
                    TemmuzIstatistik(); break;
                case "Ağustos":
                    AgustosIstatistik(); break;
                case "Eylül":
                    EylulIstatistik(); break;
                case "Ekim":
                    EkimIstatistik(); break;
                case "Kasım":
                    KasimIstatistik(); break;
                case "Aralık":
                    AralikIstatistik(); break;
            }

            void OcakIstatistik()
            {
                int maxID = kelimeOgren.tbl_KelimeListesi.Max(u => u.id);
                int i = 1;
                dogruSayisi = 0;

                while (i < maxID)
                {
                    var item = (from m in kelimeOgren.tbl_KelimeListesi
                                where m.id == i
                                select m).FirstOrDefault();
                    DateTime dt = new DateTime(2019, 1, 1);
                    TimeSpan fark = Convert.ToDateTime(item.tarih.Value) - dt;
                    if (fark.TotalDays <= 31)
                    {
                        dogruSayisi++;
                        i++;

                    }
                    else { i++; }
                }
                bar();
            }
            void SubatIstatistik()
            {
                int maxID = kelimeOgren.tbl_KelimeListesi.Max(u => u.id);
                int i = 1;
                dogruSayisi = 0;

                while (i < maxID)
                {
                    var item = (from m in kelimeOgren.tbl_KelimeListesi
                                where m.id == i
                                select m).FirstOrDefault();
                    DateTime dt = new DateTime(2019, 2, 1);
                    TimeSpan fark = Convert.ToDateTime(item.tarih.Value) - dt;
                    if (fark.TotalDays <= 28)
                    {
                        dogruSayisi++;
                        i++;

                    }
                    else { i++; }
                }
                bar();
            }
            void MartIstatistik()
            {
                int maxID = kelimeOgren.tbl_KelimeListesi.Max(u => u.id);
                int i = 1;
                dogruSayisi = 0;

                while (i < maxID)
                {
                    var item = (from m in kelimeOgren.tbl_KelimeListesi
                                where m.id == i
                                select m).FirstOrDefault();
                    DateTime dt = new DateTime(2019, 3, 1);
                    TimeSpan fark = Convert.ToDateTime(item.tarih.Value) - dt;
                    if (fark.TotalDays <= 31)
                    {
                        dogruSayisi++;
                        i++;

                    }
                    else { i++; }
                }
                bar();
            }
            void NisanIstatistik()
            {
                int maxID = kelimeOgren.tbl_KelimeListesi.Max(u => u.id);
                int i = 1;
                dogruSayisi = 0;

                while (i < maxID)
                {
                    var item = (from m in kelimeOgren.tbl_KelimeListesi
                                where m.id == i
                                select m).FirstOrDefault();
                    DateTime dt = new DateTime(2019, 4, 1);
                    TimeSpan fark = Convert.ToDateTime(item.tarih.Value) - dt;
                    if (fark.TotalDays <= 30)
                    {
                        dogruSayisi++;
                        i++;

                    }
                    else { i++; }
                }
                bar();
            }
            void MayisIstatistik()
            {
                int maxID = kelimeOgren.tbl_KelimeListesi.Max(u => u.id);
                int i = 1;
                dogruSayisi = 0;

                while (i < maxID)
                {
                    var item = (from m in kelimeOgren.tbl_KelimeListesi
                                where m.id == i
                                select m).FirstOrDefault();
                    DateTime dt = new DateTime(2019, 5, 1);
                    TimeSpan fark = Convert.ToDateTime(item.tarih.Value) - dt;
                    if (fark.TotalDays <= 31)
                    {
                        dogruSayisi++; //10
                        i++;//11

                    }
                    else { i++; }
                }
                bar();
            }
            void HaziranIstatistik()
            {
                int maxID = kelimeOgren.tbl_KelimeListesi.Max(u => u.id);
                int i = 1;
                dogruSayisi = 0;

                while (i < maxID)
                {
                    var item = (from m in kelimeOgren.tbl_KelimeListesi
                                where m.id == i
                                select m).FirstOrDefault();
                    DateTime dt = new DateTime(2019, 6, 1);
                    TimeSpan fark = Convert.ToDateTime(item.tarih.Value) - dt;
                    if (fark.TotalDays < 0) { i++; }
                    else if (fark.TotalDays <= 30)
                    {
                        dogruSayisi++;
                        i++;

                    }
                    else { i++; }
                }
                bar();
            }
            void TemmuzIstatistik()
            {
                int maxID = kelimeOgren.tbl_KelimeListesi.Max(u => u.id);
                int i = 1;
                dogruSayisi = 0;

                while (i < maxID)
                {
                    var item = (from m in kelimeOgren.tbl_KelimeListesi
                                where m.id == i
                                select m).FirstOrDefault();
                    DateTime dt = new DateTime(2019, 7, 1);
                    TimeSpan fark = Convert.ToDateTime(item.tarih.Value) - dt;
                    if (fark.TotalDays < 0) { i++; }
                    else if (fark.TotalDays <= 31)
                    {
                        dogruSayisi++;
                        i++;

                    }
                    else { i++; }
                }
                bar();
            }
            void AgustosIstatistik()
            {
                int maxID = kelimeOgren.tbl_KelimeListesi.Max(u => u.id);
                int i = 1;
                dogruSayisi = 0;

                while (i < maxID)
                {
                    var item = (from m in kelimeOgren.tbl_KelimeListesi
                                where m.id == i
                                select m).FirstOrDefault();
                    DateTime dt = new DateTime(2019, 8, 1);
                    TimeSpan fark = Convert.ToDateTime(item.tarih.Value) - dt;
                    if (fark.TotalDays < 0) { i++; }
                    else if (fark.TotalDays <= 31)
                    {
                        dogruSayisi++;
                        i++;

                    }
                    else { i++; }
                }
                bar();
            }
            void EylulIstatistik()
            {
                int maxID = kelimeOgren.tbl_KelimeListesi.Max(u => u.id);
                int i = 1;
                dogruSayisi = 0;

                while (i < maxID)
                {
                    var item = (from m in kelimeOgren.tbl_KelimeListesi
                                where m.id == i
                                select m).FirstOrDefault();
                    DateTime dt = new DateTime(2019, 9, 1);
                    TimeSpan fark = Convert.ToDateTime(item.tarih.Value) - dt;
                    if (fark.TotalDays < 0) { i++; }
                    else if (fark.TotalDays <= 30)
                    {
                        dogruSayisi++;
                        i++;

                    }
                    else { i++; }
                }
                bar();
            }
            void EkimIstatistik()
            {
                int maxID = kelimeOgren.tbl_KelimeListesi.Max(u => u.id);
                int i = 1;
                dogruSayisi = 0;

                while (i < maxID)
                {
                    var item = (from m in kelimeOgren.tbl_KelimeListesi
                                where m.id == i
                                select m).FirstOrDefault();
                    DateTime dt = new DateTime(2019, 10, 1);
                    TimeSpan fark = Convert.ToDateTime(item.tarih.Value) - dt;
                    if (fark.TotalDays < 0) { i++; }
                    else if (fark.TotalDays <= 31)
                    {
                        dogruSayisi++;
                        i++;

                    }
                    else { i++; }
                }
                bar();
            }
            void KasimIstatistik()
            {
                int maxID = kelimeOgren.tbl_KelimeListesi.Max(u => u.id);
                int i = 1;
                dogruSayisi = 0;

                while (i < maxID)
                {
                    var item = (from m in kelimeOgren.tbl_KelimeListesi
                                where m.id == i
                                select m).FirstOrDefault();
                    DateTime dt = new DateTime(2019, 11, 1);
                    TimeSpan fark = Convert.ToDateTime(item.tarih.Value) - dt;
                    if (fark.TotalDays < 0) { i++; }
                    else if (fark.TotalDays <= 30)
                    {
                        dogruSayisi++;
                        i++;

                    }
                    else { i++; }
                }
                bar();
            }
            void AralikIstatistik()
            {
                int maxID = kelimeOgren.tbl_KelimeListesi.Max(u => u.id);
                int i = 1;
                dogruSayisi = 0;

                while (i < maxID)
                {
                    var item = (from m in kelimeOgren.tbl_KelimeListesi
                                where m.id == i
                                select m).FirstOrDefault();
                    DateTime dt = new DateTime(2019, 12, 1);
                    TimeSpan fark = Convert.ToDateTime(item.tarih.Value) - dt;
                    if (fark.TotalDays < 0) { i++; }
                    else if (fark.TotalDays <= 31)
                    {
                        dogruSayisi++;
                        i++;

                    }
                    else { i++; }
                }
                bar();
            }
        }

        private void Istatistik_Load(object sender, EventArgs e)
        {
            if(metroComboBox1.Text == "")
            {
                metroLabel3.Text = "Lütfen yukarıdan ay seçiniz!";
            }
        }
    }
}

