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
    public partial class ServisAnasayfa : MetroForm
    {
        public ServisAnasayfa()
        {
            InitializeComponent();
        }

        private void btnYeniServis_Click(object sender, EventArgs e)
        {
            YeniServis NewForm = new YeniServis();

            NewForm.Show();
        }

        private void btnServisListesi_Click(object sender, EventArgs e)
        {
         
            ServisListesi servisListesi = new ServisListesi();

            servisListesi.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnatBackOfficeV2 onatBackOfficeV2 = new OnatBackOfficeV2();
            onatBackOfficeV2.Show();
            this.Hide();
        }
    }
}
