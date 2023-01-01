
namespace Banka_Otomasyonu
{
    partial class frmYeniMusteri
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
            this.txt_Isim = new System.Windows.Forms.TextBox();
            this.txt_Soyisim = new System.Windows.Forms.TextBox();
            this.checkBox_Bireysel = new System.Windows.Forms.CheckBox();
            this.checkBox_Ticari = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_YeniKayitOlustur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TekrarSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Isim
            // 
            this.txt_Isim.Location = new System.Drawing.Point(236, 142);
            this.txt_Isim.Name = "txt_Isim";
            this.txt_Isim.Size = new System.Drawing.Size(177, 22);
            this.txt_Isim.TabIndex = 0;
            // 
            // txt_Soyisim
            // 
            this.txt_Soyisim.Location = new System.Drawing.Point(236, 193);
            this.txt_Soyisim.Name = "txt_Soyisim";
            this.txt_Soyisim.Size = new System.Drawing.Size(177, 22);
            this.txt_Soyisim.TabIndex = 1;
            // 
            // checkBox_Bireysel
            // 
            this.checkBox_Bireysel.AutoSize = true;
            this.checkBox_Bireysel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_Bireysel.Location = new System.Drawing.Point(49, 369);
            this.checkBox_Bireysel.Name = "checkBox_Bireysel";
            this.checkBox_Bireysel.Size = new System.Drawing.Size(201, 26);
            this.checkBox_Bireysel.TabIndex = 2;
            this.checkBox_Bireysel.Text = "Bireysel Müşteriyim";
            this.checkBox_Bireysel.UseVisualStyleBackColor = true;
            this.checkBox_Bireysel.CheckedChanged += new System.EventHandler(this.checkBox_Bireysel_CheckedChanged);
            // 
            // checkBox_Ticari
            // 
            this.checkBox_Ticari.AutoSize = true;
            this.checkBox_Ticari.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_Ticari.Location = new System.Drawing.Point(256, 369);
            this.checkBox_Ticari.Name = "checkBox_Ticari";
            this.checkBox_Ticari.Size = new System.Drawing.Size(179, 26);
            this.checkBox_Ticari.TabIndex = 3;
            this.checkBox_Ticari.Text = "Ticari Müşteriyim";
            this.checkBox_Ticari.UseVisualStyleBackColor = true;
            this.checkBox_Ticari.CheckedChanged += new System.EventHandler(this.checkBox_Ticari_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(107, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyadınız:";
            // 
            // btn_YeniKayitOlustur
            // 
            this.btn_YeniKayitOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_YeniKayitOlustur.Location = new System.Drawing.Point(168, 415);
            this.btn_YeniKayitOlustur.Name = "btn_YeniKayitOlustur";
            this.btn_YeniKayitOlustur.Size = new System.Drawing.Size(146, 35);
            this.btn_YeniKayitOlustur.TabIndex = 6;
            this.btn_YeniKayitOlustur.Text = "Kayıt Oluştur";
            this.btn_YeniKayitOlustur.UseVisualStyleBackColor = true;
            this.btn_YeniKayitOlustur.Click += new System.EventHandler(this.btn_YeniKayitOlustur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(83, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yeni Müşteri/Kayıt";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(236, 248);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(172, 22);
            this.txt_Sifre.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(124, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(39, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tekrar Şifre:";
            // 
            // txt_TekrarSifre
            // 
            this.txt_TekrarSifre.Location = new System.Drawing.Point(236, 300);
            this.txt_TekrarSifre.Name = "txt_TekrarSifre";
            this.txt_TekrarSifre.PasswordChar = '*';
            this.txt_TekrarSifre.Size = new System.Drawing.Size(172, 22);
            this.txt_TekrarSifre.TabIndex = 10;
            // 
            // frmYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(494, 492);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TekrarSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_YeniKayitOlustur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_Ticari);
            this.Controls.Add(this.checkBox_Bireysel);
            this.Controls.Add(this.txt_Soyisim);
            this.Controls.Add(this.txt_Isim);
            this.Name = "frmYeniMusteri";
            this.Text = "Yeni Müşteri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Isim;
        private System.Windows.Forms.TextBox txt_Soyisim;
        private System.Windows.Forms.CheckBox checkBox_Bireysel;
        private System.Windows.Forms.CheckBox checkBox_Ticari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_YeniKayitOlustur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TekrarSifre;
    }
}