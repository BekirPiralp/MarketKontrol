using MarketSatis.VeriTabani.Kodlar;
using MarketSatis.VeriTabani.Veritabani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketSatis
{
    public partial class FormUrunEkle : Form
    {

        SorguUrun sorguUrun = new SorguUrun();
        Urun urun;
        

        public FormUrunEkle()
        {
            InitializeComponent();
        }

        private void resimEkle(String al)
        {
            textBoxResim.Text = al;
            try
            {
                pictureBoxUrunResim.Image = Image.FromFile(textBoxResim.Text);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Lütfen resim seçin", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxResim.Text = "";
            }
        }

        private void buttonGozat_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "sadece jpg png tif jpeg ico|*.jpg; *.png; *.tif; *.jpeg; *.ico";
            openFileDialog1.FileName = "Resim seçin";
            openFileDialog1.ShowDialog();
            resimEkle(openFileDialog1.FileName);
        }

        private void buttonIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Ürünü Eklemek İstediğinizden Emin misiniz ?", "Ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                // hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
                // Kendime not :DDDD
                //indirim yüzdesini sıfır yapmayı unutma
                //Onu Yönetici Belirliyecek
                //işlemler ve tanımlamalar
                if (
                    this.textBoxAd.Text !=""&&
                    this.textBoxAciklama.Text != "" &&
                    this.textBoxBarkod.Text != "" &&
                    this.textBoxMarka.Text != "" &&
                    this.pictureBoxUrunResim.Image != null &&
                    this.textBoxUretimYeri.Text != "" &&
                    (int)this.numericUpDownAdet.Value != 0 &&
                    this.numericUpDownFiyat.Value != 0
                    ) {
                    urun = new Urun();
                    urun.ad = this.textBoxAd.Text;
                    urun.adet = (int)this.numericUpDownAdet.Value;
                    urun.aciklama = this.textBoxAciklama.Text;
                    urun.barkod = this.textBoxBarkod.Text;
                    urun.fiyat = (float)this.numericUpDownFiyat.Value;
                    urun.indrim = 0;
                    urun.marka = this.textBoxMarka.Text;
                    urun.resim = this.pictureBoxUrunResim.Image;
                    urun.uretimYeri = this.textBoxUretimYeri.Text;
                  
                    if (!sorguUrun.Ekle(urun))
                    {
                        MessageBox.Show("Ürün ekleme sırasında bir hata oluştu.\n"+
                            "Ürününüz daha önce eklenmiş olabilir lütfen kontrol ediniz.\n"+
                            "Diğer durumlarda yöneticinize başvurunuz.",
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("İslem başarıyla gerçekleşti");
                    }
                }
                else
                {
                    MessageBox.Show("Değerleri tam girip tekrar deneyiniz.");
                }
            }

        }

        private void textBoxBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            TemelKurallar.textBox_KeyPress(sender, e);
        }
    }
}
