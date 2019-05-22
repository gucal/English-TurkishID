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
    public partial class Scene : MetroFramework.Forms.MetroForm
    {
        public Scene()
        {
            InitializeComponent();
        }
        void Sahne()
        {
            switch (metroComboBox1.Text)
            {
                case "Simple Past Tense":
                    axWindowsMediaPlayer1.URL = @"C:\Users\Lenovo\source\repos\YazilimYapimi\KelimeOgretici\Sahneler\Kung Fu Panda 2 Simple Past - YouTube.mpeg";
                    break;
                case "Simple Past Tense 2":
                    axWindowsMediaPlayer1.URL = @"C:\Users\Lenovo\source\repos\YazilimYapimi\KelimeOgretici\Sahneler\Simple past tense The Great Gatsby  - YouTube.mpeg";
                    break;
                case "Simple Present Tense":
                    axWindowsMediaPlayer1.URL = @"C:\Users\Lenovo\source\repos\YazilimYapimi\KelimeOgretici\Sahneler\Simple present tense jesse pinkman.mpeg";
                    break;
                case "Simple Present Tense 2":
                    axWindowsMediaPlayer1.URL = @"C:\Users\Lenovo\source\repos\YazilimYapimi\KelimeOgretici\Sahneler\Simple present x Monsters Inc YouTube.mpeg";
                    break;
                case "Present Continuous Tense":
                    axWindowsMediaPlayer1.URL = @"C:\Users\Lenovo\source\repos\YazilimYapimi\KelimeOgretici\Sahneler\present continuous tense sheldon1.mpeg";
                    break;
                case "Present Continuous Tense 2":
                    axWindowsMediaPlayer1.URL = @"C:\Users\Lenovo\source\repos\YazilimYapimi\KelimeOgretici\Sahneler\present continuous tense sheldon2.mpeg";
                    break;
            }
        }

        private void Btn_Izle_Click(object sender, EventArgs e)
        {
            Sahne();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}


