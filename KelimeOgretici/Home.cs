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
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        KelimeOgreticiEntities3 kelimeOgren = new KelimeOgreticiEntities3();
        public Home()
        {
            InitializeComponent();
        }

        private void Btn_AddWord_Click(object sender, EventArgs e)
        {
            AddWord addWord = new AddWord();
            addWord.Show();
            this.Hide();
        }

        private void Btn_MyWords_Click(object sender, EventArgs e)
        {
            MyWords myWords = new MyWords();
            myWords.Show();
            this.Hide();
        }

        private void Btn_Test_Click_1(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
            this.Hide();

        }

        private void Btn_Istatistik_Click_1(object sender, EventArgs e)
        {
            Istatistik istatistik = new Istatistik();
            istatistik.Show();
            this.Hide();
        }

        private void Btn_Sahne_Click(object sender, EventArgs e)
        {
            Scene sahne = new Scene();
            sahne.Show();
            this.Hide();
        }
    }


}
