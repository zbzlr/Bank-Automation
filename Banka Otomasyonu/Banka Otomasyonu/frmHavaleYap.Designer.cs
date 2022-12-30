
namespace Banka_Otomasyonu
{
    partial class frmHavaleYap
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_HavaleYapilacakHesap = new System.Windows.Forms.TextBox();
            this.txt_HavaleTutari = new System.Windows.Forms.TextBox();
            this.btn_HavaleYap = new System.Windows.Forms.Button();
            this.btn_Vazgec = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_HavaleYapanHesapNo = new System.Windows.Forms.ComboBox();
            this.richTextBox_Aciklama = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(163, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Havale İşlemleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Havale Yapılacak Hesap No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(196, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Havale Tutarı:";
            // 
            // txt_HavaleYapilacakHesap
            // 
            this.txt_HavaleYapilacakHesap.Location = new System.Drawing.Point(444, 188);
            this.txt_HavaleYapilacakHesap.Name = "txt_HavaleYapilacakHesap";
            this.txt_HavaleYapilacakHesap.Size = new System.Drawing.Size(124, 22);
            this.txt_HavaleYapilacakHesap.TabIndex = 3;
            // 
            // txt_HavaleTutari
            // 
            this.txt_HavaleTutari.Location = new System.Drawing.Point(444, 236);
            this.txt_HavaleTutari.Name = "txt_HavaleTutari";
            this.txt_HavaleTutari.Size = new System.Drawing.Size(124, 22);
            this.txt_HavaleTutari.TabIndex = 4;
            // 
            // btn_HavaleYap
            // 
            this.btn_HavaleYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HavaleYap.Location = new System.Drawing.Point(188, 382);
            this.btn_HavaleYap.Name = "btn_HavaleYap";
            this.btn_HavaleYap.Size = new System.Drawing.Size(261, 35);
            this.btn_HavaleYap.TabIndex = 5;
            this.btn_HavaleYap.Text = "İşlemi Onayla";
            this.btn_HavaleYap.UseVisualStyleBackColor = true;
            this.btn_HavaleYap.Click += new System.EventHandler(this.btn_HavaleYap_Click);
            // 
            // btn_Vazgec
            // 
            this.btn_Vazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Vazgec.Location = new System.Drawing.Point(188, 438);
            this.btn_Vazgec.Name = "btn_Vazgec";
            this.btn_Vazgec.Size = new System.Drawing.Size(261, 35);
            this.btn_Vazgec.TabIndex = 6;
            this.btn_Vazgec.Text = "Vazgeç";
            this.btn_Vazgec.UseVisualStyleBackColor = true;
            this.btn_Vazgec.Click += new System.EventHandler(this.btn_Vazgec_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Islem Yapacağınız Hesap No:";
            // 
            // comboBox_HavaleYapanHesapNo
            // 
            this.comboBox_HavaleYapanHesapNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HavaleYapanHesapNo.FormattingEnabled = true;
            this.comboBox_HavaleYapanHesapNo.Location = new System.Drawing.Point(444, 140);
            this.comboBox_HavaleYapanHesapNo.Name = "comboBox_HavaleYapanHesapNo";
            this.comboBox_HavaleYapanHesapNo.Size = new System.Drawing.Size(124, 24);
            this.comboBox_HavaleYapanHesapNo.TabIndex = 8;
            // 
            // richTextBox_Aciklama
            // 
            this.richTextBox_Aciklama.Location = new System.Drawing.Point(444, 281);
            this.richTextBox_Aciklama.Name = "richTextBox_Aciklama";
            this.richTextBox_Aciklama.Size = new System.Drawing.Size(124, 64);
            this.richTextBox_Aciklama.TabIndex = 9;
            this.richTextBox_Aciklama.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(252, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Açıklama:";
            // 
            // frmHavaleYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 503);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox_Aciklama);
            this.Controls.Add(this.comboBox_HavaleYapanHesapNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Vazgec);
            this.Controls.Add(this.btn_HavaleYap);
            this.Controls.Add(this.txt_HavaleTutari);
            this.Controls.Add(this.txt_HavaleYapilacakHesap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHavaleYap";
            this.Text = "Müşteri Paneli";
            this.Load += new System.EventHandler(this.frmHavaleYap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_HavaleYapilacakHesap;
        private System.Windows.Forms.TextBox txt_HavaleTutari;
        private System.Windows.Forms.Button btn_HavaleYap;
        private System.Windows.Forms.Button btn_Vazgec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_HavaleYapanHesapNo;
        private System.Windows.Forms.RichTextBox richTextBox_Aciklama;
        private System.Windows.Forms.Label label5;
    }
}