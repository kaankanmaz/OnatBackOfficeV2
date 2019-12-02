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
    public partial class Müsteri : MetroForm
    {
        public Müsteri()
        {
            InitializeComponent();
        }

        private void btnYeniMüşteri_Click(object sender, EventArgs e)
        {
            YeniMüsteri newform = new YeniMüsteri();

            newform.Show();
        }
    }
}
