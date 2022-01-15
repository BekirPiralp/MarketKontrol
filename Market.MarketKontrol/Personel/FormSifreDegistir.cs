using MarketSatis.VeriTabani.Kodlar;
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
    public partial class FormSifreDegistir : Form
    {
        TemelVeri temelVeri;
        SorguIslem sorguIslem = new SorguIslem();

        public FormSifreDegistir(TemelVeri temelVeri)
        {
            this.temelVeri = temelVeri;
            InitializeComponent();
        }

        private void buttonIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOnayla_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult=MessageBox.Show("Eminmisiniz...!","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dialogResult== DialogResult.Yes)
            {
                if(textBoxEskiSifre.Text!= ""&& textBoxYeniSifre1.Text !="" && textBoxYeniSifre2.Text != "")
                {
                    if (string.Compare(temelVeri.Sifre.Trim(), textBoxEskiSifre.Text.Trim()) == 0)
                    {
                        
                        if(string.Compare(textBoxYeniSifre2.Text.Trim(), textBoxYeniSifre1.Text.Trim()) == 0)
                        {
                            try
                            {
                                if(sorguIslem.temelVeriSifreGuncelle(temelVeri.Id, textBoxYeniSifre1.Text.Trim()))
                                {
                                    MessageBox.Show("İşlem başarıyla gerçekleşti \n lütfen tekrar giriş yapınız" +
                                        "\n şu anda eski şifreniz ile hala şifrenizi değiştirmeye devam ede bilirsiniz " +
                                        "ta ki yeniden giriş yapana kadar");

                                }
                                else
                                {
                                    MessageBox.Show("Sifre güncellem sırasında bir hata ile karşılaşıldı");
                                }
                            }
                            catch 
                            {
                                MessageBox.Show("Sifre güncellem sırasında bir hata ile karşılaşıldı");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Yeni şifre ve tekrarı uyuşmuyor lütfen kontrol ediniz");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Eski sifrenizi kontrol edip tekrar deneyiniz");
                    }
                }
                else
                {
                    MessageBox.Show("istenilen bilgileri tamgiriniz");
                }
            }
            else if(dialogResult== DialogResult.No)
            {
                this.Close();
            }
        }

        private void textBoxTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            TemelKurallar.textBox_KeyPress(sender, e);
        }
    }
}
