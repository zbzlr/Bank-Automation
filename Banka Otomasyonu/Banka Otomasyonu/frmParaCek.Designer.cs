
namespace Banka_Otomasyonu
{
    partial class frmParaCekYatir
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
            this.comboBox_HesapSecimi = new System.Windows.Forms.ComboBox();
            this.txt_IslemTutari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ParaCek = new System.Windows.Forms.Button();
            this.btn_AnaSayfa = new System.Windows.Forms.Button();
            this.btn_ParaYatir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlemin Yapılacağı Hesap:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(173, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "İşlem Tutarı:";
            // 
            // comboBox_HesapSecimi
            // 
            this.comboBox_HesapSecimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HesapSecimi.FormattingEnabled = true;
            this.comboBox_HesapSecimi.Location = new System.Drawing.Point(350, 135);
            this.comboBox_HesapSecimi.Name = "comboBox_HesapSecimi";
            this.comboBox_HesapSecimi.Size = new System.Drawing.Size(159, 24);
            this.comboBox_HesapSecimi.TabIndex = 2;
            // 
            // txt_IslemTutari
            // 
            this.txt_IslemTutari.Location = new System.Drawing.Point(350, 188);
            this.txt_IslemTutari.Name = "txt_IslemTutari";
            this.txt_IslemTutari.Size = new System.Drawing.Size(159, 22);
            this.txt_IslemTutari.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(170, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Para Çek/Yatır";
            // 
            // btn_ParaCek
            // 
            this.btn_ParaCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ParaCek.Location = new System.Drawing.Point(297, 238);
            this.btn_ParaCek.Name = "btn_ParaCek";
            this.btn_ParaCek.Size = new System.Drawing.Size(124, 34);
            this.btn_ParaCek.TabIndex = 5;
            this.btn_ParaCek.Text = "Çek";
            this.btn_ParaCek.UseVisualStyleBackColor = true;
            this.btn_ParaCek.Click += new System.EventHandler(this.btn_ParaCek_Click);
            // 
            // btn_AnaSayfa
            // 
            this.btn_AnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AnaSayfa.Location = new System.Drawing.Point(297, 290);
            this.btn_AnaSayfa.Name = "btn_AnaSayfa";
            this.btn_AnaSayfa.Size = new System.Drawing.Size(261, 31);
            this.btn_AnaSayfa.TabIndex = 6;
            this.btn_AnaSayfa.Text = "Ana Sayfa";
            this.btn_AnaSayfa.UseVisualStyleBackColor = true;
            this.btn_AnaSayfa.Click += new System.EventHandler(this.btn_AnaSayfa_Click);
            // 
            // btn_ParaYatir
            // 
            this.btn_ParaYatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ParaYatir.Location = new System.Drawing.Point(434, 238);
            this.btn_ParaYatir.Name = "btn_ParaYatir";
            this.btn_ParaYatir.Size = new System.Drawing.Size(124, 34);
            this.btn_ParaYatir.TabIndex = 7;
            this.btn_ParaYatir.Text = "Yatır";
            this.btn_ParaYatir.UseVisualStyleBackColor = true;
            this.btn_ParaYatir.Click += new System.EventHandler(this.btn_ParaYatir_Click);
            // 
            // frmParaCekYatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 355);
            this.Controls.Add(this.btn_ParaYatir);
            this.Controls.Add(this.btn_AnaSayfa);
            this.Controls.Add(this.btn_ParaCek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_IslemTutari);
            this.Controls.Add(this.comboBox_HesapSecimi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmParaCekYatir";
            this.Text = "Müşteri Paneli";
            this.Load += new System.EventHandler(this.frmParaCekYatir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_HesapSecimi;
        private System.Windows.Forms.TextBox txt_IslemTutari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ParaCek;
        private System.Windows.Forms.Button btn_AnaSayfa;
        private System.Windows.Forms.Button btn_ParaYatir;
    }
}