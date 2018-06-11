using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberi
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void buttonKayitEkleme_Click(object sender, EventArgs e)
        {
            KayitEkleme kayit = new KayitEkleme();
            kayit.Show();
        }

        private void buttonKayıtListeleme_Click(object sender, EventArgs e)
        {
            KayitListeleme listele = new KayitListeleme();
            listele.Show();
        }
    }
}
