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
    public partial class FormUrunGuncelle : Form
    {
        SorguUrun sorguUrun = new SorguUrun();
        Urun urun,yeni;
        bool kntrl = false; // değerler de değiştirm oldu mu ?

        public Boolean YoneticiKontrol { get; set; }
        
        public FormUrunGuncelle(Boolean YoneticiKontrol = false)
        {
            this.YoneticiKontrol=YoneticiKontrol;
            InitializeComponent();
            checkBoxIndirimGuncelle.Checked = false;
            checkBoxIndirimGuncelle.Enabled = this.YoneticiKontrol;
            numericUpDownIndirim.Enabled = this.YoneticiKontrol;
        }
        private void buttonIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOnayla_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult=MessageBox.Show("Değişikliklerden emin misiniz?", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(dialogResult== DialogResult.OK)
            {
                //değişiklikler uygulanacak
                if (this.textBoxBarkod.Text != "")
                {
                    // urun getirme tuşlama esnasında yapıldı
                    yeni = sorguUrun.kopyaOlustur(urun);
                    if (YoneticiKontrol == true)
                    {
                        // yöneticide
                        if (checkBoxIndirimGuncelle.Checked&&numericUpDownIndirim.Value>=0)
                        {
                            yeni.indrim = (float)numericUpDownIndirim.Value;
                            kntrl = true;
                        }
                    }
                    //else if (YoneticiKontrol == false)
                    //{
                    //personel de
                    //}

                    /*ortak olanları burada yazacağım*/
                    if (radioButtonAdetGuncelle.Checked)
                    {
                        yeni.adet = (int)numericUpDownAdet.Value;
                        kntrl = true;
                    }
                    else if(radioButtonAdetEkle.Checked)
                    {
                        yeni.adet += (int)numericUpDownAdet.Value;
                        kntrl = true;
                    }

                    if (checkBoxFiyatGuncelle.Checked)
                    {
                        yeni.fiyat = (float)numericUpDownFiyat.Value;
                        kntrl = true;
                    }

                    if (kntrl)
                    {
                        if (sorguUrun.Guncelle(urun, yeni))
                        {
                            MessageBox.Show("İşlem başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Veritabanına güncelleme esnasında hata ile karşılaşıldı.","Hata",
                                MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        kntrl = false;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen işlem yapıp tekrar deneyiniz veya çıkış yapınız.");
                        
                    }
                }
                else
                {
                    MessageBox.Show("Barkodu girmeden ürünü güncelleyemezsiniz.");
                }
            }
            if (dialogResult == DialogResult.Cancel)
            {
                this.textBoxBarkod.Text = "";
                kntrl = false;
                //bişey yapılmayacak
                
            }
        }

        private void textBoxBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            TemelKurallar.textBox_KeyPress(sender, e);
        }

        private void textBoxBarkod_TextChanged(object sender, EventArgs e)
        {
            urun = TemelKurallar.araUrun(sender: sender, e: e);
            if (urun != null)
            {
                numericUpDownAdet.Value = urun.adet;
                numericUpDownFiyat.Value = (decimal)urun.fiyat;
                numericUpDownIndirim.Value = (decimal)urun.indrim;
                yeni = sorguUrun.kopyaOlustur(urun);

            }
            else
            {
                numericUpDownAdet.Value = 0;
                numericUpDownFiyat.Value = 0;
                numericUpDownIndirim.Value = 0;
            }
        }
    }
}
