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
    public partial class FormIade : Form
    {
        TemelVeri temelVeri;
        SorguUrun sorguUrun = new SorguUrun();
        SorguFis sorguFis = new SorguFis();
        SorguSatis sorguSatis = new SorguSatis();
        SorguIade sorguIade = new SorguIade();
        Satis satis;
        Fis fis;
        Urun urun;
        Iade iade;
       
       // bool textBoxBarkodKntrl = false;

        public FormIade()
        {
            InitializeComponent();
        }

        public FormIade(TemelVeri temelVeri)
        {
            this.temelVeri = temelVeri;
            InitializeComponent();
        }

        private void buttonIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTamam_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Emin misiniz?", "Dikkat!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                if (numericUpDownAdet.Value != 0 && this.textBoxFisNo.Text!="")
                {
                    urun = sorguUrun.Getir(this.textBoxBarkod.Text.Trim());
                    fis = sorguFis.Getir(int.Parse(this.textBoxFisNo.Text));
                    if(urun != null && fis != null)
                    {
                        satis = sorguSatis.Getir(fis: fis.id, urun: urun.id);
                        iade = new Iade();
                        iade.fis = fis.id;
                        iade.satis = satis.id;
                        iade.personel = temelVeri.Id;
                        iade.aciklama = "Adet: " + ((int)numericUpDownAdet.Value).ToString() +
                            "\n" + this.textBoxAciklama.Text;
                        if (!sorguIade.Ekle(iade))
                        {
                            MessageBox.Show("Kayıt esnasında bir hata ile karşılaşıldı.\n Lütfen tekrar deneyiniz.",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Aradığınız fiş veya ürün bulunamadı.\n"+
                            "Lütfen bilgileri kontrol edip tekrar deneyiniz.","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("0 adet olan ürün iade edilemez");
                }

            }
            
        }

        private void textBoxFisNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TemelKurallar.textBox_KeyPress(sender, e);
        }

        private void textBoxBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            TemelKurallar.textBox_KeyPress(sender, e);
        }
    }
}
