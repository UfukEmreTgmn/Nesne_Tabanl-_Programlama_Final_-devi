
namespace Nesne_Tabanlı_Programlama_Final_Ödevi
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
            this.radioButtonKitap = new System.Windows.Forms.RadioButton();
            this.radioButtonDefter = new System.Windows.Forms.RadioButton();
            this.radioButtonKırtasiye = new System.Windows.Forms.RadioButton();
            this.groupBoxKitap = new System.Windows.Forms.GroupBox();
            this.KitapFiyat = new System.Windows.Forms.TextBox();
            this.KitapSayfaSayisi = new System.Windows.Forms.TextBox();
            this.labelKitapFiyat = new System.Windows.Forms.Label();
            this.labelKitapSayfaSayisi = new System.Windows.Forms.Label();
            this.KitapTuru = new System.Windows.Forms.ComboBox();
            this.labelKitapTuru = new System.Windows.Forms.Label();
            this.KitapAdi = new System.Windows.Forms.TextBox();
            this.labelKitapAdi = new System.Windows.Forms.Label();
            this.groupBoxDefter = new System.Windows.Forms.GroupBox();
            this.DefterFiyat = new System.Windows.Forms.TextBox();
            this.labelDefterFiyat = new System.Windows.Forms.Label();
            this.DefterSayfaSayisi = new System.Windows.Forms.TextBox();
            this.labelDefterSayisi = new System.Windows.Forms.Label();
            this.DefterTuru = new System.Windows.Forms.ComboBox();
            this.labelDefterTuru = new System.Windows.Forms.Label();
            this.DefterMarka = new System.Windows.Forms.TextBox();
            this.labelDefterMarka = new System.Windows.Forms.Label();
            this.groupBoxKırtasiye = new System.Windows.Forms.GroupBox();
            this.Renk = new System.Windows.Forms.Label();
            this.KırtasiyeFiyat = new System.Windows.Forms.TextBox();
            this.labelKırtasiyeFiyat = new System.Windows.Forms.Label();
            this.MalzemeTuru = new System.Windows.Forms.ComboBox();
            this.labelMalzemeTuru = new System.Windows.Forms.Label();
            this.KırtasiyeMarka = new System.Windows.Forms.TextBox();
            this.labelKırtasiyeMarka = new System.Windows.Forms.Label();
            this.KayitliUrunler = new System.Windows.Forms.GroupBox();
            this.listViewKayit = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.KırtasiyeRenk = new System.Windows.Forms.ComboBox();
            this.labelAdMarkaArama = new System.Windows.Forms.Label();
            this.textBoxAramaAd = new System.Windows.Forms.TextBox();
            this.labelFiyatArama = new System.Windows.Forms.Label();
            this.textBoxFiyatArama = new System.Windows.Forms.TextBox();
            this.buttonListele = new System.Windows.Forms.Button();
            this.groupBoxKitap.SuspendLayout();
            this.groupBoxDefter.SuspendLayout();
            this.groupBoxKırtasiye.SuspendLayout();
            this.KayitliUrunler.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonKitap
            // 
            this.radioButtonKitap.AutoSize = true;
            this.radioButtonKitap.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKitap.Location = new System.Drawing.Point(30, 23);
            this.radioButtonKitap.Name = "radioButtonKitap";
            this.radioButtonKitap.Size = new System.Drawing.Size(56, 20);
            this.radioButtonKitap.TabIndex = 0;
            this.radioButtonKitap.Text = "Kitap";
            this.radioButtonKitap.UseVisualStyleBackColor = true;
            this.radioButtonKitap.CheckedChanged += new System.EventHandler(this.radioButtonKitap_CheckedChanged);
            // 
            // radioButtonDefter
            // 
            this.radioButtonDefter.AutoSize = true;
            this.radioButtonDefter.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDefter.Location = new System.Drawing.Point(218, 23);
            this.radioButtonDefter.Name = "radioButtonDefter";
            this.radioButtonDefter.Size = new System.Drawing.Size(61, 20);
            this.radioButtonDefter.TabIndex = 1;
            this.radioButtonDefter.Text = "Defter";
            this.radioButtonDefter.UseVisualStyleBackColor = true;
            this.radioButtonDefter.CheckedChanged += new System.EventHandler(this.radioButtonDefter_CheckedChanged);
            // 
            // radioButtonKırtasiye
            // 
            this.radioButtonKırtasiye.AutoSize = true;
            this.radioButtonKırtasiye.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKırtasiye.Location = new System.Drawing.Point(357, 23);
            this.radioButtonKırtasiye.Name = "radioButtonKırtasiye";
            this.radioButtonKırtasiye.Size = new System.Drawing.Size(76, 20);
            this.radioButtonKırtasiye.TabIndex = 2;
            this.radioButtonKırtasiye.Text = "Kırtasiye";
            this.radioButtonKırtasiye.UseVisualStyleBackColor = true;
            this.radioButtonKırtasiye.CheckedChanged += new System.EventHandler(this.radioButtonKırtasiye_CheckedChanged);
            // 
            // groupBoxKitap
            // 
            this.groupBoxKitap.Controls.Add(this.KitapFiyat);
            this.groupBoxKitap.Controls.Add(this.KitapSayfaSayisi);
            this.groupBoxKitap.Controls.Add(this.labelKitapFiyat);
            this.groupBoxKitap.Controls.Add(this.labelKitapSayfaSayisi);
            this.groupBoxKitap.Controls.Add(this.KitapTuru);
            this.groupBoxKitap.Controls.Add(this.labelKitapTuru);
            this.groupBoxKitap.Controls.Add(this.KitapAdi);
            this.groupBoxKitap.Controls.Add(this.labelKitapAdi);
            this.groupBoxKitap.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxKitap.Location = new System.Drawing.Point(12, 57);
            this.groupBoxKitap.Name = "groupBoxKitap";
            this.groupBoxKitap.Size = new System.Drawing.Size(198, 296);
            this.groupBoxKitap.TabIndex = 3;
            this.groupBoxKitap.TabStop = false;
            this.groupBoxKitap.Text = "Kitap Bilgileri";
            // 
            // KitapFiyat
            // 
            this.KitapFiyat.Location = new System.Drawing.Point(12, 264);
            this.KitapFiyat.Name = "KitapFiyat";
            this.KitapFiyat.Size = new System.Drawing.Size(174, 23);
            this.KitapFiyat.TabIndex = 7;
            this.KitapFiyat.Text = "0";
            // 
            // KitapSayfaSayisi
            // 
            this.KitapSayfaSayisi.Location = new System.Drawing.Point(9, 197);
            this.KitapSayfaSayisi.Name = "KitapSayfaSayisi";
            this.KitapSayfaSayisi.Size = new System.Drawing.Size(177, 23);
            this.KitapSayfaSayisi.TabIndex = 6;
            // 
            // labelKitapFiyat
            // 
            this.labelKitapFiyat.AutoSize = true;
            this.labelKitapFiyat.Location = new System.Drawing.Point(12, 238);
            this.labelKitapFiyat.Name = "labelKitapFiyat";
            this.labelKitapFiyat.Size = new System.Drawing.Size(36, 16);
            this.labelKitapFiyat.TabIndex = 5;
            this.labelKitapFiyat.Text = "Fiyat";
            // 
            // labelKitapSayfaSayisi
            // 
            this.labelKitapSayfaSayisi.AutoSize = true;
            this.labelKitapSayfaSayisi.Location = new System.Drawing.Point(12, 172);
            this.labelKitapSayfaSayisi.Name = "labelKitapSayfaSayisi";
            this.labelKitapSayfaSayisi.Size = new System.Drawing.Size(75, 16);
            this.labelKitapSayfaSayisi.TabIndex = 4;
            this.labelKitapSayfaSayisi.Text = "Sayfa Sayısı";
            // 
            // KitapTuru
            // 
            this.KitapTuru.FormattingEnabled = true;
            this.KitapTuru.Items.AddRange(new object[] {
            "Roman",
            "Hikaye"});
            this.KitapTuru.Location = new System.Drawing.Point(9, 126);
            this.KitapTuru.Name = "KitapTuru";
            this.KitapTuru.Size = new System.Drawing.Size(177, 24);
            this.KitapTuru.TabIndex = 3;
            // 
            // labelKitapTuru
            // 
            this.labelKitapTuru.AutoSize = true;
            this.labelKitapTuru.Location = new System.Drawing.Point(9, 96);
            this.labelKitapTuru.Name = "labelKitapTuru";
            this.labelKitapTuru.Size = new System.Drawing.Size(68, 16);
            this.labelKitapTuru.TabIndex = 2;
            this.labelKitapTuru.Text = "Kitap Türü";
            // 
            // KitapAdi
            // 
            this.KitapAdi.Location = new System.Drawing.Point(6, 56);
            this.KitapAdi.Name = "KitapAdi";
            this.KitapAdi.Size = new System.Drawing.Size(180, 23);
            this.KitapAdi.TabIndex = 1;
            // 
            // labelKitapAdi
            // 
            this.labelKitapAdi.AutoSize = true;
            this.labelKitapAdi.Location = new System.Drawing.Point(6, 28);
            this.labelKitapAdi.Name = "labelKitapAdi";
            this.labelKitapAdi.Size = new System.Drawing.Size(60, 16);
            this.labelKitapAdi.TabIndex = 0;
            this.labelKitapAdi.Text = "Kitap Adı";
            // 
            // groupBoxDefter
            // 
            this.groupBoxDefter.Controls.Add(this.DefterFiyat);
            this.groupBoxDefter.Controls.Add(this.labelDefterFiyat);
            this.groupBoxDefter.Controls.Add(this.DefterSayfaSayisi);
            this.groupBoxDefter.Controls.Add(this.labelDefterSayisi);
            this.groupBoxDefter.Controls.Add(this.DefterTuru);
            this.groupBoxDefter.Controls.Add(this.labelDefterTuru);
            this.groupBoxDefter.Controls.Add(this.DefterMarka);
            this.groupBoxDefter.Controls.Add(this.labelDefterMarka);
            this.groupBoxDefter.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDefter.Location = new System.Drawing.Point(233, 66);
            this.groupBoxDefter.Name = "groupBoxDefter";
            this.groupBoxDefter.Size = new System.Drawing.Size(219, 287);
            this.groupBoxDefter.TabIndex = 4;
            this.groupBoxDefter.TabStop = false;
            this.groupBoxDefter.Text = "Defter Bilgileri";
            // 
            // DefterFiyat
            // 
            this.DefterFiyat.Location = new System.Drawing.Point(16, 255);
            this.DefterFiyat.Name = "DefterFiyat";
            this.DefterFiyat.Size = new System.Drawing.Size(178, 23);
            this.DefterFiyat.TabIndex = 7;
            this.DefterFiyat.Text = "0";
            // 
            // labelDefterFiyat
            // 
            this.labelDefterFiyat.AutoSize = true;
            this.labelDefterFiyat.Location = new System.Drawing.Point(16, 229);
            this.labelDefterFiyat.Name = "labelDefterFiyat";
            this.labelDefterFiyat.Size = new System.Drawing.Size(36, 16);
            this.labelDefterFiyat.TabIndex = 6;
            this.labelDefterFiyat.Text = "Fiyat";
            // 
            // DefterSayfaSayisi
            // 
            this.DefterSayfaSayisi.Location = new System.Drawing.Point(13, 188);
            this.DefterSayfaSayisi.Name = "DefterSayfaSayisi";
            this.DefterSayfaSayisi.Size = new System.Drawing.Size(181, 23);
            this.DefterSayfaSayisi.TabIndex = 5;
            // 
            // labelDefterSayisi
            // 
            this.labelDefterSayisi.AutoSize = true;
            this.labelDefterSayisi.Location = new System.Drawing.Point(13, 163);
            this.labelDefterSayisi.Name = "labelDefterSayisi";
            this.labelDefterSayisi.Size = new System.Drawing.Size(75, 16);
            this.labelDefterSayisi.TabIndex = 4;
            this.labelDefterSayisi.Text = "Sayfa Sayısı";
            // 
            // DefterTuru
            // 
            this.DefterTuru.FormattingEnabled = true;
            this.DefterTuru.Items.AddRange(new object[] {
            "Kalın Kapaklı",
            "4 Ortalı",
            "5 Ortalı"});
            this.DefterTuru.Location = new System.Drawing.Point(13, 117);
            this.DefterTuru.Name = "DefterTuru";
            this.DefterTuru.Size = new System.Drawing.Size(181, 24);
            this.DefterTuru.TabIndex = 3;
            // 
            // labelDefterTuru
            // 
            this.labelDefterTuru.AutoSize = true;
            this.labelDefterTuru.Location = new System.Drawing.Point(10, 89);
            this.labelDefterTuru.Name = "labelDefterTuru";
            this.labelDefterTuru.Size = new System.Drawing.Size(73, 16);
            this.labelDefterTuru.TabIndex = 2;
            this.labelDefterTuru.Text = "Defter Türü";
            // 
            // DefterMarka
            // 
            this.DefterMarka.Location = new System.Drawing.Point(10, 47);
            this.DefterMarka.Name = "DefterMarka";
            this.DefterMarka.Size = new System.Drawing.Size(184, 23);
            this.DefterMarka.TabIndex = 1;
            // 
            // labelDefterMarka
            // 
            this.labelDefterMarka.AutoSize = true;
            this.labelDefterMarka.Location = new System.Drawing.Point(7, 23);
            this.labelDefterMarka.Name = "labelDefterMarka";
            this.labelDefterMarka.Size = new System.Drawing.Size(45, 16);
            this.labelDefterMarka.TabIndex = 0;
            this.labelDefterMarka.Text = "Marka";
            // 
            // groupBoxKırtasiye
            // 
            this.groupBoxKırtasiye.Controls.Add(this.KırtasiyeRenk);
            this.groupBoxKırtasiye.Controls.Add(this.Renk);
            this.groupBoxKırtasiye.Controls.Add(this.KırtasiyeFiyat);
            this.groupBoxKırtasiye.Controls.Add(this.labelKırtasiyeFiyat);
            this.groupBoxKırtasiye.Controls.Add(this.MalzemeTuru);
            this.groupBoxKırtasiye.Controls.Add(this.labelMalzemeTuru);
            this.groupBoxKırtasiye.Controls.Add(this.KırtasiyeMarka);
            this.groupBoxKırtasiye.Controls.Add(this.labelKırtasiyeMarka);
            this.groupBoxKırtasiye.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxKırtasiye.Location = new System.Drawing.Point(484, 66);
            this.groupBoxKırtasiye.Name = "groupBoxKırtasiye";
            this.groupBoxKırtasiye.Size = new System.Drawing.Size(201, 287);
            this.groupBoxKırtasiye.TabIndex = 5;
            this.groupBoxKırtasiye.TabStop = false;
            this.groupBoxKırtasiye.Text = "Kırtasiye Bilgileri";
            // 
            // Renk
            // 
            this.Renk.AutoSize = true;
            this.Renk.Location = new System.Drawing.Point(9, 163);
            this.Renk.Name = "Renk";
            this.Renk.Size = new System.Drawing.Size(37, 16);
            this.Renk.TabIndex = 9;
            this.Renk.Text = "Renk";
            // 
            // KırtasiyeFiyat
            // 
            this.KırtasiyeFiyat.Location = new System.Drawing.Point(9, 255);
            this.KırtasiyeFiyat.Name = "KırtasiyeFiyat";
            this.KırtasiyeFiyat.Size = new System.Drawing.Size(178, 23);
            this.KırtasiyeFiyat.TabIndex = 8;
            this.KırtasiyeFiyat.Text = "0";
            // 
            // labelKırtasiyeFiyat
            // 
            this.labelKırtasiyeFiyat.AutoSize = true;
            this.labelKırtasiyeFiyat.Location = new System.Drawing.Point(15, 229);
            this.labelKırtasiyeFiyat.Name = "labelKırtasiyeFiyat";
            this.labelKırtasiyeFiyat.Size = new System.Drawing.Size(36, 16);
            this.labelKırtasiyeFiyat.TabIndex = 7;
            this.labelKırtasiyeFiyat.Text = "Fiyat";
            // 
            // MalzemeTuru
            // 
            this.MalzemeTuru.FormattingEnabled = true;
            this.MalzemeTuru.Items.AddRange(new object[] {
            "Oyun Hamuru",
            "Silgi",
            "Simli Kalem"});
            this.MalzemeTuru.Location = new System.Drawing.Point(9, 117);
            this.MalzemeTuru.Name = "MalzemeTuru";
            this.MalzemeTuru.Size = new System.Drawing.Size(181, 24);
            this.MalzemeTuru.TabIndex = 4;
            // 
            // labelMalzemeTuru
            // 
            this.labelMalzemeTuru.AutoSize = true;
            this.labelMalzemeTuru.Location = new System.Drawing.Point(6, 89);
            this.labelMalzemeTuru.Name = "labelMalzemeTuru";
            this.labelMalzemeTuru.Size = new System.Drawing.Size(89, 16);
            this.labelMalzemeTuru.TabIndex = 3;
            this.labelMalzemeTuru.Text = "Malzeme Türü";
            // 
            // KırtasiyeMarka
            // 
            this.KırtasiyeMarka.Location = new System.Drawing.Point(6, 47);
            this.KırtasiyeMarka.Name = "KırtasiyeMarka";
            this.KırtasiyeMarka.Size = new System.Drawing.Size(184, 23);
            this.KırtasiyeMarka.TabIndex = 2;
            // 
            // labelKırtasiyeMarka
            // 
            this.labelKırtasiyeMarka.AutoSize = true;
            this.labelKırtasiyeMarka.Location = new System.Drawing.Point(6, 23);
            this.labelKırtasiyeMarka.Name = "labelKırtasiyeMarka";
            this.labelKırtasiyeMarka.Size = new System.Drawing.Size(45, 16);
            this.labelKırtasiyeMarka.TabIndex = 1;
            this.labelKırtasiyeMarka.Text = "Marka";
            // 
            // KayitliUrunler
            // 
            this.KayitliUrunler.Controls.Add(this.listViewKayit);
            this.KayitliUrunler.Location = new System.Drawing.Point(12, 373);
            this.KayitliUrunler.Name = "KayitliUrunler";
            this.KayitliUrunler.Size = new System.Drawing.Size(436, 160);
            this.KayitliUrunler.TabIndex = 6;
            this.KayitliUrunler.TabStop = false;
            this.KayitliUrunler.Text = "Kayitli Ürünler";
            // 
            // listViewKayit
            // 
            this.listViewKayit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewKayit.HideSelection = false;
            this.listViewKayit.Location = new System.Drawing.Point(12, 19);
            this.listViewKayit.Name = "listViewKayit";
            this.listViewKayit.Size = new System.Drawing.Size(366, 135);
            this.listViewKayit.TabIndex = 0;
            this.listViewKayit.UseCompatibleStateImageBehavior = false;
            this.listViewKayit.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürünler";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad/Marka";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyat TL";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 100;
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEkle.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEkle.Location = new System.Drawing.Point(484, 373);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(139, 31);
            this.buttonEkle.TabIndex = 7;
            this.buttonEkle.Text = "ÜRÜN EKLE";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Brown;
            this.buttonCikis.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCikis.Location = new System.Drawing.Point(484, 422);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(139, 31);
            this.buttonCikis.TabIndex = 8;
            this.buttonCikis.Text = "ÇIKIŞ";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // KırtasiyeRenk
            // 
            this.KırtasiyeRenk.FormattingEnabled = true;
            this.KırtasiyeRenk.Items.AddRange(new object[] {
            "Sarı",
            "Kırmızı",
            "Lacivert",
            "Mor",
            "Pembe"});
            this.KırtasiyeRenk.Location = new System.Drawing.Point(9, 182);
            this.KırtasiyeRenk.Name = "KırtasiyeRenk";
            this.KırtasiyeRenk.Size = new System.Drawing.Size(181, 24);
            this.KırtasiyeRenk.TabIndex = 10;
            // 
            // labelAdMarkaArama
            // 
            this.labelAdMarkaArama.AutoSize = true;
            this.labelAdMarkaArama.Location = new System.Drawing.Point(661, 373);
            this.labelAdMarkaArama.Name = "labelAdMarkaArama";
            this.labelAdMarkaArama.Size = new System.Drawing.Size(55, 13);
            this.labelAdMarkaArama.TabIndex = 9;
            this.labelAdMarkaArama.Text = "Ad/Marka";
            // 
            // textBoxAramaAd
            // 
            this.textBoxAramaAd.Location = new System.Drawing.Point(658, 392);
            this.textBoxAramaAd.Name = "textBoxAramaAd";
            this.textBoxAramaAd.Size = new System.Drawing.Size(178, 20);
            this.textBoxAramaAd.TabIndex = 10;
            // 
            // labelFiyatArama
            // 
            this.labelFiyatArama.AutoSize = true;
            this.labelFiyatArama.Location = new System.Drawing.Point(661, 422);
            this.labelFiyatArama.Name = "labelFiyatArama";
            this.labelFiyatArama.Size = new System.Drawing.Size(29, 13);
            this.labelFiyatArama.TabIndex = 11;
            this.labelFiyatArama.Text = "Fiyat";
            // 
            // textBoxFiyatArama
            // 
            this.textBoxFiyatArama.Location = new System.Drawing.Point(658, 438);
            this.textBoxFiyatArama.Name = "textBoxFiyatArama";
            this.textBoxFiyatArama.Size = new System.Drawing.Size(178, 20);
            this.textBoxFiyatArama.TabIndex = 12;
            // 
            // buttonListele
            // 
            this.buttonListele.BackColor = System.Drawing.SystemColors.Info;
            this.buttonListele.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListele.Location = new System.Drawing.Point(658, 464);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(139, 31);
            this.buttonListele.TabIndex = 13;
            this.buttonListele.Text = "ÜRÜN LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = false;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(848, 545);
            this.ControlBox = false;
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.textBoxFiyatArama);
            this.Controls.Add(this.labelFiyatArama);
            this.Controls.Add(this.textBoxAramaAd);
            this.Controls.Add(this.labelAdMarkaArama);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.KayitliUrunler);
            this.Controls.Add(this.groupBoxKırtasiye);
            this.Controls.Add(this.groupBoxDefter);
            this.Controls.Add(this.groupBoxKitap);
            this.Controls.Add(this.radioButtonKırtasiye);
            this.Controls.Add(this.radioButtonDefter);
            this.Controls.Add(this.radioButtonKitap);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Ürün Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxKitap.ResumeLayout(false);
            this.groupBoxKitap.PerformLayout();
            this.groupBoxDefter.ResumeLayout(false);
            this.groupBoxDefter.PerformLayout();
            this.groupBoxKırtasiye.ResumeLayout(false);
            this.groupBoxKırtasiye.PerformLayout();
            this.KayitliUrunler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonKitap;
        private System.Windows.Forms.RadioButton radioButtonDefter;
        private System.Windows.Forms.RadioButton radioButtonKırtasiye;
        private System.Windows.Forms.GroupBox groupBoxKitap;
        private System.Windows.Forms.TextBox KitapFiyat;
        private System.Windows.Forms.TextBox KitapSayfaSayisi;
        private System.Windows.Forms.Label labelKitapFiyat;
        private System.Windows.Forms.Label labelKitapSayfaSayisi;
        private System.Windows.Forms.ComboBox KitapTuru;
        private System.Windows.Forms.Label labelKitapTuru;
        private System.Windows.Forms.TextBox KitapAdi;
        private System.Windows.Forms.Label labelKitapAdi;
        private System.Windows.Forms.GroupBox groupBoxDefter;
        private System.Windows.Forms.TextBox DefterFiyat;
        private System.Windows.Forms.Label labelDefterFiyat;
        private System.Windows.Forms.TextBox DefterSayfaSayisi;
        private System.Windows.Forms.Label labelDefterSayisi;
        private System.Windows.Forms.ComboBox DefterTuru;
        private System.Windows.Forms.Label labelDefterTuru;
        private System.Windows.Forms.TextBox DefterMarka;
        private System.Windows.Forms.Label labelDefterMarka;
        private System.Windows.Forms.GroupBox groupBoxKırtasiye;
        private System.Windows.Forms.Label Renk;
        private System.Windows.Forms.TextBox KırtasiyeFiyat;
        private System.Windows.Forms.Label labelKırtasiyeFiyat;
        private System.Windows.Forms.ComboBox MalzemeTuru;
        private System.Windows.Forms.Label labelMalzemeTuru;
        private System.Windows.Forms.TextBox KırtasiyeMarka;
        private System.Windows.Forms.Label labelKırtasiyeMarka;
        private System.Windows.Forms.GroupBox KayitliUrunler;
        private System.Windows.Forms.ListView listViewKayit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.ComboBox KırtasiyeRenk;
        private System.Windows.Forms.Label labelAdMarkaArama;
        private System.Windows.Forms.TextBox textBoxAramaAd;
        private System.Windows.Forms.Label labelFiyatArama;
        private System.Windows.Forms.TextBox textBoxFiyatArama;
        private System.Windows.Forms.Button buttonListele;
    }
}

