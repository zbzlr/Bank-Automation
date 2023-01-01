
namespace Banka_Otomasyonu
{
    partial class frmIslemGecmisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_HesapNo = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_ParaCekYatir = new System.Windows.Forms.TabPage();
            this.tabPage_Havale = new System.Windows.Forms.TabPage();
            this.listView_ParaCekYatir = new System.Windows.Forms.ListView();
            this.listView_Havale = new System.Windows.Forms.ListView();
            this.İşlemKategorisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.İşlemTutarı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.İşlemTarihVeSaati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IslemTutari = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TarihVeSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kimden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage_ParaCekYatir.SuspendLayout();
            this.tabPage_Havale.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(190, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Geçmişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(203, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap No:";
            // 
            // comboBox_HesapNo
            // 
            this.comboBox_HesapNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HesapNo.FormattingEnabled = true;
            this.comboBox_HesapNo.Location = new System.Drawing.Point(325, 357);
            this.comboBox_HesapNo.Name = "comboBox_HesapNo";
            this.comboBox_HesapNo.Size = new System.Drawing.Size(121, 24);
            this.comboBox_HesapNo.TabIndex = 2;
            this.comboBox_HesapNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_HesapNo_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_ParaCekYatir);
            this.tabControl1.Controls.Add(this.tabPage_Havale);
            this.tabControl1.Location = new System.Drawing.Point(46, 128);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 201);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage_ParaCekYatir
            // 
            this.tabPage_ParaCekYatir.Controls.Add(this.listView_ParaCekYatir);
            this.tabPage_ParaCekYatir.Location = new System.Drawing.Point(4, 25);
            this.tabPage_ParaCekYatir.Name = "tabPage_ParaCekYatir";
            this.tabPage_ParaCekYatir.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ParaCekYatir.Size = new System.Drawing.Size(568, 172);
            this.tabPage_ParaCekYatir.TabIndex = 0;
            this.tabPage_ParaCekYatir.Text = "Para Çek-Yatır Geçmişi";
            this.tabPage_ParaCekYatir.UseVisualStyleBackColor = true;
            // 
            // tabPage_Havale
            // 
            this.tabPage_Havale.Controls.Add(this.listView_Havale);
            this.tabPage_Havale.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Havale.Name = "tabPage_Havale";
            this.tabPage_Havale.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Havale.Size = new System.Drawing.Size(568, 172);
            this.tabPage_Havale.TabIndex = 1;
            this.tabPage_Havale.Text = "Havale Geçmişi";
            this.tabPage_Havale.UseVisualStyleBackColor = true;
            // 
            // listView_ParaCekYatir
            // 
            this.listView_ParaCekYatir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.İşlemKategorisi,
            this.İşlemTutarı,
            this.İşlemTarihVeSaati});
            this.listView_ParaCekYatir.HideSelection = false;
            this.listView_ParaCekYatir.Location = new System.Drawing.Point(7, 6);
            this.listView_ParaCekYatir.Name = "listView_ParaCekYatir";
            this.listView_ParaCekYatir.Size = new System.Drawing.Size(555, 160);
            this.listView_ParaCekYatir.TabIndex = 0;
            this.listView_ParaCekYatir.UseCompatibleStateImageBehavior = false;
            this.listView_ParaCekYatir.View = System.Windows.Forms.View.Details;
            // 
            // listView_Havale
            // 
            this.listView_Havale.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Kategori,
            this.IslemTutari,
            this.TarihVeSaat,
            this.Kimden,
            this.Aciklama});
            this.listView_Havale.HideSelection = false;
            this.listView_Havale.Location = new System.Drawing.Point(7, 6);
            this.listView_Havale.Name = "listView_Havale";
            this.listView_Havale.Size = new System.Drawing.Size(555, 160);
            this.listView_Havale.TabIndex = 0;
            this.listView_Havale.UseCompatibleStateImageBehavior = false;
            this.listView_Havale.View = System.Windows.Forms.View.Details;
            // 
            // İşlemKategorisi
            // 
            this.İşlemKategorisi.Text = "Kategori";
            this.İşlemKategorisi.Width = 144;
            // 
            // İşlemTutarı
            // 
            this.İşlemTutarı.Text = "İşlem Tutarı";
            this.İşlemTutarı.Width = 138;
            // 
            // İşlemTarihVeSaati
            // 
            this.İşlemTarihVeSaati.Text = "Tarih ve Saat";
            this.İşlemTarihVeSaati.Width = 161;
            // 
            // Kategori
            // 
            this.Kategori.Text = "Kategori";
            this.Kategori.Width = 85;
            // 
            // IslemTutari
            // 
            this.IslemTutari.Text = "İşlem Tutarı";
            this.IslemTutari.Width = 88;
            // 
            // TarihVeSaat
            // 
            this.TarihVeSaat.Text = "Tarih ve Saat";
            this.TarihVeSaat.Width = 113;
            // 
            // Kimden
            // 
            this.Kimden.Text = "Kimden";
            this.Kimden.Width = 98;
            // 
            // Aciklama
            // 
            this.Aciklama.Text = "Açıklama";
            this.Aciklama.Width = 151;
            // 
            // frmIslemGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox_HesapNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIslemGecmisi";
            this.Text = "Müşteri Paneli";
            this.Load += new System.EventHandler(this.frmIslemGecmisi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_ParaCekYatir.ResumeLayout(false);
            this.tabPage_Havale.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_HesapNo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_ParaCekYatir;
        private System.Windows.Forms.TabPage tabPage_Havale;
        private System.Windows.Forms.ListView listView_ParaCekYatir;
        private System.Windows.Forms.ListView listView_Havale;
        private System.Windows.Forms.ColumnHeader İşlemKategorisi;
        private System.Windows.Forms.ColumnHeader İşlemTutarı;
        private System.Windows.Forms.ColumnHeader İşlemTarihVeSaati;
        private System.Windows.Forms.ColumnHeader Kategori;
        private System.Windows.Forms.ColumnHeader IslemTutari;
        private System.Windows.Forms.ColumnHeader TarihVeSaat;
        private System.Windows.Forms.ColumnHeader Kimden;
        private System.Windows.Forms.ColumnHeader Aciklama;
    }
}