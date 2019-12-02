namespace Onat_BackOfficeV2
{
    partial class ServisAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServisAnasayfa));
            this.btnYeniServis = new MetroFramework.Controls.MetroButton();
            this.btnServisListesi = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniServis
            // 
            this.btnYeniServis.Location = new System.Drawing.Point(23, 121);
            this.btnYeniServis.Name = "btnYeniServis";
            this.btnYeniServis.Size = new System.Drawing.Size(166, 132);
            this.btnYeniServis.TabIndex = 0;
            this.btnYeniServis.Text = "Yeni Servis";
            this.btnYeniServis.Click += new System.EventHandler(this.btnYeniServis_Click);
            // 
            // btnServisListesi
            // 
            this.btnServisListesi.Location = new System.Drawing.Point(243, 121);
            this.btnServisListesi.Name = "btnServisListesi";
            this.btnServisListesi.Size = new System.Drawing.Size(166, 132);
            this.btnServisListesi.TabIndex = 0;
            this.btnServisListesi.Text = "Servis Listesi";
            this.btnServisListesi.Click += new System.EventHandler(this.btnServisListesi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ServisAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 324);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnServisListesi);
            this.Controls.Add(this.btnYeniServis);
            this.Name = "ServisAnasayfa";
            this.Text = "Servis Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnYeniServis;
        private MetroFramework.Controls.MetroButton btnServisListesi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}