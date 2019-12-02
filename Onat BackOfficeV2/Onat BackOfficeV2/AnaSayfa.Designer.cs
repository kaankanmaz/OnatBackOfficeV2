namespace Onat_BackOfficeV2
{
    partial class OnatBackOfficeV2
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnMusteri = new MetroFramework.Controls.MetroButton();
            this.btnTeklif = new MetroFramework.Controls.MetroButton();
            this.btnServis = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMusteri
            // 
            this.btnMusteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteri.Location = new System.Drawing.Point(81, 115);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(165, 128);
            this.btnMusteri.TabIndex = 0;
            this.btnMusteri.Text = "Müşteriler";
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnTeklif
            // 
            this.btnTeklif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeklif.Location = new System.Drawing.Point(318, 115);
            this.btnTeklif.Name = "btnTeklif";
            this.btnTeklif.Size = new System.Drawing.Size(165, 128);
            this.btnTeklif.TabIndex = 1;
            this.btnTeklif.Text = "Teklif";
            this.btnTeklif.Click += new System.EventHandler(this.btnTeklif_Click);
            // 
            // btnServis
            // 
            this.btnServis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnServis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServis.Location = new System.Drawing.Point(550, 115);
            this.btnServis.Name = "btnServis";
            this.btnServis.Size = new System.Drawing.Size(165, 128);
            this.btnServis.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnServis.TabIndex = 2;
            this.btnServis.Text = "Servis";
            this.btnServis.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnServis.Click += new System.EventHandler(this.btnServis_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // OnatBackOfficeV2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 351);
            this.Controls.Add(this.btnServis);
            this.Controls.Add(this.btnTeklif);
            this.Controls.Add(this.btnMusteri);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "OnatBackOfficeV2";
            this.Text = "Onat BackOfficeV2";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnMusteri;
        private MetroFramework.Controls.MetroButton btnTeklif;
        private MetroFramework.Controls.MetroButton btnServis;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

