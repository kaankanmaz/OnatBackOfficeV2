using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;


namespace Onat_BackOfficeV2
{
    public partial class TeklifAnasayfa : MetroForm
    {
        public TeklifAnasayfa()
        {
            InitializeComponent();
        }

        private void Teklif_Load(object sender, EventArgs e)
        {

        }

        private void btnYeniTeklif_Click(object sender, EventArgs e)
        {
            YeniTeklif newform = new YeniTeklif();

            newform.Show();
        }

        private void btnTeklifListesi_Click(object sender, EventArgs e)
        {
            TeklifListesi newform = new TeklifListesi();

            newform.Show();
        }
    }
}
