﻿
namespace Banka_Otomasyonu
{
    partial class frmAnaEkran
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaEkran));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HesaplariYonetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapOzetiGoruntuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraCekYatirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havaleYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameOfBank2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hToolStripMenuItem,
            this.paraToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HesaplariYonetToolStripMenuItem,
            this.hesapOzetiGoruntuleToolStripMenuItem});
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.hToolStripMenuItem.Text = "Hesap İşlemleri";
            // 
            // HesaplariYonetToolStripMenuItem
            // 
            this.HesaplariYonetToolStripMenuItem.Name = "HesaplariYonetToolStripMenuItem";
            this.HesaplariYonetToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.HesaplariYonetToolStripMenuItem.Text = "Hesaplarım";
            this.HesaplariYonetToolStripMenuItem.Click += new System.EventHandler(this.HesaplariYonetToolStripMenuItem_Click);
            // 
            // hesapOzetiGoruntuleToolStripMenuItem
            // 
            this.hesapOzetiGoruntuleToolStripMenuItem.Name = "hesapOzetiGoruntuleToolStripMenuItem";
            this.hesapOzetiGoruntuleToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.hesapOzetiGoruntuleToolStripMenuItem.Text = "Hesap Özeti Görüntüle";
            this.hesapOzetiGoruntuleToolStripMenuItem.Click += new System.EventHandler(this.hesapOzetiGoruntuleToolStripMenuItem_Click);
            // 
            // paraToolStripMenuItem
            // 
            this.paraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraCekYatirToolStripMenuItem,
            this.havaleYapToolStripMenuItem});
            this.paraToolStripMenuItem.Name = "paraToolStripMenuItem";
            this.paraToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.paraToolStripMenuItem.Text = "Para";
            // 
            // paraCekYatirToolStripMenuItem
            // 
            this.paraCekYatirToolStripMenuItem.Name = "paraCekYatirToolStripMenuItem";
            this.paraCekYatirToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.paraCekYatirToolStripMenuItem.Text = "Para Çek/Yatır";
            this.paraCekYatirToolStripMenuItem.Click += new System.EventHandler(this.paraCekYatirToolStripMenuItem_Click);
            // 
            // havaleYapToolStripMenuItem
            // 
            this.havaleYapToolStripMenuItem.Name = "havaleYapToolStripMenuItem";
            this.havaleYapToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.havaleYapToolStripMenuItem.Text = "Havale Yap";
            this.havaleYapToolStripMenuItem.Click += new System.EventHandler(this.havaleYapToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // nameOfBank2
            // 
            this.nameOfBank2.Icon = ((System.Drawing.Icon)(resources.GetObject("nameOfBank2.Icon")));
            this.nameOfBank2.Text = "NameOfBank";
            this.nameOfBank2.Visible = true;
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnaEkran";
            this.Text = "Müşteri Paneli";
            this.Load += new System.EventHandler(this.frmAnaEkran_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HesaplariYonetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapOzetiGoruntuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraCekYatirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havaleYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon nameOfBank2;
    }
}