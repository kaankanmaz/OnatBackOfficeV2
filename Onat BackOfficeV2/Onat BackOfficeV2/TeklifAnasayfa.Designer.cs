namespace Onat_BackOfficeV2
{
    partial class TeklifAnasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnYeniTeklif = new MetroFramework.Controls.MetroButton();
            this.btnTeklifListesi = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnYeniTeklif
            // 
            this.btnYeniTeklif.Location = new System.Drawing.Point(23, 86);
            this.btnYeniTeklif.Name = "btnYeniTeklif";
            this.btnYeniTeklif.Size = new System.Drawing.Size(183, 142);
            this.btnYeniTeklif.TabIndex = 0;
            this.btnYeniTeklif.Text = "Yeni Teklif";
            this.btnYeniTeklif.Click += new System.EventHandler(this.btnYeniTeklif_Click);
            // 
            // btnTeklifListesi
            // 
            this.btnTeklifListesi.Location = new System.Drawing.Point(289, 86);
            this.btnTeklifListesi.Name = "btnTeklifListesi";
            this.btnTeklifListesi.Size = new System.Drawing.Size(183, 142);
            this.btnTeklifListesi.TabIndex = 0;
            this.btnTeklifListesi.Text = "Teklif Listesi";
            this.btnTeklifListesi.Click += new System.EventHandler(this.btnTeklifListesi_Click);
            // 
            // TeklifAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 299);
            this.Controls.Add(this.btnTeklifListesi);
            this.Controls.Add(this.btnYeniTeklif);
            this.Name = "TeklifAnasayfa";
            this.Text = "Teklif AnaSayfa";
            this.Load += new System.EventHandler(this.Teklif_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnYeniTeklif;
        private MetroFramework.Controls.MetroButton btnTeklifListesi;
    }
}