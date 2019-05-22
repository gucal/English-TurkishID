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
    public partial class Test : MetroFramework.Forms.MetroForm
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Btn_WordTest_Click(object sender, EventArgs e)
        {
            WordTest testForm = new WordTest();
            testForm.Show();
            this.Hide();
        }

        private void Btn_SceneTest_Click(object sender, EventArgs e)
        {
            Scene scenetest = new Scene();
            scenetest.Show();
            this.Hide();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Btn_TimeTest_Click(object sender, EventArgs e)
        {
            TimeTest tt = new TimeTest();
            tt.Show();
            this.Hide();
        }
    }
}
