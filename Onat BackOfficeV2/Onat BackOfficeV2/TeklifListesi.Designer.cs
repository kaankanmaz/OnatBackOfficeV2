namespace Onat_BackOfficeV2
{
    partial class TeklifListesi
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
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.btnGüncelle = new MetroFramework.Controls.MetroButton();
            this.cmbGüncelle = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.cmbGetir = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview1
            // 
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.Location = new System.Drawing.Point(23, 112);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.Size = new System.Drawing.Size(754, 329);
            this.datagridview1.TabIndex = 0;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(23, 447);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(180, 62);
            this.btnGüncelle.TabIndex = 1;
            this.btnGüncelle.Text = "Güncelle";
            // 
            // cmbGüncelle
            // 
            this.cmbGüncelle.FormattingEnabled = true;
            this.cmbGüncelle.ItemHeight = 23;
            this.cmbGüncelle.Items.AddRange(new object[] {
            "Red",
            "Onaylandı",
            "Bekliyor"});
            this.cmbGüncelle.Location = new System.Drawing.Point(304, 464);
            this.cmbGüncelle.Name = "cmbGüncelle";
            this.cmbGüncelle.Size = new System.Drawing.Size(201, 29);
            this.cmbGüncelle.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(210, 464);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Teklif Durumu";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(248, 63);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(180, 29);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Getir";
            // 
            // cmbGetir
            // 
            this.cmbGetir.FormattingEnabled = true;
            this.cmbGetir.ItemHeight = 23;
            this.cmbGetir.Items.AddRange(new object[] {
            "Red",
            "Onaylandı",
            "Bekliyor"});
            this.cmbGetir.Location = new System.Drawing.Point(23, 63);
            this.cmbGetir.Name = "cmbGetir";
            this.cmbGetir.Size = new System.Drawing.Size(201, 29);
            this.cmbGetir.TabIndex = 2;
            // 
            // TeklifListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbGetir);
            this.Controls.Add(this.cmbGüncelle);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.datagridview1);
            this.Name = "TeklifListesi";
            this.Text = "TeklifListesi";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview1;
        private MetroFramework.Controls.MetroButton btnGüncelle;
        private MetroFramework.Controls.MetroComboBox cmbGüncelle;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroComboBox cmbGetir;
    }
}