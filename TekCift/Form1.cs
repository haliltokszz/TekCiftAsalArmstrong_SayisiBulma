using System;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;

namespace TekCift
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        enum enİslem
        {
            eCiftSayi = 1,
            eTekSayi =0,
            eArmstrongSayi = 3,
            eAsalSayi = 2
        }

        void EkranHazirla()
        {
            msktxtBaslangic.Text = "1";
            msktxtBitis.Text = "10000";
            msktxtBaslangic.Focus();
        }

        
        ArrayList TekSayiBul(int sayi1, int sayi2)
        {
            ArrayList tekSayilar = new ArrayList();
            for (int i = sayi1; i < sayi2; i++)
            {
                if (i % 2 != 0)
                {
                     tekSayilar.Add(i);
                }
                
            }
            return tekSayilar;
        }
        ArrayList CiftSayiBul(int sayi1, int sayi2)
        {
            ArrayList ciftSayilar = new ArrayList();
            for (int i = sayi1; i < sayi2; i++)
            {
                if (i % 2 == 0)
                {
                    ciftSayilar.Add(i);
                }

            }
            return ciftSayilar;
        }
        ArrayList AsalSayiBul(int sayi1, int sayi2)
        {
            ArrayList asalSayilar = new ArrayList();
            bool asallikKontrol= false;
            for (int degerlendirilecekSayi = sayi1; degerlendirilecekSayi < sayi2; degerlendirilecekSayi++)
            {
                for (int sayac = 2; sayac < degerlendirilecekSayi; sayac++)
                {
                    if (degerlendirilecekSayi % sayac == 0)
                    {
                        asallikKontrol = false;
                        break;
                    }
                    else
                    {
                        asallikKontrol = true;
                    }  
                }
                if (asallikKontrol == true)
                {
                    asalSayilar.Add(degerlendirilecekSayi);
                }
                
            }
            return asalSayilar;
        }
        ArrayList ArmstrongSayiBul(int sayi1, int sayi2)
        {
            ArrayList armstrongSayilar = new ArrayList();
            for (int degerlendirileceksayi = sayi1; degerlendirileceksayi < sayi2; degerlendirileceksayi++)
            {
                string strSayi = degerlendirileceksayi.ToString();
                int us = strSayi.Length;
                int toplam = 0;
                foreach (char basamak in strSayi)
                {
                    string strBasamak = Convert.ToString(basamak);
                    toplam += (int)Math.Pow(Convert.ToInt32(strBasamak),us);
                }
                if (degerlendirileceksayi == toplam)
                {
                    armstrongSayilar.Add(degerlendirileceksayi);
                }
            }
            return armstrongSayilar;
        }

        ulong Toplama(ArrayList sayilar)
        {
            ulong toplam=0;
            foreach(int z in sayilar)
            {
                toplam += Convert.ToUInt64(z);
            }
            return toplam;
        }
        BigInteger Carpma(ArrayList sayilar)
        {
            BigInteger carpim = 1;
            foreach (int z in sayilar)
            {
                carpim=BigInteger.Multiply(z, carpim);
            }
            return carpim;
        }

        void LogYaz(enİslem islemTuru ,ulong toplam, BigInteger carpim, ArrayList sayiListe)
        {
            if (islemTuru == enİslem.eTekSayi)
            {
                ListViewItem liste;
                foreach (int sayi in sayiListe)
                {
                    liste = new ListViewItem(sayi.ToString());
                    lstTekSayilar.Items.Add(liste);
                }
                string[] degerler = new string[3];
                degerler[0] = "Toplam ve Çarpım Sonucu"; degerler[1] = toplam.ToString(); degerler[2] = carpim.ToString();
                liste = new ListViewItem(degerler);
                lstTekSayilar.Items.Add(liste);

            }
            else if (islemTuru == enİslem.eCiftSayi)
            {
                ListViewItem liste;
                foreach (int sayi in sayiListe)
                {
                    liste = new ListViewItem(sayi.ToString());
                    lstCiftSayilar.Items.Add(liste);
                }
                string[] degerler = new string[3];
                degerler[0] = "Toplam ve Çarpım Sonucu"; degerler[1] = toplam.ToString(); degerler[2] = carpim.ToString();
                liste = new ListViewItem(degerler);
                lstCiftSayilar.Items.Add(liste);
            }
            else if (islemTuru == enİslem.eAsalSayi) { 
                foreach (int sayi in sayiListe)
                {
                    ListViewItem liste;
                    string[] degerler = new string[3];
                    degerler[0] = sayi.ToString(); degerler[1] = toplam.ToString(); degerler[2] = carpim.ToString();
                    liste = new ListViewItem(degerler);
                    lstAsalSayilar.Items.Add(liste);
                }
            }else if (islemTuru == enİslem.eArmstrongSayi)
                {
                foreach (int sayi in sayiListe)
                {
                    ListViewItem liste;
                    string[] degerler = new string[3];
                    degerler[0] = sayi.ToString(); degerler[1] = toplam.ToString(); degerler[2] = carpim.ToString();
                    liste = new ListViewItem(degerler);
                    lstArmstrongSayilar.Items.Add(liste);
                }
            }
        }

        void Islemler(int eTur, int ilkSayi, int sonSayi)
        {
            ulong tekToplam = Toplama(TekSayiBul(ilkSayi, sonSayi));
            BigInteger tekCarpim = Carpma(TekSayiBul(ilkSayi, sonSayi));
            ulong ciftToplam = Toplama(CiftSayiBul(ilkSayi, sonSayi));
            BigInteger ciftCarpim = Carpma(CiftSayiBul(ilkSayi, sonSayi));
            ulong asalToplam = Toplama(AsalSayiBul(ilkSayi, sonSayi));
            BigInteger asalCarpim = Carpma(AsalSayiBul(ilkSayi, sonSayi));
            ulong armToplam = Toplama(ArmstrongSayiBul(ilkSayi, sonSayi));
            BigInteger armCarpim = Carpma(ArmstrongSayiBul(ilkSayi, sonSayi));
            if (eTur == (int)enİslem.eTekSayi)
            {
                LogYaz(enİslem.eTekSayi, tekToplam, tekCarpim, TekSayiBul(ilkSayi, sonSayi));
                DosyayaYazdir(enİslem.eTekSayi, tekToplam, tekCarpim, lstTekSayilar);
            }
            else if (eTur == (int)enİslem.eCiftSayi)
            {
                LogYaz(enİslem.eCiftSayi, ciftToplam, ciftCarpim, CiftSayiBul(ilkSayi, sonSayi));
                DosyayaYazdir(enİslem.eCiftSayi, ciftToplam, ciftCarpim, lstCiftSayilar);
            }
            else if (eTur == (int)enİslem.eAsalSayi)
            {
                LogYaz(enİslem.eAsalSayi, asalToplam, asalCarpim, AsalSayiBul(ilkSayi, sonSayi));
                DosyayaYazdir(enİslem.eAsalSayi, asalToplam, asalCarpim, lstAsalSayilar);
            }
            else if (eTur == (int)enİslem.eArmstrongSayi)
            {
                LogYaz(enİslem.eArmstrongSayi, armToplam, armCarpim, ArmstrongSayiBul(ilkSayi, sonSayi));
                DosyayaYazdir(enİslem.eArmstrongSayi, armToplam, armCarpim, lstArmstrongSayilar);
            }
        }
        private void DosyayaYazdir(enİslem islemTuru, BigInteger toplamaSonuc, BigInteger carpmaSonuc, ListView sayilar)
        {
            string dosya_yolu = @"listviewLog.txt";
            using (StreamWriter sw = new StreamWriter(dosya_yolu, true))
            {
                sw.WriteLine("***********************************");
                DateTime simdi = DateTime.Now;
                sw.WriteLine(simdi + " " + islemTuru + "\n");
                sw.WriteLine("Sayılar: ");
                for (int i = 1; i < sayilar.Items.Count; i++)
                {
                    sw.WriteLine(sayilar.Items[i - 1].Text + ", ");
                }
                sw.WriteLine("\nToplama Sonucu: " + toplamaSonuc);
                sw.WriteLine("\nÇarpma Sonucu: " + carpmaSonuc);
                sw.WriteLine("***********************************");
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                notifyIcon.Visible = true;
                notifyIcon.Text = "NotifyIcon Denemesi";
                notifyIcon.BalloonTipTitle = "Program Çalışıyor";
                notifyIcon.BalloonTipText = "Program sağ alt köşede konumlandı.";
                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon.ShowBalloonTip(30000);
                notifyIcon.MouseDoubleClick += new MouseEventHandler(MyIcon_MouseDoubleClick);
            }
        }

        void MyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIcon.Visible = false;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt32(msktxtBaslangic.Text);
            int bitis = Convert.ToInt32(msktxtBitis.Text);
            Islemler(tabIslemler.SelectedIndex, baslangic, bitis);
            
            EkranHazirla();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            notifyIcon.Icon = new Icon(@"C:\Users\Monster-Halil\Downloads\icon.ico");
            notifyIcon.Visible = true;
            notifyIcon.Text = "NotifyIcon Denemesi";
            notifyIcon.BalloonTipTitle = "Program Çalışıyor";
            notifyIcon.BalloonTipText = "Program sağ alt köşede konumlandı.";
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.ShowBalloonTip(30000);
            notifyIcon.MouseDoubleClick += new MouseEventHandler(MyIcon_MouseDoubleClick);

            EkranHazirla();
            lstTekSayilar.View = View.Details;
            lstTekSayilar.GridLines = true;
            lstTekSayilar.FullRowSelect = true;

            lstCiftSayilar.View = View.Details;
            lstCiftSayilar.GridLines = true;
            lstCiftSayilar.FullRowSelect = true;

            lstAsalSayilar.View = View.Details;
            lstAsalSayilar.GridLines = true;
            lstAsalSayilar.FullRowSelect = true;


            lstArmstrongSayilar.View = View.Details;
            lstArmstrongSayilar.GridLines = true;
            lstArmstrongSayilar.FullRowSelect = true;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            
            if (tabIslemler.SelectedIndex == 0)
            {
                tabIslemler.SelectedIndex = 3;
            }else tabIslemler.SelectedIndex--;

        }

        private void btnİleri_Click(object sender, EventArgs e)
        {
            
            if (tabIslemler.SelectedIndex == 3)
            {
                tabIslemler.SelectedIndex = 0;
            }else tabIslemler.SelectedIndex++;

        }

        void ListSil(int eTur)
        {
            if (eTur == (int)enİslem.eTekSayi)
            {
                foreach (ListViewItem secilikayitbilgisi in lstTekSayilar.SelectedItems)
                {
                    secilikayitbilgisi.Remove();
                }
            }
            else if (eTur == (int)enİslem.eCiftSayi)
            {
                foreach (ListViewItem secilikayitbilgisi in lstCiftSayilar.SelectedItems)
                {
                    secilikayitbilgisi.Remove();
                }
            }
            else if (eTur == (int)enİslem.eAsalSayi)
            {
                foreach (ListViewItem secilikayitbilgisi in lstAsalSayilar.SelectedItems)
                {
                    secilikayitbilgisi.Remove();
                }
            }
            else if (eTur == (int)enİslem.eArmstrongSayi)
            {
                foreach (ListViewItem secilikayitbilgisi in lstArmstrongSayilar.SelectedItems)
                {
                    secilikayitbilgisi.Remove();
                }
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ListSil(tabIslemler.SelectedIndex);
        }

        void AcilacakSayfa()
        {
            String seciliTabAyari;
            seciliTabAyari =System.Configuration.ConfigurationSettings.AppSettings["acilacak_sayfa"];
            if (seciliTabAyari=="armstrong")
            {
                tabIslemler.SelectedIndex = 3;
            }
            else if (seciliTabAyari=="asal")
            {
                tabIslemler.SelectedIndex = 2;
            }
            else if (seciliTabAyari=="cift")
            {
                tabIslemler.SelectedIndex = 1;
            }
            else
            {
                tabIslemler.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AcilacakSayfa();
        }

    }
}
