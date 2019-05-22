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
    public partial class TimeTest : MetroFramework.Forms.MetroForm
    {
        public TimeTest()
        {
            InitializeComponent();
        }
        KelimeOgreticiEntities3 kelimeOgren = new KelimeOgreticiEntities3();
        tbl_Gun1 gun1 = new tbl_Gun1();
        tbl_Gun7 gun7 = new tbl_Gun7();
        tbl_Gun30 gun30 = new tbl_Gun30();
        tbl_Gun180 gun180 = new tbl_Gun180();
        int i = 1, a = 0, mx, mc, b = 0, c = 0;
        string var, var2;


        void soruSor() //1 GUNLUK SORU SORAR
        {
            int maxID = kelimeOgren.tbl_KelimeListesi.Max(u => u.id);
            mx = maxID;
            while (i <= maxID)
            {
                var item = (from m in kelimeOgren.tbl_KelimeListesi
                            where m.id == i
                            select m).FirstOrDefault();
                TimeSpan gun1fark = DateTime.Now - Convert.ToDateTime(item.tarih.Value); // Şimdiki zaman ile Veri Tabanı Arasındaki

                if (gun1fark.TotalDays >= 1)
                {
                    metroLabel1.Text = "1 GÜN OLDU " + item.ingilizcekelime + " Kelimesinin Türkçe Karşılığı Nedir?";
                    var = item.turkcekelime;
                    var2 = item.ingilizcekelime;
                    break;
                }
                else
                {
                    i++;
                 
                }
            }
            if (i > maxID)
            {
                MessageBox.Show("Süresi dolan kelime kalmadı. Program kapanıyor.");
                this.Close();
            }
           
        }
        void soruCevapla() // 1 GUNLUK SORU CEVABI KONTROL
        {
            if (txt_Answer.Text == var.ToString())
            {
                MessageBox.Show("DOĞRU");
                gun1.ingilizcekelime = var2;
                gun1.turkcekelime = var;
                kelimeOgren.tbl_Gun1.Add(gun1);
                kelimeOgren.SaveChanges();
            }
            else { MessageBox.Show("YANLIŞ"); }
        }
        void soruCevapla2() //7 GUNLUK SORU CEVABI KONTROLÜ
        {
            if (a != 0)
            {
                if (txt_Answer.Text == var.ToString())
                {
                    MessageBox.Show("DOĞRU");
                    gun7.ingilizcekelime = var2;
                    gun7.turkcekelime = var;
                    kelimeOgren.tbl_Gun7.Add(gun7);
                    kelimeOgren.SaveChanges();
                }
                else { MessageBox.Show("YANLIŞ"); }
                txt_Answer.Text = "";
            }
        }


        void soruCevapla3() //30 GUNLUK SORU CEVABI KONTROL
        {
            if (b != 0)
            {
                if (txt_Answer.Text == var.ToString())
                {
                    MessageBox.Show("DOĞRU");
                    gun30.ingilizcekelime = var2;
                    gun30.turkcekelime = var;
                    kelimeOgren.tbl_Gun30.Add(gun30);
                    kelimeOgren.SaveChanges();
                    txt_Answer.Text = "";
                }
                else
                {
                    MessageBox.Show("YANLIŞ");
                    txt_Answer.Text = "";
                }
            }
        }
        void soruCevapla4() //180 GUNLUK SORU CEVABI KONTROL
        {
            if (c != 0)
            {
                if (txt_Answer.Text == var.ToString())
                {
                    MessageBox.Show("DOĞRU");
                    gun180.ingilizcekelime = var2;
                    gun180.turkcekelime = var;
                    kelimeOgren.tbl_Gun180.Add(gun180);
                    kelimeOgren.SaveChanges();
                    txt_Answer.Text = "";
                }
                else
                {
                    MessageBox.Show("YANLIŞ");
                    txt_Answer.Text = "";
                }
            }

        }
        void soruSor2() //7 GUNLUK SORU SORAR
        {
            int maxID = kelimeOgren.tbl_Gun1.Max(u => u.id); //> Son ID sayısını bulan sorgu. LINQ^^

            while (a <= maxID)
            {
                var item = (from m in kelimeOgren.tbl_KelimeListesi
                            where m.id == a
                            select m).FirstOrDefault();
                TimeSpan gun1fark = DateTime.Now - Convert.ToDateTime(item.tarih.Value);
                if (gun1fark.TotalDays >= 7)
                {
                    var item2 = (from m in kelimeOgren.tbl_Gun1
                                 where m.id == a
                                 select m).FirstOrDefault();
                    metroLabel1.Text = "7 GÜN OLDU " + item.ingilizcekelime + " Kelimesinin Türkçe Karşılığı Nedir?";
                    var = item2.turkcekelime;
                    var2 = item2.ingilizcekelime;
                    break;
                }
                else { a++; }
            }
        }
        void soruSor3() //30 GUNLUK SORU SORAR
        {
            int maxID = kelimeOgren.tbl_Gun7.Max(u => u.id); //> Son ID sayısını bulan sorgu. LINQ^^
            mc = maxID;
            while (b <= maxID)
            {
                var item = (from m in kelimeOgren.tbl_KelimeListesi
                            where m.id == b
                            select m).FirstOrDefault();
                TimeSpan gun1fark = DateTime.Now - Convert.ToDateTime(item.tarih.Value); // Şimdiki zaman ile Veri Tabanı Arasındaki
                if (gun1fark.TotalDays >= 30)
                {
                    var item2 = (from m in kelimeOgren.tbl_Gun1
                                 where m.id == b
                                 select m).FirstOrDefault();
                    metroLabel1.Text = "30 GÜN OLDU " + item.ingilizcekelime + " Kelimesinin Türkçe Karşılığı Nedir?";
                    var = item2.turkcekelime;
                    var2 = item2.ingilizcekelime;
                    break;
                }
                else { b++; }
            }
        }
        void soruSor4() //180 gunluk soru sorar.
        {
            int maxID = kelimeOgren.tbl_Gun30.Max(u => u.id); //> Son ID sayısını bulan sorgu. LINQ^^

            while (c <= maxID)
            {
                var item = (from m in kelimeOgren.tbl_KelimeListesi
                            where m.id == c
                            select m).FirstOrDefault();
                TimeSpan gun1fark = DateTime.Now - Convert.ToDateTime(item.tarih.Value); // Şimdiki zaman ile Veri Tabanı Arasındaki
                if (gun1fark.TotalDays >= 180)
                {
                    var item2 = (from m in kelimeOgren.tbl_Gun1
                                 where m.id == c
                                 select m).FirstOrDefault();
                    metroLabel1.Text = "180 GÜN OLDU " + item.ingilizcekelime + " Kelimesinin Türkçe Karşılığı Nedir?";
                    var = item2.turkcekelime;
                    var2 = item2.ingilizcekelime;
                    break;
                }
                else { c++; }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            soruSor();
        }

        private void Btn_Cevap_Click(object sender, EventArgs e)
        {
            if (i <= mx)
            {
                soruCevapla();
                txt_Answer.Text = "";
                i++;
                soruSor();
            }
            //if (i > mx && a <= mx)
            //{
            //    soruCevapla2();
            //    a++;
            //    soruSor2();
            //}
            //if (a > mx && b <= mx)
            //{
            //    soruCevapla3();
            //    b++;
            //    soruSor3();
            //}
            //if (b > mx)
            //{
            //    soruCevapla4();
            //    c++;
            //    soruSor4();

        }
    }
}
