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
    public partial class FormDefo : Form
    {
        TemelVeri temelVeri;
        SorguUrun sorguUrun = new SorguUrun();
        SorguDefo sorguDefo = new SorguDefo();
        Urun urun;
        Defo defo;
        bool textBoxBarkodKntrl = false;


        public FormDefo()
        {
            InitializeComponent();
        }
        public FormDefo(TemelVeri temelVeri)
        {
            this.temelVeri = temelVeri;
            InitializeComponent();
            
        }
               

        private void buttonIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if(this.numericUpDownAdet.Value != 0 && urun != null&&urun.adet>= (int)this.numericUpDownAdet.Value)
            {
                dialogResult = MessageBox.Show("Emin misiniz?", "Dikkat!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    defo = new Defo();
                    defo.personel = temelVeri.Id;
                    defo.urun = urun.id;
                    defo.adet = (int)this.numericUpDownAdet.Value;
                    defo.aciklama = this.textBoxAcıklama.Text;
                    if (sorguDefo.Ekle(defo))
                    {
                        Urun yeni = sorguUrun.kopyaOlustur(urun);
                        yeni.adet -= defo.adet;
                        sorguUrun.Guncelle(urun, yeni);
                        MessageBox.Show("Başarı ile tamalandı");
                    }
                    else
                    {
                        MessageBox.Show(
                            "Kayıt esnasında bir sorun oluştu", "dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    this.textBoxBarkod.Text = "";
                    this.numericUpDownAdet.Value = 1;
                    this.textBoxAcıklama.Text = "";
                    this.textBoxBarkodKntrl = false;
                }
            }
            
        
        }

        private void textBoxBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            TemelKurallar.textBox_KeyPress(sender, e);
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
        }
    }
}
