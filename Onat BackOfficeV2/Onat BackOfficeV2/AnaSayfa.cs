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
using System.Data.Sql;
using System.Data.SqlClient;
using MetroFramework.Forms;

namespace Onat_BackOfficeV2
{
    public partial class OnatBackOfficeV2 : MetroForm
    {
        public OnatBackOfficeV2()
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager1;

            this.Style = MetroFramework.MetroColorStyle.Blue;

            
        
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            Müsteri NewForm = new Müsteri();

            NewForm.Show();
        }

        private void btnTeklif_Click(object sender, EventArgs e)
        {
            TeklifAnasayfa NewForm = new TeklifAnasayfa();

            NewForm.Show();
        }

        private void btnServis_Click(object sender, EventArgs e)
        {
            ServisAnasayfa NewForm = new ServisAnasayfa();

            NewForm.Show();
        }
    }
}
