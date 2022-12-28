
namespace Banka_Otomasyonu
{
    partial class frmHesaplariYonet
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
            this.btn_HesapOlustur = new System.Windows.Forms.Button();
            this.listView_HesapBilgileri = new System.Windows.Forms.ListView();
            this.column_HesapNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_HesapTuru = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Bakiye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_HesapSil = new System.Windows.Forms.Button();
            this.btn_AnaSayfayaDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_HesapOlustur
            // 
            this.btn_HesapOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HesapOlustur.Location = new System.Drawing.Point(254, 265);
            this.btn_HesapOlustur.Name = "btn_HesapOlustur";
            this.btn_HesapOlustur.Size = new System.Drawing.Size(167, 38);
            this.btn_HesapOlustur.TabIndex = 2;
            this.btn_HesapOlustur.Text = "Yeni Hesap Oluştur";
            this.btn_HesapOlustur.UseVisualStyleBackColor = true;
            this.btn_HesapOlustur.Click += new System.EventHandler(this.btn_HesapOlustur_Click);
            // 
            // listView_HesapBilgileri
            // 
            this.listView_HesapBilgileri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_HesapNo,
            this.column_HesapTuru,
            this.column_Bakiye});
            this.listView_HesapBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView_HesapBilgileri.FullRowSelect = true;
            this.listView_HesapBilgileri.HideSelection = false;
            this.listView_HesapBilgileri.Location = new System.Drawing.Point(29, 94);
            this.listView_HesapBilgileri.MultiSelect = false;
            this.listView_HesapBilgileri.Name = "listView_HesapBilgileri";
            this.listView_HesapBilgileri.Size = new System.Drawing.Size(417, 145);
            this.listView_HesapBilgileri.TabIndex = 3;
            this.listView_HesapBilgileri.UseCompatibleStateImageBehavior = false;
            this.listView_HesapBilgileri.View = System.Windows.Forms.View.Details;
            // 
            // column_HesapNo
            // 
            this.column_HesapNo.Text = "Hesap No";
            this.column_HesapNo.Width = 128;
            // 
            // column_HesapTuru
            // 
            this.column_HesapTuru.Text = "Hesap Türü";
            this.column_HesapTuru.Width = 131;
            // 
            // column_Bakiye
            // 
            this.column_Bakiye.Text = "Bakiye";
            this.column_Bakiye.Width = 113;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(142, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hesaplarım";
            // 
            // btn_HesapSil
            // 
            this.btn_HesapSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HesapSil.Location = new System.Drawing.Point(64, 265);
            this.btn_HesapSil.Name = "btn_HesapSil";
            this.btn_HesapSil.Size = new System.Drawing.Size(167, 38);
            this.btn_HesapSil.TabIndex = 6;
            this.btn_HesapSil.Text = "Hesabı Kapat";
            this.btn_HesapSil.UseVisualStyleBackColor = true;
            this.btn_HesapSil.Click += new System.EventHandler(this.btn_HesapSil_Click);
            // 
            // btn_AnaSayfayaDon
            // 
            this.btn_AnaSayfayaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AnaSayfayaDon.Location = new System.Drawing.Point(149, 319);
            this.btn_AnaSayfayaDon.Name = "btn_AnaSayfayaDon";
            this.btn_AnaSayfayaDon.Size = new System.Drawing.Size(167, 36);
            this.btn_AnaSayfayaDon.TabIndex = 7;
            this.btn_AnaSayfayaDon.Text = "Ana Sayfa";
            this.btn_AnaSayfayaDon.UseVisualStyleBackColor = true;
            this.btn_AnaSayfayaDon.Click += new System.EventHandler(this.btn_AnaSayfayaDon_Click);
            // 
            // frmHesaplariYonet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 394);
            this.Controls.Add(this.btn_AnaSayfayaDon);
            this.Controls.Add(this.btn_HesapSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView_HesapBilgileri);
            this.Controls.Add(this.btn_HesapOlustur);
            this.Name = "frmHesaplariYonet";
            this.Text = "Müşteri Paneli";
            this.Load += new System.EventHandler(this.frmHesaplariYonet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HesapOlustur;
        private System.Windows.Forms.ListView listView_HesapBilgileri;
        private System.Windows.Forms.ColumnHeader column_HesapNo;
        private System.Windows.Forms.ColumnHeader column_HesapTuru;
        private System.Windows.Forms.ColumnHeader column_Bakiye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_HesapSil;
        private System.Windows.Forms.Button btn_AnaSayfayaDon;
    }
}