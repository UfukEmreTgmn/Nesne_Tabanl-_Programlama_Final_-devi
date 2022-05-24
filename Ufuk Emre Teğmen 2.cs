using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne_Tabanlı_Programlama_Final_Ödevi
{
    public partial class Form1 : Form
    {
        List<Urunler> kayitliurun;
        public Form1()
        {
            InitializeComponent();
        }
        public void UrunEkleKitap()
        {

                Kitap urunler = new Kitap();
                urunler.ad = KitapAdi.Text;
                urunler.fiyat = KitapFiyat.Text;
                urunler.sayfasayisi = KitapSayfaSayisi.Text;
                urunler.tur = radioButtonKitap.Text;
            string[] bilgiler = { urunler.ad, urunler.fiyat, urunler.sayfasayisi, urunler.tur };
            ListViewItem kayit = new ListViewItem(bilgiler);
            listViewKayit.Items.Add(kayit);

        }
        public void UrunEkleDefter()
        {
            
                Defter urunler = new Defter();
                urunler.ad = DefterMarka.Text;
                urunler.fiyat = DefterFiyat.Text;
                urunler.sayfasayisi = DefterSayfaSayisi.Text;
                urunler.tur = radioButtonDefter.Text;
                string [] bilgiler = { urunler.ad, urunler.fiyat, urunler.sayfasayisi, urunler.tur };
            ListViewItem kayit = new ListViewItem(bilgiler);
            listViewKayit.Items.Add(kayit);

        }
        public void UrunEkleKırtasiye()
        {
            
                Kırtasiye urunler = new Kırtasiye();
                urunler.ad = KırtasiyeMarka.Text;
                urunler.fiyat = KırtasiyeFiyat.Text;
                urunler.Renk = KırtasiyeRenk.Text;
                urunler.tur = MalzemeTuru.Text;
            string[] bilgiler = { urunler.ad, urunler.fiyat, urunler.sayfasayisi, urunler.tur };
            ListViewItem kayit = new ListViewItem(bilgiler);
            listViewKayit.Items.Add(kayit);


        }
        public void Temizle()
        {
            KırtasiyeMarka.Text="";
            KırtasiyeFiyat.Text="";
            KitapAdi.Text="";
            KitapFiyat.Text="";
            KitapSayfaSayisi.Text="";
            DefterFiyat.Text="";
            DefterMarka.Text="";
            DefterSayfaSayisi.Text="";
            DefterTuru.SelectedIndex = -1;
            KitapTuru.SelectedIndex = -1;
            MalzemeTuru.SelectedIndex = -1;
            KırtasiyeRenk.SelectedIndex = -1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxDefter.Enabled = false;
            groupBoxKitap.Enabled = false;
            groupBoxKırtasiye.Enabled = false;
            /*kayitliurun = new List<Urunler>();*/
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {

            if (radioButtonKitap.Checked==true)
            {
                UrunEkleKitap();
                Temizle();
            }
            else if (radioButtonDefter.Checked==true)
            {
                UrunEkleDefter();
                Temizle();
            }
            else if (radioButtonKırtasiye.Checked==true)
            {
                UrunEkleKırtasiye();
                Temizle();
            }
            
            
        }
        public void Ekle()
        {
            
            for (int i = 0; i <kayitliurun.Count ; i++)
            {
                string[] bilgiler = kayitliurun[i].BilgiDondur();
                ListViewItem item = new ListViewItem(bilgiler);
                listViewKayit.Items.Add(item);
            }
        }
        public void Listele()
        {
            for (int i = 0; i < kayitliurun.Count; i++)
            {
                string[] bilgiler = kayitliurun[i].BilgiDondur();
                ListViewItem item = new ListViewItem(bilgiler);
                listViewKayit.Items.Add(item);
            }
        }
       /* public void ListeleFiyat(string fiyat)
        {
            for (int i = 0; i < kayitliurun.Count; i++)
            {
                if (kayitliurun[i].fiyat <= fiyat)
                {
                    string[] bilgiler = kayitliurun[i].BilgiDondur();
                    ListViewItem item = new ListViewItem(bilgiler);
                    listViewKayit.Items.Add(item);
                }
            }

        }*/
       /* public void ListeleAd(string ad)
        {
            for (int i = 0; i < kayitliurun.Count; i++)
            {
                if (kayitliurun[i].ad.Contains(ad))
                {
                    string[] bilgiler = kayitliurun[i].BilgiDondur();
                    ListViewItem item = new ListViewItem(bilgiler);
                    listViewKayit.Items.Add(item);
                }
            }

        }*/
      /*  public void ListeleAdFiyat(string ad , int fiyat)
        {
            for (int i = 0; i < kayitliurun.Count; i++)
            {
                if (kayitliurun[i].ad.Contains(ad) && kayitliurun[i].fiyat <= fiyat)
                {
                    string[] bilgiler = kayitliurun[i].BilgiDondur();
                    ListViewItem item = new ListViewItem(bilgiler);
                    listViewKayit.Items.Add(item);
                }
            }

        }*/
        public bool TumBilgilerGirildi()
        {

            if (KitapAdi.Text == " " || KitapFiyat.Text == " " || KitapSayfaSayisi.Text == " " || KitapTuru.SelectedIndex < 0 ||
                    DefterFiyat.Text == " " || DefterMarka.Text == " " || DefterSayfaSayisi.Text == " " || DefterTuru.SelectedIndex < 0 || KırtasiyeMarka.Text == " " ||
                    KırtasiyeFiyat.Text == " " || KırtasiyeRenk.SelectedIndex < 0 || MalzemeTuru.SelectedIndex < 0)
                return false;
            else
            {
                return true;
            }
        }
        private void radioButtonKitap_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKitap.Checked == true)
            {
                groupBoxKitap.Enabled = true;
            }
            else
            {
                groupBoxKitap.Enabled = false;
            }
        }

        private void radioButtonDefter_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDefter.Checked==true)
            {
                groupBoxDefter.Enabled = true;
            }
            else
            {
                groupBoxDefter.Enabled = false;
            }
        }

        private void radioButtonKırtasiye_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKırtasiye.Checked==true)
            {
                groupBoxKırtasiye.Enabled = true;
            }
            else
            {
                groupBoxKırtasiye.Enabled = false;
            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Emin Misiniz? ", "!!!Uyarı Mesajı!!!",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (cikis == DialogResult.Yes)
                Application.Exit();
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
           /* if (textBoxAramaAd.Text==""&& textBoxFiyatArama.Text=="")
            {
                Listele();
            }
            else if (textBoxAramaAd.Text == " " && textBoxFiyatArama.Text != " ")
            {
                int fiyat = Convert.ToInt32(textBoxFiyatArama.Text);
                ListeleFiyat(fiyat);
            }
            else if (textBoxAramaAd.Text != " " && textBoxFiyatArama.Text == " ")
            {
                string ad = textBoxAramaAd.Text;
                ListeleAd(ad);
            }
            else
            {
                string ad = textBoxAramaAd.Text;
                int fiyat = Convert.ToInt32(textBoxFiyatArama.Text);
                ListeleAdFiyat(ad, fiyat);
            }*/
        }
    }
}
