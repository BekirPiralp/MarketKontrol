using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketSatis;
using MarketSatis.VeriTabani.Veritabani;
using MarketSatis.VeriTabani.Kodlar;

namespace MarketSatis
{
    public partial class FormPersonel : Form
    {
        TemelVeri temelVeri;
        SorguUrun sorguUrun = new SorguUrun();
        SorguFis sorguFis = new SorguFis();
        SorguSatis sorguSatis = new SorguSatis();
        List<ListUrunSatis> listUruns = new List<ListUrunSatis>();
        Urun urun;
        Satis satis;
        Fis fis = new Fis();
        bool textBoxBarkodKntrl = false;
        public FormPersonel()
        {
            timer1.Enabled = true;
            
            InitializeComponent();
            
        }

        public FormPersonel(TemelVeri temelVeri)
        {
            this.temelVeri = temelVeri;
            InitializeComponent();
            this.labelPersonelisim.Text = temelVeri.Ad + " " + temelVeri.Soyad;
        }
        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHakkinda frm = new FormHakkinda();
            frm.ShowDialog();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfil formProfil = new FormProfil(temelVeri);
            formProfil.ShowDialog();
        }

        private void profilDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSifreDegistir formSifreDegistir = new FormSifreDegistir(temelVeri);
            formSifreDegistir.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close(); // ilgili form dan çıkar.
            //Application.Exit(); // hepsinden çıkar.

            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //MessageBox.Show("");// hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrunEkle formUrunEkle = new FormUrunEkle();
            formUrunEkle.ShowDialog();
        }

        //satış iptal
        private void buttoniptal_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show("Eminmisiniz ?!", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                this.listBoxSatis.Items.Clear();
                this.labelToplamFiyat.Text = "0";
                this.labelFiyat.Text = "0";
                this.labelindirim.Text = "0";
                this.numericUpDownAdet.Value = 1;
            }
        }

        private void ürünGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrunGuncelle formUrunGuncelle = new FormUrunGuncelle(false);
            formUrunGuncelle.ShowDialog();
        }

        private void defoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDefo formDefo = new FormDefo();
            formDefo.ShowDialog();
        }

        private void iadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIade formIade = new FormIade();
            formIade.ShowDialog();
        }

        private void textBoxBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            TemelKurallar.textBox_KeyPress(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTarihSaat.Text = DateTime.Now.ToString();
        }

        /*Fise ekleme*/
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (!this.textBoxBarkodKntrl)
            {
                textBoxBarkod_MouseHover(this.textBoxBarkod,new EventArgs());
            }
            else
            {
                // yapılacak işlemler
                if(this.textBoxBarkod.Text == "")
                {
                    MessageBox.Show("Lütfen geçerli bir barkod girerek deneyiniz","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                        
                    if(urun != null)
                    {
                        satis = new Satis();
                        satis.adet = (int)this.numericUpDownAdet.Value;
                        listBoxGuncelle(TemelKurallar.urunEkleCikar(urun: urun,
                        satis: satis,
                        lists: listUruns));
                            
                    }
                    else
                    {
                        MessageBox.Show("Aradıgınız " + this.textBoxBarkod.Text + " urun bulunamadı lütfen kontrol ediniz");
                    }

                    this.numericUpDownAdet.Value = 1;
                   
                }
            }
            this.textBoxBarkodKntrl = false;
        }

       
        private void textBoxBarkod_MouseHover(object sender, EventArgs e)
        {
            TextBox al = (TextBox)sender;
            if (!this.textBoxBarkodKntrl)
            {
                al.Text = "";
                this.textBoxBarkodKntrl = true;

            }
        }

        private void textBoxBarkod_TextChanged(object sender, EventArgs e)
        {
            urun = TemelKurallar.araUrun(sender: sender, e: e);
            if(urun != null)
            {
                pictureBoxUrun.Image = urun.resim;
                this.labelFiyat.Text = urun.fiyat.ToString();
                this.labelindirim.Text = urun.indrim.ToString();
                this.labelKDV.Text = "18"; // varsayılan olarak alınmıştır
                                          // aslında her urun için veya sistemde kayıt olarak ala bilirdim
                                          // fakat sadece bilgi amaçlı bu şekilde ayarladım
                                          //kdv değişince adamcağız uğraşmasın diye hesaplamaya katmayacağım
                                          // bu yüzden değer olarak almadım olaki geliştirmek gerekise urun getire ve urun tablosuna ufak
                                          //ekleme ile bu sorun giderile bilir....
            }
            else
            {
                this.labelFiyat.Text = "0";
                this.labelindirim.Text = "0";
                this.labelKDV.Text = "18";
            }
        }

        /*List box güncelleme*/
        private void listBoxGuncelle(bool a)
        {
            if (a)
            {
                this.listBoxSatis.Items.Clear();
                float toplamFiyat=0;
                for(int i=0; i < listUruns.Count; i++)
                {
                    this.listBoxSatis.Items.Add(listUruns[i].ToString());
                    toplamFiyat+=listUruns[i].fiyatGetir();
                }
                this.labelToplamFiyat.Text = toplamFiyat.ToString();
            }
        }

        //Ürün çıkarma
        private void buttonCikar_Click(object sender, EventArgs e)
        {
            if (!this.textBoxBarkodKntrl)
            {
                textBoxBarkod_MouseHover(this.textBoxBarkod, new EventArgs());
            }
            else
            {
                // yapılacak işlemler
                if (this.textBoxBarkod.Text == "")
                {
                    MessageBox.Show("Lütfen geçerli bir barkod girerek deneyiniz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (urun != null)
                    {
                        satis = new Satis();
                        satis.adet = -1*(int)this.numericUpDownAdet.Value;
                        listBoxGuncelle(TemelKurallar.urunEkleCikar(urun: urun,
                        satis: satis,
                        lists: listUruns));

                    }
                    else
                    {
                        MessageBox.Show("Aradıgınız " + this.textBoxBarkod.Text + " urun bulunamadı lütfen kontrol ediniz");
                    }

                    this.numericUpDownAdet.Value = 1;

                }
            }
            this.textBoxBarkodKntrl = false;
        }

        //ürün satış ve onay
        private void buttonSat_Click(object sender, EventArgs e)
        {
            String fisKod = 
                DateTime.Now.Year.ToString() + temelVeri.Tc.Trim(); //ör 2021+12345678910 yıl + personel tc
            if (this.listUruns.Count == 0)
            {
                MessageBox.Show("Lütfen ürün ekleyip tekrar deneyiniz...");
                return;
            }
            DialogResult dialogResult
                =MessageBox.Show("Ücret alındımı?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.OK)
            {
                fis = new Fis();
                fis.personel = temelVeri.Id;
                fis.toplamFiyat = float.Parse(this.labelToplamFiyat.Text);
                fis.fisKod = fisKod;
                //Tüketiciye verilecek fiş'de fiş kod yazar ve yanında da fiş no olarak fiş id
                //fakat bu uygulamada fiş basma kısmı düşünülmediğinden eklenmemiştir
                //lakin fiş yükle fonksiyonunun içine ufak bir güncelleme ile
                //fiş basma sağlana bilir
                if (!TemelKurallar.fisYukle(fis,listUruns))
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı fiş kaydedilemedi\n" +
                        "İnternet bağlantınızı kotnrol ediniz\n" +
                        "Fiş üzerinde işlem yapmadan tekrar satışı onaylayınız\n" +
                        "Sıkıntı hala devam ederse yetkililere başvurunuz veya parayı iade ediniz");
                }
                else
                {
                    this.listBoxSatis.Items.Clear();
                    this.labelToplamFiyat.Text = "0";
                    this.labelFiyat.Text = "0";
                    this.labelindirim.Text = "0";
                    this.numericUpDownAdet.Value = 1;
                }
            }
            else
            {
                MessageBox.Show("Ücret alınmadığı için satış iptal edildi");
                buttoniptal_Click(sender: sender, e: e);
            }
        }
    }
}
