
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.column_HesapNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_HesapTuru = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Bakiye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_HesapSil = new System.Windows.Forms.Button();
            this.btn_AnaSayfayaDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(238, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yeni Hesap Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_HesapNo,
            this.column_HesapTuru,
            this.column_Bakiye});
            this.listView1.Enabled = false;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 94);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(395, 145);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.label2.Location = new System.Drawing.Point(126, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hesaplarım";
            // 
            // btn_HesapSil
            // 
            this.btn_HesapSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HesapSil.Location = new System.Drawing.Point(48, 267);
            this.btn_HesapSil.Name = "btn_HesapSil";
            this.btn_HesapSil.Size = new System.Drawing.Size(167, 38);
            this.btn_HesapSil.TabIndex = 6;
            this.btn_HesapSil.Text = "Hesabı Kapat";
            this.btn_HesapSil.UseVisualStyleBackColor = true;
            // 
            // btn_AnaSayfayaDon
            // 
            this.btn_AnaSayfayaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AnaSayfayaDon.Location = new System.Drawing.Point(133, 321);
            this.btn_AnaSayfayaDon.Name = "btn_AnaSayfayaDon";
            this.btn_AnaSayfayaDon.Size = new System.Drawing.Size(167, 36);
            this.btn_AnaSayfayaDon.TabIndex = 7;
            this.btn_AnaSayfayaDon.Text = "Ana Sayfa";
            this.btn_AnaSayfayaDon.UseVisualStyleBackColor = true;
            // 
            // frmHesaplariYonet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 394);
            this.Controls.Add(this.btn_AnaSayfayaDon);
            this.Controls.Add(this.btn_HesapSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "frmHesaplariYonet";
            this.Text = "Müşteri Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader column_HesapNo;
        private System.Windows.Forms.ColumnHeader column_HesapTuru;
        private System.Windows.Forms.ColumnHeader column_Bakiye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_HesapSil;
        private System.Windows.Forms.Button btn_AnaSayfayaDon;
    }
}