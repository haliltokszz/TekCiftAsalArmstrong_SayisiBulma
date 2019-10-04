namespace TekCift
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.grpGirisBilgileri = new System.Windows.Forms.GroupBox();
            this.msktxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.msktxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnİleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBaslangicSayi = new System.Windows.Forms.Label();
            this.tabIslemler = new System.Windows.Forms.TabControl();
            this.tbpgTekSayilar = new System.Windows.Forms.TabPage();
            this.lstTekSayilar = new System.Windows.Forms.ListView();
            this.clmTekListe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTekToplam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTekCarpim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpgCiftSayilar = new System.Windows.Forms.TabPage();
            this.lstCiftSayilar = new System.Windows.Forms.ListView();
            this.clmCiftListe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCiftToplam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCiftCarpim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpgAsalSayilar = new System.Windows.Forms.TabPage();
            this.lstAsalSayilar = new System.Windows.Forms.ListView();
            this.clmAsalListe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAsalToplam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAsalCarpim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpgArmstrongSayilar = new System.Windows.Forms.TabPage();
            this.lstArmstrongSayilar = new System.Windows.Forms.ListView();
            this.clmArmListe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmArmToplam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmArmCarpim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpAcilacakSayfa = new System.Windows.Forms.GroupBox();
            this.grpGirisBilgileri.SuspendLayout();
            this.tabIslemler.SuspendLayout();
            this.tbpgTekSayilar.SuspendLayout();
            this.tbpgCiftSayilar.SuspendLayout();
            this.tbpgAsalSayilar.SuspendLayout();
            this.tbpgArmstrongSayilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(284, 60);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(106, 27);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // grpGirisBilgileri
            // 
            this.grpGirisBilgileri.Controls.Add(this.msktxtBitis);
            this.grpGirisBilgileri.Controls.Add(this.msktxtBaslangic);
            this.grpGirisBilgileri.Controls.Add(this.btnSil);
            this.grpGirisBilgileri.Controls.Add(this.btnİleri);
            this.grpGirisBilgileri.Controls.Add(this.btnGeri);
            this.grpGirisBilgileri.Controls.Add(this.btnHesapla);
            this.grpGirisBilgileri.Controls.Add(this.lblBitis);
            this.grpGirisBilgileri.Controls.Add(this.lblBaslangicSayi);
            this.grpGirisBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpGirisBilgileri.Name = "grpGirisBilgileri";
            this.grpGirisBilgileri.Size = new System.Drawing.Size(579, 119);
            this.grpGirisBilgileri.TabIndex = 1;
            this.grpGirisBilgileri.TabStop = false;
            this.grpGirisBilgileri.Text = "Giriş Bilgileri";
            // 
            // msktxtBitis
            // 
            this.msktxtBitis.Location = new System.Drawing.Point(151, 66);
            this.msktxtBitis.Mask = "00000";
            this.msktxtBitis.Name = "msktxtBitis";
            this.msktxtBitis.Size = new System.Drawing.Size(100, 22);
            this.msktxtBitis.TabIndex = 7;
            this.msktxtBitis.ValidatingType = typeof(int);
            // 
            // msktxtBaslangic
            // 
            this.msktxtBaslangic.Location = new System.Drawing.Point(9, 66);
            this.msktxtBaslangic.Mask = "0000";
            this.msktxtBaslangic.Name = "msktxtBaslangic";
            this.msktxtBaslangic.Size = new System.Drawing.Size(100, 22);
            this.msktxtBaslangic.TabIndex = 1;
            this.msktxtBaslangic.ValidatingType = typeof(int);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(450, 60);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(86, 28);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnİleri
            // 
            this.btnİleri.Location = new System.Drawing.Point(496, 21);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(40, 27);
            this.btnİleri.TabIndex = 5;
            this.btnİleri.Text = ">>";
            this.btnİleri.UseVisualStyleBackColor = true;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(450, 21);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(40, 27);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "<<";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(148, 39);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(38, 17);
            this.lblBitis.TabIndex = 1;
            this.lblBitis.Text = "Bitiş:";
            // 
            // lblBaslangicSayi
            // 
            this.lblBaslangicSayi.AutoSize = true;
            this.lblBaslangicSayi.Location = new System.Drawing.Point(6, 36);
            this.lblBaslangicSayi.Name = "lblBaslangicSayi";
            this.lblBaslangicSayi.Size = new System.Drawing.Size(73, 17);
            this.lblBaslangicSayi.TabIndex = 0;
            this.lblBaslangicSayi.Text = "Başlangıç:";
            // 
            // tabIslemler
            // 
            this.tabIslemler.Controls.Add(this.tbpgTekSayilar);
            this.tabIslemler.Controls.Add(this.tbpgCiftSayilar);
            this.tabIslemler.Controls.Add(this.tbpgAsalSayilar);
            this.tabIslemler.Controls.Add(this.tbpgArmstrongSayilar);
            this.tabIslemler.Location = new System.Drawing.Point(12, 137);
            this.tabIslemler.Name = "tabIslemler";
            this.tabIslemler.SelectedIndex = 0;
            this.tabIslemler.Size = new System.Drawing.Size(579, 302);
            this.tabIslemler.TabIndex = 6;
            // 
            // tbpgTekSayilar
            // 
            this.tbpgTekSayilar.Controls.Add(this.lstTekSayilar);
            this.tbpgTekSayilar.Location = new System.Drawing.Point(4, 25);
            this.tbpgTekSayilar.Name = "tbpgTekSayilar";
            this.tbpgTekSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgTekSayilar.Size = new System.Drawing.Size(571, 273);
            this.tbpgTekSayilar.TabIndex = 0;
            this.tbpgTekSayilar.Text = "Tek Sayılar";
            this.tbpgTekSayilar.UseVisualStyleBackColor = true;
            // 
            // lstTekSayilar
            // 
            this.lstTekSayilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTekListe,
            this.clmTekToplam,
            this.clmTekCarpim});
            this.lstTekSayilar.HideSelection = false;
            this.lstTekSayilar.Location = new System.Drawing.Point(-4, 0);
            this.lstTekSayilar.Name = "lstTekSayilar";
            this.lstTekSayilar.Size = new System.Drawing.Size(575, 277);
            this.lstTekSayilar.TabIndex = 0;
            this.lstTekSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // clmTekListe
            // 
            this.clmTekListe.Text = "Liste";
            this.clmTekListe.Width = 150;
            // 
            // clmTekToplam
            // 
            this.clmTekToplam.Text = "Toplam";
            this.clmTekToplam.Width = 150;
            // 
            // clmTekCarpim
            // 
            this.clmTekCarpim.Text = "Çarpım";
            this.clmTekCarpim.Width = 150;
            // 
            // tbpgCiftSayilar
            // 
            this.tbpgCiftSayilar.Controls.Add(this.lstCiftSayilar);
            this.tbpgCiftSayilar.Location = new System.Drawing.Point(4, 25);
            this.tbpgCiftSayilar.Name = "tbpgCiftSayilar";
            this.tbpgCiftSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgCiftSayilar.Size = new System.Drawing.Size(571, 273);
            this.tbpgCiftSayilar.TabIndex = 1;
            this.tbpgCiftSayilar.Text = "Çift Sayılar";
            this.tbpgCiftSayilar.UseVisualStyleBackColor = true;
            // 
            // lstCiftSayilar
            // 
            this.lstCiftSayilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCiftListe,
            this.clmCiftToplam,
            this.clmCiftCarpim});
            this.lstCiftSayilar.HideSelection = false;
            this.lstCiftSayilar.Location = new System.Drawing.Point(-4, -2);
            this.lstCiftSayilar.Name = "lstCiftSayilar";
            this.lstCiftSayilar.Size = new System.Drawing.Size(579, 277);
            this.lstCiftSayilar.TabIndex = 1;
            this.lstCiftSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // clmCiftListe
            // 
            this.clmCiftListe.Text = "Liste";
            this.clmCiftListe.Width = 150;
            // 
            // clmCiftToplam
            // 
            this.clmCiftToplam.Text = "Toplam";
            this.clmCiftToplam.Width = 150;
            // 
            // clmCiftCarpim
            // 
            this.clmCiftCarpim.Text = "Çarpım";
            this.clmCiftCarpim.Width = 150;
            // 
            // tbpgAsalSayilar
            // 
            this.tbpgAsalSayilar.Controls.Add(this.lstAsalSayilar);
            this.tbpgAsalSayilar.Location = new System.Drawing.Point(4, 25);
            this.tbpgAsalSayilar.Name = "tbpgAsalSayilar";
            this.tbpgAsalSayilar.Size = new System.Drawing.Size(571, 273);
            this.tbpgAsalSayilar.TabIndex = 2;
            this.tbpgAsalSayilar.Text = "Asal Sayılar";
            this.tbpgAsalSayilar.UseVisualStyleBackColor = true;
            // 
            // lstAsalSayilar
            // 
            this.lstAsalSayilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmAsalListe,
            this.clmAsalToplam,
            this.clmAsalCarpim});
            this.lstAsalSayilar.HideSelection = false;
            this.lstAsalSayilar.Location = new System.Drawing.Point(-4, -2);
            this.lstAsalSayilar.Name = "lstAsalSayilar";
            this.lstAsalSayilar.Size = new System.Drawing.Size(579, 277);
            this.lstAsalSayilar.TabIndex = 1;
            this.lstAsalSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // clmAsalListe
            // 
            this.clmAsalListe.Text = "Liste";
            this.clmAsalListe.Width = 150;
            // 
            // clmAsalToplam
            // 
            this.clmAsalToplam.Text = "Toplam";
            this.clmAsalToplam.Width = 150;
            // 
            // clmAsalCarpim
            // 
            this.clmAsalCarpim.Text = "Çarpım";
            this.clmAsalCarpim.Width = 150;
            // 
            // tbpgArmstrongSayilar
            // 
            this.tbpgArmstrongSayilar.Controls.Add(this.lstArmstrongSayilar);
            this.tbpgArmstrongSayilar.Location = new System.Drawing.Point(4, 25);
            this.tbpgArmstrongSayilar.Name = "tbpgArmstrongSayilar";
            this.tbpgArmstrongSayilar.Size = new System.Drawing.Size(571, 273);
            this.tbpgArmstrongSayilar.TabIndex = 3;
            this.tbpgArmstrongSayilar.Text = "Armstrong Sayılar";
            this.tbpgArmstrongSayilar.UseVisualStyleBackColor = true;
            // 
            // lstArmstrongSayilar
            // 
            this.lstArmstrongSayilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmArmListe,
            this.clmArmToplam,
            this.clmArmCarpim});
            this.lstArmstrongSayilar.HideSelection = false;
            this.lstArmstrongSayilar.Location = new System.Drawing.Point(-4, 3);
            this.lstArmstrongSayilar.Name = "lstArmstrongSayilar";
            this.lstArmstrongSayilar.Size = new System.Drawing.Size(579, 277);
            this.lstArmstrongSayilar.TabIndex = 1;
            this.lstArmstrongSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // clmArmListe
            // 
            this.clmArmListe.Text = "Liste";
            this.clmArmListe.Width = 150;
            // 
            // clmArmToplam
            // 
            this.clmArmToplam.Text = "Toplam";
            this.clmArmToplam.Width = 150;
            // 
            // clmArmCarpim
            // 
            this.clmArmCarpim.Text = "Çarpım";
            this.clmArmCarpim.Width = 150;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "NotifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // grpAcilacakSayfa
            // 
            this.grpAcilacakSayfa.Location = new System.Drawing.Point(12, 449);
            this.grpAcilacakSayfa.Name = "grpAcilacakSayfa";
            this.grpAcilacakSayfa.Size = new System.Drawing.Size(575, 50);
            this.grpAcilacakSayfa.TabIndex = 7;
            this.grpAcilacakSayfa.TabStop = false;
            this.grpAcilacakSayfa.Text = "Açılacak Sayfa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 511);
            this.Controls.Add(this.grpAcilacakSayfa);
            this.Controls.Add(this.tabIslemler);
            this.Controls.Add(this.grpGirisBilgileri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.grpGirisBilgileri.ResumeLayout(false);
            this.grpGirisBilgileri.PerformLayout();
            this.tabIslemler.ResumeLayout(false);
            this.tbpgTekSayilar.ResumeLayout(false);
            this.tbpgCiftSayilar.ResumeLayout(false);
            this.tbpgAsalSayilar.ResumeLayout(false);
            this.tbpgArmstrongSayilar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.GroupBox grpGirisBilgileri;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblBaslangicSayi;
        private System.Windows.Forms.Button btnİleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TabControl tabIslemler;
        private System.Windows.Forms.TabPage tbpgTekSayilar;
        private System.Windows.Forms.TabPage tbpgCiftSayilar;
        private System.Windows.Forms.ListView lstCiftSayilar;
        private System.Windows.Forms.TabPage tbpgAsalSayilar;
        private System.Windows.Forms.ListView lstAsalSayilar;
        private System.Windows.Forms.TabPage tbpgArmstrongSayilar;
        private System.Windows.Forms.ListView lstArmstrongSayilar;
        private System.Windows.Forms.ListView lstTekSayilar;
        private System.Windows.Forms.ColumnHeader clmCiftListe;
        private System.Windows.Forms.ColumnHeader clmAsalListe;
        private System.Windows.Forms.ColumnHeader clmArmListe;
        private System.Windows.Forms.ColumnHeader clmTekListe;
        private System.Windows.Forms.ColumnHeader clmTekToplam;
        private System.Windows.Forms.ColumnHeader clmTekCarpim;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ColumnHeader clmCiftToplam;
        private System.Windows.Forms.ColumnHeader clmCiftCarpim;
        private System.Windows.Forms.ColumnHeader clmAsalToplam;
        private System.Windows.Forms.ColumnHeader clmAsalCarpim;
        private System.Windows.Forms.ColumnHeader clmArmToplam;
        private System.Windows.Forms.ColumnHeader clmArmCarpim;
        private System.Windows.Forms.MaskedTextBox msktxtBaslangic;
        private System.Windows.Forms.MaskedTextBox msktxtBitis;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.GroupBox grpAcilacakSayfa;
    }
}

